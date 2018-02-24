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

namespace Gerenciador_de_Dados.Paineis.Cadastrar
{
    public partial class Filmes : UserControl
    {
        public Filmes()
        {
            InitializeComponent();
            criarDatabase();
            txt_CadFilmes_Ano.Text = "" + DateTime.Now.Year;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastrar_Filme(txt_CadFilmes_Nome.Text, monthCalendar1.SelectionRange.Start, int.Parse(txt_CadFilmes_Ano.Text),(int)num_Nota.Value);
        }
        private void limpar_Cad_Cliente()
        {
            txt_CadFilmes_Ano.Text = "2016";
            txt_CadFilmes_Nome.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpar_Cad_Cliente();
        }
        private void cadastrar_Filme(String nome, DateTime dia_Assistido, int ano, int nota)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
                con.Open();
                SQLiteCommand com = new SQLiteCommand(con);
                com.CommandText = "INSERT INTO Filmes(nome,ano_lancamento,data_assistido,nota) VALUES (@nome,@ano,@data_assistido,@nota)";
                com.Parameters.Add(new SQLiteParameter("@nome", nome));
                com.Parameters.Add(new SQLiteParameter("@ano", ano));
                com.Parameters.Add(new SQLiteParameter("@data_assistido", dia_Assistido));
                com.Parameters.Add(new SQLiteParameter("@nota", nota));
                com.ExecuteNonQuery();
                limpar_Cad_Cliente();
                con.Close();
                Log("Filme \"" + nome + "\" cadastrado com sucesso2!");
                Paineis.Listar.Filmes list = (Paineis.Listar.Filmes) Program.getPrincipal().Lista_Paineis["Listar_Filmes"];
                list.RefreshItens();
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
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS [Filmes] (
                          [ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                          [nome] VARCHAR(80)  NOT NULL,
                          [ano_lancamento] VARCHAR(4)  NOT NULL,
                          [data_assistido] DATE NOT NULL,
                          [nota]int(2) NOT NULL
                          )";
            if (!(File.Exists(@"Dados.sqlite")))
            {
                SQLiteConnection.CreateFile("Dados.sqlite");
            }
            SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
            SQLiteCommand com = new SQLiteCommand(con);
            con.Open();                             // Open the connection to the database
            com.CommandText = createTableQuery;     // Set CommandText to our query that will create the table
            com.ExecuteNonQuery();                  // Execute the query

            Console.WriteLine("Database Criada!");
            con.Close();
        }
        private void Log(String Texto)
        {
            txt_log.AppendText(Texto + "\n");
        }
        public void selecionarNome()
        {
            txt_CadFilmes_Nome.Focus();
        }
    }
}
