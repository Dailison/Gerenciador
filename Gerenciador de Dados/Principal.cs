using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Data.SQLite;
using System.IO;
using System.Threading;

namespace Gerenciador_de_Dados
{
    public partial class Principal : Form
    {
        public Dictionary<String, UserControl> Lista_Paineis = new Dictionary<String, UserControl>();

        public Principal()
        {
            InitializeComponent();

            // LISTA DE PAINEIS //

                //CADASTRO
                    Lista_Paineis.Add("Cad_Filmes", new Paineis.Cadastrar.Filmes()); // CADASTRO DE FILMES
                    Lista_Paineis.Add("Cad_MacWifi", new Paineis.Cadastrar.MacWifi()); // CADASTRO DE MAC WIFI
                    Lista_Paineis.Add("Cad_Series", new Paineis.Cadastrar.Series()); // CADASTRO DE SERIES
                    Lista_Paineis.Add("Cad_Senhas", new Paineis.Cadastrar.Senhas()); // CADASTRO DE SENHAS
                    Lista_Paineis.Add("Cad_Poemas", new Paineis.Cadastrar.Poemas()); // CADASTRO DE POEMAS

            //LISTAR
            Lista_Paineis.Add("Listar_Filmes", new Paineis.Listar.Filmes()); // LISTAR FILMES
            Lista_Paineis.Add("Listar_MacWifi", new Paineis.Listar.MacWifi());
            Lista_Paineis.Add("Listar_Series", new Paineis.Listar.Series());
            Lista_Paineis.Add("Listar_Senhas", new Paineis.Listar.Panel_Senhas());

            Lista_Paineis.Add("Login", new Paineis.Login.Login()); // LOGIN DE USO
            foreach (var pan in Lista_Paineis.Values)
            {
                panel_principal.Controls.Add(pan);
            }
           // Console.WriteLine("QT" + this.panel_principal.Controls.Count);
            selecionarPainel("Login");
            this.menu_Principal.Visible = false;
            //
            Backup();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)(delegate
            {
                Thread t1 = new Thread(delegate ()
                {
                    Atualizar.verVersao();
                });
                t1.Start();
                Lista_Paineis["Login"].Visible = true;
                Lista_Paineis["Login"].BringToFront();
                Paineis.Login.Login painel = (Paineis.Login.Login)Lista_Paineis["Login"];
                painel.txt_Login_Usuario.Focus();
            }));
            
        }
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Show();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void selecionarPainel(String nome)
        {
            Console.WriteLine("QT" + this.panel_principal.Controls.Count);
            foreach (var pan in Lista_Paineis.Values)
            {
                pan.Visible = false;
            }
           Lista_Paineis[nome].Visible = true;
        }

        private void Click_Cad_Series(object sender, EventArgs e)
        {
            selecionarPainel("Cad_Series");
        }

        private void Click_Cad_Filmes(object sender, EventArgs e)
        {
            selecionarPainel("Cad_Filmes");
            Paineis.Cadastrar.Filmes painel = (Paineis.Cadastrar.Filmes)Lista_Paineis["Cad_Filmes"];
            painel.selecionarNome();
        }

        private void Click_Cad_MacWifi(object sender, EventArgs e)
        {
            selecionarPainel("Cad_MacWifi");
            Paineis.Cadastrar.MacWifi painel = (Paineis.Cadastrar.MacWifi)Lista_Paineis["Cad_MacWifi"];
            painel.selecionarNome();
        }

        private void Click_Cad_Senhas(object sender, EventArgs e)
        {
            selecionarPainel("Cad_Senhas");
            Paineis.Cadastrar.Senhas painel = (Paineis.Cadastrar.Senhas)Lista_Paineis["Cad_Senhas"];
            painel.selecionar_Txt();
        }

        private void menu_Listar_Filmes_Click(object sender, EventArgs e)
        {
            selecionarPainel("Listar_Filmes");
        }

        private void menu_Listar_Series_Click(object sender, EventArgs e)
        {
            selecionarPainel("Listar_Series");
            Paineis.Listar.Series series = (Paineis.Listar.Series)Lista_Paineis["Listar_Series"];
            series.ListarSeries(series.GerarLista());
        }

        private void menu_Listar_MacWifi_Click(object sender, EventArgs e)
        {
            selecionarPainel("Listar_MacWifi");
        }

        private void menu_Listar_Senhas_Click(object sender, EventArgs e)
        {
            selecionarPainel("Listar_Senhas");
        }

        private void menu_Backup_Click(object sender, EventArgs e)
        {
            Backup();
        }
        private void Backup()
        {
            DateTime d = DateTime.Now;
            String Data = "" + d.Day + d.Month + d.Year + d.Hour + d.Minute + d.Second;

            string fileName = "Dados.sqlite";
            string sourcePath = Application.StartupPath;
            string targetPath = Application.StartupPath + @"\Backup_" + Data;

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            System.IO.File.Copy(sourceFile, destFile, true);

            System.IO.Directory.CreateDirectory(Application.StartupPath + @"\Backup");
            string startPath = Application.StartupPath + @"\Backup_" + Data;
            string zipPath = Application.StartupPath + @"\Backup\Backup_" + Data + ".zip";
            ZipFile.CreateFromDirectory(startPath, zipPath);
            Array.ForEach(Directory.GetFiles(startPath),
              delegate (string path) { File.Delete(path); });
            System.IO.Directory.Delete(startPath,false);
        }

        private void menu_Poemas_Click(object sender, EventArgs e)
        {
            selecionarPainel("Cad_Poemas");
        }
    }
}
