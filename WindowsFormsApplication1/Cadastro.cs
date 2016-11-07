using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using SistemaProntuario1;
using System.Net.Mail;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        DialogResult da = MessageBox.Show("O paciente que esta pedindo a própria ficha ? ", "Atenção !", MessageBoxButtons.YesNo);
        string txtInternacao = "";
        DateTime now = DateTime.Now;
        
        public Form1(string NumUpa)
        {
            InitializeComponent();

            string nmUpa = NumUpa;
            CbUnid.Text = nmUpa;

            if (da == DialogResult.Yes)
            {
                label5.Visible = false;
                label4.Visible = false;
                txtRgSolicitante.Visible = false;
                txtNomeSolicitante.Visible = false;
            }
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtObs.KeyPress += new KeyPressEventHandler(this.txtObs_KeyPress);
            txtNomePaciente.CharacterCasing = CharacterCasing.Upper;
            txtNomeSolicitante.CharacterCasing = CharacterCasing.Upper;
            txtRgPaciente.CharacterCasing = CharacterCasing.Upper;
            txtRgSolicitante.CharacterCasing = CharacterCasing.Upper;
            txtDias.CharacterCasing = CharacterCasing.Upper;
            txtTele.CharacterCasing = CharacterCasing.Upper;
            txtDias.CharacterCasing = CharacterCasing.Upper;
            txtDataSolicitacao.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txtLocalFato.CharacterCasing = CharacterCasing.Upper;
            txtDtFato.CharacterCasing = CharacterCasing.Upper;
            txtNomedaMae.CharacterCasing = CharacterCasing.Upper;
            
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            string funcionarioReg = System.Environment.UserName;
            string statuscore = "Aguardando resposta";
            SqlConnection conexao = ConexaoSqlServer.GetConexao();
            if (RbSim.Checked)
            {
                txtInternacao = "Sim";

            }
            else
            {
                txtInternacao = "Não";

            }

            try
            {

                if (txtNomePaciente.Text == string.Empty)
                {
                    MessageBox.Show("Campo Nome do Paciente esta vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomePaciente.BackColor = Color.Red;
                    return;
                }
                else if (txtNomeSolicitante.Text == string.Empty && txtNomeSolicitante.Visible == false)
                {
                    MessageBox.Show("Campo Nome do Solicitante esta vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomeSolicitante.BackColor = Color.Red;
                    return;
                }
                else if (txtRgPaciente.Text == string.Empty)
                {
                    MessageBox.Show("Campo Rg do Paciente esta vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRgPaciente.BackColor = Color.Red;
                    return;
                }
                else if (txtRgSolicitante.Text == string.Empty && txtRgSolicitante.Visible == false)
                {
                    MessageBox.Show("Campo Rg do Solicitante esta vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRgSolicitante.BackColor = Color.Red;
                    return;
                }
                else if (txtDtNasc.Text == "  /  /")
                {
                    MessageBox.Show("Campo Data de Nascimento esta vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDtNasc.BackColor = Color.Red;
                    return;
                }
                else if (txtDtAtend.Text == "  /  /")
                {
                    MessageBox.Show("Campo Data de Atendimento esta vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDtAtend.BackColor = Color.Red;
                    return;
                }

                else if (txtTele.Text == string.Empty)
                {
                    MessageBox.Show("Campo Telefone esta vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTele.BackColor = Color.Red;
                    return;
                }
                else if (CbUnid.Text == string.Empty)
                {
                    MessageBox.Show("Campo Unidade esta vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CbUnid.BackColor = Color.Red;
                    return;
                }
                else if (txtInternacao == string.Empty)
                {
                    MessageBox.Show("Campo Internação esta vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RbNao.BackColor = Color.Red;
                    RbSim.BackColor = Color.Red;
                    return;
                }
                else if (txtNomedaMae.Text == string.Empty)
                {
                    MessageBox.Show("Campo Nome da Mãe esta vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomedaMae.BackColor = Color.Red;
                    return;
                }
                else if (CbUnid.Text == string.Empty)
                {
                    MessageBox.Show("Campo Unidade esta vazio!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CbUnid.BackColor = Color.Red;
                    return;
                }

                string sqlQuery = "insert into prontuariosupas(NomePaciente,NomedaMae,NomeSoliciante,RgPaciente,RgSolicitante,DtNascimento,DtAtendimento," +
                    "Telefone,Unidade,Internacao,Dias,Obs,DtSolicitacao,Status,Funcionario,DtHrFato,LocalFato,Motivo) values ('" + this.txtNomePaciente.Text + "','" +
                    this.txtNomedaMae.Text+"','" + this.txtNomeSolicitante.Text + "','" + this.txtRgPaciente.Text + "','" + this.txtRgSolicitante.Text + "','" +
                    this.txtDtNasc.Text + "','" + this.txtDtAtend.Text + "','" + this.txtTele.Text + "','" + this.CbUnid.Text + "','" + txtInternacao + "','" +
                    this.txtDias.Text + "','" + this.txtObs.Text + "','" + now + "','" + statuscore + "','" + funcionarioReg + "','" + this.txtDtFato.Text + "','" + this.txtLocalFato.Text + "','"+this.txtMotivo.Text+"')";


                SqlCommand objComm = new SqlCommand(sqlQuery, conexao);
                SqlDataReader MyReader2;

                MyReader2 = objComm.ExecuteReader();

                MessageBox.Show("Solicitação salva com sucesso !!!");
                
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            printPreviewDialog1.ShowDialog();
            //////////////////////////////////////EMAILS///////////////////////////////////////////
            if (txtUpa.Text != null)
            {

                if (txtUpa.Text == "AD")
                {
                    string email0 = "upa.alvesassuncao@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br";
                    string msg0 = "Email enviado para UPA Alves Dias !";
                    email.EnviaEmail(txtNomePaciente.Text, txtNomedaMae.Text, txtMotivo.Text, txtDtAtend.Text, txtDtNasc.Text, txtInternacao, txtDias.Text, txtDtFato.Text, txtLocalFato.Text, txtObs.Text, email0, msg0, funcionarioReg);
                }
                if (txtUpa.Text == "BN")
                {
                    string email1 = "upa.baeta@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,departamento.hospitalar@gmail.com,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br";
                    string msg1 = "Email enviado para UPA Beata Neves !";
                    email.EnviaEmail(txtNomePaciente.Text, txtNomedaMae.Text, txtMotivo.Text, txtDtAtend.Text, txtDtNasc.Text, txtInternacao, txtDias.Text, txtDtFato.Text, txtLocalFato.Text, txtObs.Text, email1, msg1, funcionarioReg);
                }
                if (txtUpa.Text == "DE")
                {
                    string email2 = "upa.dembatis@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,departamento.hospitalar@gmail.com,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br";
                    string msg2 = "Email enviado para UPA Dermachi !";
                    email.EnviaEmail(txtNomePaciente.Text, txtNomedaMae.Text, txtMotivo.Text, txtDtAtend.Text, txtDtNasc.Text, txtInternacao, txtDias.Text, txtDtFato.Text, txtLocalFato.Text, txtObs.Text, email2, msg2, funcionarioReg);
                }
                if (txtUpa.Text == "PA")
                {
                    string email3 = "upa.paultab@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,departamento.hospitalar@gmail.com,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br";
                    string msg3 = "Email enviado para UPA Paulicéia !";
                    email.EnviaEmail(txtNomePaciente.Text, txtNomedaMae.Text, txtMotivo.Text, txtDtAtend.Text, txtDtNasc.Text, txtInternacao, txtDias.Text, txtDtFato.Text, txtLocalFato.Text, txtObs.Text, email3, msg3, funcionarioReg);
                }
                if (txtUpa.Text == "RG")
                {
                    string email4 = "upa.riachogrande@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,departamento.hospitalar@gmail.com,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br";
                    string msg4 = "Email enviado para UPA Riacho Grande !";
                    email.EnviaEmail(txtNomePaciente.Text, txtNomedaMae.Text, txtMotivo.Text, txtDtAtend.Text, txtDtNasc.Text, txtInternacao, txtDias.Text, txtDtFato.Text, txtLocalFato.Text, txtObs.Text, email4, msg4, funcionarioReg);
                }
                if (txtUpa.Text == "RR")
                {
                    string email5 = "upa.rudgeramos@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,departamento.hospitalar@gmail.com,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br";
                    string msg5 = "Email enviado para UPA Rudge Ramos !";
                    email.EnviaEmail(txtNomePaciente.Text, txtNomedaMae.Text, txtMotivo.Text, txtDtAtend.Text, txtDtNasc.Text, txtInternacao, txtDias.Text, txtDtFato.Text, txtLocalFato.Text, txtObs.Text, email5, msg5, funcionarioReg);
                }
                if (txtUpa.Text == "SP")
                {
                    string email6 = "upa.vilasaopedro@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,departamento.hospitalar@gmail.com,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br";
                    string msg6 = "Email enviado para São Pedro !";
                    email.EnviaEmail(txtNomePaciente.Text, txtNomedaMae.Text, txtMotivo.Text, txtDtAtend.Text, txtDtNasc.Text, txtInternacao, txtDias.Text, txtDtFato.Text, txtLocalFato.Text, txtObs.Text, email6, msg6, funcionarioReg);
                }
                if (txtUpa.Text == "SI")
                {
                    string email7 = "upa.silvinaferrazopolis@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br";
                    string msg7 = "Email enviado para Silvina !";
                    email.EnviaEmail(txtNomePaciente.Text, txtNomedaMae.Text, txtMotivo.Text, txtDtAtend.Text, txtDtNasc.Text, txtInternacao, txtDias.Text, txtDtFato.Text, txtLocalFato.Text, txtObs.Text, email7, msg7, funcionarioReg);
                }
                if (txtUpa.Text == "UN")
                {
                    string email8 = "upa.uniao@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br";
                    string msg8 = "Email enviado para UPA União !";
                    email.EnviaEmail(txtNomePaciente.Text, txtNomedaMae.Text, txtMotivo.Text, txtDtAtend.Text, txtDtNasc.Text, txtInternacao, txtDias.Text, txtDtFato.Text, txtLocalFato.Text, txtObs.Text, email8, msg8, funcionarioReg);
                }
                if (txtUpa.Text == "SM")
                {
                    string email9 = "samu.192@saobernardo.sp.gov.br,samu.arquivo@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br";
                    string msg9 = "Email enviado para SAMU !";
                    email.EnviaEmail(txtNomePaciente.Text, txtNomedaMae.Text, txtMotivo.Text, txtDtAtend.Text, txtDtNasc.Text, txtInternacao, txtDias.Text, txtDtFato.Text, txtLocalFato.Text, txtObs.Text, email9, msg9, funcionarioReg);
                }
                DialogResult result1 = MessageBox.Show("Deseja solicitar nova ficha ? ",
                    "ATENÇÃO",
                MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    Limpar();
                    txtNomePaciente.Focus();
                }
                else if (result1 == DialogResult.No)
                {

                    this.Dispose();
                }

            }
        }

        private void RbSim_CheckedChanged(object sender, EventArgs e)
        {
            label12.Visible = true;
            txtDias.Visible = true;
        }

        private void RbNao_CheckedChanged(object sender, EventArgs e)
        {
            label12.Visible = false;
            txtDias.Visible = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string txtID = "";
            SqlConnection conexao = ConexaoSqlServer.GetConexao();

            string sqlQuery = "SELECT idProntuarios FROM prontuarios";

            try
            {
                SqlCommand objComm = new SqlCommand(sqlQuery, conexao);
                SqlDataReader MyReader2;

                MyReader2 = objComm.ExecuteReader();
                while (MyReader2.Read())
                {
                    String ID = MyReader2.GetString(0);
                    txtID = (ID);

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
            e.Graphics.DrawString(txtNomePaciente.Text, fonte2, Brushes.Black, 290, 285);
            e.Graphics.DrawString(txtDtNasc.Text, fonte2, Brushes.Black, 330, 305);
            e.Graphics.DrawString(txtRgPaciente.Text, fonte2, Brushes.Black, 200, 325);
            e.Graphics.DrawString(txtNomeSolicitante.Text, fonte2, Brushes.Black, 225, 345);
            e.Graphics.DrawString(txtDtAtend.Text, fonte2, Brushes.Black, 330, 365);

            if (RbSim.Checked)
            {
                e.Graphics.DrawString("X", fonte, Brushes.Black, 260, 388);
            }
            else
                e.Graphics.DrawString("X", fonte, Brushes.Black, 600, 388);

            e.Graphics.DrawString(txtDias.Text, fonte2, Brushes.Black, 355, 385);
            e.Graphics.DrawString(CbUnid.Text, fonte2, Brushes.Black, 362, 425);
            e.Graphics.DrawString(txtTele.Text, fonte2, Brushes.Black, 337, 465);

            e.Graphics.DrawString(DateTime.Now.ToString("dd                      MMMMM                        yyyy"), fonte2, Brushes.Black, 359, 527);
            e.Graphics.DrawString(DateTime.Now.ToString("dd/MM/yyyy"), fonte2, Brushes.Black, 320, 830);
            e.Graphics.DrawString(txtNomePaciente.Text, fonte2, Brushes.Black, 320, 850);
            e.Graphics.DrawString(txtDtAtend.Text, fonte2, Brushes.Black, 330, 870);
            e.Graphics.DrawString(CbUnid.Text, fonte2, Brushes.Black, 350, 890);
            e.Graphics.DrawString(txtID, fonte2, Brushes.Black, 700, 205);
            e.Graphics.DrawString(txtID, fonte2, Brushes.Black, 700, 800);

            if(da == DialogResult.Yes){
            e.Graphics.DrawString("Esse prontuário só poderá ser entregue ao paciente na propria upa solicitada.", fonte2, Brushes.Black, 100, 1040);
            }
            else
            {
                e.Graphics.DrawString("Esse prontuário só poderá ser entregue ao solicitante, onde devera comparecer ao" + Environment.NewLine +
                    "departamento Rua João Pessoa nº 59 – 2º andar – Centro – São Bernardo do Campo – SP.", fonte2, Brushes.Black, 100, 1040);
   
            }
            e.Graphics.DrawString("Prazo: 20 à 30 dias uteis", fonte, Brushes.Black, 100, 1090);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("PaperA4", 826, 1169);
            printDocument1.Print();
            this.Dispose();
        }

        private void txtNomePaciente_KeyUp(object sender, KeyEventArgs e)
        {
           
            if (da == DialogResult.Yes)
            {
                txtNomeSolicitante.Text = "";
                txtNomeSolicitante.Enabled = false;
                
            }
            

        }

        private void txtRgPaciente_KeyUp(object sender, KeyEventArgs e)
        {
            if (da == DialogResult.Yes)
            {
                txtRgSolicitante.Text = txtRgPaciente.Text;
                txtRgSolicitante.Enabled = false;
            }
        }

        private void cBpac_CheckedChanged(object sender, EventArgs e)
        {
            if (da == DialogResult.Yes)
            {
                txtNomeSolicitante.Text = txtNomePaciente.Text;
                txtRgSolicitante.Text = txtRgPaciente.Text;
                txtNomeSolicitante.Enabled = false;
                txtRgSolicitante.Enabled = false;

            }
            else
            {
                txtNomeSolicitante.Text = "";
                txtRgSolicitante.Text = "";
                txtNomeSolicitante.Enabled = true;
                txtRgSolicitante.Enabled = true;


            }
        }

        private void CbUnid_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CbUnid.Text == "ALVES DIAS")
            {
                txtUpa.Text = "AD";
            }
            else if (CbUnid.Text == "BAETA NEVES")
            {
                txtUpa.Text = "BN";
            }
            else if (CbUnid.Text == "DEMARCHI")
            {
                txtUpa.Text = "DE";
            }
            else if (CbUnid.Text == "PAULICÉIA")
            {
                txtUpa.Text = "PA";
            }
            else if (CbUnid.Text == "RIACHO GRANDE")
            {
                txtUpa.Text = "RG";
            }
            else if (CbUnid.Text == "RUDGE RAMOS")
            {
                txtUpa.Text = "RR";
            }
            else if (CbUnid.Text == "SÃO PEDRO")
            {
                txtUpa.Text = "SP";
            }
            else if (CbUnid.Text == "SILVINA")
            {
                txtUpa.Text = "SI";
            }
            else if (CbUnid.Text == "UNIÃO")
            {
                txtUpa.Text = "UN";
            }
            else if (CbUnid.Text == "SAMU")
            {
                txtUpa.Text = "SM";
            }

            if (txtUpa.Text == "SM")
            {
                lbldatafato.Visible = true;
                txtDtFato.Visible = true;
                lblfato.Visible = true;
                txtLocalFato.Visible = true;

            }
            else
            {
                lbldatafato.Visible = false;
                txtDtFato.Visible = false;
                lblfato.Visible = false;
                txtLocalFato.Visible = false;
            }
        }
        public void Limpar()
        {
            txtNomePaciente.Text = "";
            txtNomeSolicitante.Text = "";
            txtRgPaciente.Text = "";
            txtRgSolicitante.Text = "";
            txtDtNasc.Text = "";
            txtDtAtend.Text = "";
            txtDias.Text = "";
            txtObs.Text = "";
            txtTele.Text = "";
            CbUnid.Text = "";
            RbSim.Checked = false;
            RbNao.Checked = false;
            label12.Visible = false;
            txtDias.Visible = false;
            lbldatafato.Visible = false;
            txtDtFato.Visible = false;
            lblfato.Visible = false;
            txtLocalFato.Visible = false;
            lbldatafato.Text = "";
            txtDtFato.Text = "";
            lblfato.Text = "";
            txtLocalFato.Text = "";
            txtMotivo.Text = "";
            label5.Visible = false;
            label4.Visible = false;
            txtRgSolicitante.Visible = false;
            txtNomeSolicitante.Visible = false;

        }
        private void txtObs_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
        private void BtnVortar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CbUnid.Enabled = true;
        }
    }

}


