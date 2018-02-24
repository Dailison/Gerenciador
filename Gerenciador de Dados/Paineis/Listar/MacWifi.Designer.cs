namespace Gerenciador_de_Dados.Paineis.Listar
{
    partial class MacWifi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MacWifi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Apagar = new System.Windows.Forms.Button();
            this.button_Alterar = new System.Windows.Forms.Button();
            this.button_Atualizar = new System.Windows.Forms.Button();
            this.list_Mac = new System.Windows.Forms.ListView();
            this.col_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Mac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button_Apagar);
            this.groupBox1.Controls.Add(this.button_Alterar);
            this.groupBox1.Controls.Add(this.button_Atualizar);
            this.groupBox1.Controls.Add(this.list_Mac);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(800, 600);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereços M.A.C Cadastrados";
            // 
            // button_Apagar
            // 
            this.button_Apagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Apagar.BackgroundImage")));
            this.button_Apagar.Location = new System.Drawing.Point(299, 531);
            this.button_Apagar.Name = "button_Apagar";
            this.button_Apagar.Size = new System.Drawing.Size(100, 35);
            this.button_Apagar.TabIndex = 3;
            this.button_Apagar.Text = "Apagar";
            this.button_Apagar.UseVisualStyleBackColor = true;
            this.button_Apagar.Click += new System.EventHandler(this.button_Apagar_Click);
            // 
            // button_Alterar
            // 
            this.button_Alterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Alterar.BackgroundImage")));
            this.button_Alterar.Location = new System.Drawing.Point(11, 531);
            this.button_Alterar.Name = "button_Alterar";
            this.button_Alterar.Size = new System.Drawing.Size(100, 35);
            this.button_Alterar.TabIndex = 2;
            this.button_Alterar.Text = "Alterar";
            this.button_Alterar.UseVisualStyleBackColor = true;
            // 
            // button_Atualizar
            // 
            this.button_Atualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Atualizar.BackgroundImage")));
            this.button_Atualizar.Location = new System.Drawing.Point(679, 531);
            this.button_Atualizar.Name = "button_Atualizar";
            this.button_Atualizar.Size = new System.Drawing.Size(100, 35);
            this.button_Atualizar.TabIndex = 1;
            this.button_Atualizar.Text = "Atualizar";
            this.button_Atualizar.UseVisualStyleBackColor = true;
            this.button_Atualizar.Click += new System.EventHandler(this.button_Atualizar_Click);
            // 
            // list_Mac
            // 
            this.list_Mac.CheckBoxes = true;
            this.list_Mac.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ID,
            this.col_Nome,
            this.Col_Mac,
            this.col_Tipo});
            this.list_Mac.FullRowSelect = true;
            this.list_Mac.Location = new System.Drawing.Point(11, 21);
            this.list_Mac.Name = "list_Mac";
            this.list_Mac.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.list_Mac.ShowGroups = false;
            this.list_Mac.Size = new System.Drawing.Size(778, 466);
            this.list_Mac.TabIndex = 0;
            this.list_Mac.UseCompatibleStateImageBehavior = false;
            this.list_Mac.View = System.Windows.Forms.View.Details;
            this.list_Mac.MouseClick += new System.Windows.Forms.MouseEventHandler(this.list_Mac_MouseClick);
            // 
            // col_ID
            // 
            this.col_ID.Text = "ID";
            this.col_ID.Width = 37;
            // 
            // col_Nome
            // 
            this.col_Nome.Text = "Nome";
            this.col_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_Nome.Width = 300;
            // 
            // Col_Mac
            // 
            this.Col_Mac.Text = "Endereço M.A.C";
            this.Col_Mac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Col_Mac.Width = 200;
            // 
            // col_Tipo
            // 
            this.col_Tipo.Text = "Tipo de Dispositivo";
            this.col_Tipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_Tipo.Width = 225;
            // 
            // MacWifi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Gerenciador_de_Dados.Properties.Resources.hardened_clay_stained_blue;
            this.Controls.Add(this.groupBox1);
            this.Name = "MacWifi";
            this.Size = new System.Drawing.Size(820, 620);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView list_Mac;
        private System.Windows.Forms.ColumnHeader col_ID;
        private System.Windows.Forms.ColumnHeader col_Nome;
        private System.Windows.Forms.ColumnHeader Col_Mac;
        private System.Windows.Forms.Button button_Apagar;
        private System.Windows.Forms.Button button_Alterar;
        private System.Windows.Forms.Button button_Atualizar;
        private System.Windows.Forms.ColumnHeader col_Tipo;
    }
}
