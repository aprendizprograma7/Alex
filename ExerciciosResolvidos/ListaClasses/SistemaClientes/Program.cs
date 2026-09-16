internal class Program
{
    public class Clientes
    {
        public int NumeroPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public List<Produtos> produtos { get; set; } = new List<Produtos>();

        public void RegistrarPedido()
        {
            Console.WriteLine("Informe o número do pedido ");
            NumeroPedido = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a data do pedido (dd/mm/aaaa) ");
            DataPedido = Convert.ToDateTime(Console.ReadLine());
            string continuar = "n";

            do
            {
                Produtos produto = new Produtos();

                Console.WriteLine("Informe o nome do produto ");
                produto.NomeProduto = Console.ReadLine();
                Console.WriteLine("Informe o valor do produto");
                produto.ValorProduto = Convert.ToDecimal(Console.ReadLine());

                produtos.Add(produto);

                Console.WriteLine("Deseja adicionar outro produto? (s/n)");
                continuar = Console.ReadLine();
                Console.Clear();

            } while (continuar != "n" && continuar != "N");
        }

        public void ExibirValorTotalPedido()
        {
            decimal total = 0;
            
            foreach(Produtos produto in produtos)
            {
                total += produto.ValorProduto;
            }
            
            Console.WriteLine($"O valor total do pedido {NumeroPedido}, feito no dia {DataPedido.ToShortDateString()}, foi de {total:F2}");
        }
    }

    public class Produtos
    {
        public string NomeProduto { get; set; }
        public decimal ValorProduto { get; set; }
    }

    private static void Main(string[] args)
    {
        Clientes cliente = new Clientes();

        cliente.RegistrarPedido();
        cliente.ExibirValorTotalPedido();
    }
}