namespace BirthdayParty
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cakeText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.birthdayCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // numPeople
            // 
            this.numPeople.Location = new System.Drawing.Point(6, 30);
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
            this.ckFancy.Location = new System.Drawing.Point(6, 59);
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
            this.ckHealth.Location = new System.Drawing.Point(6, 87);
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
            this.label2.Location = new System.Drawing.Point(3, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coast";
            // 
            // lbCoast
            // 
            this.lbCoast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCoast.Location = new System.Drawing.Point(53, 115);
            this.lbCoast.Name = "lbCoast";
            this.lbCoast.Size = new System.Drawing.Size(101, 23);
            this.lbCoast.TabIndex = 5;
            this.lbCoast.Text = "$";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(229, 212);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ckHealth);
            this.tabPage1.Controls.Add(this.lbCoast);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numPeople);
            this.tabPage1.Controls.Add(this.ckFancy);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(177, 183);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dinner Party";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cakeText);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.numberBirthday);
            this.tabPage2.Controls.Add(this.fancyBirthday);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(221, 183);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday Party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cakeText
            // 
            this.cakeText.Location = new System.Drawing.Point(6, 111);
            this.cakeText.Name = "cakeText";
            this.cakeText.Size = new System.Drawing.Size(145, 22);
            this.cakeText.TabIndex = 13;
            this.cakeText.Text = "Happy Birthday";
            this.cakeText.TextChanged += new System.EventHandler(this.cakeText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cake Writing";
            // 
            // birthdayCost
            // 
            this.birthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthdayCost.Location = new System.Drawing.Point(56, 147);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(101, 23);
            this.birthdayCost.TabIndex = 11;
            this.birthdayCost.Text = "$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of People";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Coast";
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(6, 33);
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(120, 22);
            this.numberBirthday.TabIndex = 7;
            this.numberBirthday.ValueChanged += new System.EventHandler(this.numberBirthday_ValueChanged);
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Checked = true;
            this.fancyBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBirthday.Location = new System.Drawing.Point(6, 62);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(148, 21);
            this.fancyBirthday.TabIndex = 8;
            this.fancyBirthday.Text = "Fancy Decorations";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.fancyBirthday_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 229);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dinner Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numPeople;
        private System.Windows.Forms.CheckBox ckFancy;
        private System.Windows.Forms.CheckBox ckHealth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCoast;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox cakeText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label birthdayCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.CheckBox fancyBirthday;
    }
}

