internal class Program
{
    private static void Main(string[] args)
    {
        
    }

    private static void Questao1()
    {
        int numero;
        Console.WriteLine("Digite um número: ");
        numero = Convert.ToInt32(Console.ReadLine());
        if (numero > 20)
        {
            Console.WriteLine("O número informado é maior que 20.");
        }
        else
        {
            Console.WriteLine("O número informado não é menor que 20");
        }
    }

    private static void Questao3()
    {
        int numero;
        Console.WriteLine("Digite um número: ");
        numero = Convert.ToInt32(Console.ReadLine());
        if (numero % 2 == 0)
        {
            Console.WriteLine("O número informado é par.");
        }
        else
        {
            Console.WriteLine("O número informado é ímpar.");
        }
    }

    private static void Questao4()
    {
        int numero;
        Console.WriteLine("Digite um número:");
        numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("O número informado é POSITIVO!");
        }
        else if (numero == 0)
        {
            Console.WriteLine("O número informado é NULO!");
        }
        else
        {
            Console.WriteLine("O número informado é NEGATIVO!");
        }
    }
}