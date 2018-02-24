namespace Gerenciador_de_Dados.Paineis.Cadastrar
{
    partial class Poemas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Poemas = new System.Windows.Forms.TextBox();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_Poemas);
            this.groupBox1.Controls.Add(this.button_Cadastrar);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(800, 600);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Poemas";
            // 
            // txt_Poemas
            // 
            this.txt_Poemas.Location = new System.Drawing.Point(47, 32);
            this.txt_Poemas.Multiline = true;
            this.txt_Poemas.Name = "txt_Poemas";
            this.txt_Poemas.Size = new System.Drawing.Size(702, 346);
            this.txt_Poemas.TabIndex = 1;
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.BackgroundImage = global::Gerenciador_de_Dados.Properties.Resources.anvil_base;
            this.button_Cadastrar.ForeColor = System.Drawing.Color.White;
            this.button_Cadastrar.Location = new System.Drawing.Point(47, 404);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(100, 40);
            this.button_Cadastrar.TabIndex = 0;
            this.button_Cadastrar.Text = "Cadastrar";
            this.button_Cadastrar.UseVisualStyleBackColor = true;
            this.button_Cadastrar.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // Poemas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Gerenciador_de_Dados.Properties.Resources.hardened_clay_stained_blue;
            this.Controls.Add(this.groupBox1);
            this.Name = "Poemas";
            this.Size = new System.Drawing.Size(820, 620);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Cadastrar;
        private System.Windows.Forms.TextBox txt_Poemas;
    }
}
