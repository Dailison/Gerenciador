using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Dados
{
    public static class Program
    {
        private static Principal Principal;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Principal = new Principal();
            Application.Run(Principal);
            StreamWriter file = new StreamWriter("log.txt");
            file.WriteLine("Teste");
            file.Close();
        }
        public static Principal getPrincipal()
        {
            return Principal;
        }
        public static void Instalar()
        {
            //Criando a chave
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            //Nome do executável
            string sNameApplication = "Gerenciador de Dados";

            //Local de onde o executável vai ser chamado – pode ser em ProgamFiles por exemplo.
            string sApplicationPath = Application.ExecutablePath.ToString();

            //Setar o registro.
            rkApp.SetValue(sNameApplication, sApplicationPath);
        }
        public static void Alerta(int tipo, String msg)
        {
            /*
            UserControl pane = new Paineis.Alerta.Simples(tipo,msg);
            Principal.Controls.Add(pane);
            pane.BringToFront();
            ThreadStart myThread = () =>
            {
                Thread.Sleep(1000);
                if (pane.InvokeRequired)
                {
                    pane.Invoke(new MethodInvoker(delegate {
                        Principal.Controls.Remove(pane);
                    }));
                }
                else
                {
                    Principal.Controls.Remove(pane);
                }
            };
            new Thread(myThread).Start();
            */
            Console.WriteLine("Msg: " + msg);
        }
    }
}
