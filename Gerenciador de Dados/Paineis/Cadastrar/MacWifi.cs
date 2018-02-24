using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Text.RegularExpressions;

namespace Gerenciador_de_Dados.Paineis.Cadastrar
{
    public partial class MacWifi : UserControl
    {
        public MacWifi()
        {
            InitializeComponent();
            criarDatabase();
        }
        private bool validarLetras()
        {
            if (txt_Cad_MacWifi_Nome.Text != null && txt_Cad_MacWifi_Nome.Text != "")
            {
                String txt = txt_Cad_MacWifi_Nome.Text;
                txt = txt.Replace(" ", "");
                // VALIDAR Z = 0 + 1
                Regex rgx = new Regex(@"^[a-z,A-Z]*$");
                if (rgx.IsMatch(txt))
                {
                    return true;
                }
            }
            return false;
        }
        private bool validarMac()
        {
            if (txt_MacWifi.Text != null && txt_MacWifi.Text != "")
            {
                String texto = txt_MacWifi.Text.Replace(".", "");
                texto = texto.ToUpper();
                if (texto.Length == 12)
                {
                    // VALIDAR SOMENTE NUMEROS //
                    Regex rgx = new Regex(@"^[0-9,A-Z]*$");
                    if (rgx.IsMatch(texto))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            if (txt_Cad_MacWifi_Nome.Text.Length <= 50 && validarLetras())
            {
                if (validarMac())
                {
                    int tipo = 0; // COMPUTADOR DE MESA
                    if (radioButton_Celular.Checked)
                    {
                        tipo = 1; // CELULAR
                    }
                    if (radioButton_Notbook.Checked)
                    {
                        tipo = 2; // NOTBOOK
                    }
                    Cadastrar(txt_Cad_MacWifi_Nome.Text, txt_MacWifi.Text.Replace(".",""), tipo);
                    MessageBox.Show("Cadastrado com sucesso!");
                    txt_MacWifi.BackColor = Color.Empty;
                    txt_Cad_MacWifi_Nome.BackColor = Color.Empty;
                    Limpar();
                }
                else
                {
                    txt_MacWifi.BackColor = Color.Red;
                    txt_MacWifi.Focus();

                }
            }
            else
            {
                txt_Cad_MacWifi_Nome.BackColor = Color.Red;
                txt_Cad_MacWifi_Nome.Focus();
            }
        }
        private void Cadastrar(String nome, String mac, int tipo)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
                con.Open();
                SQLiteCommand com = new SQLiteCommand(con);
                com.CommandText = "INSERT INTO MacWifi(Nome,Mac,Tipo) VALUES (@nome,@mac,@tipo)";
                com.Parameters.Add(new SQLiteParameter("@nome", nome));
                com.Parameters.Add(new SQLiteParameter("@mac", mac));
                com.Parameters.Add(new SQLiteParameter("@tipo", tipo));
                com.ExecuteNonQuery();
                Limpar();
                con.Close();
                MessageBox.Show("MacWifi \"" + nome + "\" cadastrado com sucesso!");
                //Paineis.Listar.Filmes list = (Paineis.Listar.Filmes)Principal.Lista_Paineis["Listar_Filmes"];
                //list.RefreshItens();
            }
            catch (SQLiteException e)
            {
                MessageBox.Show("Erro ao cadastrar + " + e);

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao cadastrar + " + e);
            }
        }
        private void criarDatabase()
        {
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS [MacWifi] (
                          [ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                          [Nome] NVARCHAR(50)  NOT NULL,
                          [Mac] VARCHAR(50)  NOT NULL,
                          [Tipo] int(30) NOT NULL
                          )";
            if (!(File.Exists(@"Dados.sqlite"))){
                SQLiteConnection.CreateFile("Dados.sqlite");
            }
            SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
            SQLiteCommand com = new SQLiteCommand(con);
            con.Open();                             // Open the connection to the database
            com.CommandText = createTableQuery;     // Set CommandText to our query that will create the table
            com.ExecuteNonQuery();                  // Execute the query
            con.Close();
            Console.WriteLine("Database Criada!");

        }
        private void Limpar()
        {
            txt_Cad_MacWifi_Nome.Text = null;
            txt_MacWifi.Text = null;
        }
        public void selecionarNome()
        {
            txt_Cad_MacWifi_Nome.Focus();
        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            txt_Cad_MacWifi_Nome.Text = null;
            txt_Cad_MacWifi_Nome.BackColor = Color.Empty;
            txt_MacWifi.Text = null;
            txt_MacWifi.BackColor = Color.Empty;
            txt_Cad_MacWifi_Nome.Focus();
        }

        private void txt_Cad_MacWifi_Nome_TextChanged(object sender, EventArgs e)
        {
            if (validarLetras())
            {
                txt_Cad_MacWifi_Nome.BackColor = Color.LightGreen;
            }
            else
            {
                txt_Cad_MacWifi_Nome.BackColor = Color.Red;
            }
        }

        private void txt_MacWifi_TextChanged(object sender, EventArgs e)
        {
            if (validarMac())
            {
                txt_MacWifi.BackColor = Color.LightGreen;
            }
            else
            {
                txt_MacWifi.BackColor = Color.Red;
            }
        }
    }
}
