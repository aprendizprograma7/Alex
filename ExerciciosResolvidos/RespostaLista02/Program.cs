internal partial class Program
{
    private static void Main(string[] args)
    {
        
    }

    private static void Questao1()
    {
        int n1, n2, n3, n4, n5, soma;
        Console.WriteLine("Digite o primeiro número:");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o terceiro número:");
        n3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o quarto número:");
        n4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o quinto número:");
        n5 = Convert.ToInt32(Console.ReadLine());
        soma = n1 + n2 + n3 + n4 + n5;
        Console.WriteLine($"A soma dos números digitados é: {soma}");
    }

    private static void Questao2()
    {
        int n1, n2;
        Console.WriteLine("Digite o primeiro número:");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"A subtração do primeiro número pelo segundo é: {n1 - n2}");
    }

    private static void Questao3()
    {
        int numero;
        Console.WriteLine("Informe o número: ");
        numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O dobro do valor informado é igual a {numero * 2}");
    }

    private static void Questao4()
    {
        int n1, n2, n3;
        Console.WriteLine("Digite o primeiro número:");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o terceiro número:");
        n3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"A média dos números digitados é: {(n1 + n2 + n3) / 3}");
    }

    private static void Questao5()
    {
        int n1, n2;
        Console.WriteLine("Digite o primeiro número:");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"A multiplicação do primeiro número pelo segundo é: {n1 * n2}");
    }

    private static void Questao6()
    {
        int numero;
        Console.WriteLine("Digite o número:");
        numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"A metade do número é: {numero / 2}");
    }

    private static void Questao7()
    {
        decimal valor, desconto, valorFinal;
        Console.WriteLine("Digite o valor do produto:");
        valor = Convert.ToDecimal(Console.ReadLine());
        desconto = valor * 0.10m;
        valorFinal = valor - desconto;
        Console.WriteLine($"O valor final do produto com desconto de 10% é: {valorFinal}");
    }
}