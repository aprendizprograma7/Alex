internal class Program
{
    private static void Main(string[] args)
    {
        string senha = "1234";
        string informacao = "";
        int contador = 0;
        do
        {
            Console.WriteLine("Informe a senha desejada");
            informacao = Console.ReadLine();
            Console.Clear();
        } while (senha != informacao);
    }
}