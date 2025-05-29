class Musica 
{ 
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }


    public void ExibirDetalhes() 
    {
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}");
    }
}