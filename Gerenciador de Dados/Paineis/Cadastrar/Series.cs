using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SQLite;
using System.IO;

namespace Gerenciador_de_Dados.Paineis.Cadastrar
{
    public partial class Series : UserControl
    {
        public Series()
        {
            InitializeComponent();
            criarDatabase();
        }
        private bool validarLetras(String txt)
        {
            if (txt != null && txt != "")
            {
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
        private bool validarNumeros(String txt)
        {
            if (txt != null && txt != "")
            {
                // VALIDAR SOMENTE NUMEROS //
                Regex rgx = new Regex(@"^[0-9]*$");
                if (rgx.IsMatch(txt))
                {
                    return true;
                }
            }
            return false;
        }
        private void Cadastrar(String nome, String genero,int anoLancamento,int temporada, int episodio, Boolean final, DateTime ultimoVisto, DateTime proximoEpisodio)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
                con.Open();
                SQLiteCommand com = new SQLiteCommand(con);
                com.CommandText = "INSERT INTO Series(nome,genero,anoLancamento,temporada,episodio,final,proximoEpisodio,ultimoEpisodioVisto) " +
                "VALUES (@nome,@genero,@anoLancamento,@temporada,@episodio,@final,@proximoEpisodio,@ultimoEpisodioVisto)";
                com.Parameters.Add(new SQLiteParameter("@nome", nome));
                com.Parameters.Add(new SQLiteParameter("@genero", genero));
                com.Parameters.Add(new SQLiteParameter("@anoLancamento", anoLancamento));
                com.Parameters.Add(new SQLiteParameter("@temporada", temporada));
                com.Parameters.Add(new SQLiteParameter("@episodio", episodio));
                com.Parameters.Add(new SQLiteParameter("@final", final));
                com.Parameters.Add(new SQLiteParameter("@proximoEpisodio", proximoEpisodio));
                com.Parameters.Add(new SQLiteParameter("@ultimoEpisodioVisto", ultimoVisto));
                com.ExecuteNonQuery();
                //Limpar();
                con.Close();
                MessageBox.Show("Serie \"" + nome + "\" cadastrada com sucesso!");
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
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS [Series] (
                          [ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                          [nome] VARCHAR(50)  NULL,
                          [genero] VARCHAR(50)  NULL,
                          [anoLancamento] int(4) NOT NULL,
                          [temporada] int(2) NOT NULL,
                          [episodio] int(2) NOT NULL,
                          [final] boolean NOT NULL,
                          [proximoEpisodio] DATE NULL,
                          [ultimoEpisodioVisto] DATE NULL
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
            con.Close();
            Console.WriteLine("Database Criada!");
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            String genero = "Ação";
            Cadastrar(txt_Nome.Text,genero,int.Parse(txt_Ano_Lancamento.Text),(int)num_Temporada.Value, (int)num_Episodio.Value,checkBox_Fim_Serie.Checked, System.DateTime.Now ,dateTimePicker_UltimoEpisodio.Value);
        }
    }
}
