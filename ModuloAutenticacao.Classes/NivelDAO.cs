using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModuloAutenticacao.Classes
{
    public class NivelDAO
    {
      
        public string Inserir(string nome)
        {   //abrindo a conexão
            Conexao.MinhaInstancia.Open();
            //Definindo o comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            //Definindo o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;
            //Definindo DML
            comando.CommandText = "INSERT INTO Nivel(Nome)Values(@Nome);";
            //Iniciando a DML         
            comando.Parameters.Add(new SqlParameter("@Nome", nome));
            //Esta tudo pronto! Vamos exeutar o comando.
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();


            return "Dados inseridos com sucesso!";
        }
        public string Atualizar(string id, string nome)
        {
            

            Conexao.MinhaInstancia.Open();
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = ("update Nivel set Nome=@Nome where codigo=@ID;");
            comando.Parameters.AddWithValue("@ID", id);
            comando.Parameters.AddWithValue("@Nome", nome);
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();


            return "Dados Atualizados";

        }
        public DataTable Pesquisar()

        {
            // abrindo a conexão
            Conexao.MinhaInstancia.Open();
            //Definindo o comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            //Definindo o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;
            //Definindo DQL - pesquisa
            comando.CommandText = "select* from Nivel";

            //DataTable (tabela na memória)
            DataTable dataTable = new DataTable();
            //Executa o SQL
            SqlDataReader reader = comando.ExecuteReader(); //Comando usado para pesquisar
            dataTable.Load(reader);
            //Carrega a tabela DataTable
            comando.ExecuteNonQuery(); //carregar pesquisa
            //Fecha conexão
            Conexao.MinhaInstancia.Close();
            //Retorna os dados da tabela
            return dataTable;

        }
        //sobrecarga de método-mesmo nome
        //overload
        public DataTable PesquisarPorNome(string nome)
        {
            
                Conexao.MinhaInstancia.Open();
                SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = ("SELECT * from Nivel where Nome=@Nome;");
                comando.Parameters.AddWithValue("@Nome", nome);
                DataTable dataTable = new DataTable();
                SqlDataReader reader = comando.ExecuteReader();
                dataTable.Load(reader);
                Conexao.MinhaInstancia.Close();

                return dataTable;

            
            //return $"Olá {nome}";
        }
        public string Deletar(string id)
        {
            Conexao.MinhaInstancia.Open();
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = ("delete Nivel where codigo=@id");//DELETE FROM Nivel WHERE Codigo=x;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();

            return "";


        }

    }



}

