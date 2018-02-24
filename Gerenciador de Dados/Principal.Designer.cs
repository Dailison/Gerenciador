namespace Gerenciador_de_Dados
{
    partial class Principal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menu_Principal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Backup = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Filmes = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Series = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_MacWifi = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Senhas = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Poemas = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Listar_Filmes = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Listar_Series = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Listar_MacWifi = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Listar_Senhas = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.groupBox_Atualizar = new System.Windows.Forms.GroupBox();
            this.progressBar_Atualizando = new System.Windows.Forms.ProgressBar();
            this.pictureBox_Load = new System.Windows.Forms.PictureBox();
            this.menu_Principal.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel_principal.SuspendLayout();
            this.groupBox_Atualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Load)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_Principal
            // 
            this.menu_Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.menu_Principal.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menu_Principal.Location = new System.Drawing.Point(0, 0);
            this.menu_Principal.Name = "menu_Principal";
            this.menu_Principal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu_Principal.Size = new System.Drawing.Size(804, 28);
            this.menu_Principal.TabIndex = 0;
            this.menu_Principal.Text = "menuStrip1";
            this.menu_Principal.Visible = false;
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Backup,
            this.menu_Sair});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // menu_Backup
            // 
            this.menu_Backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.menu_Backup.Name = "menu_Backup";
            this.menu_Backup.Size = new System.Drawing.Size(128, 24);
            this.menu_Backup.Text = "Backup";
            this.menu_Backup.Click += new System.EventHandler(this.menu_Backup_Click);
            // 
            // menu_Sair
            // 
            this.menu_Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.menu_Sair.Name = "menu_Sair";
            this.menu_Sair.Size = new System.Drawing.Size(128, 24);
            this.menu_Sair.Text = "Sair";
            this.menu_Sair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Filmes,
            this.menu_Series,
            this.menu_MacWifi,
            this.menu_Senhas,
            this.menu_Poemas});
            this.cadastrarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // menu_Filmes
            // 
            this.menu_Filmes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.menu_Filmes.Name = "menu_Filmes";
            this.menu_Filmes.Size = new System.Drawing.Size(197, 24);
            this.menu_Filmes.Text = "Filmes Assistidos";
            this.menu_Filmes.Click += new System.EventHandler(this.Click_Cad_Filmes);
            // 
            // menu_Series
            // 
            this.menu_Series.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.menu_Series.Name = "menu_Series";
            this.menu_Series.Size = new System.Drawing.Size(197, 24);
            this.menu_Series.Text = "Series Assistidas";
            this.menu_Series.Click += new System.EventHandler(this.Click_Cad_Series);
            // 
            // menu_MacWifi
            // 
            this.menu_MacWifi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.menu_MacWifi.Name = "menu_MacWifi";
            this.menu_MacWifi.Size = new System.Drawing.Size(197, 24);
            this.menu_MacWifi.Text = "M.A.Cs Wifi";
            this.menu_MacWifi.Click += new System.EventHandler(this.Click_Cad_MacWifi);
            // 
            // menu_Senhas
            // 
            this.menu_Senhas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.menu_Senhas.Name = "menu_Senhas";
            this.menu_Senhas.Size = new System.Drawing.Size(197, 24);
            this.menu_Senhas.Text = "Senhas";
            this.menu_Senhas.Click += new System.EventHandler(this.Click_Cad_Senhas);
            // 
            // menu_Poemas
            // 
            this.menu_Poemas.Name = "menu_Poemas";
            this.menu_Poemas.Size = new System.Drawing.Size(197, 24);
            this.menu_Poemas.Text = "Poemas";
            this.menu_Poemas.Visible = false;
            this.menu_Poemas.Click += new System.EventHandler(this.menu_Poemas_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Listar_Filmes,
            this.menu_Listar_Series,
            this.menu_Listar_MacWifi,
            this.menu_Listar_Senhas});
            this.listarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // menu_Listar_Filmes
            // 
            this.menu_Listar_Filmes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.menu_Listar_Filmes.Name = "menu_Listar_Filmes";
            this.menu_Listar_Filmes.Size = new System.Drawing.Size(152, 24);
            this.menu_Listar_Filmes.Text = "Filmes";
            this.menu_Listar_Filmes.Click += new System.EventHandler(this.menu_Listar_Filmes_Click);
            // 
            // menu_Listar_Series
            // 
            this.menu_Listar_Series.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.menu_Listar_Series.Name = "menu_Listar_Series";
            this.menu_Listar_Series.Size = new System.Drawing.Size(152, 24);
            this.menu_Listar_Series.Text = "Series";
            this.menu_Listar_Series.Click += new System.EventHandler(this.menu_Listar_Series_Click);
            // 
            // menu_Listar_MacWifi
            // 
            this.menu_Listar_MacWifi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.menu_Listar_MacWifi.Name = "menu_Listar_MacWifi";
            this.menu_Listar_MacWifi.Size = new System.Drawing.Size(152, 24);
            this.menu_Listar_MacWifi.Text = "M.A.C Wifi";
            this.menu_Listar_MacWifi.Click += new System.EventHandler(this.menu_Listar_MacWifi_Click);
            // 
            // menu_Listar_Senhas
            // 
            this.menu_Listar_Senhas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.menu_Listar_Senhas.Name = "menu_Listar_Senhas";
            this.menu_Listar_Senhas.Size = new System.Drawing.Size(152, 24);
            this.menu_Listar_Senhas.Text = "Senhas";
            this.menu_Listar_Senhas.Click += new System.EventHandler(this.menu_Listar_Senhas_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipTitle = "By Dailison";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Dailison - Gerenciador de Dados";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurarToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 48);
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            this.restaurarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.restaurarToolStripMenuItem.Text = "Restaurar";
            this.restaurarToolStripMenuItem.Click += new System.EventHandler(this.restaurarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // panel_principal
            // 
            this.panel_principal.AutoSize = true;
            this.panel_principal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_principal.BackColor = System.Drawing.Color.Transparent;
            this.panel_principal.Controls.Add(this.groupBox_Atualizar);
            this.panel_principal.Controls.Add(this.pictureBox_Load);
            this.panel_principal.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_principal.Location = new System.Drawing.Point(0, 30);
            this.panel_principal.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.panel_principal.MinimumSize = new System.Drawing.Size(820, 620);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(820, 620);
            this.panel_principal.TabIndex = 1;
            // 
            // groupBox_Atualizar
            // 
            this.groupBox_Atualizar.BackColor = System.Drawing.Color.White;
            this.groupBox_Atualizar.Controls.Add(this.progressBar_Atualizando);
            this.groupBox_Atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Atualizar.Location = new System.Drawing.Point(223, 273);
            this.groupBox_Atualizar.Name = "groupBox_Atualizar";
            this.groupBox_Atualizar.Size = new System.Drawing.Size(375, 74);
            this.groupBox_Atualizar.TabIndex = 3;
            this.groupBox_Atualizar.TabStop = false;
            this.groupBox_Atualizar.Text = "Baixando Atualização, por favor aguarde";
            this.groupBox_Atualizar.Visible = false;
            // 
            // progressBar_Atualizando
            // 
            this.progressBar_Atualizando.Location = new System.Drawing.Point(6, 25);
            this.progressBar_Atualizando.Name = "progressBar_Atualizando";
            this.progressBar_Atualizando.Size = new System.Drawing.Size(363, 31);
            this.progressBar_Atualizando.TabIndex = 1;
            // 
            // pictureBox_Load
            // 
            this.pictureBox_Load.Location = new System.Drawing.Point(223, 132);
            this.pictureBox_Load.Name = "pictureBox_Load";
            this.pictureBox_Load.Size = new System.Drawing.Size(375, 356);
            this.pictureBox_Load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Load.TabIndex = 1;
            this.pictureBox_Load.TabStop = false;
            this.pictureBox_Load.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Gerenciador_de_Dados.Properties.Resources.hardened_clay_stained_blue;
            this.ClientSize = new System.Drawing.Size(804, 581);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.menu_Principal);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(820, 620);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Dados   by: @dailison";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu_Principal.ResumeLayout(false);
            this.menu_Principal.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel_principal.ResumeLayout(false);
            this.groupBox_Atualizar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Load)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_Sair;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_Filmes;
        private System.Windows.Forms.ToolStripMenuItem menu_Senhas;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_Listar_Filmes;
        private System.Windows.Forms.ToolStripMenuItem menu_Listar_Series;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu_Series;
        private System.Windows.Forms.ToolStripMenuItem menu_MacWifi;
        private System.Windows.Forms.ToolStripMenuItem menu_Listar_MacWifi;
        public System.Windows.Forms.MenuStrip menu_Principal;
        public System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.ToolStripMenuItem menu_Listar_Senhas;
        private System.Windows.Forms.ToolStripMenuItem menu_Backup;
        private System.Windows.Forms.ToolStripMenuItem menu_Poemas;
        public System.Windows.Forms.GroupBox groupBox_Atualizar;
        public System.Windows.Forms.ProgressBar progressBar_Atualizando;
        private System.Windows.Forms.PictureBox pictureBox_Load;
    }
}

