namespace BallInPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.udTrajectory = new System.Windows.Forms.NumericUpDown();
            this.udDistance = new System.Windows.Forms.NumericUpDown();
            this.PlayBall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.udTrajectory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trajectory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance";
            // 
            // udTrajectory
            // 
            this.udTrajectory.Location = new System.Drawing.Point(99, 16);
            this.udTrajectory.Name = "udTrajectory";
            this.udTrajectory.Size = new System.Drawing.Size(120, 26);
            this.udTrajectory.TabIndex = 2;
            // 
            // udDistance
            // 
            this.udDistance.Location = new System.Drawing.Point(99, 49);
            this.udDistance.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.udDistance.Name = "udDistance";
            this.udDistance.Size = new System.Drawing.Size(120, 26);
            this.udDistance.TabIndex = 3;
            // 
            // PlayBall
            // 
            this.PlayBall.Location = new System.Drawing.Point(99, 82);
            this.PlayBall.Name = "PlayBall";
            this.PlayBall.Size = new System.Drawing.Size(120, 31);
            this.PlayBall.TabIndex = 4;
            this.PlayBall.Text = "PlayBall!";
            this.PlayBall.UseVisualStyleBackColor = true;
            this.PlayBall.Click += new System.EventHandler(this.PlayBall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 124);
            this.Controls.Add(this.PlayBall);
            this.Controls.Add(this.udDistance);
            this.Controls.Add(this.udTrajectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Baseball";
            ((System.ComponentModel.ISupportInitialize)(this.udTrajectory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown udTrajectory;
        private System.Windows.Forms.NumericUpDown udDistance;
        private System.Windows.Forms.Button PlayBall;
    }
}

