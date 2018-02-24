namespace Gerenciador_de_Dados.Paineis.Cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Series));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.num_Episodio = new System.Windows.Forms.NumericUpDown();
            this.num_Temporada = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_UltimoEpisodio = new System.Windows.Forms.DateTimePicker();
            this.checkBox_Fim_Serie = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkBox_Genero_Terror = new System.Windows.Forms.CheckBox();
            this.checkBox_Genero_Aventura = new System.Windows.Forms.CheckBox();
            this.checkBox_Genero_Ficcao = new System.Windows.Forms.CheckBox();
            this.checkBox_Genero_Drama = new System.Windows.Forms.CheckBox();
            this.checkBox_Genero_Romance = new System.Windows.Forms.CheckBox();
            this.checkBox_Genero_Acao = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Ano_Lancamento = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_Limpar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox_Previsao = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Episodio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Temporada)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.button_Cadastrar);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.button_Limpar);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(10, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(800, 600);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cadastro de Series";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.num_Episodio);
            this.groupBox4.Controls.Add(this.num_Temporada);
            this.groupBox4.Controls.Add(this.checkBox_Fim_Serie);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(18, 295);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(401, 222);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Último Episódio Assistido";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(217, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Data";
            // 
            // num_Episodio
            // 
            this.num_Episodio.Location = new System.Drawing.Point(39, 125);
            this.num_Episodio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Episodio.Name = "num_Episodio";
            this.num_Episodio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_Episodio.Size = new System.Drawing.Size(120, 20);
            this.num_Episodio.TabIndex = 15;
            this.num_Episodio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_Temporada
            // 
            this.num_Temporada.Location = new System.Drawing.Point(39, 52);
            this.num_Temporada.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Temporada.Name = "num_Temporada";
            this.num_Temporada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_Temporada.Size = new System.Drawing.Size(120, 20);
            this.num_Temporada.TabIndex = 14;
            this.num_Temporada.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePicker_UltimoEpisodio
            // 
            this.dateTimePicker_UltimoEpisodio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_UltimoEpisodio.Location = new System.Drawing.Point(15, 66);
            this.dateTimePicker_UltimoEpisodio.Name = "dateTimePicker_UltimoEpisodio";
            this.dateTimePicker_UltimoEpisodio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker_UltimoEpisodio.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker_UltimoEpisodio.TabIndex = 13;
            // 
            // checkBox_Fim_Serie
            // 
            this.checkBox_Fim_Serie.AutoSize = true;
            this.checkBox_Fim_Serie.Location = new System.Drawing.Point(39, 187);
            this.checkBox_Fim_Serie.Name = "checkBox_Fim_Serie";
            this.checkBox_Fim_Serie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Fim_Serie.Size = new System.Drawing.Size(90, 17);
            this.checkBox_Fim_Serie.TabIndex = 12;
            this.checkBox_Fim_Serie.Text = "Fim da Série?";
            this.checkBox_Fim_Serie.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Episódio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Temporada";
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Cadastrar.BackgroundImage")));
            this.button_Cadastrar.Location = new System.Drawing.Point(25, 540);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(100, 35);
            this.button_Cadastrar.TabIndex = 8;
            this.button_Cadastrar.Text = "Cadastrar";
            this.button_Cadastrar.UseVisualStyleBackColor = true;
            this.button_Cadastrar.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.checkBox_Genero_Terror);
            this.groupBox7.Controls.Add(this.checkBox_Genero_Aventura);
            this.groupBox7.Controls.Add(this.checkBox_Genero_Ficcao);
            this.groupBox7.Controls.Add(this.checkBox_Genero_Drama);
            this.groupBox7.Controls.Add(this.checkBox_Genero_Romance);
            this.groupBox7.Controls.Add(this.checkBox_Genero_Acao);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.txt_Ano_Lancamento);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.txt_Nome);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(18, 27);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(752, 258);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Informações da Série";
            // 
            // checkBox_Genero_Terror
            // 
            this.checkBox_Genero_Terror.AutoSize = true;
            this.checkBox_Genero_Terror.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Genero_Terror.ForeColor = System.Drawing.Color.White;
            this.checkBox_Genero_Terror.Location = new System.Drawing.Point(562, 119);
            this.checkBox_Genero_Terror.Name = "checkBox_Genero_Terror";
            this.checkBox_Genero_Terror.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Genero_Terror.Size = new System.Drawing.Size(54, 17);
            this.checkBox_Genero_Terror.TabIndex = 23;
            this.checkBox_Genero_Terror.Text = "Terror";
            this.checkBox_Genero_Terror.UseVisualStyleBackColor = false;
            // 
            // checkBox_Genero_Aventura
            // 
            this.checkBox_Genero_Aventura.AutoSize = true;
            this.checkBox_Genero_Aventura.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Genero_Aventura.ForeColor = System.Drawing.Color.White;
            this.checkBox_Genero_Aventura.Location = new System.Drawing.Point(562, 90);
            this.checkBox_Genero_Aventura.Name = "checkBox_Genero_Aventura";
            this.checkBox_Genero_Aventura.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Genero_Aventura.Size = new System.Drawing.Size(69, 17);
            this.checkBox_Genero_Aventura.TabIndex = 22;
            this.checkBox_Genero_Aventura.Text = "Aventura";
            this.checkBox_Genero_Aventura.UseVisualStyleBackColor = false;
            // 
            // checkBox_Genero_Ficcao
            // 
            this.checkBox_Genero_Ficcao.AutoSize = true;
            this.checkBox_Genero_Ficcao.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Genero_Ficcao.ForeColor = System.Drawing.Color.White;
            this.checkBox_Genero_Ficcao.Location = new System.Drawing.Point(562, 54);
            this.checkBox_Genero_Ficcao.Name = "checkBox_Genero_Ficcao";
            this.checkBox_Genero_Ficcao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Genero_Ficcao.Size = new System.Drawing.Size(58, 17);
            this.checkBox_Genero_Ficcao.TabIndex = 21;
            this.checkBox_Genero_Ficcao.Text = "Ficção";
            this.checkBox_Genero_Ficcao.UseVisualStyleBackColor = false;
            // 
            // checkBox_Genero_Drama
            // 
            this.checkBox_Genero_Drama.AutoSize = true;
            this.checkBox_Genero_Drama.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Genero_Drama.ForeColor = System.Drawing.Color.White;
            this.checkBox_Genero_Drama.Location = new System.Drawing.Point(466, 119);
            this.checkBox_Genero_Drama.Name = "checkBox_Genero_Drama";
            this.checkBox_Genero_Drama.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Genero_Drama.Size = new System.Drawing.Size(57, 17);
            this.checkBox_Genero_Drama.TabIndex = 20;
            this.checkBox_Genero_Drama.Text = "Drama";
            this.checkBox_Genero_Drama.UseVisualStyleBackColor = false;
            // 
            // checkBox_Genero_Romance
            // 
            this.checkBox_Genero_Romance.AutoSize = true;
            this.checkBox_Genero_Romance.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Genero_Romance.ForeColor = System.Drawing.Color.White;
            this.checkBox_Genero_Romance.Location = new System.Drawing.Point(466, 86);
            this.checkBox_Genero_Romance.Name = "checkBox_Genero_Romance";
            this.checkBox_Genero_Romance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Genero_Romance.Size = new System.Drawing.Size(72, 17);
            this.checkBox_Genero_Romance.TabIndex = 19;
            this.checkBox_Genero_Romance.Text = "Romance";
            this.checkBox_Genero_Romance.UseVisualStyleBackColor = false;
            // 
            // checkBox_Genero_Acao
            // 
            this.checkBox_Genero_Acao.AutoSize = true;
            this.checkBox_Genero_Acao.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Genero_Acao.ForeColor = System.Drawing.Color.White;
            this.checkBox_Genero_Acao.Location = new System.Drawing.Point(466, 55);
            this.checkBox_Genero_Acao.Name = "checkBox_Genero_Acao";
            this.checkBox_Genero_Acao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Genero_Acao.Size = new System.Drawing.Size(51, 17);
            this.checkBox_Genero_Acao.TabIndex = 18;
            this.checkBox_Genero_Acao.Text = "Ação";
            this.checkBox_Genero_Acao.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(466, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Gênero";
            // 
            // txt_Ano_Lancamento
            // 
            this.txt_Ano_Lancamento.Location = new System.Drawing.Point(29, 121);
            this.txt_Ano_Lancamento.MaxLength = 4;
            this.txt_Ano_Lancamento.Name = "txt_Ano_Lancamento";
            this.txt_Ano_Lancamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Ano_Lancamento.Size = new System.Drawing.Size(100, 20);
            this.txt_Ano_Lancamento.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(27, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Ano de Lançamento";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(27, 55);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Nome.Size = new System.Drawing.Size(374, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(27, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Nome";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numericUpDown3);
            this.groupBox6.Controls.Add(this.checkBox10);
            this.groupBox6.Controls.Add(this.checkBox9);
            this.groupBox6.Controls.Add(this.checkBox8);
            this.groupBox6.Controls.Add(this.checkBox7);
            this.groupBox6.Controls.Add(this.checkBox6);
            this.groupBox6.Controls.Add(this.checkBox5);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.textBox9);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.textBox7);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.textBox8);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Location = new System.Drawing.Point(18, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(752, 258);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Informações da Série";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(466, 55);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown3.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown3.TabIndex = 24;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(557, 206);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox10.Size = new System.Drawing.Size(54, 17);
            this.checkBox10.TabIndex = 23;
            this.checkBox10.Text = "Terror";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(557, 177);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox9.Size = new System.Drawing.Size(69, 17);
            this.checkBox9.TabIndex = 22;
            this.checkBox9.Text = "Aventura";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(557, 141);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox8.Size = new System.Drawing.Size(58, 17);
            this.checkBox8.TabIndex = 21;
            this.checkBox8.Text = "Ficção";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(461, 206);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox7.Size = new System.Drawing.Size(57, 17);
            this.checkBox7.TabIndex = 20;
            this.checkBox7.Text = "Drama";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(461, 173);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox6.Size = new System.Drawing.Size(72, 17);
            this.checkBox6.TabIndex = 19;
            this.checkBox6.Text = "Romance";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(461, 142);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox5.Size = new System.Drawing.Size(51, 17);
            this.checkBox5.TabIndex = 18;
            this.checkBox5.Text = "Ação";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(461, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Gênero";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Nota 0-10";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(27, 139);
            this.textBox9.Name = "textBox9";
            this.textBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox9.Size = new System.Drawing.Size(374, 20);
            this.textBox9.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nome em Português";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(31, 219);
            this.textBox7.Name = "textBox7";
            this.textBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ano de Lançamento";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(27, 55);
            this.textBox8.Name = "textBox8";
            this.textBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox8.Size = new System.Drawing.Size(374, 20);
            this.textBox8.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nome em Inglês";
            // 
            // button_Limpar
            // 
            this.button_Limpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Limpar.BackgroundImage")));
            this.button_Limpar.Location = new System.Drawing.Point(319, 540);
            this.button_Limpar.Name = "button_Limpar";
            this.button_Limpar.Size = new System.Drawing.Size(100, 35);
            this.button_Limpar.TabIndex = 13;
            this.button_Limpar.Text = "Limpar";
            this.button_Limpar.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.checkBox_Previsao);
            this.groupBox5.Controls.Add(this.dateTimePicker_UltimoEpisodio);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(447, 294);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(324, 222);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data de Lançamento do Próximo Episódio";
            // 
            // checkBox_Previsao
            // 
            this.checkBox_Previsao.AutoSize = true;
            this.checkBox_Previsao.Location = new System.Drawing.Point(15, 19);
            this.checkBox_Previsao.Name = "checkBox_Previsao";
            this.checkBox_Previsao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_Previsao.Size = new System.Drawing.Size(67, 17);
            this.checkBox_Previsao.TabIndex = 11;
            this.checkBox_Previsao.Text = "Previsão";
            this.checkBox_Previsao.UseVisualStyleBackColor = true;
            // 
            // Series
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Gerenciador_de_Dados.Properties.Resources.hardened_clay_stained_blue;
            this.Controls.Add(this.groupBox3);
            this.Name = "Series";
            this.Size = new System.Drawing.Size(820, 620);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Episodio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Temporada)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown num_Episodio;
        private System.Windows.Forms.NumericUpDown num_Temporada;
        private System.Windows.Forms.DateTimePicker dateTimePicker_UltimoEpisodio;
        private System.Windows.Forms.CheckBox checkBox_Fim_Serie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Cadastrar;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox checkBox_Genero_Terror;
        private System.Windows.Forms.CheckBox checkBox_Genero_Aventura;
        private System.Windows.Forms.CheckBox checkBox_Genero_Ficcao;
        private System.Windows.Forms.CheckBox checkBox_Genero_Drama;
        private System.Windows.Forms.CheckBox checkBox_Genero_Romance;
        private System.Windows.Forms.CheckBox checkBox_Genero_Acao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Ano_Lancamento;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_Limpar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox_Previsao;
    }
}
