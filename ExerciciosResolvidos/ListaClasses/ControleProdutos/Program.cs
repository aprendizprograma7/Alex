internal class Program
{
    internal class Produtos
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

        public void DefinirProduto()
        {
            Console.WriteLine("Informe o nome do produto ");
            Nome = Console.ReadLine();
            Console.WriteLine("Informe o valor do produto (R$ 0.00) ");
            Preco = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe a quantidade em estoque do produto ");
            QuantidadeEstoque = Convert.ToInt32(Console.ReadLine());
        }

        public void ExibirValorTotalEmEstoque()
        {
            Console.WriteLine($"O valor total em estoque do produto {Nome} é de {Preco * QuantidadeEstoque}");
        }
    }

    private static void Main(string[] args)
    {
        Produtos produto = new Produtos();

        produto.DefinirProduto();

        produto.ExibirValorTotalEmEstoque();   
    }
}