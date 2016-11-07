using Solicitacao_de_Ambulancias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Menu : Form
    {
        string numUpa = "";

        public string  NumUpa
        {
            get { return numUpa; }
            set { numUpa = value; }
        }
        public Menu(string NumeroUpa)
        {
            InitializeComponent();
            numUpa = NumeroUpa;
            label2.MaximumSize = new Size(236, 0);
            label2.AutoSize = true;
            label2.Text = "LEMBRE-SE DE SEMPRE QUE ENTREGAR A FICHA, DAR BAIXA NO SISTEMA PELA PESQUISA DE STATUS !";
            this.Text = "Sistema de Solicitação de Prontuários. Versão: " + appverion;

            
        }
        Version appverion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        private void btnNew_Click(object sender, EventArgs e)
        {
           horarioComercial();
           Form1 fs = new Form1(numUpa);
           fs.ShowDialog();
            
        }

        public void horarioComercial()
        {
            TimeSpan inicio = new TimeSpan(07, 50, 0);
            TimeSpan final = new TimeSpan(17, 10, 0);
            TimeSpan puts = DateTime.Now - DateTime.Now.Date;
            TimeSpan agora = new TimeSpan(puts.Hours, puts.Minutes, puts.Seconds);

            if (inicio.CompareTo(agora) == 1)
            {
                MessageBox.Show("O sistema funciona somente em horário comercial: 08:00h às 17:00h !", "Fora do horário comercial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            if (final.CompareTo(agora) == -1)
            {
                MessageBox.Show("O sistema funciona somente em horário comercial: 08:00h às 17:00h !", "Fora do horário comercial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisa pes = new Pesquisa(numUpa);
            pes.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"\\10.1.0.7\Mapa_de_Leitos\Sistemas - Vinicius\Sistema de Solicitacao de Prontuarios\SOLICITAÇÃO DE PRONTUÁRIO.doc");
        }


    }
}
