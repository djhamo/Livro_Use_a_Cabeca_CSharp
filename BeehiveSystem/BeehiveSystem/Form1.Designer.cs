namespace BeehiveSystem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.report = new System.Windows.Forms.TextBox();
            this.assignJob = new System.Windows.Forms.Button();
            this.nextShift = new System.Windows.Forms.Button();
            this.nunUpDOwnShift = new System.Windows.Forms.NumericUpDown();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nunUpDOwnShift)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Worker Bee JOB";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.report);
            this.groupBox1.Controls.Add(this.assignJob);
            this.groupBox1.Controls.Add(this.nextShift);
            this.groupBox1.Controls.Add(this.nunUpDOwnShift);
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 356);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assigments";
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(28, 141);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(525, 195);
            this.report.TabIndex = 6;
            // 
            // assignJob
            // 
            this.assignJob.Location = new System.Drawing.Point(28, 105);
            this.assignJob.Name = "assignJob";
            this.assignJob.Size = new System.Drawing.Size(315, 29);
            this.assignJob.TabIndex = 5;
            this.assignJob.Text = "Assign this job to a bee";
            this.assignJob.UseVisualStyleBackColor = true;
            this.assignJob.Click += new System.EventHandler(this.assignJob_Click);
            // 
            // nextShift
            // 
            this.nextShift.Location = new System.Drawing.Point(445, 36);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(108, 98);
            this.nextShift.TabIndex = 4;
            this.nextShift.Text = "Work the next shift";
            this.nextShift.UseVisualStyleBackColor = true;
            this.nextShift.Click += new System.EventHandler(this.nextShift_Click);
            // 
            // nunUpDOwnShift
            // 
            this.nunUpDOwnShift.Location = new System.Drawing.Point(350, 70);
            this.nunUpDOwnShift.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nunUpDOwnShift.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nunUpDOwnShift.Name = "nunUpDOwnShift";
            this.nunUpDOwnShift.Size = new System.Drawing.Size(73, 26);
            this.nunUpDOwnShift.TabIndex = 3;
            this.nunUpDOwnShift.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol "});
            this.workerBeeJob.Location = new System.Drawing.Point(28, 70);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(315, 28);
            this.workerBeeJob.TabIndex = 2;
            this.workerBeeJob.SelectedIndexChanged += new System.EventHandler(this.workerBeeJob_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shifts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nunUpDOwnShift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox report;
        private System.Windows.Forms.Button assignJob;
        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.NumericUpDown nunUpDOwnShift;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.Label label2;
    }
}

