using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Dados
{
    public class Atualizar
    {
        private static bool Baixando = false;

        public Atualizar()
        {
            verVersao();
        }

        public static bool verVersao()
        {
            try
            {
                String nomeApp = Assembly.GetExecutingAssembly().GetName().Name;
                Console.WriteLine("Verificando se existe" + nomeApp + "Updater");
                if (File.Exists(Environment.CurrentDirectory + @"\" + nomeApp + "Updater.exe"))
                {
                    File.Delete(Environment.CurrentDirectory + @"\" + nomeApp + "Updater.exe");
                }
                
                string remoteUri = "http://arquivos.mundosurvival.com/" + nomeApp + "Versions/";
                string fileName = "Version.txt", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, Environment.CurrentDirectory + @"\Version.txt");
                string newversao = System.IO.File.ReadAllText(Environment.CurrentDirectory + @"\Version.txt");
                System.IO.File.Delete(Environment.CurrentDirectory + @"\Version.txt");
                Char[] saaa = newversao.ToCharArray();
                int newversao0 = int.Parse(saaa[0].ToString());
                int newversao1 = int.Parse(saaa[1].ToString());
                int newversao2 = int.Parse(saaa[2].ToString());
                Console.WriteLine("Versao" + newversao);
                string assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                String[] versao = assemblyVersion.Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries);
                int versao0 = int.Parse(versao[0]);
                int versao1 = int.Parse(versao[1]);
                int versao2 = int.Parse(versao[2]);
                if (newversao0 > versao0)
                {
                    baixarAtualizacao(newversao);
                }
                else if (newversao1 > versao1)
                {
                    baixarAtualizacao(newversao);
                }
                else if (newversao2 > versao2)
                {
                    baixarAtualizacao(newversao);
                }
                else
                {
                    Console.WriteLine("Aplicativo atualizado!");
                    return true;
                }
                return true;
            }
            catch (Exception e) {  Console.WriteLine("Nao baixado atualização porque" + e); return true; }
        }
        public static void baixarAtualizacao(String versao)
        {
            Baixando = true;
            Console.WriteLine("Baixando atualizacao");
            try
            {
                string remoteUri = "http://arquivos.mundosurvival.com" + Assembly.GetExecutingAssembly().GetName().Name + "Versions/";
                string fileName = Assembly.GetExecutingAssembly().GetName().Name + versao + ".exe", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                Program.getPrincipal().BeginInvoke((MethodInvoker)delegate {
                    Program.getPrincipal().groupBox_Atualizar.Visible = true;
                    Program.getPrincipal().groupBox_Atualizar.BringToFront();
                });
                myWebClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                myWebClient.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadPronto);
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFileAsync(new Uri(myStringWebResource), Environment.CurrentDirectory + Assembly.GetExecutingAssembly().GetName().Name + @"\Temp.exe");
            }
            catch (Exception) { Console.WriteLine("Versão atualizada nao baixada"); Baixando = false; return; }
            try
            {
                string remoteUri = "http://arquivos.mundosurvival.com" + Assembly.GetExecutingAssembly().GetName().Name + "/Versions/";
                string fileName = Assembly.GetExecutingAssembly().FullName, myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, Environment.CurrentDirectory + @"\" + Assembly.GetExecutingAssembly().GetName().Name + @"\" + Assembly.GetExecutingAssembly().GetName().Name + "Updater.exe");
            }
            catch (Exception) { Console.WriteLine("Updater nao baixado"); Baixando = false; return; }
        }
        public static void update()
        {
            Console.WriteLine("Executando Updater");
            System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
            start.FileName = Environment.CurrentDirectory + @"\" + Assembly.GetExecutingAssembly().GetName().Name+ @"\" + Assembly.GetExecutingAssembly().GetName().Name+ "Updater.exe";
            start.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            start.UseShellExecute = false;
            start.CreateNoWindow = true;
            Process.Start(start);
            Environment.Exit(0);
        }
        private static void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            Program.getPrincipal().BeginInvoke((MethodInvoker)delegate
            {
                Program.getPrincipal().progressBar_Atualizando.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        private static void client_DownloadPronto(object sender, AsyncCompletedEventArgs e)
        {
            update();
        }
    }
}
