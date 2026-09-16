public class Materiais
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public string Categoria { get; set; } = "";
    public int Quantidade { get; set; }
    public int EstoqueMinimo { get; set; }

    public void ExibirDados()
    {
        Console.WriteLine($"Código: {Id}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Categoria: {Categoria}");
        Console.WriteLine($"Quantidade: {Quantidade}");
        Console.WriteLine($"Estoque mínimo: {EstoqueMinimo}");
        
        if (Quantidade == 0)
        {
            Console.WriteLine("Status: ESTOQUE ZERADO");
        }
        else if (Quantidade <= EstoqueMinimo)
        {
            Console.WriteLine("Status: ESTOQUE BAIXO");
        }
        else
        {
            Console.WriteLine("Status: ESTOQUE NORMAL");
        }
        Console.WriteLine("---------------------");
    }
}