using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_makeup
{
    internal class ClienteDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        //Sempre o nome da classe
        public ClienteDAO() //método construtor
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public void Insert(Cliente cliente)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText =
            @"INSERT INTO 
            Cliente VALUES 
            (@nome, @sobrenome, @cidade,@cpf,@estado,@telefone)";

            Command.Parameters.AddWithValue("@nome", cliente.Nome);
            Command.Parameters.AddWithValue("@sobrenome", cliente.Sobrenome);
            Command.Parameters.AddWithValue("@cidade", cliente.Cidade);
            Command.Parameters.AddWithValue("@cpf", cliente.Cpf);
            Command.Parameters.AddWithValue("@estado", cliente.Estado);
            Command.Parameters.AddWithValue("@telefone", cliente.Telefone);


            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " +
                    "erro no cadastro.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }


        public void Update(Cliente cliente)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Property SET 
            Nome = @nome,
            Sobrenome = @sobrenome,
            Cidade = @cidade,
            Cpf =@cpf,
            Estado = @estado,
            Telefone = @telefone
            WHERE CodProperty = @code";

            Command.Parameters.AddWithValue("@nome", cliente.Nome);
            Command.Parameters.AddWithValue("@sobrenome", cliente.Sobrenome);
            Command.Parameters.AddWithValue("@cidade", cliente.Cidade);
            Command.Parameters.AddWithValue("@cpf", cliente.Cpf);
            Command.Parameters.AddWithValue("@estado", cliente.Estado);
            Command.Parameters.AddWithValue("@telefone", cliente.Telefone);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: " +
                    "Problemas ao realizar atualização de " +
                    "erro no cadastro.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Delete(int codCliente)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Cliente
            WHERE CodCliente = @code";
            Command.Parameters.AddWithValue("@code", codCliente);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir " +
                    "dígito errado.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Cliente> ListAllCliente()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Cliente";

            List<Cliente> listaclientes = new List<Cliente>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Cliente cliente = new Cliente(
                        (int)rd["CodCliente"],
                        (string)rd["Nome"],
                        (string)rd["Sobrenome"],
                        (string)rd["Cidade"],
                        (string)rd["Cpf"],
                        (string)rd["Estado"],
                        (string)rd["Telefone"]
                        );

                    listaclientes.Add(cliente);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar " +
                    "cadatro feito incorretamente.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return listaclientes;
        }
    }
}

