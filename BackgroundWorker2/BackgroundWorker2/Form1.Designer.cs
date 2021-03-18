namespace BackgroundWorker2
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
            this.useBackgroundWorkerCheckbox = new System.Windows.Forms.CheckBox();
            this.goButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbStatus = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // useBackgroundWorkerCheckbox
            // 
            this.useBackgroundWorkerCheckbox.AutoSize = true;
            this.useBackgroundWorkerCheckbox.Location = new System.Drawing.Point(9, 8);
            this.useBackgroundWorkerCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.useBackgroundWorkerCheckbox.Name = "useBackgroundWorkerCheckbox";
            this.useBackgroundWorkerCheckbox.Size = new System.Drawing.Size(141, 17);
            this.useBackgroundWorkerCheckbox.TabIndex = 0;
            this.useBackgroundWorkerCheckbox.Text = "Use BackgroundWorker";
            this.useBackgroundWorkerCheckbox.UseVisualStyleBackColor = true;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(9, 29);
            this.goButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(55, 21);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Go !";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(67, 28);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(55, 21);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 54);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(209, 18);
            this.progressBar1.TabIndex = 3;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(9, 76);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(43, 13);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "Status :";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 96);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.useBackgroundWorkerCheckbox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "BackgroundWorker example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox useBackgroundWorkerCheckbox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

