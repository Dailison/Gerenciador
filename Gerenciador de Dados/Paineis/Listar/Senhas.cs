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
    public partial class Panel_Senhas : UserControl
    {
        public Panel_Senhas()
        {
            InitializeComponent();
            Listar(GerarLista());
        }
        private List<String[]> GerarLista()
        {
            List<String[]> Lista = new List<String[]>();
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
                con.Open();
                SQLiteCommand com = new SQLiteCommand("SELECT * FROM Senhas ORDER BY ID ASC", con);
                SQLiteDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    String[] sa = new String[5];
                    sa[0] = Convert.ToString(r["id"]);
                    sa[1] = Convert.ToString(r["nome"]);
                    sa[2] = Convert.ToString(r["usuario"]);
                    sa[3] = Convert.ToString(r["senha"]);
                    sa[4] = "" + sa[3].Length;
                    Lista.Add(sa);
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO AO LISTAR SENHAS " + e);
            }
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
                    SQLiteCommand com = new SQLiteCommand("DELETE FROM Senhas WHERE ID = " + item, con);
                    SQLiteDataReader r = com.ExecuteReader();
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO AO APAGAR SENHAS " + e);
            }
        }
        private void Listar(List<String[]> lista)
        {
            list_Senhas.Items.Clear();
            foreach (String[] item in lista)
            {
                ListViewItem lv = new ListViewItem(item);
                list_Senhas.Items.Add(lv);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listar(GerarLista());
        }

        private void button_apagar_Click(object sender, EventArgs e)
        {
            List<int> apg = new List<int>();
            foreach (ListViewItem item in list_Senhas.Items)
            {
                if (item.Checked)
                {
                    item.Remove();
                    apg.Add(int.Parse(item.SubItems[0].Text));
                }
            }
            apagar(apg);
        }

        private void list_Senhas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(list_Senhas.SelectedItems[0].SubItems[3].Text);
            Program.Alerta(0, "Senha Copiada!");
        }
    }
}
