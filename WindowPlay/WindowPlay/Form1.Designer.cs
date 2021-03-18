namespace WindowPlay
{
    partial class Principal
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
            this.bt_change_color = new System.Windows.Forms.Button();
            this.ck_color_ok = new System.Windows.Forms.CheckBox();
            this.tx_alvo = new System.Windows.Forms.Label();
            this.bt_parar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_say = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bt_speak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bt_parar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_change_color
            // 
            this.bt_change_color.Location = new System.Drawing.Point(29, 31);
            this.bt_change_color.Name = "bt_change_color";
            this.bt_change_color.Size = new System.Drawing.Size(107, 37);
            this.bt_change_color.TabIndex = 0;
            this.bt_change_color.Text = "Change Color";
            this.bt_change_color.UseVisualStyleBackColor = true;
            this.bt_change_color.Click += new System.EventHandler(this.bt_change_color_Click);
            // 
            // ck_color_ok
            // 
            this.ck_color_ok.AutoSize = true;
            this.ck_color_ok.Location = new System.Drawing.Point(192, 31);
            this.ck_color_ok.Name = "ck_color_ok";
            this.ck_color_ok.Size = new System.Drawing.Size(164, 21);
            this.ck_color_ok.TabIndex = 1;
            this.ck_color_ok.Text = "Enable Change Color";
            this.ck_color_ok.UseVisualStyleBackColor = true;
            // 
            // tx_alvo
            // 
            this.tx_alvo.AutoSize = true;
            this.tx_alvo.Font = new System.Drawing.Font("Source Code Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_alvo.Location = new System.Drawing.Point(25, 87);
            this.tx_alvo.Name = "tx_alvo";
            this.tx_alvo.Size = new System.Drawing.Size(351, 24);
            this.tx_alvo.TabIndex = 2;
            this.tx_alvo.Text = "Press Button to change my color";
            // 
            // bt_parar
            // 
            this.bt_parar.Image = global::WindowPlay.Properties.Resources.sair;
            this.bt_parar.Location = new System.Drawing.Point(362, 31);
            this.bt_parar.Name = "bt_parar";
            this.bt_parar.Size = new System.Drawing.Size(45, 37);
            this.bt_parar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_parar.TabIndex = 3;
            this.bt_parar.TabStop = false;
            this.bt_parar.Click += new System.EventHandler(this.bt_parar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Say This";
            // 
            // tx_say
            // 
            this.tx_say.Location = new System.Drawing.Point(131, 139);
            this.tx_say.Name = "tx_say";
            this.tx_say.Size = new System.Drawing.Size(276, 22);
            this.tx_say.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "# of Times";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(131, 185);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // bt_speak
            // 
            this.bt_speak.Location = new System.Drawing.Point(281, 185);
            this.bt_speak.Name = "bt_speak";
            this.bt_speak.Size = new System.Drawing.Size(75, 23);
            this.bt_speak.TabIndex = 8;
            this.bt_speak.Text = "Speak";
            this.bt_speak.UseVisualStyleBackColor = true;
            this.bt_speak.Click += new System.EventHandler(this.bt_speak_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 226);
            this.Controls.Add(this.bt_speak);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_say);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_parar);
            this.Controls.Add(this.tx_alvo);
            this.Controls.Add(this.ck_color_ok);
            this.Controls.Add(this.bt_change_color);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Fun Window";
            ((System.ComponentModel.ISupportInitialize)(this.bt_parar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_change_color;
        private System.Windows.Forms.CheckBox ck_color_ok;
        private System.Windows.Forms.Label tx_alvo;
        private System.Windows.Forms.PictureBox bt_parar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_say;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button bt_speak;
    }
}

