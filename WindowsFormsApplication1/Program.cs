using Solicitacao_de_Ambulancias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Diagnostics.Process.Start("D:\\Solicitação de Prontuarios\\Sistema de Solicitação de Prontuários\\pastaDTI.bat");

            Update updatando = new Update();
            updatando.up();

            if (updatando.Yn == true)
            {
                Environment.Exit(1);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuUpa());
        }
    }
}
