internal class Program
{
    public class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public decimal SaldoInicial { get; set; }
        public string TipoConta { get; set; }

        public void CriarConta()
        {
            Console.Clear();
            Console.WriteLine("Digite o número da conta:");
            NumeroConta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o saldo inicial:");
            SaldoInicial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o tipo de conta (Corrente/Poupança):");
            TipoConta = Console.ReadLine();
            Console.WriteLine($"Conta criada com sucesso! Saldo inicial: {SaldoInicial:C}");
        }

        public void Depositar()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor a ser depositado: ");
            decimal valorDeposito = Convert.ToDecimal(Console.ReadLine());
            SaldoInicial += valorDeposito;
            Console.WriteLine($"Depósito realizado com sucesso! Novo saldo: {SaldoInicial:C}");
        }

        public void Sacar()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor do saque: ");
            decimal valorSaque = Convert.ToDecimal(Console.ReadLine());
            if (valorSaque <= SaldoInicial)
            {
                SaldoInicial -= valorSaque;
                Console.WriteLine($"Saque realizado com sucesso! Novo saldo: {SaldoInicial:C}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
        }
    }

    private static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria();
        conta.CriarConta();
        string resposta = "";
        do
        {
            Console.WriteLine("\nEscolha uma opção:\n1 - Depositar\n2 - Sacar\n3 - Sair do Programa");
            int opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    conta.Depositar();
                    break;
                case 2:
                    conta.Sacar();
                    break;
                case 3:
                    Console.WriteLine("Saindo do programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
            Console.WriteLine("Deseja realizar outra operação? (S/N)");
            resposta = Console.ReadLine();
        } while (resposta.ToUpper() == "S");
    }
}