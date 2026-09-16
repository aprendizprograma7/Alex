internal class Program
{
    private static void Main(string[] args)
    {
        char continuar = 's';
        int opcao = 0;
        decimal n1, n2;

        do
        {
            Console.Clear();
            Console.WriteLine("CALCULADORA CONSOLE\nSelecione uma das opções abaixo\n1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir");
            opcao = Convert.ToInt32(Console.ReadLine());
            if (opcao == 1 || opcao == 2 ||  opcao == 3 || opcao == 4)
            {
                Console.WriteLine("Informe o primeiro número ");
                n1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Informe o segundo número ");
                n2 = Convert.ToDecimal(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine($"A soma dos dois números é igual a {(n1 + n2)}");
                }
                else if (opcao == 2)
                {
                    Console.WriteLine($"A subtração entre os dois números é igual a {(n1 - n2)}");
                }
                else if (opcao == 3)
                {
                    Console.WriteLine($"A multiplicação dos dois números é igual a {(n1 * n2)}");
                }
                else
                {
                    Console.WriteLine($"A divisão entre os dois números é igual a {(n1 / n2)}");
                }
                Console.WriteLine("Deseja continuar com outro cálculo?");
                continuar = Convert.ToChar(Console.ReadLine());
                if (continuar == 'n' || continuar == 's')
                {
                    
                }
                else
                {
                    return;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida");
                return;
            }
            
        } while (continuar != 'n');
    }
}