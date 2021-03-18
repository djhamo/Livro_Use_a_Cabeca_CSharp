namespace KnightRider
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txPosX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txPosY = new System.Windows.Forms.TextBox();
            this.txAltura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txLargura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numVelocidade = new System.Windows.Forms.NumericUpDown();
            this.txJogadores = new System.Windows.Forms.TextBox();
            this.ckTodasSolucoes = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lbStart = new System.Windows.Forms.ToolStripLabel();
            this.lbReset = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.abrirToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.imprimirToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numVelocidade)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txPosX
            // 
            this.txPosX.Location = new System.Drawing.Point(256, 45);
            this.txPosX.Name = "txPosX";
            this.txPosX.Size = new System.Drawing.Size(32, 26);
            this.txPosX.TabIndex = 0;
            this.txPosX.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "X";
            // 
            // txPosY
            // 
            this.txPosY.Location = new System.Drawing.Point(385, 45);
            this.txPosY.Name = "txPosY";
            this.txPosY.Size = new System.Drawing.Size(33, 26);
            this.txPosY.TabIndex = 2;
            this.txPosY.Text = "0";
            // 
            // txAltura
            // 
            this.txAltura.Location = new System.Drawing.Point(401, 78);
            this.txAltura.Name = "txAltura";
            this.txAltura.Size = new System.Drawing.Size(40, 26);
            this.txAltura.TabIndex = 0;
            this.txAltura.Text = "8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "X";
            // 
            // txLargura
            // 
            this.txLargura.Location = new System.Drawing.Point(272, 78);
            this.txLargura.Name = "txLargura";
            this.txLargura.Size = new System.Drawing.Size(40, 26);
            this.txLargura.TabIndex = 2;
            this.txLargura.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posição Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamanho do Tabuleiro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Velocidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jogadores";
            // 
            // numVelocidade
            // 
            this.numVelocidade.Location = new System.Drawing.Point(206, 112);
            this.numVelocidade.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numVelocidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVelocidade.Name = "numVelocidade";
            this.numVelocidade.Size = new System.Drawing.Size(120, 26);
            this.numVelocidade.TabIndex = 4;
            this.numVelocidade.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numVelocidade.ValueChanged += new System.EventHandler(this.numVelocidade_ValueChanged);
            // 
            // txJogadores
            // 
            this.txJogadores.Location = new System.Drawing.Point(206, 144);
            this.txJogadores.Name = "txJogadores";
            this.txJogadores.ReadOnly = true;
            this.txJogadores.Size = new System.Drawing.Size(100, 26);
            this.txJogadores.TabIndex = 5;
            this.txJogadores.Text = "1";
            // 
            // ckTodasSolucoes
            // 
            this.ckTodasSolucoes.AutoSize = true;
            this.ckTodasSolucoes.Location = new System.Drawing.Point(12, 176);
            this.ckTodasSolucoes.Name = "ckTodasSolucoes";
            this.ckTodasSolucoes.Size = new System.Drawing.Size(210, 24);
            this.ckTodasSolucoes.TabIndex = 6;
            this.ckTodasSolucoes.Text = "Obter todas as Soluções";
            this.ckTodasSolucoes.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStart,
            this.lbReset,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.abrirToolStripButton1,
            this.salvarToolStripButton1,
            this.imprimirToolStripButton1,
            this.toolStripSeparator3,
            this.ajudaToolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(454, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lbStart
            // 
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(49, 25);
            this.lbStart.Text = "Start";
            this.lbStart.Click += new System.EventHandler(this.lbStart_Click);
            // 
            // lbReset
            // 
            this.lbReset.Name = "lbReset";
            this.lbReset.Size = new System.Drawing.Size(55, 25);
            this.lbReset.Text = "Reset";
            this.lbReset.Click += new System.EventHandler(this.lbReset_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 25);
            this.toolStripLabel1.Text = "Turbo";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // abrirToolStripButton1
            // 
            this.abrirToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton1.Image")));
            this.abrirToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton1.Name = "abrirToolStripButton1";
            this.abrirToolStripButton1.Size = new System.Drawing.Size(23, 25);
            this.abrirToolStripButton1.Text = "&Abrir";
            this.abrirToolStripButton1.Click += new System.EventHandler(this.abrirToolStripButton1_Click);
            // 
            // salvarToolStripButton1
            // 
            this.salvarToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton1.Image")));
            this.salvarToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton1.Name = "salvarToolStripButton1";
            this.salvarToolStripButton1.Size = new System.Drawing.Size(23, 25);
            this.salvarToolStripButton1.Text = "&Salvar";
            this.salvarToolStripButton1.Click += new System.EventHandler(this.salvarToolStripButton1_Click);
            // 
            // imprimirToolStripButton1
            // 
            this.imprimirToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton1.Image")));
            this.imprimirToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton1.Name = "imprimirToolStripButton1";
            this.imprimirToolStripButton1.Size = new System.Drawing.Size(23, 25);
            this.imprimirToolStripButton1.Text = "&Imprimir";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // ajudaToolStripButton1
            // 
            this.ajudaToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ajudaToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripButton1.Image")));
            this.ajudaToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajudaToolStripButton1.Name = "ajudaToolStripButton1";
            this.ajudaToolStripButton1.Size = new System.Drawing.Size(23, 25);
            this.ajudaToolStripButton1.Text = "&Ajuda";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(454, 30);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(61, 25);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Largura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Linha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Coluna";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(344, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Altura";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(13, 207);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(428, 184);
            this.listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 428);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txPosY);
            this.Controls.Add(this.txJogadores);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txPosX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numVelocidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckTodasSolucoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txAltura);
            this.Controls.Add(this.txLargura);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Knight Rider";
            this.Move += new System.EventHandler(this.Form1_Move);
            ((System.ComponentModel.ISupportInitialize)(this.numVelocidade)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lbStart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txAltura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txLargura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numVelocidade;
        private System.Windows.Forms.ToolStripLabel lbReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton1;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton1;
        private System.Windows.Forms.ToolStripButton imprimirToolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ajudaToolStripButton1;
        private System.Windows.Forms.TextBox txPosX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txPosY;
        private System.Windows.Forms.TextBox txJogadores;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox ckTodasSolucoes;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

