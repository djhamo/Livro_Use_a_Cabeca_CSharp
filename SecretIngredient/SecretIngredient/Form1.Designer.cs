namespace SecretIngredient
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
            this.btIngredients = new System.Windows.Forms.Button();
            this.btSuzanne = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.btAmy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // btIngredients
            // 
            this.btIngredients.Location = new System.Drawing.Point(12, 12);
            this.btIngredients.Name = "btIngredients";
            this.btIngredients.Size = new System.Drawing.Size(192, 37);
            this.btIngredients.TabIndex = 0;
            this.btIngredients.Text = "Get The Igredients";
            this.btIngredients.UseVisualStyleBackColor = true;
            this.btIngredients.Click += new System.EventHandler(this.btIngredients_Click);
            // 
            // btSuzanne
            // 
            this.btSuzanne.Location = new System.Drawing.Point(12, 56);
            this.btSuzanne.Name = "btSuzanne";
            this.btSuzanne.Size = new System.Drawing.Size(248, 37);
            this.btSuzanne.TabIndex = 1;
            this.btSuzanne.Text = "Get Suzanne\'s delegate";
            this.btSuzanne.UseVisualStyleBackColor = true;
            this.btSuzanne.Click += new System.EventHandler(this.btSuzanne_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(210, 19);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(50, 26);
            this.amount.TabIndex = 2;
            // 
            // btAmy
            // 
            this.btAmy.Location = new System.Drawing.Point(12, 100);
            this.btAmy.Name = "btAmy";
            this.btAmy.Size = new System.Drawing.Size(248, 37);
            this.btAmy.TabIndex = 3;
            this.btAmy.Text = "Get Amy\'s delegate";
            this.btAmy.UseVisualStyleBackColor = true;
            this.btAmy.Click += new System.EventHandler(this.btAmy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 153);
            this.Controls.Add(this.btAmy);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.btSuzanne);
            this.Controls.Add(this.btIngredients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Secret Ingredientes";
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btIngredients;
        private System.Windows.Forms.Button btSuzanne;
        private System.Windows.Forms.NumericUpDown amount;
        private System.Windows.Forms.Button btAmy;
    }
}

