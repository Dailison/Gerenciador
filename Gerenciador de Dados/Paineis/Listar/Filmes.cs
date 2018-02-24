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

namespace Gerenciador_de_Dados.Paineis.Listar
{
    public partial class Filmes : UserControl
    {
        DataSet ds = new DataSet();
        public Filmes()
        {
            InitializeComponent();

            data_Filmes.AutoGenerateColumns = true;

            ds.Tables.Add("Filmes");
            ds.Tables["Filmes"].Columns.Add("ID").DataType = typeof(Int32);
            ds.Tables["Filmes"].Columns.Add("NOME").DataType = typeof(String);
            ds.Tables["Filmes"].Columns.Add("ANO").DataType = typeof(Int32);
            ds.Tables["Filmes"].Columns.Add("DATA ASSISTIDO").DataType = typeof(String);
            ds.Tables["Filmes"].Columns.Add("NOTA").DataType = typeof(Int32);

            data_Filmes.DataSource = ds;
            data_Filmes.DataMember = "Filmes";

            DataGridViewButtonColumn but = new DataGridViewButtonColumn();
            but.Text = "Apagar";
            but.Name = "Apagar";
            but.HeaderText = "";
            but.UseColumnTextForButtonValue = true;
            data_Filmes.Columns.Add(but);
            RefreshItens();
        }
        private List<Film> GerarListaFilmes()
        {
            List<Film> Filmee = new List<Film>();
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
                con.Open();
                SQLiteCommand com = new SQLiteCommand("SELECT * FROM Filmes ORDER BY ID DESC", con);
                SQLiteDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    String[] sa = new String[5];
                    sa[0] = Convert.ToString(r["id"]);
                    sa[1] = Convert.ToString(r["nome"]);
                    sa[2] = Convert.ToString(r["ano_lancamento"]);
                    DateTime d = DateTime.Parse(Convert.ToString(r["data_assistido"]));
                    sa[3] = d.Day + "/" + d.Month + "/" + d.Year;
                    sa[4] = Convert.ToString(r["nota"]);
                    Filmee.Add(new Film(int.Parse(sa[0]), sa[1], int.Parse(sa[2]),sa[3],int.Parse(sa[4])));
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO AO LISTAR FILMES " + e);
            }
            return Filmee;
        }
        private void apagarFilme(int id)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
                con.Open();
                SQLiteCommand com = new SQLiteCommand("DELETE FROM Filmes WHERE ID = " + id, con);
                SQLiteDataReader r = com.ExecuteReader();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO AO APAGAR FILMES " + e);
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            ListarFilmes(GerarListaFilmes());
        }
        public void RefreshItens()
        {
            ListarFilmes(GerarListaFilmes());
        }
        private void ListarFilmes(List<Film> fi)
        {
            ds.Tables["Filmes"].Rows.Clear();
            foreach (Film item in fi)
            {
                ds.Tables["Filmes"].Rows.Add(item.Id, item.Nome, item.Ano_Lancamento,item.Data_Assistido,item.Nota);
            }
        }
        private void data_Filmes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private class Film
        {
            public int Id { get; set; }
            public String Nome { get; set; }
            public int Ano_Lancamento { get; set; }
            public int Nota { get; set; }
            public String Data_Assistido { get; set; }
            public Film(int id, String nome,int ano_lancamento, String data_assistido, int nota)
            {
                Id = id;
                Nome = nome;
                Ano_Lancamento = ano_lancamento;
                Nota = nota;
                Data_Assistido = data_assistido;
            }
        }

        private void data_Filmes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != data_Filmes.Columns["apagar"].Index)
            {
                return;
            }
            else
            {
                apagarFilme((int)data_Filmes.Rows[e.RowIndex].Cells["id"].Value);
                data_Filmes.Rows.RemoveAt(e.RowIndex);
            }

        }
    }
}
