namespace Gerenciador_de_Dados.Paineis.Login
{
    partial class Login
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Senha_Incorreta = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Login_Senha = new System.Windows.Forms.MaskedTextBox();
            this.txt_Login_Usuario = new System.Windows.Forms.TextBox();
            this.but_Login_Logar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_Senha_Incorreta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Senha_Incorreta
            // 
            this.groupBox_Senha_Incorreta.BackColor = System.Drawing.Color.Salmon;
            this.groupBox_Senha_Incorreta.Controls.Add(this.label4);
            this.groupBox_Senha_Incorreta.Controls.Add(this.label3);
            this.groupBox_Senha_Incorreta.Enabled = false;
            this.groupBox_Senha_Incorreta.Location = new System.Drawing.Point(225, 175);
            this.groupBox_Senha_Incorreta.Name = "groupBox_Senha_Incorreta";
            this.groupBox_Senha_Incorreta.Size = new System.Drawing.Size(350, 250);
            this.groupBox_Senha_Incorreta.TabIndex = 7;
            this.groupBox_Senha_Incorreta.TabStop = false;
            this.groupBox_Senha_Incorreta.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Por favor tente novamente...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dados inválidos!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Gerenciador_de_Dados.Properties.Resources.hardened_clay_stained_blue;
            this.groupBox1.Controls.Add(this.txt_Login_Senha);
            this.groupBox1.Controls.Add(this.txt_Login_Usuario);
            this.groupBox1.Controls.Add(this.but_Login_Logar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(100, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logue-se";
            // 
            // txt_Login_Senha
            // 
            this.txt_Login_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Login_Senha.Location = new System.Drawing.Point(211, 222);
            this.txt_Login_Senha.Name = "txt_Login_Senha";
            this.txt_Login_Senha.PasswordChar = '●';
            this.txt_Login_Senha.Size = new System.Drawing.Size(188, 29);
            this.txt_Login_Senha.TabIndex = 4;
            this.txt_Login_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Login_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Login_Senha_KeyDown);
            // 
            // txt_Login_Usuario
            // 
            this.txt_Login_Usuario.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Login_Usuario.Location = new System.Drawing.Point(211, 120);
            this.txt_Login_Usuario.Name = "txt_Login_Usuario";
            this.txt_Login_Usuario.Size = new System.Drawing.Size(188, 28);
            this.txt_Login_Usuario.TabIndex = 3;
            this.txt_Login_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Login_Usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Login_Senha_KeyDown);
            // 
            // but_Login_Logar
            // 
            this.but_Login_Logar.BackgroundImage = global::Gerenciador_de_Dados.Properties.Resources.anvil_base;
            this.but_Login_Logar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Login_Logar.ForeColor = System.Drawing.Color.White;
            this.but_Login_Logar.Location = new System.Drawing.Point(261, 306);
            this.but_Login_Logar.Name = "but_Login_Logar";
            this.but_Login_Logar.Size = new System.Drawing.Size(86, 33);
            this.but_Login_Logar.TabIndex = 2;
            this.but_Login_Logar.Text = "Logar";
            this.but_Login_Logar.UseVisualStyleBackColor = true;
            this.but_Login_Logar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(274, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(274, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Usuario";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Senha_Incorreta);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(800, 600);
            this.groupBox_Senha_Incorreta.ResumeLayout(false);
            this.groupBox_Senha_Incorreta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_Senha_Incorreta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txt_Login_Senha;
        private System.Windows.Forms.Button but_Login_Logar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_Login_Usuario;
    }
}
