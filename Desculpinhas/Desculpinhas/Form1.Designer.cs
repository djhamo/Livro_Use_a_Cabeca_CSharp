namespace Desculpinhas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textExcuse = new System.Windows.Forms.TextBox();
            this.textResults = new System.Windows.Forms.TextBox();
            this.textFileDate = new System.Windows.Forms.TextBox();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.labelLastUsed = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excuse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Used";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "File Date";
            // 
            // textExcuse
            // 
            this.textExcuse.Location = new System.Drawing.Point(140, 22);
            this.textExcuse.Name = "textExcuse";
            this.textExcuse.Size = new System.Drawing.Size(331, 26);
            this.textExcuse.TabIndex = 4;
            this.textExcuse.TextChanged += new System.EventHandler(this.textExcuse_TextChanged);
            // 
            // textResults
            // 
            this.textResults.Location = new System.Drawing.Point(140, 61);
            this.textResults.Name = "textResults";
            this.textResults.Size = new System.Drawing.Size(331, 26);
            this.textResults.TabIndex = 5;
            this.textResults.TextChanged += new System.EventHandler(this.textResults_TextChanged);
            // 
            // textFileDate
            // 
            this.textFileDate.Location = new System.Drawing.Point(140, 139);
            this.textFileDate.Name = "textFileDate";
            this.textFileDate.Size = new System.Drawing.Size(331, 26);
            this.textFileDate.TabIndex = 7;
            // 
            // buttonFolder
            // 
            this.buttonFolder.Location = new System.Drawing.Point(14, 182);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(94, 31);
            this.buttonFolder.TabIndex = 8;
            this.buttonFolder.Text = "Folder";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(114, 182);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 31);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Enabled = false;
            this.buttonOpen.Location = new System.Drawing.Point(214, 182);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(94, 31);
            this.buttonOpen.TabIndex = 10;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Enabled = false;
            this.buttonRandom.Location = new System.Drawing.Point(314, 182);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(157, 31);
            this.buttonRandom.TabIndex = 11;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // labelLastUsed
            // 
            this.labelLastUsed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLastUsed.Location = new System.Drawing.Point(140, 100);
            this.labelLastUsed.Name = "labelLastUsed";
            this.labelLastUsed.Size = new System.Drawing.Size(331, 23);
            this.labelLastUsed.TabIndex = 12;
            this.labelLastUsed.Text = "label5";
            this.labelLastUsed.Click += new System.EventHandler(this.labelLastUsed_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 231);
            this.Controls.Add(this.labelLastUsed);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.textFileDate);
            this.Controls.Add(this.textResults);
            this.Controls.Add(this.textExcuse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Excuse Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textExcuse;
        private System.Windows.Forms.TextBox textResults;
        private System.Windows.Forms.TextBox textFileDate;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Label labelLastUsed;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

