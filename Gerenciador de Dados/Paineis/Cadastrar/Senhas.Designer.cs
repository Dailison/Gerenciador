namespace Gerenciador_de_Dados.Paineis.Cadastrar
{
    partial class Senhas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Senhas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_Numeros = new System.Windows.Forms.CheckBox();
            this.checkBox_Caracteres_Especiais = new System.Windows.Forms.CheckBox();
            this.checkBox_Maiusculas = new System.Windows.Forms.CheckBox();
            this.txt_Tamanho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Gerar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_Usuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button_Cadastrar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Senha);
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(800, 600);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Senhas";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.Location = new System.Drawing.Point(40, 122);
            this.txt_Usuario.MaxLength = 64;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Usuario.Size = new System.Drawing.Size(664, 28);
            this.txt_Usuario.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuário";
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Cadastrar.BackgroundImage")));
            this.button_Cadastrar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cadastrar.Location = new System.Drawing.Point(31, 504);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Cadastrar.Size = new System.Drawing.Size(100, 40);
            this.button_Cadastrar.TabIndex = 6;
            this.button_Cadastrar.Text = "Cadastrar";
            this.button_Cadastrar.UseVisualStyleBackColor = true;
            this.button_Cadastrar.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_Numeros);
            this.groupBox2.Controls.Add(this.checkBox_Caracteres_Especiais);
            this.groupBox2.Controls.Add(this.checkBox_Maiusculas);
            this.groupBox2.Controls.Add(this.txt_Tamanho);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button_Gerar);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(37, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(656, 216);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gerador de Senha";
            // 
            // checkBox_Numeros
            // 
            this.checkBox_Numeros.AutoSize = true;
            this.checkBox_Numeros.Checked = true;
            this.checkBox_Numeros.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Numeros.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Numeros.Location = new System.Drawing.Point(167, 102);
            this.checkBox_Numeros.Name = "checkBox_Numeros";
            this.checkBox_Numeros.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Numeros.Size = new System.Drawing.Size(89, 24);
            this.checkBox_Numeros.TabIndex = 5;
            this.checkBox_Numeros.Text = "Números";
            this.checkBox_Numeros.UseVisualStyleBackColor = true;
            // 
            // checkBox_Caracteres_Especiais
            // 
            this.checkBox_Caracteres_Especiais.AutoSize = true;
            this.checkBox_Caracteres_Especiais.Checked = true;
            this.checkBox_Caracteres_Especiais.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Caracteres_Especiais.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Caracteres_Especiais.Location = new System.Drawing.Point(167, 68);
            this.checkBox_Caracteres_Especiais.Name = "checkBox_Caracteres_Especiais";
            this.checkBox_Caracteres_Especiais.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Caracteres_Especiais.Size = new System.Drawing.Size(172, 24);
            this.checkBox_Caracteres_Especiais.TabIndex = 4;
            this.checkBox_Caracteres_Especiais.Text = "Caracteres Especiais";
            this.checkBox_Caracteres_Especiais.UseVisualStyleBackColor = true;
            // 
            // checkBox_Maiusculas
            // 
            this.checkBox_Maiusculas.AutoSize = true;
            this.checkBox_Maiusculas.Checked = true;
            this.checkBox_Maiusculas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Maiusculas.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Maiusculas.Location = new System.Drawing.Point(167, 36);
            this.checkBox_Maiusculas.Name = "checkBox_Maiusculas";
            this.checkBox_Maiusculas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Maiusculas.Size = new System.Drawing.Size(194, 24);
            this.checkBox_Maiusculas.TabIndex = 3;
            this.checkBox_Maiusculas.Text = "Maiusculas e Minusculas";
            this.checkBox_Maiusculas.UseVisualStyleBackColor = true;
            // 
            // txt_Tamanho
            // 
            this.txt_Tamanho.Location = new System.Drawing.Point(32, 81);
            this.txt_Tamanho.Name = "txt_Tamanho";
            this.txt_Tamanho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Tamanho.Size = new System.Drawing.Size(62, 28);
            this.txt_Tamanho.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 58);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tamanho";
            // 
            // button_Gerar
            // 
            this.button_Gerar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Gerar.BackgroundImage")));
            this.button_Gerar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Gerar.Location = new System.Drawing.Point(17, 160);
            this.button_Gerar.Name = "button_Gerar";
            this.button_Gerar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Gerar.Size = new System.Drawing.Size(100, 40);
            this.button_Gerar.TabIndex = 5;
            this.button_Gerar.Text = "Gerar";
            this.button_Gerar.UseVisualStyleBackColor = true;
            this.button_Gerar.Click += new System.EventHandler(this.button_Gerar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.Location = new System.Drawing.Point(40, 187);
            this.txt_Senha.MaxLength = 64;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Senha.Size = new System.Drawing.Size(664, 28);
            this.txt_Senha.TabIndex = 3;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(40, 54);
            this.txt_Nome.MaxLength = 64;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Nome.Size = new System.Drawing.Size(664, 28);
            this.txt_Nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // Senhas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Gerenciador_de_Dados.Properties.Resources.hardened_clay_stained_blue;
            this.Controls.Add(this.groupBox1);
            this.Name = "Senhas";
            this.Size = new System.Drawing.Size(820, 620);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Cadastrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Gerar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_Numeros;
        private System.Windows.Forms.CheckBox checkBox_Caracteres_Especiais;
        private System.Windows.Forms.CheckBox checkBox_Maiusculas;
        private System.Windows.Forms.TextBox txt_Tamanho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label4;
    }
}
