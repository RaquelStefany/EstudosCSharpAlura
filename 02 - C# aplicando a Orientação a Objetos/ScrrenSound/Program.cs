Musica musica1 = new Musica();
musica1.nome = "Bohemian Rhapsody";
musica1.artista = "Queen";
musica1.duracao = 354; // duração em segundos
musica1.DefinirDisponibilidade(true); // Definindo a música como disponível


Musica musica2 = new Musica();
musica2.nome = "Heathens";
musica2.artista = "Twenty One Pilots";
musica2.duracao = 200; // duração em segundos
musica2.DefinirDisponibilidade(true); // Definindo a música como disponível

musica1.ExibirDetalhes();
Console.WriteLine(); // Linha em branco para separar as exibições
musica2.ExibirDetalhes();