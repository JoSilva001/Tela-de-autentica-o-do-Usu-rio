using System.Data.Common;
using System.Data.SqlClient;

namespace ModuloAutenticacao.Classes
{
    internal class Conexao
    {
        public static SqlConnection _conn;

        //Propriedade Automática
        public static SqlConnection MinhaInstancia
        { //a chave da propriedade
            get
            { //a chave do método get
                //se não existe conexão.
                if (_conn == null)
                {
                    //criar a conexão com SqlServer  //nos parênteses -connection string
                    _conn = new SqlConnection(@"Server = Lab206_9; Database = projetoestoquev; Uid = sa; Pwd = teste*123;");
                }
                //retorna a conexão
                return _conn;
            }
        }

    }
}
