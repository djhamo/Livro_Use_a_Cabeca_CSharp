namespace GoFish
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
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.listHand = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textProgress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBooks = new System.Windows.Forms.TextBox();
            this.buttonAsk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Jogador";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(13, 37);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(236, 26);
            this.textName.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(256, 37);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(152, 35);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Começar o Jogo";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listHand
            // 
            this.listHand.FormattingEnabled = true;
            this.listHand.ItemHeight = 20;
            this.listHand.Location = new System.Drawing.Point(414, 37);
            this.listHand.Name = "listHand";
            this.listHand.Size = new System.Drawing.Size(193, 404);
            this.listHand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sua Mão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Progresso do Jogo";
            // 
            // textProgress
            // 
            this.textProgress.Location = new System.Drawing.Point(13, 94);
            this.textProgress.Multiline = true;
            this.textProgress.Name = "textProgress";
            this.textProgress.Size = new System.Drawing.Size(395, 255);
            this.textProgress.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monte";
            // 
            // textBooks
            // 
            this.textBooks.Location = new System.Drawing.Point(13, 380);
            this.textBooks.Multiline = true;
            this.textBooks.Name = "textBooks";
            this.textBooks.Size = new System.Drawing.Size(395, 106);
            this.textBooks.TabIndex = 8;
            // 
            // buttonAsk
            // 
            this.buttonAsk.Enabled = false;
            this.buttonAsk.Location = new System.Drawing.Point(415, 447);
            this.buttonAsk.Name = "buttonAsk";
            this.buttonAsk.Size = new System.Drawing.Size(192, 39);
            this.buttonAsk.TabIndex = 9;
            this.buttonAsk.Text = "Peça por Cartas !";
            this.buttonAsk.UseVisualStyleBackColor = true;
            this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 498);
            this.Controls.Add(this.buttonAsk);
            this.Controls.Add(this.textBooks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listHand);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Go Fish!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox listHand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBooks;
        private System.Windows.Forms.Button buttonAsk;
    }
}

