internal class Program
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public decimal Altura { get; set; }
        public int Idade { get; set; }

        public void Apresentacao()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e minha altura é {Altura} metros.");
        }         
    }

    private static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();

        Console.Write("Digite o nome da pessoa: ");
        pessoa.Nome = Console.ReadLine();
        Console.Write("Digite a altura da pessoa (em metros): ");
        pessoa.Altura = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite a idade da pessoa: ");
        pessoa.Idade = Convert.ToInt32(Console.ReadLine());

        pessoa.Apresentacao();
    }
}