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
    public partial class Senhas : UserControl
    {
        public Senhas()
        {
            InitializeComponent();
            criarDatabase();
        }
        private void button_Gerar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txt_Tamanho.Text) >= 128)
            {
                Program.Alerta(0, "Tamanho máximo 128 digitos!");
                return;
            }
            txt_Senha.Text = gerarSenha();
        }
        private String gerarSenha()
        {
            string carac = "abcdefhijklmnopqrstuvxwyz";
            if (int.Parse(txt_Tamanho.Text) >= 25)
            {
                carac = carac + carac;
                if (int.Parse(txt_Tamanho.Text) >= 50)
                {
                    carac = carac + carac + carac + carac + carac;
                }
            }
            if (checkBox_Caracteres_Especiais.Checked)
            {
                carac = carac + "!@#&";
            }
            if (checkBox_Maiusculas.Checked)
            {
                carac = carac + "ABCDEFGHIJLMNOPQRSTUVXYWZ";
            }
            if (checkBox_Numeros.Checked)
            {
                carac = carac + "1234567890";
            }

            // converte em uma matriz de caracteres
            char[] letras = carac.ToCharArray();

            // vamos embaralhar 5 vezes
            Embaralhar(ref letras, 5);

            // junta as partes e forma uma senha de 8 dígitos e/ou
            // caracteres
            string senha = new String(letras).Substring(0, int.Parse(txt_Tamanho.Text));
            return senha;
        }

        void Embaralhar(ref char[] array, int vezes)
        {
            Random rand = new Random(DateTime.Now.Millisecond);

            for (int i = 1; i <= vezes; i++)
            {
                for (int x = 1; x <= array.Length; x++)
                {
                    Trocar(ref array[rand.Next(0, array.Length)],
                      ref array[rand.Next(0, array.Length)]);
                }
            }
        }

        void Trocar(ref char arg1, ref char arg2)
        {
            char strTemp = arg1;
            arg1 = arg2;
            arg2 = strTemp;
        }
        public void selecionar_Txt()
        {
            txt_Nome.Focus();
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar(txt_Nome.Text,txt_Usuario.Text,txt_Senha.Text);
        }
        private void Cadastrar(String nome, String usuario, String Senha)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
                con.Open();
                SQLiteCommand com = new SQLiteCommand(con);
                com.CommandText = "INSERT INTO Senhas(nome,usuario,senha) VALUES (@nome,@usuario,@senha)";
                com.Parameters.Add(new SQLiteParameter("@nome", nome));
                com.Parameters.Add(new SQLiteParameter("@usuario", usuario));
                com.Parameters.Add(new SQLiteParameter("@senha", Senha));
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Senha \"" + nome + "\" cadastrada com sucesso!");
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
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS [Senhas] (
                          [ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                          [nome] VARCHAR(50)  NOT NULL,
                          [usuario] VARCHAR(50)  NOT NULL,
                          [senha] VARCHAR(128)  NOT NULL
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
    }
}
