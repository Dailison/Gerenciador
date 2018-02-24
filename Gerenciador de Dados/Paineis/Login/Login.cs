using System;
using System.Windows.Forms;
using System.Threading;
using Gerenciador_de_Dados.Paineis.Login;

namespace Gerenciador_de_Dados.Paineis.Login
{
    public partial class Login : UserControl
    {
        public static Paineis.Login.Autenticado Auth;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (txt_Login_Usuario.Text == "dailison") {
                //if (txt_Login_Senha.Text == "dsm0105")
               // {
                    Program.getPrincipal().Lista_Paineis["Login"].Visible = false;
                    Program.getPrincipal().menu_Principal.Show();
                    Auth = new Paineis.Login.Autenticado(txt_Login_Usuario.Text);
               // }
               // else {
               //     senhaIncorreta();
              //  }
           // }
            //else
            //{
            //    senhaIncorreta();
           // }
        }
        private void senhaIncorreta()
        {
            groupBox1.Hide();
            groupBox_Senha_Incorreta.Show();
            groupBox_Senha_Incorreta.Update();
            Thread.Sleep(500);
            groupBox_Senha_Incorreta.Hide();
            groupBox1.Show();
            groupBox_Senha_Incorreta.Update();
            txt_Login_Senha.Text = null;
            txt_Login_Senha.Select();
        }
        private void txt_Login_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.but_Login_Logar.PerformClick();
            }
        }
    }
}
