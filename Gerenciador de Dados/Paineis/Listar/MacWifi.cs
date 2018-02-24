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
    public partial class MacWifi : UserControl
    {
        public MacWifi()
        {
            InitializeComponent();
            ListarMacs(GerarListaMacs());
        }

        private void button_Atualizar_Click(object sender, EventArgs e)
        {
            ListarMacs(GerarListaMacs());
        }
        private List<String[]> GerarListaMacs()
        {
            List<String[]> Lista = new List<String[]>();
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
                con.Open();
                SQLiteCommand com = new SQLiteCommand("SELECT * FROM MacWifi ORDER BY ID ASC", con);
                SQLiteDataReader r = com.ExecuteReader();
                while (r.Read())
                {
                    String[] sa = new String[4];
                    sa[0] = Convert.ToString(r["id"]);
                    sa[1] = Convert.ToString(r["nome"]);
                    String txt = Convert.ToString(r["mac"]);
                    String txtFinal = "";
                    char[] txt1 = txt.ToCharArray();
                    int a = 0;
                    foreach (char item in txt1)
                    {
                        if (a == 2)
                        {
                            txtFinal = txtFinal + ".";
                            a = 0;
                        }
                        txtFinal = txtFinal + item;
                        a++;
                        Console.WriteLine("Valor " + item);
                    }
                    sa[2] = txtFinal;
                    String tipo = "";
                    switch (int.Parse(Convert.ToString(r["tipo"])))
                    {
                        case 0:
                            tipo = "Computador de Mesa";
                            break;
                        case 1:
                            tipo = "Celular";
                            break;
                        case 2:
                            tipo = "Notbook";
                            break;
                        default:
                            break;
                    }
                    sa[3] = tipo;
                    Lista.Add(sa);
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO AO LISTAR MACS " + e);
            }
            return Lista;
        }
        private void apagarMacs(List<int> Lista)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("data source=Dados.sqlite");
                con.Open();
                foreach (int item in Lista)
                {
                    SQLiteCommand com = new SQLiteCommand("DELETE FROM MacWifi WHERE ID = " + item, con);
                    SQLiteDataReader r = com.ExecuteReader();
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("ERRO AO APAGAR MACS " + e);
            }
        }
        private void ListarMacs(List<String[]> lista)
        {
            list_Mac.Items.Clear();
            foreach (String[] item in lista)
            {
                ListViewItem lv = new ListViewItem(item);
                list_Mac.Items.Add(lv);
            }
        }

        private void button_Apagar_Click(object sender, EventArgs e)
        {
            List<int> apagar = new List<int>();
            foreach (ListViewItem item in list_Mac.Items)
            {
                if (item.Checked)
                {
                    item.Remove();
                    apagar.Add(int.Parse(item.SubItems[0].Text));
                }
            }
            apagarMacs(apagar);
        }

        private void list_Mac_MouseClick(object sender, MouseEventArgs e)
        {

            Clipboard.SetText(list_Mac.SelectedItems[0].SubItems[2].Text.Replace(".",""));
            Program.Alerta(0,"M.A.C Copiado!");
        }
    }
}
