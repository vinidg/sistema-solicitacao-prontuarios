using MySql.Data.MySqlClient;
using SistemaProntuario1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Pesquisa : Form
    {
        string nmupa = "";
        public Pesquisa(string numeroUpa)
        {
            InitializeComponent();
            nmupa = numeroUpa;
            PesquisarDados();
        }

        string IDpesquisa;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ListaPesquisa.SelectedItems.Count > 0)
            {
                IDpesquisa = ListaPesquisa.SelectedItems[0].Text;
            }
            // this.Dispose();
            Status ST = new Status(IDpesquisa);
            ST.ShowDialog();
        }

        private void Pesquisa_Load(object sender, EventArgs e)
        {
            PesquisarDados();

        }

        private void PesquisarDados()
        {
            string sqlQuery = "";
            ListaPesquisa.Items.Clear();
            SqlConnection conexao = ConexaoSqlServer.GetConexao();

            if (txtID.Text == "")
            {
                sqlQuery = "SELECT * FROM prontuariosupas WHERE Unidade = '" + nmupa + "'";
            }
            else
            {
                sqlQuery = "SELECT * FROM prontuariosupas WHERE idProntuarios='" + txtID.Text + "' and Unidade = '" + nmupa + "'";

            }
            if (txtPacientePesquisa.Text != "")
            {

                sqlQuery = "SELECT * FROM prontuariosupas WHERE NomePaciente like '" + txtPacientePesquisa.Text + "%' and Unidade = '" + nmupa + "'";

            } if (txtRgPaciente.Text != "")
            {
                sqlQuery = "SELECT * FROM prontuariosupas WHERE RgPaciente like '" + txtRgPaciente.Text + "%' and Unidade = '" + nmupa + "'";
            }

            try
            {

                SqlCommand objComm = new SqlCommand(sqlQuery, conexao);
                SqlDataReader MyReader2;

                MyReader2 = objComm.ExecuteReader();
                while (MyReader2.Read())
                {
                    ListViewItem IT = new ListViewItem(MyReader2["idProntuarios"].ToString());
                    IT.SubItems.Add(MyReader2["NomePaciente"].ToString());
                    IT.SubItems.Add(MyReader2["NomedaMae"].ToString());
                    IT.SubItems.Add(MyReader2["NomeSoliciante"].ToString());
                    IT.SubItems.Add(MyReader2["Motivo"].ToString());
                    IT.SubItems.Add(MyReader2["RgPaciente"].ToString());
                    IT.SubItems.Add(MyReader2["RgSolicitante"].ToString());
                    IT.SubItems.Add(MyReader2["DtNascimento"].ToString());
                    IT.SubItems.Add(MyReader2["DtAtendimento"].ToString());
                    IT.SubItems.Add(MyReader2["Telefone"].ToString());
                    IT.SubItems.Add(MyReader2["Unidade"].ToString());
                    IT.SubItems.Add(MyReader2["Internacao"].ToString());
                    IT.SubItems.Add(MyReader2["Dias"].ToString());
                    IT.SubItems.Add(MyReader2["DtSolicitacao"].ToString());
                    IT.SubItems.Add(MyReader2["Obs"].ToString());
                    IT.SubItems.Add(MyReader2["Status"].ToString());
                    IT.SubItems.Add(MyReader2["Funcionario"].ToString());
                    IT.SubItems.Add(MyReader2["DtRetirada"].ToString());
                    IT.SubItems.Add(MyReader2["Motivo_Rg"].ToString());
                    IT.SubItems.Add(MyReader2["DtHrFato"].ToString());
                    IT.SubItems.Add(MyReader2["LocalFato"].ToString());
                    ListaPesquisa.Items.Add(IT);



                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarDados();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnPesquisar.PerformClick();
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnPesquisar.PerformClick();
            }
        }

        private void txtPacientePesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnPesquisar.PerformClick();
            }
            PesquisarDados();
        }

        private void txtRgPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnPesquisar.PerformClick();
            }
            PesquisarDados();
        }

        private void txtUnidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnPesquisar.PerformClick();
            }
        }

        private void txtStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnPesquisar.PerformClick();
            }
        }


    }

}



