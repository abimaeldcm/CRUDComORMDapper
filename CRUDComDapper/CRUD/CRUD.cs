using Dapper;
using System;
using System.Data.SqlClient;

namespace CRUDComDapper.CRUD
{
    public class CRUD
    {
        public static void BuscarTodos()
        {
            using (SqlConnection conexao = new SqlConnection(StringConexao.Conexao()))
            {
                var Usuarios = conexao.Query<Funcionario>("SELECT * FROM Funcionario ORDER BY Nome");
                foreach (var item in Usuarios)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("");
                }
            };
        }
        public static void BuscarPorNome()
        {
            using (SqlConnection conexao = new SqlConnection(StringConexao.Conexao()))
            {
                try
                {
                    Console.Write("Informe o nome do usuário desejado:");
                    var nome = Console.ReadLine();
                    var UsuariosNome = conexao.Query<Funcionario>($"SELECT * FROM Funcionario WHERE Nome LIKE '%{nome}%';");
                    foreach (var item in UsuariosNome)
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("");
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine($"Erro ao buscar os usuários no banco. Detalhes: {erro.Message}");
                }

            };

        }
        public static void Adicionar()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(StringConexao.Conexao()))
                {
                    Console.Write("Informe o nome do funcionário:");
                    var nome = Console.ReadLine();
                    Console.Write("Informe o sobrenome do funcionário:");
                    var sobrenome = Console.ReadLine();

                    conexao.Execute($"INSERT INTO Funcionario (Nome, Sobrenome) VALUES ('{nome}', '{sobrenome}')");
                    Console.WriteLine($"Usuário {nome} Adicionado com sucesso");
                };
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro ao realizar a adição do funcionário ao banco. Detalhes: {erro.Message}");
            }
        }
        public static void Editar()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(StringConexao.Conexao()))
                {
                    CRUD.BuscarPorNome();
                    Console.WriteLine("Encontramos esses resultados. \nInforma o Id do usuário desejado:");
                    var Id = Console.ReadLine();
                    Console.WriteLine("Digite o novo nome:");
                    var Nome = Console.ReadLine();
                    Console.WriteLine("Digite o novo sobrenome:");
                    var Sobrenome = Console.ReadLine();
                    var UsuarioNome = conexao.Execute($"UPDATE Funcionario SET Nome = '{Nome}', Sobrenome = '{Sobrenome}' WHERE Id = {Id}");
                    Console.WriteLine("Usuário editado com sucesso!");
                };
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro ao editar o usuário no banco. Detalhes: {erro.Message}");
            }
        }
        public static void Excluir()
        {
            try
            {
                using (SqlConnection conexao = new SqlConnection(StringConexao.Conexao()))
                {
                    CRUD.BuscarPorNome();
                    Console.WriteLine("Encontramos esses resultados. \nInforma o Id do usuário desejado:");
                    var IdFuncionario = Console.ReadLine();
                    Console.WriteLine("Digite o novo nome:");
                    conexao.Execute($"DELETE FROM Funcionario WHERE Id = {IdFuncionario};");
                    Console.WriteLine("Usuário deletado com sucesso");
                };

            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro ao buscar os usuário no banco. Detalhes: {erro.Message}");
            }
            
        }
    }
}
