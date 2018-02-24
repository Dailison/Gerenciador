namespace Gerenciador_de_Dados.Paineis.Listar
{
    partial class Series
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.data_Series = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.episodio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimo_episodio_assistido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano_lancamento = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_fim = new System.Windows.Forms.DataGridViewButtonColumn();
            this.but_apagar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Series)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.data_Series);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1012, 618);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Séries";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(710, 538);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(88, 64);
            this.label1.TabIndex = 6;
            this.label1.Text = "F2 - Editar\r\nF3 - Apagar\r\nF5 - Atualizar\nF1 - Assistido";
            // 
            // data_Series
            // 
            this.data_Series.AllowUserToAddRows = false;
            this.data_Series.AllowUserToDeleteRows = false;
            this.data_Series.AllowUserToResizeColumns = false;
            this.data_Series.AllowUserToResizeRows = false;
            this.data_Series.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data_Series.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_Series.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_Series.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_Series.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Series.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.temporada,
            this.episodio,
            this.ultimo_episodio_assistido,
            this.ano_lancamento,
            this.genero,
            this.but_fim,
            this.but_apagar});
            this.data_Series.Cursor = System.Windows.Forms.Cursors.Default;
            this.data_Series.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data_Series.GridColor = System.Drawing.SystemColors.Control;
            this.data_Series.Location = new System.Drawing.Point(6, 19);
            this.data_Series.MaximumSize = new System.Drawing.Size(1920, 500);
            this.data_Series.MinimumSize = new System.Drawing.Size(1000, 500);
            this.data_Series.Name = "data_Series";
            this.data_Series.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_Series.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.data_Series.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.data_Series.RowTemplate.ErrorText = "Dados Inválidos";
            this.data_Series.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.data_Series.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data_Series.ShowCellErrors = false;
            this.data_Series.ShowRowErrors = false;
            this.data_Series.Size = new System.Drawing.Size(1000, 500);
            this.data_Series.TabIndex = 5;
            this.data_Series.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.data_Series_CellBeginEdit);
            this.data_Series.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Series_CellClick);
            this.data_Series.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Series_CellEndEdit);
            this.data_Series.KeyDown += new System.Windows.Forms.KeyEventHandler(this.data_Series_KeyDown);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 46;
            // 
            // nome
            // 
            this.nome.HeaderText = "NOME";
            this.nome.Name = "nome";
            this.nome.Width = 67;
            // 
            // temporada
            // 
            this.temporada.HeaderText = "Temp";
            this.temporada.Name = "temporada";
            this.temporada.Width = 59;
            // 
            // episodio
            // 
            this.episodio.HeaderText = "Epi";
            this.episodio.Name = "episodio";
            this.episodio.Width = 49;
            // 
            // ultimo_episodio_assistido
            // 
            this.ultimo_episodio_assistido.HeaderText = "Data Assistido";
            this.ultimo_episodio_assistido.Name = "ultimo_episodio_assistido";
            this.ultimo_episodio_assistido.ReadOnly = true;
            this.ultimo_episodio_assistido.Width = 106;
            // 
            // ano_lancamento
            // 
            this.ano_lancamento.HeaderText = "Lançamento";
            this.ano_lancamento.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000"});
            this.ano_lancamento.Name = "ano_lancamento";
            this.ano_lancamento.Width = 73;
            // 
            // genero
            // 
            this.genero.HeaderText = "Gênero";
            this.genero.Name = "genero";
            this.genero.Width = 69;
            // 
            // but_fim
            // 
            this.but_fim.HeaderText = "Fim";
            this.but_fim.Name = "but_fim";
            this.but_fim.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.but_fim.Text = "Sim";
            this.but_fim.Width = 31;
            // 
            // but_apagar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.but_apagar.DefaultCellStyle = dataGridViewCellStyle2;
            this.but_apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_apagar.HeaderText = "Apagar";
            this.but_apagar.Name = "but_apagar";
            this.but_apagar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.but_apagar.Text = "Apagar";
            this.but_apagar.UseColumnTextForButtonValue = true;
            this.but_apagar.Width = 50;
            // 
            // Series
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(10, 10);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Series";
            this.Size = new System.Drawing.Size(1015, 621);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Series)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView data_Series;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn episodio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimo_episodio_assistido;
        private System.Windows.Forms.DataGridViewComboBoxColumn ano_lancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewButtonColumn but_fim;
        private System.Windows.Forms.DataGridViewButtonColumn but_apagar;
    }
}
