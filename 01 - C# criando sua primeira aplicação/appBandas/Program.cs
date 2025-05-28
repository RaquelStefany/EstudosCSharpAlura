using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    public static void Main(string[] args)
    {
        string mensagemBoasVindas = @"            
            ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
            ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
            ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
            ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
            ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
            ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
        ";

        // Lista para armazenar os nomes das bandas registradas
        Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
        bandasRegistradas.Add("Imagine Dragons", new List<int> { 10, 8, 9 });
        bandasRegistradas.Add("Twenty One Pilots", new List<int>());

        void ExibirLogo()
        {
            Console.WriteLine(mensagemBoasVindas);
        }

        void ExibirOpcoesMenu()
        {
            Console.Clear();
            ExibirLogo();
            Console.WriteLine("Digite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para mostrar todas as bandas");
            Console.WriteLine("Digite 3 para avaliar uma banda");
            Console.WriteLine("Digite 4 para exibir a média de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            int opcaoEscolhida = int.Parse(Console.ReadLine()!);
            switch (opcaoEscolhida)
            {
                case 1:
                    RegistrarBanda();
                    break;
                case 2:
                    MostrarBandasRegistradas();
                    break;
                case 3:
                    AnaliarBanda();
                    break;
                case 4:
                    MediaBanda();
                    break;
                case -1:
                    Console.WriteLine("\nTchau tchau :)");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        void RegistrarBanda()
        {
            Console.Clear();
            ExibirTituloOpcao("Registro de bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            // Adicionando a banda e uma lista vazia
            bandasRegistradas.Add(nomeDaBanda, new List<int>());
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Console.ReadKey();
            ExibirOpcoesMenu();
        }

        void MostrarBandasRegistradas()
        {
            Console.Clear();
            ExibirTituloOpcao("Exibindo todas as bandas registradas");
            int i = 1;
            foreach (var banda in bandasRegistradas.Keys)
            {
                string avaliacoes = bandasRegistradas[banda].Count > 0 ? string.Join(", ", bandasRegistradas[banda]) : "Não Avaliado";
                Console.WriteLine($"Banda {i}: {banda} - Avaliações: {avaliacoes}");
                i++;
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            ExibirOpcoesMenu();
        }

        void ExibirTituloOpcao(string titulo)
        {
            int quantidadeLetras = titulo.Length;
            string detalhes = string.Empty.PadLeft(quantidadeLetras, '-');
            Console.WriteLine(detalhes);
            Console.WriteLine(titulo);
            Console.WriteLine(detalhes);
            Console.WriteLine();
        }

        void AnaliarBanda()
        {
            Console.Clear();
            ExibirTituloOpcao("Análise de bandas");
            Console.WriteLine("Bandas registradas:");
            if(bandasRegistradas.Count == 0)
            {
                Console.WriteLine("Nenhuma banda registrada.");
                Console.ReadKey();
                ExibirOpcoesMenu();
                return;
            }
            int i = 1;
            foreach (var banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda {i}: {banda}");
                i++;
            }
            Console.WriteLine();
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nomeBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeBanda))
            {
                Console.Write("Digite a nota de 0 a 10: ");
                int nota = int.Parse(Console.ReadLine()!);
                bandasRegistradas[nomeBanda].Add(nota);
                Console.WriteLine($"\nA banda {nomeBanda} foi avaliada com sucesso!");
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeBanda} não está registrada.");
            }
            Console.ReadKey();
            ExibirOpcoesMenu();
        }

        void MediaBanda()
        {
            Console.Clear();
            ExibirTituloOpcao("Média de bandas");
            Console.WriteLine("Bandas registradas:");
            if (bandasRegistradas.Count == 0)
            {
                Console.WriteLine("Nenhuma banda registrada.");
                Console.ReadKey();
                ExibirOpcoesMenu();
                return;
            }
            int i = 1;
            foreach (var banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda {i}: {banda}");
                i++;
            }
            Console.WriteLine();
            Console.Write("Digite o nome da banda que deseja calcular a média: ");
            string nomeBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeBanda))
            {
                List<int> notas = bandasRegistradas[nomeBanda];
                if (notas.Count > 0)
                {
                    // Calcula a média das notas
                    double media = notas.Average();
                    Console.WriteLine($"\nA média das avaliações da banda {nomeBanda} é: {media:F2}");
                }
                else
                {
                    Console.WriteLine($"\nA banda {nomeBanda} ainda não possui avaliações.");
                }
            }
            else
            {
                Console.WriteLine($"A banda {nomeBanda} não está registrada.");
            }
            Console.ReadKey();
            ExibirOpcoesMenu();
        }

        ExibirOpcoesMenu();
    }
}
