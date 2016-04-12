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

        string IDpesquisa, nomePaciente;


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
               if (nmupa == "DAHUE") {
                   sqlQuery = "SELECT * FROM prontuariosupas";
               }
               else {
                   sqlQuery = "SELECT * FROM prontuariosupas WHERE Unidade = '" + nmupa + "'";
               }
               
            }
            else
            {
                if (nmupa == "DAHUE")
                {
                    sqlQuery = "SELECT * FROM prontuariosupas WHERE idProntuarios='" + txtID.Text + "'";
                }
                else { 
                    sqlQuery = "SELECT * FROM prontuariosupas WHERE idProntuarios='" + txtID.Text + "' and Unidade = '" + nmupa + "'"; 
                }

            }
            if (txtPacientePesquisa.Text != "")
            {
                if (nmupa == "DAHUE")
                {
                    sqlQuery = "SELECT * FROM prontuariosupas WHERE NomePaciente like '" + txtPacientePesquisa.Text + "%'";
                }
                else { 
                    sqlQuery = "SELECT * FROM prontuariosupas WHERE NomePaciente like '" + txtPacientePesquisa.Text + "%' and Unidade = '" + nmupa + "'"; 
                }

                

            } if (txtRgPaciente.Text != "")
            {
                if (nmupa == "DAHUE")
                {
                    sqlQuery = "SELECT * FROM prontuariosupas WHERE RgPaciente like '" + txtRgPaciente.Text + "%'";
                }
                else { 
                    sqlQuery = "SELECT * FROM prontuariosupas WHERE RgPaciente like '" + txtRgPaciente.Text + "%' and Unidade = '" + nmupa + "'"; 
                }

                
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

        string NomePaciente, DtNasc, RgPaciente, NomeSolicitante, DtAtend, Dias, Unidade, Telefone, Internacao;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string txtID = "";
            SqlConnection conexao = ConexaoSqlServer.GetConexao();

            string sqlQuery = "SELECT * FROM prontuariosupas WHERE idProntuarios='" + IDpesquisa + "'";

            try
            {
                SqlCommand objComm = new SqlCommand(sqlQuery, conexao);
                SqlDataReader MyReader2;

                MyReader2 = objComm.ExecuteReader();
                while (MyReader2.Read())
                {
                    NomePaciente = MyReader2["NomePaciente"].ToString();
                    DtNasc = MyReader2["DtNascimento"].ToString();
                    RgPaciente = MyReader2["RgPaciente"].ToString();
                    NomeSolicitante = MyReader2["NomeSoliciante"].ToString();
                    DtAtend = MyReader2["DtAtendimento"].ToString();
                    Dias = MyReader2["Dias"].ToString();
                    Unidade = MyReader2["Unidade"].ToString();
                    Telefone = MyReader2["Telefone"].ToString();
                    Internacao = MyReader2["Internacao"].ToString();
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            Font fonte = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
            Font fonte2 = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);


            Bitmap jpg = Properties.Resources.Form2;
            Image newImage = jpg;
            e.Graphics.DrawImage(newImage, 1, 1, newImage.Width, newImage.Height);
            e.Graphics.DrawString(NomePaciente, fonte2, Brushes.Black, 290, 285);
            e.Graphics.DrawString(DtNasc, fonte2, Brushes.Black, 330, 305);
            e.Graphics.DrawString(RgPaciente, fonte2, Brushes.Black, 200, 325);
            e.Graphics.DrawString(NomeSolicitante, fonte2, Brushes.Black, 225, 345);
            e.Graphics.DrawString(DtAtend, fonte2, Brushes.Black, 330, 365);

            if (Internacao == "Sim")
            {
                e.Graphics.DrawString("X", fonte, Brushes.Black, 260, 388);
            }
            else
                e.Graphics.DrawString("X", fonte, Brushes.Black, 600, 388);

            e.Graphics.DrawString(Dias, fonte2, Brushes.Black, 355, 385);
            e.Graphics.DrawString(Unidade, fonte2, Brushes.Black, 362, 425);
            e.Graphics.DrawString(Telefone, fonte2, Brushes.Black, 337, 465);

            e.Graphics.DrawString(DateTime.Now.ToString("dd                      MMMMM                        yyyy"), fonte2, Brushes.Black, 359, 527);
            e.Graphics.DrawString(DateTime.Now.ToString("dd/MM/yyyy"), fonte2, Brushes.Black, 320, 830);
            e.Graphics.DrawString(NomePaciente, fonte2, Brushes.Black, 320, 850);
            e.Graphics.DrawString(DtAtend, fonte2, Brushes.Black, 330, 870);
            e.Graphics.DrawString(Unidade, fonte2, Brushes.Black, 350, 890);
            e.Graphics.DrawString(IDpesquisa, fonte2, Brushes.Black, 700, 205);
            e.Graphics.DrawString(IDpesquisa, fonte2, Brushes.Black, 700, 800);

            if (NomeSolicitante == NomePaciente)
            {
                e.Graphics.DrawString("Esse prontuário só poderá ser entregue ao paciente na propria upa solicitada.", fonte2, Brushes.Black, 100, 1040);
            }
            else
            {
                e.Graphics.DrawString("Esse prontuário só poderá ser entregue ao solicitante, onde devera comparecer ao" + Environment.NewLine +
                    "Departamento localizado na Rua Aurora, 10 - Caminho do Mar, São Bernardo do Campo - SP.", fonte2, Brushes.Black, 100, 1040);
            }
            e.Graphics.DrawString("Prazo: 20 à 30 dias uteis", fonte, Brushes.Black, 100, 1090);  
        }
        
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("PaperA4", 826, 1169);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void ListaPesquisa_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void ListaPesquisa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListaPesquisa.SelectedItems.Count > 0)
            {
                IDpesquisa = ListaPesquisa.SelectedItems[0].Text;
            }

            Status ST = new Status(IDpesquisa);
            ST.ShowDialog();
        }

        private void ListaPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaPesquisa.SelectedItems.Count > 0)
            {
                IDpesquisa = ListaPesquisa.SelectedItems[0].Text;
                nomePaciente = ListaPesquisa.SelectedItems[0].SubItems[1].Text;
                nomeDoPaciente.Text = nomePaciente;
            }
        }


    }

}



