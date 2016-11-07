using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class email
    {

        public static MailMessage EnviaEmail(string NomePaciente, string Nomemae, string Motivo, string DataAtendimento, string DataNascimento, string Internado, string Dias, string dthrFato, string Localfato, string Obs, string Email, string Msg, string funcionario)
        {

            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("depto.hospitalar@gmail.com");
                // mail.To.Add("upa.alvesassuncao@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br");
                // mail.To.Add("upa.baeta@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,departamento.hospitalar@gmail.com,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br");
                // mail.To.Add("upa.dembatis@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,departamento.hospitalar@gmail.com,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br");
                // mail.To.Add("upa.riachogrande@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,departamento.hospitalar@gmail.com,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br");
                // mail.To.Add("upa.rudgeramos@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,departamento.hospitalar@gmail.com,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br");
                // mail.To.Add("upa.silvinaferrazopolis@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,departamento.hospitalar@gmail.com,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br");
                // mail.To.Add("upa.vilasaopedro@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,departamento.hospitalar@gmail.com,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br");
                // mail.To.Add("upa.uniao@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,departamento.hospitalar@gmail.com,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br");
                // mail.To.Add("samu.192@saobernardo.sp.gov.br,departamento.hospitalar@saobernardo.sp.gov.br,departamento.hospitalar@gmail.com,vinicius.galdino@saobernardo.sp.gov.br,divisao.prehospitalar@saobernardo.sp.gov.br");
                mail.To.Add(Email);
                mail.Subject = "SOLICITAÇÃO DE FAA " + NomePaciente + ".";
                mail.Body = "Olá, Solicitado a seguinte Folha de Atendimento: " + 
                    Environment.NewLine + Environment.NewLine + NomePaciente +Environment.NewLine+ " - Data de Atendimento: " +
                DataAtendimento + Environment.NewLine+" - Data de Nascimento: " + DataNascimento+ Environment.NewLine+ " - Nome da Mãe: " + Nomemae + 
                Environment.NewLine + " - Motivo: " + Motivo + Environment.NewLine + " - Internação: " +
                Internado + ". Dias: " + Dias + Environment.NewLine+" - Data e Hora do Fato: " + dthrFato + Environment.NewLine+ " - Local do Fato: " + Localfato +
                Environment.NewLine + " - Funcionário: " + funcionario + Environment.NewLine + Environment.NewLine +

                "Observações: "+Environment.NewLine+ Obs + ".";

                SmtpServer.Port = 465;
                SmtpServer.Credentials = new System.Net.NetworkCredential("depto.hospitalar@gmail.com", "upa24horas");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show(Msg);
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());

                DialogResult result1 = MessageBox.Show("E-mail não enviado! Tentar novamente? " + ex,
                "ATENÇÃO",
                MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    EnviaEmail(NomePaciente, Nomemae, Motivo, DataAtendimento, DataNascimento, Internado, Dias, dthrFato, Localfato, Obs, Email, Msg, funcionario);
                }
                else if (result1 == DialogResult.No)
                {
                    MessageBox.Show("E-mail não enviado, favor verificar !");
                }
            }
            return null;
        }



    }
}
