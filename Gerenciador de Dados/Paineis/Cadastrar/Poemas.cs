using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_Dados.Paineis.Cadastrar
{
    public partial class Poemas : UserControl
    {
        public Poemas()
        {
            InitializeComponent();
        }

        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Texto do poema: " + txt_Poemas.Text);
        }
    }
}
