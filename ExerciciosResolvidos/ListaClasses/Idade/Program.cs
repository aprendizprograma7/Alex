internal partial class Program
{
    internal class Clientes
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento {get; set; }

        public void CadastrarClientes()
        {
            Console.WriteLine("Informe o nome do cliente ");
            Nome = Console.ReadLine();
            Console.WriteLine("Informa o email do cliente ");
            Email = Console.ReadLine();
            Console.WriteLine("Informe a data de nascimento do cliente (dd/mm/aaaa) ");
            DataNascimento = Convert.ToDateTime(Console.ReadLine());
        }

        public void MostrarIdade()
        {
            string anoAtual = DateTime.Now.Year.ToString();
            string anoNascimento = DataNascimento.Year.ToString();
            int idade = Convert.ToInt32(anoAtual) - Convert.ToInt32(anoNascimento);
            Console.WriteLine($"O cliente por nome {Nome} tem {idade} anos de idade");
        }

        public void MostrarIdade2()
        {
            Console.WriteLine($"O cliente por nome {Nome} tem {Convert.ToInt32(DateTime.Now.Year.ToString()) - Convert.ToInt32(DataNascimento.Year.ToString())} anos de idade");
        }

        public void MostrarIdade3()
        {
            Console.WriteLine($"O cliente por nome {Nome} tem {DateTime.Now.Date - DataNascimento.Date} anos de idade");
        }
    }

    private static void Main(string[] args)
    {
        Clientes cliente = new Clientes();

        cliente.CadastrarClientes();

        cliente.MostrarIdade3();
    }
}