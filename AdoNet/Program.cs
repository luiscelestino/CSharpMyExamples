using System;
using System.Data.SqlClient;

namespace AdoNet
{
    class Program
    {
        static string GetConnString()
        {
            string connString = "Server=DESKTOP-94SNDR2\\SQLEXPRESS;Database=CSharpAdoNET;" +
                "User Id=sa;Password=serpro";
            return connString;
        }

        static void ListarClientes()
        {
            // criando conexao com o BD
            string connString = GetConnString();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // abrindo conexao
                conn.Open();

                // criando comando para ser executado
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM clientes ORDER BY id";

                // executando o comando
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    // exibindo resultado
                    while (dr.Read())
                    {
                        Console.WriteLine("ID: {0}", dr["id"]);
                        Console.WriteLine("Nome: {0}", dr["nome"]);
                        Console.WriteLine("E-mail: {0}", dr["email"]);
                        Console.WriteLine("--------------------------");
                    }
                }
            }
        }

        static void SalvarCliente(string nome, string email)
        {
            // criando conexao com o BD
            string connString = GetConnString();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // abrindo conexao
                conn.Open();

                // criando sql dinâmico para ser executado, usando bind
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO clientes (nome, email) VALUES (@nome, @email)";
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);

                // executando o comando
                cmd.ExecuteNonQuery();
            }
        }

        static void SalvarCliente(string nome, string email, int id)
        {
            // criando conexao com o BD
            string connString = GetConnString();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // abrindo conexao
                conn.Open();

                // criando sql dinâmico para ser executado, usando bind
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE clientes SET nome=@nome, email=@email WHERE id=@id";
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", id);

                // executando o comando
                cmd.ExecuteNonQuery();
            }
        }

        static (int, string, string) SelecionarCliente(int id)
        {
            // declarando uma tupla para retorno
            (int, string, string) retorno;

            // criando conexao com o BD
            string connString = GetConnString();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // abrindo conexao
                conn.Open();

                // criando comando para ser executado
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM clientes WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", id);

                // executando o comando
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    // armazenando resultado em uma tupla
                    dr.Read();
                    retorno = (int.Parse(dr["id"].ToString()), dr["nome"].ToString(), dr["email"].ToString());
                }
            }

            // retornando resultado
            return retorno;
        }

        static void DeletarCliente(int id)
        {
            // criando conexao com o BD
            string connString = GetConnString();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                // abrindo conexao
                conn.Open();

                // criando sql dinâmico para ser executado, usando bind
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM clientes WHERE id=@id";
                cmd.Parameters.AddWithValue("@id", id);

                // executando o comando
                cmd.ExecuteNonQuery();
            }
        }

        static void Main(string[] args)
        {
            // exibindo titulo e opções da aplicação
            Console.Title = "Controle de Clientes";
            Console.WriteLine("====================== CONTROLE DE CLIENTES ======================");
            Console.WriteLine();
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Listar");
            Console.WriteLine("2 - Cadastrar");
            Console.WriteLine("3 - Editar");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("5 - Visualizar");

            // lendo uma opção do teclado
            Console.WriteLine();
            Console.Write("Opção: ");
            int opc = int.Parse(Console.ReadLine());
            
            // limpa a tela
            Console.Clear();

            // seleciona opcao
            switch(opc)
            {
                case 1:
                    Console.Title = "Listagem de Clientes";
                    Console.WriteLine("====================== LISTAGEM DE CLIENTES ======================");
                    ListarClientes();
                    break;
                case 2:
                    Console.Title = "Novo Cliente";
                    Console.WriteLine("====================== CADASTRO DE CLIENTE ======================");
                    Console.Write("Informe um nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Informe um e-mail: ");
                    string email = Console.ReadLine();
                    SalvarCliente(nome, email);
                    break;
                case 3:
                    Console.Title = "Alteração de Cliente";
                    Console.WriteLine("====================== ALTERAÇÃO DE CLIENTE ======================");
                    ListarClientes();
                    Console.Write("Selecione o cliente pelo ID: ");
                    int id = int.Parse(Console.ReadLine());
                    (int idSelecionado, string nomeSelecionado, string emailSelecionado) = SelecionarCliente(id);

                    Console.Clear();
                    Console.Title = $"Alteração de Cliente - {nomeSelecionado}";
                    Console.WriteLine($"====================== ALTERAÇÃO DE CLIENTE - {nomeSelecionado} ======================");
                    Console.Write("Informe um nome: ");
                    nome = Console.ReadLine();
                    nome = nome.Equals("") ? nomeSelecionado : nome;
                    Console.Write("Informe um e-mail: ");
                    email = Console.ReadLine();
                    email = email.Equals("") ? emailSelecionado : email;
                    SalvarCliente(nome, email, id);

                    break;
                case 4:
                    Console.Title = "Exclusão de Cliente";
                    Console.WriteLine("====================== EXCLUSÃO DE CLIENTE ======================");
                    ListarClientes();
                    Console.Write("Selecione o cliente pelo ID: ");
                    id = int.Parse(Console.ReadLine());
                    (idSelecionado, nomeSelecionado, emailSelecionado) = SelecionarCliente(id);

                    Console.Clear();
                    Console.Title = $"Exclusão de Cliente - {nomeSelecionado}";
                    Console.WriteLine($"====================== EXCLUSÃO DE CLIENTE - {nomeSelecionado} ======================");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("********************** ATENÇÃO **********************");
                    Console.WriteLine();
                    Console.Write("Confirma a exclusão do cliente (s/n)? ");
                    string confirma = Console.ReadLine().ToUpper();

                    if (confirma.Equals("S"))
                    {
                        DeletarCliente(id);
                    }
                    
                    break;
                case 5:
                    Console.Title = "Visualização de Cliente";
                    Console.WriteLine("====================== DETALHES DE CLIENTE ======================");
                    ListarClientes();
                    Console.Write("Selecione o cliente pelo ID: ");
                    id = int.Parse(Console.ReadLine());
                    (idSelecionado, nomeSelecionado, emailSelecionado) = SelecionarCliente(id);

                    Console.Clear();
                    Console.Title = $"Visualização de Cliente - {nomeSelecionado}";
                    Console.WriteLine($"====================== DETALHES DE CLIENTE - {nomeSelecionado} ======================");
                    Console.WriteLine();
                    Console.WriteLine("ID: {0}", idSelecionado);
                    Console.WriteLine("Nome: {0}", nomeSelecionado);
                    Console.WriteLine("E-mail: {0}", emailSelecionado);

                    break;
                default:
                    Console.Title = "Opção Inválida";
                    Console.WriteLine("====================== SELECIONE UMA OPÇÃO VÁLIDA ======================");
                    break;
            }

            // aguarda pressionar tecla para sair
            Console.ReadKey();
        }
    }
}
