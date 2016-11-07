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
    public partial class Status : Form
    {
        Boolean STATUS;
        string STATUSre;
        DateTime now = DateTime.Now;
        public Status(string IDpesquisa)
        {
            InitializeComponent();
            label3.Text = IDpesquisa;
            txtFuncio.Text = System.Environment.UserName;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txtFuncio.Text))
            {
                MessageBox.Show("Digite o nome do funcionario que esta alterando o Status !!!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMotivoRG.Text))
            {
                MessageBox.Show("Digite o motivo ou RG !!!");
                return;
            }

            Statando();     //verifica o status
            SalvaFunc();       //salva o alteracao


            this.Dispose();
            
          
        }

        private void SalvaFunc()
        {
            SqlConnection conexao = ConexaoSqlServer.GetConexao();


            string sqlQuery2 = "UPDATE prontuariosupas SET Funcionario='" + this.txtFuncio.Text + "',Status='" + STATUSre + "',DtRetirada='" + now + "',Motivo_Rg='" + this.txtMotivoRG.Text + "' WHERE idProntuarios ='" + label3.Text + "'";
            try
            {
                SqlCommand objComm = new SqlCommand(sqlQuery2, conexao);
                SqlDataReader MyReader2;

                MyReader2 = objComm.ExecuteReader();

                //MessageBox.Show("Alterado com sucesso !!!");
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSim_Click(object sender, EventArgs e)
        {
            BtnSim.Visible = false;
            BtnNao.Visible = false;
            txtMotivoRG.Visible = true;
            label1.Text = "Rg do Retirante:";
            STATUS = true;
            button1.Visible = true;

        }

        private void BtnNao_Click(object sender, EventArgs e)
        {

            BtnSim.Visible = false;
            BtnNao.Visible = false;
            txtMotivoRG.Visible = true;
            label1.Text = "Motivo:";
            STATUS = false;
            button1.Visible = true;
        }

        private void Statando()
        {
            //verifica qual é o status agora

            if (STATUS == true)
            {
                STATUSre = "Entregue";

            }
            else
            {
                STATUSre = "Não entregue";

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnSim.Visible = true;
            BtnNao.Visible = true;
            txtMotivoRG.Visible = false;
            label1.Text = "Solicitação foi entregue ?";
            button1.Visible = false;
        }
       

    }
}
