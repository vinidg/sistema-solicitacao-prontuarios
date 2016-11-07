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
            string strCon = "data source = srv-mssql-01;initial catalog = DAHUE;user id = dahue; password = DT1_D@huE_1438_DtI";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
        }
    }
}
