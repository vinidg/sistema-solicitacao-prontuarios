using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using MySql.Data.MySqlClient;

namespace SistemaProntuario1
{
    static class ConexaoBd
    {

        public static MySqlConnection GetConexao()
        {
           // string conexao = "SERVER=DIV-HOS-AD03; Port=3306; DATABASE=dahue; UID=root; PASSWORD=dahue123;";
            string conexao = "SERVER=localhost; Port=3306; DATABASE=dahue; UID=root; PASSWORD=dahue123;";
            MySqlConnection objConexao = new MySqlConnection(conexao);
            objConexao.Open();
            return objConexao;
        }
    }
}
