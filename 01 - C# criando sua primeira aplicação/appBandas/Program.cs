using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    public static void Main(string[] args)
    {
        string mensagemBoasVindas = "Bem Vindo ao Screen Sound";
        List<string> listaBandas = new List<string>
        {
            "Imagine Dragons",
            "Twenty One Pilots",
            "Panic! At The Disco",
        };

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
                    Console.WriteLine("Você digitou 3!");
                    break;
                case 4:
                    Console.WriteLine("Você digitou 4!");
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
            listaBandas.Add(nomeDaBanda);
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Console.ReadKey();
            ExibirOpcoesMenu();
        }

        void MostrarBandasRegistradas()
        {
            Console.Clear();
            ExibirTituloOpcao("Exibindo todas as bandas registradas");
            for (int i = 0; i < listaBandas.Count; i++)
            {
                Console.WriteLine($"Banda {i + 1}: {listaBandas[i]}");
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

        ExibirOpcoesMenu();
    }
}
