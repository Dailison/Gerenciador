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
    public partial class Series : UserControl
    {
        public Series()
        {
            InitializeComponent();
            ListarSeries(GerarLista());
        }
        public List<String[]> GerarLista()
        {
            List<String[]> Lista = new List<String[]>();
            List<String[]> ListaFinal = new List<String[]>();
            //try
            //{
                SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
                con.Open();
                SQLiteCommand com = new SQLiteCommand("SELECT * FROM Series ORDER BY final DESC,ultimoEpisodioVisto ASC", con);
                SQLiteDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    String[] sa = new String[10];
                    sa[0] = Convert.ToString(r["id"]);
                    sa[1] = Convert.ToString(r["nome"]);
                    sa[2] = Convert.ToString(r["temporada"]);
                    sa[3] = Convert.ToString(r["episodio"]);
                    sa[4] = Convert.ToString(r["ultimoEpisodioVisto"]);
                    sa[5] = Convert.ToString(r["anoLancamento"]);
                    sa[6] = Convert.ToString(r["genero"]);
                    sa[7] = Convert.ToString(r["proximoEpisodio"]);
                    sa[8] = Convert.ToString(r["final"]);
                    if(sa[0].Equals("true"))
                    {
                        ListaFinal.Add(sa);
                        continue;
                    }
                    Lista.Add(sa);
                }
                foreach (String[] itens in ListaFinal)
                {
                    Lista.Add(itens);
                }
                con.Close();
            //}
           // catch (Exception e)
           // {
           //     MessageBox.Show("ERRO AO LISTAR SERIES " + e);
           // }
            return Lista;
        }
        private void apagar(List<int> Lista)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
                con.Open();
                foreach (int item in Lista)
                {
                    SQLiteCommand com = new SQLiteCommand("DELETE FROM Series WHERE ID = " + item, con);
                    SQLiteDataReader r = com.ExecuteReader();
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO AO APAGAR SERIE " + e);
            }
        }
        public enum Month
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        };

        public void ListarSeries(List<String[]> lista)
        {
            data_Series.Rows.Clear();
            ComboBox cb = new ComboBox();
            for (int a = 1990; a <= DateTime.Now.Year; a++)
            {
                cb.Items.Add("" + a);
            }
            // ID  TEMPORADA EPISODIO - DATA ASSISTIDO - ANO LANCAMENTO - GENERO - PROXIMO EPISODIO
            for (int i = lista.Count-1;i>=0;i--)
            {
                String[] item = lista[i];
                String fim = "NÃO";
                if (item[8].ToLower().Equals("true"))
                {
                    fim = "SIM";
                    data_Series.Rows.Add(item[0], item[1], item[2], item[3], item[4], null, item[6], fim, "APAGAR");
                    data_Series.Rows[data_Series.Rows.Count-1].ReadOnly = true;
                    data_Series.Rows[data_Series.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGray;
                    ((DataGridViewComboBoxColumn)data_Series.Columns["ano_lancamento"]).DataSource = cb.Items;
                    DataGridViewComboBoxCell cba2 = (DataGridViewComboBoxCell)data_Series.Rows[data_Series.Rows.Count - 1].Cells["ano_lancamento"];
                    cba2.Value = item[5];
                    continue;
                }
                fim = "NÃO";
                data_Series.Rows.Add(item[0], item[1], item[2], item[3], item[4], null, item[6], fim, "APAGAR");
                ((DataGridViewComboBoxColumn)data_Series.Columns["ano_lancamento"]).DataSource = cb.Items;
                DataGridViewComboBoxCell cba = (DataGridViewComboBoxCell)data_Series.Rows[data_Series.Rows.Count - 1].Cells["ano_lancamento"];
                cba.Value = item[5];
            }
            this.MinimumSize = new Size(data_Series.Width, this.groupBox1.Height);
            this.groupBox1.MinimumSize = new Size(data_Series.Width,this.groupBox1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarSeries(GerarLista());
        }

        private void button_Atualizar_Click(object sender, EventArgs e)
        {
            data_Series.Rows.Clear();
            ListarSeries(GerarLista());
        }

        private void data_Series_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1: // NOME
                    {
                        editarNomeSerie(int.Parse((string)data_Series.Rows[e.RowIndex].Cells[0].Value), (string)data_Series.Rows[e.RowIndex].Cells[1].Value);
                        break;
                    }
                case 2: // TEMPORADA
                    {
                        editarTemporada(int.Parse((string)data_Series.Rows[e.RowIndex].Cells[0].Value), int.Parse((string)data_Series.Rows[e.RowIndex].Cells[2].Value));
                        break;
                    }
                case 3: //EPISODIO
                    {
                        editarEpisodio(int.Parse((string)data_Series.Rows[e.RowIndex].Cells[0].Value), int.Parse((string)data_Series.Rows[e.RowIndex].Cells[3].Value));
                        break;
                    }
            }
        }

        private void data_Series_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        // SQL
        private void editarNomeSerie(int id, String Nome)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
                con.Open();
                SQLiteCommand com = new SQLiteCommand("UPDATE Series SET nome = '" + Nome + "' WHERE ID = " + id, con);
                com.ExecuteNonQuery();
                Console.WriteLine("Serie " + Nome + " alterada!");
                con.Close();
            }catch(Exception e)
            {
                Console.WriteLine("Erro ao alterar nome Serie: " + nome + " Erro: " + e);
            }
        }
        private void editarTemporada(int id, int temporada)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
                con.Open();
                SQLiteCommand com = new SQLiteCommand("UPDATE Series SET temporada = " + temporada + " WHERE ID = " + id, con);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao alterar nome Serie: " + nome + " Erro: " + e);
            }
        }
        private void editarFim(int id, int valor)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
                con.Open();
                SQLiteCommand com = new SQLiteCommand("UPDATE Series SET final = '" + valor + "' WHERE ID = " + id, con);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao alterar fim Serie: " + id + " Erro: " + e);
            }
        }
        private void editarEpisodio(int id, int episodio)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
                con.Open();
                SQLiteCommand com = new SQLiteCommand("UPDATE Series SET episodio = " + episodio + " WHERE ID = " + id, con);
                com.ExecuteNonQuery();
                com = new SQLiteCommand("UPDATE Series SET ultimoEpisodioVisto = @ultimoEpisodioVisto WHERE ID = " + id, con);
                com.Parameters.Add(new SQLiteParameter("@ultimoEpisodioVisto", System.DateTime.Now));
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao alterar nome Serie: " + nome + " Erro: " + e);
            }
        }

        private void data_Series_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if(e.ColumnIndex == data_Series.Columns["but_apagar"].Index) { 
                apagarSerie(int.Parse((string)data_Series.Rows[e.RowIndex].Cells["id"].Value));
            }else if (e.ColumnIndex == data_Series.Columns["but_fim"].Index)
            {
                DataGridViewButtonCell botao = (DataGridViewButtonCell)data_Series.Rows[e.RowIndex].Cells["but_fim"];
                if (botao.Value.Equals("SIM"))
                {
                    editarFim(int.Parse((string)data_Series.Rows[e.RowIndex].Cells["id"].Value), 0);
                }
                else
                {
                    editarFim(int.Parse((string)data_Series.Rows[e.RowIndex].Cells["id"].Value), 1);
                }
                data_Series.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void apagarSerie(int id)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
                con.Open();
                SQLiteCommand com = new SQLiteCommand("DELETE FROM Series WHERE ID = " + id, con);
                SQLiteDataReader r = com.ExecuteReader();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO AO APAGAR FILMES " + e);
            }
        }
        private void data_Series_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (data_Series.CurrentCell.ColumnIndex == 2 || data_Series.CurrentCell.ColumnIndex == 3)
                {
                    if (int.Parse((string)data_Series.CurrentCell.Value) > 1)
                    {
                        data_Series.CurrentCell.Value = "" + (int.Parse((string)data_Series.CurrentCell.Value) - 1);
                        if (data_Series.CurrentCell.ColumnIndex == 2)
                        {
                            editarTemporada(int.Parse((String)data_Series.CurrentRow.Cells[0].Value), int.Parse((string)data_Series.CurrentRow.Cells[2].Value));
                        }
                        else if (data_Series.CurrentCell.ColumnIndex == 3)
                        {
                            editarEpisodio(int.Parse((string)data_Series.CurrentRow.Cells[0].Value), int.Parse((string)data_Series.CurrentRow.Cells[3].Value));
                        }
                        return;
                    }
                    MessageBox.Show("Você ainda não assistiu nenhum episódio!");
                }
            }
            if (e.KeyCode == Keys.F2)
            {
                if (data_Series.CurrentCell.ColumnIndex == 2 || data_Series.CurrentCell.ColumnIndex == 3)
                {
                    data_Series.CurrentCell.Value = "" + (int.Parse((string)data_Series.CurrentCell.Value) + 1);
                    if (data_Series.CurrentCell.ColumnIndex == 2)
                    {
                        editarTemporada(int.Parse((String)data_Series.CurrentRow.Cells[0].Value), int.Parse((string)data_Series.CurrentRow.Cells[2].Value));
                    }
                    else if (data_Series.CurrentCell.ColumnIndex == 3)
                    {
                        editarEpisodio(int.Parse((string)data_Series.CurrentRow.Cells[0].Value), int.Parse((string)data_Series.CurrentRow.Cells[3].Value));
                    }
                    return;
                }
            }
            if (e.KeyCode == Keys.F5)
            {
                ListarSeries(GerarLista());
            }
        }
    }
}
