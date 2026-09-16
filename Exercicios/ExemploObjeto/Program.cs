using System.Reflection;

internal partial class Program
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public decimal Altura { get; set; }

        public void Apresentacao(string nome, int idade, decimal altura)
        {
            Console.WriteLine($"Olá, meu nome é {nome}, tenho {altura} metros de altura e possuo {idade} anos.");
        }
    }

    private static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();
        Console.WriteLine("Informe o nome da pessoa ");
        pessoa.Nome = Console.ReadLine();
        Console.WriteLine("Informe a altura da pessoa ");
        pessoa.Altura = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Informe a idade da pessoa ");
        pessoa.Idade = Convert.ToInt32(Console.ReadLine());

        pessoa.Apresentacao(pessoa.Nome, pessoa.Idade, pessoa.Altura);        
    }
}