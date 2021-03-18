namespace HouseExplorer
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
            this.txDescription = new System.Windows.Forms.TextBox();
            this.btGoHere = new System.Windows.Forms.Button();
            this.cbExits = new System.Windows.Forms.ComboBox();
            this.btGoDoor = new System.Windows.Forms.Button();
            this.bt_check = new System.Windows.Forms.Button();
            this.bt_hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txDescription
            // 
            this.txDescription.Location = new System.Drawing.Point(13, 13);
            this.txDescription.Multiline = true;
            this.txDescription.Name = "txDescription";
            this.txDescription.Size = new System.Drawing.Size(560, 295);
            this.txDescription.TabIndex = 0;
            // 
            // btGoHere
            // 
            this.btGoHere.Location = new System.Drawing.Point(13, 314);
            this.btGoHere.Name = "btGoHere";
            this.btGoHere.Size = new System.Drawing.Size(120, 29);
            this.btGoHere.TabIndex = 1;
            this.btGoHere.Text = "Go Here";
            this.btGoHere.UseVisualStyleBackColor = true;
            this.btGoHere.Click += new System.EventHandler(this.btGoHere_Click);
            // 
            // cbExits
            // 
            this.cbExits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExits.FormattingEnabled = true;
            this.cbExits.Location = new System.Drawing.Point(140, 315);
            this.cbExits.Name = "cbExits";
            this.cbExits.Size = new System.Drawing.Size(433, 28);
            this.cbExits.TabIndex = 2;
            // 
            // btGoDoor
            // 
            this.btGoDoor.Location = new System.Drawing.Point(13, 350);
            this.btGoDoor.Name = "btGoDoor";
            this.btGoDoor.Size = new System.Drawing.Size(560, 37);
            this.btGoDoor.TabIndex = 3;
            this.btGoDoor.Text = "Go through the MAIN door";
            this.btGoDoor.UseVisualStyleBackColor = true;
            this.btGoDoor.Click += new System.EventHandler(this.btGoDoor_Click);
            // 
            // bt_check
            // 
            this.bt_check.Location = new System.Drawing.Point(13, 393);
            this.bt_check.Name = "bt_check";
            this.bt_check.Size = new System.Drawing.Size(560, 37);
            this.bt_check.TabIndex = 4;
            this.bt_check.Text = "CHECK !!!";
            this.bt_check.UseVisualStyleBackColor = true;
            this.bt_check.Click += new System.EventHandler(this.bt_check_Click);
            // 
            // bt_hide
            // 
            this.bt_hide.Location = new System.Drawing.Point(12, 436);
            this.bt_hide.Name = "bt_hide";
            this.bt_hide.Size = new System.Drawing.Size(560, 37);
            this.bt_hide.TabIndex = 5;
            this.bt_hide.Text = "Hide";
            this.bt_hide.UseVisualStyleBackColor = true;
            this.bt_hide.Click += new System.EventHandler(this.bt_hide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 478);
            this.Controls.Add(this.bt_hide);
            this.Controls.Add(this.bt_check);
            this.Controls.Add(this.btGoDoor);
            this.Controls.Add(this.cbExits);
            this.Controls.Add(this.btGoHere);
            this.Controls.Add(this.txDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Explore the House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txDescription;
        private System.Windows.Forms.Button btGoHere;
        private System.Windows.Forms.ComboBox cbExits;
        private System.Windows.Forms.Button btGoDoor;
        private System.Windows.Forms.Button bt_check;
        private System.Windows.Forms.Button bt_hide;
    }
}

