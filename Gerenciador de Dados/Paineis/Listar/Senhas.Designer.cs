namespace Gerenciador_de_Dados.Paineis.Listar
{
    partial class Panel_Senhas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Senhas));
            this.list_Senhas = new System.Windows.Forms.ListView();
            this.col_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Senha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Tamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_apagar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_Senhas
            // 
            this.list_Senhas.CheckBoxes = true;
            this.list_Senhas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ID,
            this.col_Nome,
            this.col_Usuario,
            this.col_Senha,
            this.col_Tamanho});
            this.list_Senhas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Senhas.FullRowSelect = true;
            this.list_Senhas.Location = new System.Drawing.Point(21, 53);
            this.list_Senhas.Name = "list_Senhas";
            this.list_Senhas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.list_Senhas.Size = new System.Drawing.Size(752, 411);
            this.list_Senhas.TabIndex = 0;
            this.list_Senhas.UseCompatibleStateImageBehavior = false;
            this.list_Senhas.View = System.Windows.Forms.View.Details;
            this.list_Senhas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_Senhas_MouseDoubleClick);
            // 
            // col_ID
            // 
            this.col_ID.Text = "ID";
            this.col_ID.Width = 30;
            // 
            // col_Nome
            // 
            this.col_Nome.Text = "Nome";
            this.col_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_Nome.Width = 150;
            // 
            // col_Usuario
            // 
            this.col_Usuario.Text = "Usuario";
            this.col_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_Usuario.Width = 150;
            // 
            // col_Senha
            // 
            this.col_Senha.Text = "Senha";
            this.col_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_Senha.Width = 310;
            // 
            // col_Tamanho
            // 
            this.col_Tamanho.Text = "Tamanho";
            this.col_Tamanho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_Tamanho.Width = 107;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_apagar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.list_Senhas);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(800, 600);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Senhas";
            // 
            // button_apagar
            // 
            this.button_apagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_apagar.BackgroundImage")));
            this.button_apagar.Location = new System.Drawing.Point(21, 498);
            this.button_apagar.Name = "button_apagar";
            this.button_apagar.Size = new System.Drawing.Size(100, 40);
            this.button_apagar.TabIndex = 2;
            this.button_apagar.Text = "Apagar";
            this.button_apagar.UseVisualStyleBackColor = true;
            this.button_apagar.Click += new System.EventHandler(this.button_apagar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(337, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Panel_Senhas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Gerenciador_de_Dados.Properties.Resources.hardened_clay_stained_blue;
            this.Controls.Add(this.groupBox1);
            this.Name = "Panel_Senhas";
            this.Size = new System.Drawing.Size(820, 620);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_Senhas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader col_ID;
        private System.Windows.Forms.ColumnHeader col_Nome;
        private System.Windows.Forms.ColumnHeader col_Senha;
        private System.Windows.Forms.ColumnHeader col_Tamanho;
        private System.Windows.Forms.Button button_apagar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader col_Usuario;
    }
}
