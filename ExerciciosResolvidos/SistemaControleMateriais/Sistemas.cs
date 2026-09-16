public class Sistemas
{
    public List<Materiais> Materiais { get; set; } = new List<Materiais>();
    public int Opcao { get; set; } = 0;
    public bool Executando { get; set; } = true;
    public BancoDados Banco { get; set; } = new BancoDados();

    public void Iniciar()
    {
        Console.Clear();
        Banco.CriarBanco();
        
        while (Executando)
        {
            ExibirMenu();

            switch (Opcao)
            {
                case 1:
                    CadastrarMaterial();
                    break;

                case 2:
                    ListarMateriais();
                    break;

                case 3:
                    ExibirResumo();
                    break;

                case 4:
                    PesquisarMaterial();
                    break;

                case 5:
                    AlterarMaterial();
                    break;

                case 6:
                    ExcluirMaterial();
                    break;

                case 7:
                    ExibirInformacoes();
                    break;

                case 0:
                    Encerrar();
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("Escolha uma opção entre 0 e 7.");
                    Console.ReadLine();
                    break;
            }    
        }        
    }

    public void ExibirMenu()
    {        
        Console.Clear();
        Console.WriteLine("=====================\nCONTROLE DE MATERIAIS TECHSCHOOL\n=====================");
        Console.WriteLine();
        Console.WriteLine("1 - Cadastrar Material\n2 - Listar Materiais\n3 - Exibir resumo do estoque\n4 - Pesquisar material por Id\n5 - Alterar material\n6 - Excluir material\n7 - Exibir informações do sistema\n0 - Encerrar");
        Console.WriteLine();
        Console.WriteLine("Digite a opção desejada:");
        Opcao = Convert.ToInt32(Console.ReadLine());
    }

    public void CadastrarMaterial()
    {
        Sistemas sistema = new Sistemas();
        Materiais material = new Materiais();

        do
        {
            Console.WriteLine("Digite o nome do material:");
            material.Nome = Console.ReadLine() ?? "";
            if (material.Nome == "")
            {
                Console.WriteLine("Nome do material não pode ser vazio.");
                return;
            }

            Console.WriteLine("Digite a categoria do material:");
            material.Categoria = Console.ReadLine() ?? "";
            if (material.Categoria == "")
            {
                Console.WriteLine("Categoria do material não pode ser vazio.");
                return;
            }
            
            Console.WriteLine("Digite a quantidade do material:");
            material.Quantidade = Convert.ToInt32(Console.ReadLine());
            if (material.Quantidade < 0)
            {
                Console.WriteLine("Quantidade do material não pode ser negativa.");
                return;
            }

            Console.WriteLine("Digite o estoque mínimo do material:");
            material.EstoqueMinimo = Convert.ToInt32(Console.ReadLine());
            if (material.EstoqueMinimo < 0)
            {
                Console.WriteLine("Estoque mínimo do material não pode ser negativo.");
                return;
            };
            Banco.SalvarMaterial(material);
            Console.WriteLine("Material cadastrado com sucesso!");
            Console.WriteLine("Deseja cadastrar outro material?\n1 - Sim\n2 - Não");
            sistema.Opcao = Convert.ToInt32(Console.ReadLine());
        } while (sistema.Opcao == 1);
    }

    public void PesquisarMaterial()
    {
        Console.Clear();
        Console.WriteLine("========================================");
        Console.WriteLine(" PESQUISAR MATERIAL");
        Console.WriteLine("========================================");

        Console.Write("Digite o Id do material: ");
        int.TryParse(Console.ReadLine(), out int id);

        Materiais? material = Banco.BuscarMaterialPorId(id);

        if (material == null)
        {
            Console.WriteLine("Material não encontrado.");
        }
        else
        {
            Console.WriteLine();
            material.ExibirDados();
        }

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para voltar ao menu.");
        Console.ReadLine();
    }

    public void ExcluirMaterial()
    {
        Console.Clear();
        Console.WriteLine("========================================");
        Console.WriteLine(" EXCLUIR MATERIAL");
        Console.WriteLine("========================================");

        Console.Write("Digite o Id do material: ");
        int.TryParse(Console.ReadLine(), out int id);

        Materiais? material = Banco.BuscarMaterialPorId(id);

        if (material == null)
        {
            Console.WriteLine("Material não encontrado.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine();
        Console.WriteLine("MATERIAL ENCONTRADO");
        material.ExibirDados();

        Console.WriteLine();
        Console.WriteLine("Deseja realmente excluir este material?\n1 - Sim\n2 - Não");
        Console.Write("Digite uma opção: ");

        string resposta = Console.ReadLine() ?? "2";

        if (resposta == "1")
        {
            bool excluido = Banco.ExcluirMaterial(id);

            if (excluido)
                Console.WriteLine("Material excluído com sucesso!");
            else
                Console.WriteLine("Não foi possível excluir o material.");
        }
        else
        {
            Console.WriteLine("Exclusão cancelada.");
        }

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para voltar ao menu.");
        Console.ReadLine();
    }

    public void AlterarMaterial()
    {
        Console.Clear();
        Console.WriteLine("========================================");
        Console.WriteLine(" ALTERAR MATERIAL");
        Console.WriteLine("========================================");

        Console.Write("Digite o Id do material: ");
        int.TryParse(Console.ReadLine(), out int id);

        Materiais? material = Banco.BuscarMaterialPorId(id);

        if (material == null)
        {
            Console.WriteLine("Material não encontrado.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine();
        Console.WriteLine("DADOS ATUAIS");
        material.ExibirDados();
        Console.WriteLine();

        Console.Write("Novo nome: ");
        string novoNome = Console.ReadLine() ?? "";

        Console.Write("Nova categoria: ");
        string novaCategoria = Console.ReadLine() ?? "";

        Console.Write("Nova quantidade: ");
        int.TryParse(Console.ReadLine(), out int novaQuantidade);

        Console.Write("Novo estoque mínimo: ");
        int.TryParse(Console.ReadLine(), out int novoEstoqueMinimo);

        if (string.IsNullOrWhiteSpace(novoNome) ||
            string.IsNullOrWhiteSpace(novaCategoria))
        {
            Console.WriteLine("Nome e categoria devem ser preenchidos.");
        }
        else if (novaQuantidade < 0 || novoEstoqueMinimo < 0)
        {
            Console.WriteLine("Quantidade e estoque mínimo não podem ser negativos.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Deseja confirmar a alteração?\n1 - Sim\n2 - Não");

            string resposta = Console.ReadLine() ?? "2";

            if (resposta == "1")
            {
                material.Nome = novoNome;
                material.Categoria = novaCategoria;
                material.Quantidade = novaQuantidade;
                material.EstoqueMinimo = novoEstoqueMinimo;

                bool alterado = Banco.AlterarMaterial(material);

                if (alterado)
                    Console.WriteLine("Material alterado com sucesso!");
                else
                    Console.WriteLine("Não foi possível alterar o material.");
            }
            else
            {
                Console.WriteLine("Alteração cancelada.");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para voltar ao menu.");
        Console.ReadLine();
    }

    public void ListarMateriais()
    {
        Console.Clear();
        Console.WriteLine("=====================\nMATERIAIS CADASTRADOS\n=====================");

        Materiais = Banco.ListarMateriais();

        if (Materiais.Count == 0)
        {
            Console.WriteLine("Nenhum material foi cadastrado!");
            Console.WriteLine("Utilize a opção 1 do menu para cadastrar.");
        }
        else
        {
            int cont = 1;         
            foreach (var material in Materiais)
            {
                Console.WriteLine($"MATERIAL {cont}");
                material.ExibirDados();
                Console.WriteLine("----------------------------------------");
                cont++;
            }
            
            if (Materiais.Count == 0)
            {
                Console.WriteLine("Nenhum material foi cadastrado.\nUtilize a opção 1 do menu para cadastrar materiais.");
            }
            else
            {
                Console.WriteLine($"Total de materiais cadastrados: {Materiais.Count}");
            }
            
        }   

        Console.WriteLine("\nListagem concluída. Pressione ENTER para voltar ao menu");
        Console.ReadKey();  
    }

    public void ExibirResumo()
    {
        Console.Clear();
        Console.WriteLine("=====================\nRESUMO DO ESTOQUE\n======================");
        Materiais = Banco.ListarMateriais();

        int totalUnidades = 0;

        foreach (var mat in Materiais)
        {
            totalUnidades += mat.Quantidade;
        }

        Console.WriteLine("Resumo do estoque de materiais cadastrados:");
        Console.WriteLine($"Materiais cadastrados: {Materiais.Count}");
        Console.WriteLine($"Total de materiais disponíveis: {totalUnidades}");
        Console.WriteLine();

        if (Materiais.Count > 0)
        {
            Console.WriteLine("Situação geral: Existem materiais cadastrados");
        }
        else
        {
            Console.WriteLine("Situação geral: Nenhum material cadastrado");
        }

        Console.WriteLine("Pressione ENTER para voltar ao menu principal...");
        Console.ReadKey();
    }

    public void ExibirInformacoes()
    {
        Console.Clear();
        Console.WriteLine("=====================\nINFORMAÇÕES DO SISTEMA\n======================");
        Console.WriteLine();
        Console.WriteLine("Sistema: Controle de Materiais TechSchool");
        Console.WriteLine("Versão: 3.0");
        Console.WriteLine("Tipo: Aplicação de console");
        Console.WriteLine("Persistência: SQLite");
        Console.WriteLine("Operações: Cadastro, pesquisa, alteração, exclusão e listagem");
        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para voltar ao menu principal...");
        Console.ReadKey();
    }

    public void Encerrar()
    {
        Console.Clear();
        Console.WriteLine("=====================\nENCERRAR APLICAÇÃO\n======================");
        Console.WriteLine("Deseja realmente encerrar a aplicação?\n1 - Sim\n2 - Não\nDigite a opção desejada:");
        int opcao = Convert.ToInt32(Console.ReadLine());
        if (opcao == 1)
        {
            Console.WriteLine("Aplicação encerrada. Pressione ENTER para sair...");
            Console.ReadKey();
            Executando = false;
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Pressione ENTER para voltar ao menu.");
            Console.ReadKey();
        }
    }
}