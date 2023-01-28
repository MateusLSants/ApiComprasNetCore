using Dapper;
using MySqlConnector;

namespace AppComprasNetCore.Infra.Data.Migrations;

public static class DataBase
{
    public static void CriarDataBase(string conexaoBancoDados, string nomeBancoDados)
    {
        using var minhaConexao = new MySqlConnection(conexaoBancoDados);

        var parametros = new DynamicParameters();
        parametros.Add("nome", nomeBancoDados);

        var registros = minhaConexao.Query("SELECT * FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @nome", parametros);

        if (!registros.Any())
        {
            minhaConexao.Execute($"CREATE DATABASE {nomeBancoDados}");
        }
    }    
}
