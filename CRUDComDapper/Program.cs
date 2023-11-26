using CRUDComDapper.CRUD;

namespace CRUDComDapper
{
    public class Program
    {
        static void Main(string[] args)
        {
        Inicio:
            try
            {
                Console.WriteLine("SISTEMA DE GERENCIAMENTO DE USUÁRIOS DAPPER");
                Console.WriteLine("1 - BUSCAR TODOS USUÁRIOS");
                Console.WriteLine("2 - BUSCAR USUÁRIO POR NOME");
                Console.WriteLine("3 - ADICIONAR USUÁRIO");
                Console.WriteLine("4 - EDITAR USUÁRIO");
                Console.WriteLine("5 - EXCLUIR USUÁRIO");

                Console.Write("SELECIONE UMA OPÇÃO: ");
                var opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CRUD.CRUD.BuscarTodos();
                        break;

                    case 2:
                        CRUD.CRUD.BuscarPorNome();
                        break;

                    case 3:
                        CRUD.CRUD.Adicionar();
                        break;

                    case 4:
                        CRUD.CRUD.Editar();
                        break;
                    case 5:
                        CRUD.CRUD.Excluir();
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("Aperte enter para uma nova consulta");
                Console.ReadKey();

                Console.Clear();
                goto Inicio;
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Um erro aconteceu. Tente novamente!");
                Console.WriteLine();
                goto Inicio;
            }

        }
    }
}