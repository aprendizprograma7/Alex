internal class Program
{
    private static void Main(string[] args)
    {
        Questao15();
    }

    private static void Questao01()
    {
        string nome;
        Console.WriteLine("Informe o seu nome");
        nome = Console.ReadLine();
        Console.WriteLine($"Olá {nome}! Seja bem-vindo ao DotNet!!!");
    }

    private static void Questao02()
    {
        int idade;
        Console.WriteLine("Informe a sua idade");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Você tem {idade} anos.");
    }

    private static void Questao3()
    {
        string cidade;
        Console.WriteLine("Informe a cidade que você mora");
        cidade = Console.ReadLine();
        Console.WriteLine($"Você mora em {cidade}");
    }

    private static void Questao4()
    {
        decimal altura;
        Console.WriteLine("Informe a altura");
        altura = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"A altura informada foi de {altura} metros");
    }

    private static void Questao5()
    {
        decimal peso;
        Console.WriteLine("Informe seu peso");
        peso = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"Seu peso é {peso} quilos.");
    }

    private static void Questao6()
    {
        string nome;
        Console.WriteLine("Informe o seu nome completo");
        nome = Console.ReadLine();
        Console.WriteLine($"O seu nome completo é {nome}");
    }

    private static void Questao7()
    {
        string serieAno;
        Console.WriteLine("Informe qual a sua série/ano");
        serieAno = Console.ReadLine();
        Console.WriteLine($"A sua série/ano é {serieAno}");
    }

    private static void Questao8()
    {
        decimal nota;
        Console.WriteLine("Informe a sua nota");
        nota = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"Nota Registrada: {nota}");
    }

    private static void Questao9()
    {
        char letra;
        Console.WriteLine("Informe uma letra");
        letra = Convert.ToChar(Console.ReadLine());
        Console.WriteLine($"Sua letra favorita é {letra}");
    }

    private static void Questao10()
    {
        char genero;
        Console.WriteLine("Informe o seu gênero (M/F)");
        genero = Convert.ToChar(Console.ReadLine());
        Console.WriteLine($"O seu gênero é {genero}");
    }

    private static void Questao11()
    {
        string nomeTime;
        Console.WriteLine("Informe o nome do seu time de futebol");
        nomeTime = Console.ReadLine();
        Console.WriteLine($"O nome do seu time é {nomeTime}");
    }

    private static void Questao12()
    {
        string filmeFavorito;
        Console.WriteLine("Informe o nome do seu filme favorito");
        filmeFavorito = Console.ReadLine();
        Console.WriteLine($"O seu filme favorito é {filmeFavorito}");
    }

    private static void Questao13()
    {
        int numeroTelefone;
        Console.WriteLine("Informe o número de telefone (apenas números)");
        numeroTelefone = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O seu número de telefone é {numeroTelefone}");
    }

    private static void Questao14()
    {
        string dia, mes, ano;
        Console.WriteLine("Informe o dia do seu nascimento");
        dia = Console.ReadLine();
        Console.WriteLine("Informe o mês do seu nascimento");
        mes = Console.ReadLine();
        Console.WriteLine("Informe o ano do seu nascimento");
        ano = Console.ReadLine();
        Console.WriteLine($"Data de Nascimento: {dia}/{mes}/{ano}");
    }

    private static void Questao15()
    {
        string nome, idade, cidade;
        Console.WriteLine("Informe o seu nome");
        nome = Console.ReadLine();
        Console.WriteLine("Informe a sua idade");
        idade = Console.ReadLine();
        Console.WriteLine("Informe a cidade que você mora");
        cidade = Console.ReadLine();
        Console.WriteLine($"FICHA CADASTRAL\n");
        Console.WriteLine($"Nome: {nome}\nIdade: {idade} anos\nCidade: {cidade}");
    }

    private static void Questao16()
    {
        string nomeJogador, posicao;
        int numeroCamisa;
        Console.WriteLine("Informe o nome do jogador");
        nomeJogador = Console.ReadLine();
        Console.WriteLine("Informe o número da camisa");
        numeroCamisa = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a posição do jogador");
        posicao = Console.ReadLine();
        Console.WriteLine($"O jogador {nomeJogador}, atua com a camisa número {numeroCamisa} e joga na posição {posicao}");
    }

    private static void Questao17()
    {
        string nome, cidade;
        int idade;
        Console.WriteLine("Informe o seu nome");
        nome = Console.ReadLine();
        Console.WriteLine("Informe a sua idade");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a cidade que você mora");
        cidade = Console.ReadLine();
        Console.WriteLine($"Olá {nome}, você tem {idade} anos e mora na cidade de {cidade}");
    }

    private static void Questao18()
    {
        string nome, cursoDesejado, cidade;
        int idade;
        Console.WriteLine("Informe o seu nome");
        nome = Console.ReadLine();
        Console.WriteLine("Informe a sua idade");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a cidade que você mora");
        cidade = Console.ReadLine();
        Console.WriteLine("Informe o curso desejado");
        cursoDesejado = Console.ReadLine();
        Console.WriteLine($"Olá {nome}, você tem {idade} anos, mora na cidade de {cidade} e deseja fazer o curso de {cursoDesejado}");
    }

    private static void Questao19()
    {
        string nome, serie, cidade, materiaFavorita;
        int idade;
        decimal altura;
        Console.WriteLine("Informe o seu nome");
        nome = Console.ReadLine();
        Console.WriteLine("Informe a sua idade");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a sua altura");
        altura = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Informe a cidade que você mora");
        cidade = Console.ReadLine();
        Console.WriteLine("Informe a sua série/ano");
        serie = Console.ReadLine();
        Console.WriteLine("Informe a sua matéria favorita");
        materiaFavorita = Console.ReadLine();
        Console.WriteLine($"Olá {nome}, você tem {idade} anos, mede {altura} metros, mora na cidade de {cidade}, está cursando a série/ano {serie} e sua matéria favorita é {materiaFavorita}");
    }
}