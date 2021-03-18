namespace DinnerParty
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
            this.label1 = new System.Windows.Forms.Label();
            this.numPeople = new System.Windows.Forms.NumericUpDown();
            this.ckFancy = new System.Windows.Forms.CheckBox();
            this.ckHealth = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCoast = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // numPeople
            // 
            this.numPeople.Location = new System.Drawing.Point(16, 34);
            this.numPeople.Name = "numPeople";
            this.numPeople.Size = new System.Drawing.Size(120, 22);
            this.numPeople.TabIndex = 1;
            this.numPeople.ValueChanged += new System.EventHandler(this.numPeople_ValueChanged);
            // 
            // ckFancy
            // 
            this.ckFancy.AutoSize = true;
            this.ckFancy.Checked = true;
            this.ckFancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckFancy.Location = new System.Drawing.Point(16, 63);
            this.ckFancy.Name = "ckFancy";
            this.ckFancy.Size = new System.Drawing.Size(148, 21);
            this.ckFancy.TabIndex = 2;
            this.ckFancy.Text = "Fancy Decorations";
            this.ckFancy.UseVisualStyleBackColor = true;
            this.ckFancy.CheckedChanged += new System.EventHandler(this.ckFancy_CheckedChanged);
            // 
            // ckHealth
            // 
            this.ckHealth.AutoSize = true;
            this.ckHealth.Location = new System.Drawing.Point(16, 91);
            this.ckHealth.Name = "ckHealth";
            this.ckHealth.Size = new System.Drawing.Size(117, 21);
            this.ckHealth.TabIndex = 3;
            this.ckHealth.Text = "Health Option";
            this.ckHealth.UseVisualStyleBackColor = true;
            this.ckHealth.CheckedChanged += new System.EventHandler(this.ckHealth_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coast";
            // 
            // lbCoast
            // 
            this.lbCoast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCoast.Location = new System.Drawing.Point(63, 119);
            this.lbCoast.Name = "lbCoast";
            this.lbCoast.Size = new System.Drawing.Size(101, 23);
            this.lbCoast.TabIndex = 5;
            this.lbCoast.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 157);
            this.Controls.Add(this.lbCoast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckHealth);
            this.Controls.Add(this.ckFancy);
            this.Controls.Add(this.numPeople);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dinner Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPeople;
        private System.Windows.Forms.CheckBox ckFancy;
        private System.Windows.Forms.CheckBox ckHealth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCoast;
    }
}

