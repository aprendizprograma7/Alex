using Microsoft.Data.Sqlite;

public class BancoDados
{
    private string ConnectionString = "Data Source=techschool.db";

    public void CriarBanco()
    {
        using SqliteConnection conexao = new SqliteConnection(ConnectionString);
        conexao.Open();

        string sql = @"
            CREATE TABLE IF NOT EXISTS Materiais (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nome TEXT NOT NULL,
                Categoria TEXT NOT NULL,
                Quantidade INTEGER NOT NULL,
                EstoqueMinimo INTEGER NOT NULL
            );";

        using SqliteCommand comando = new SqliteCommand(sql, conexao);
        comando.ExecuteNonQuery();
    }

    public void SalvarMaterial(Materiais material)
    {
        using SqliteConnection conexao = new SqliteConnection(ConnectionString);
        conexao.Open();

        string sql = @"
            INSERT INTO Materiais
            (Nome, Categoria, Quantidade, EstoqueMinimo)
            VALUES
            (@Nome, @Categoria, @Quantidade, @EstoqueMinimo);";

        using SqliteCommand comando = new SqliteCommand(sql, conexao);
        comando.Parameters.AddWithValue("@Nome", material.Nome);
        comando.Parameters.AddWithValue("@Categoria", material.Categoria);
        comando.Parameters.AddWithValue("@Quantidade", material.Quantidade);
        comando.Parameters.AddWithValue("@EstoqueMinimo", material.EstoqueMinimo);
        comando.ExecuteNonQuery();
    }

    public List<Materiais> ListarMateriais()
    {
        List<Materiais> materiais = new List<Materiais>();

        using SqliteConnection conexao = new SqliteConnection(ConnectionString);
        conexao.Open();

        string sql = @"
            SELECT Id, Nome, Categoria, Quantidade, EstoqueMinimo
            FROM Materiais
            ORDER BY Id;";

        using SqliteCommand comando = new SqliteCommand(sql, conexao);
        using SqliteDataReader leitor = comando.ExecuteReader();

        while (leitor.Read())
        {
            Materiais material = new Materiais();
            material.Id = leitor.GetInt32(0);
            material.Nome = leitor.GetString(1);
            material.Categoria = leitor.GetString(2);
            material.Quantidade = leitor.GetInt32(3);
            material.EstoqueMinimo = leitor.GetInt32(4);
            materiais.Add(material);
        }

        return materiais;
    }

    public Materiais? BuscarMaterialPorId(int id)
    {
        using SqliteConnection conexao = new SqliteConnection(ConnectionString);
        conexao.Open();

        string sql = @"
            SELECT Id, Nome, Categoria, Quantidade, EstoqueMinimo
            FROM Materiais
            WHERE Id = @Id;";

        using SqliteCommand comando = new SqliteCommand(sql, conexao);
        comando.Parameters.AddWithValue("@Id", id);

        using SqliteDataReader leitor = comando.ExecuteReader();

        if (leitor.Read())
        {
            Materiais material = new Materiais();
            material.Id = leitor.GetInt32(0);
            material.Nome = leitor.GetString(1);
            material.Categoria = leitor.GetString(2);
            material.Quantidade = leitor.GetInt32(3);
            material.EstoqueMinimo = leitor.GetInt32(4);
            return material;
        }

        return null;
    }

    public bool AlterarMaterial(Materiais material)
    {
        using SqliteConnection conexao = new SqliteConnection(ConnectionString);
        conexao.Open();

        string sql = @"
            UPDATE Materiais
            SET Nome = @Nome,
                Categoria = @Categoria,
                Quantidade = @Quantidade,
                EstoqueMinimo = @EstoqueMinimo
            WHERE Id = @Id;";

        using SqliteCommand comando = new SqliteCommand(sql, conexao);
        comando.Parameters.AddWithValue("@Nome", material.Nome);
        comando.Parameters.AddWithValue("@Categoria", material.Categoria);
        comando.Parameters.AddWithValue("@Quantidade", material.Quantidade);
        comando.Parameters.AddWithValue("@EstoqueMinimo", material.EstoqueMinimo);
        comando.Parameters.AddWithValue("@Id", material.Id);

        return comando.ExecuteNonQuery() > 0;
    }

    public bool ExcluirMaterial(int id)
    {
        using SqliteConnection conexao = new SqliteConnection(ConnectionString);
        conexao.Open();

        string sql = "DELETE FROM Materiais WHERE Id = @Id;";

        using SqliteCommand comando = new SqliteCommand(sql, conexao);
        comando.Parameters.AddWithValue("@Id", id);

        return comando.ExecuteNonQuery() > 0;
    }
}
