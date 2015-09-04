using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ConexaoSqlServer
    {
        public static SqlConnection GetConexao()
        {
            string strCon = "data source = XXX;initial catalog = XXXX;user id = dXXXXX; password = XXXX";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
        }
    }
}
