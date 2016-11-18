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
    public partial class MenuUpa : Form
    {
        public MenuUpa()
        {
            InitializeComponent();
        }
        Version appverion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "ALVES DIAS")
            {
                Menu mn = new Menu("ALVES DIAS");
                mn.ShowDialog();
               
            }
            else if(comboBox1.Text == "BAETA NEVES")
            {
                Menu mn = new Menu("BAETA NEVES");
                mn.ShowDialog();
               
            }
            else if(comboBox1.Text == "DEMARCHI")
            {
                Menu mn = new Menu("DEMARCHI");
                mn.ShowDialog();
               
            }
            else if(comboBox1.Text == "PAULICÉIA")
            {
                Menu mn = new Menu("PAULICÉIA");
                mn.ShowDialog();
               
            }
            else if (comboBox1.Text == "RIACHO GRANDE")
            {
                Menu mn = new Menu("RIACHO GRANDE");
                mn.ShowDialog();
               
            }
            else if (comboBox1.Text == "RUDGE RAMOS")
            {
                Menu mn = new Menu("RUDGE RAMOS");
                mn.ShowDialog();
               
            }
            else if (comboBox1.Text == "SÃO PEDRO")
            {
                Menu mn = new Menu("SÃO PEDRO");
                mn.ShowDialog();
               
            }
            else if (comboBox1.Text == "SILVINA")
            {
                Menu mn = new Menu("SILVINA");
                mn.ShowDialog();
               
            }
            else if (comboBox1.Text == "UNIÃO")
            {
                Menu mn = new Menu("UNIÃO");
                mn.ShowDialog();
               
            }
            else if (comboBox1.Text == "SAMU")
            {
                Menu mn = new Menu("SAMU");
                mn.ShowDialog();
               
            }
            else if (comboBox1.Text == "DAHUE")
            {
                Menu mn = new Menu("DAHUE");
                mn.ShowDialog();

            }
            else 
            {
                MessageBox.Show("Não foi reconhecida a unidade", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
