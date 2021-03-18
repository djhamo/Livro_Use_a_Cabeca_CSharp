namespace HitKey
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.correctLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.missedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.acuracyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dificultyProgressBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.ColumnWidth = 45;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 67;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(854, 123);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctLabel,
            this.missedLabel,
            this.totalLabel,
            this.acuracyLabel,
            this.dificultyProgressBarLabel,
            this.difficultProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 98);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(854, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // correctLabel
            // 
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(72, 20);
            this.correctLabel.Text = "Correct: 0";
            // 
            // missedLabel
            // 
            this.missedLabel.Name = "missedLabel";
            this.missedLabel.Size = new System.Drawing.Size(70, 20);
            this.missedLabel.Text = "Missed: 0";
            // 
            // totalLabel
            // 
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(58, 20);
            this.totalLabel.Text = "Total: 0";
            // 
            // acuracyLabel
            // 
            this.acuracyLabel.Name = "acuracyLabel";
            this.acuracyLabel.Size = new System.Drawing.Size(83, 20);
            this.acuracyLabel.Text = "Accuracy: 0";
            // 
            // dificultyProgressBarLabel
            // 
            this.dificultyProgressBarLabel.Name = "dificultyProgressBarLabel";
            this.dificultyProgressBarLabel.Size = new System.Drawing.Size(415, 20);
            this.dificultyProgressBarLabel.Spring = true;
            this.dificultyProgressBarLabel.Text = "Difficult";
            this.dificultyProgressBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // difficultProgressBar
            // 
            this.difficultProgressBar.Maximum = 800;
            this.difficultProgressBar.Name = "difficultProgressBar";
            this.difficultProgressBar.Size = new System.Drawing.Size(100, 19);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 123);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Hit Key Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel correctLabel;
        private System.Windows.Forms.ToolStripStatusLabel missedLabel;
        private System.Windows.Forms.ToolStripStatusLabel totalLabel;
        private System.Windows.Forms.ToolStripStatusLabel acuracyLabel;
        private System.Windows.Forms.ToolStripStatusLabel dificultyProgressBarLabel;
        private System.Windows.Forms.ToolStripProgressBar difficultProgressBar;
    }
}

