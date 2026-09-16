internal class Program
{
    private static void Main(string[] args)
    {
        Questao1();
    }

    private static void Questao1()
    {
        string nome;
        Console.WriteLine("Informe o seu nome");
        nome = Console.ReadLine();
        Console.WriteLine($"Olá {nome}!, seja bem-vindo ao DotNet");
    }
}