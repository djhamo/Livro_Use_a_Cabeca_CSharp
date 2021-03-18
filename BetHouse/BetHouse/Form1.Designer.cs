namespace BetHouse
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPlayer3 = new System.Windows.Forms.Label();
            this.lbPlayer2 = new System.Windows.Forms.Label();
            this.lbPlayer1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numDog = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numBet = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.lbSelectLabel = new System.Windows.Forms.Label();
            this.rbPlayer3 = new System.Windows.Forms.RadioButton();
            this.rbPlayer2 = new System.Windows.Forms.RadioButton();
            this.rbPlayer1 = new System.Windows.Forms.RadioButton();
            this.lbet = new System.Windows.Forms.Label();
            this.pbTrack = new System.Windows.Forms.PictureBox();
            this.pbDog1 = new System.Windows.Forms.PictureBox();
            this.pbDog2 = new System.Windows.Forms.PictureBox();
            this.pbDog3 = new System.Windows.Forms.PictureBox();
            this.pbDog4 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPlayer3);
            this.groupBox1.Controls.Add(this.lbPlayer2);
            this.groupBox1.Controls.Add(this.lbPlayer1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.numDog);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numBet);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbSelectLabel);
            this.groupBox1.Controls.Add(this.rbPlayer3);
            this.groupBox1.Controls.Add(this.rbPlayer2);
            this.groupBox1.Controls.Add(this.rbPlayer1);
            this.groupBox1.Controls.Add(this.lbet);
            this.groupBox1.Location = new System.Drawing.Point(24, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // lbPlayer3
            // 
            this.lbPlayer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPlayer3.Location = new System.Drawing.Point(628, 129);
            this.lbPlayer3.Name = "lbPlayer3";
            this.lbPlayer3.Size = new System.Drawing.Size(318, 23);
            this.lbPlayer3.TabIndex = 13;
            this.lbPlayer3.Text = "Player 3\'s Bet";
            // 
            // lbPlayer2
            // 
            this.lbPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPlayer2.Location = new System.Drawing.Point(628, 98);
            this.lbPlayer2.Name = "lbPlayer2";
            this.lbPlayer2.Size = new System.Drawing.Size(318, 23);
            this.lbPlayer2.TabIndex = 12;
            this.lbPlayer2.Text = "Player 2\'s Bet";
            // 
            // lbPlayer1
            // 
            this.lbPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPlayer1.Location = new System.Drawing.Point(628, 67);
            this.lbPlayer1.Name = "lbPlayer1";
            this.lbPlayer1.Size = new System.Drawing.Size(318, 23);
            this.lbPlayer1.TabIndex = 11;
            this.lbPlayer1.Text = "Player 1\'s Bet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(625, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bets";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(871, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Race";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numDog
            // 
            this.numDog.Location = new System.Drawing.Point(396, 170);
            this.numDog.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDog.Name = "numDog";
            this.numDog.Size = new System.Drawing.Size(36, 22);
            this.numDog.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "bucks on dog number";
            // 
            // numBet
            // 
            this.numBet.Location = new System.Drawing.Point(189, 170);
            this.numBet.Name = "numBet";
            this.numBet.Size = new System.Drawing.Size(50, 22);
            this.numBet.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Bet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSelectLabel
            // 
            this.lbSelectLabel.AutoSize = true;
            this.lbSelectLabel.Location = new System.Drawing.Point(31, 173);
            this.lbSelectLabel.Name = "lbSelectLabel";
            this.lbSelectLabel.Size = new System.Drawing.Size(48, 17);
            this.lbSelectLabel.TabIndex = 4;
            this.lbSelectLabel.Text = "Player";
            // 
            // rbPlayer3
            // 
            this.rbPlayer3.AutoSize = true;
            this.rbPlayer3.Location = new System.Drawing.Point(31, 125);
            this.rbPlayer3.Name = "rbPlayer3";
            this.rbPlayer3.Size = new System.Drawing.Size(81, 21);
            this.rbPlayer3.TabIndex = 3;
            this.rbPlayer3.TabStop = true;
            this.rbPlayer3.Text = "Player 3";
            this.rbPlayer3.UseVisualStyleBackColor = true;
            this.rbPlayer3.CheckedChanged += new System.EventHandler(this.rbPlayer3_CheckedChanged);
            // 
            // rbPlayer2
            // 
            this.rbPlayer2.AutoSize = true;
            this.rbPlayer2.Location = new System.Drawing.Point(31, 97);
            this.rbPlayer2.Name = "rbPlayer2";
            this.rbPlayer2.Size = new System.Drawing.Size(81, 21);
            this.rbPlayer2.TabIndex = 2;
            this.rbPlayer2.TabStop = true;
            this.rbPlayer2.Text = "Player 2";
            this.rbPlayer2.UseVisualStyleBackColor = true;
            this.rbPlayer2.Click += new System.EventHandler(this.rbPlayer2_CheckedChanged);
            // 
            // rbPlayer1
            // 
            this.rbPlayer1.AutoSize = true;
            this.rbPlayer1.Location = new System.Drawing.Point(31, 69);
            this.rbPlayer1.Name = "rbPlayer1";
            this.rbPlayer1.Size = new System.Drawing.Size(81, 21);
            this.rbPlayer1.TabIndex = 1;
            this.rbPlayer1.TabStop = true;
            this.rbPlayer1.Text = "Player 1";
            this.rbPlayer1.UseVisualStyleBackColor = true;
            this.rbPlayer1.Click += new System.EventHandler(this.rbPlayer1_CheckedChanged);
            // 
            // lbet
            // 
            this.lbet.AutoSize = true;
            this.lbet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbet.Location = new System.Drawing.Point(28, 37);
            this.lbet.Name = "lbet";
            this.lbet.Size = new System.Drawing.Size(104, 18);
            this.lbet.TabIndex = 0;
            this.lbet.Text = "Minimum bet";
            // 
            // pbTrack
            // 
            this.pbTrack.Image = global::BetHouse.Properties.Resources.racetrack;
            this.pbTrack.Location = new System.Drawing.Point(24, 13);
            this.pbTrack.Name = "pbTrack";
            this.pbTrack.Size = new System.Drawing.Size(970, 316);
            this.pbTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrack.TabIndex = 1;
            this.pbTrack.TabStop = false;
            // 
            // pbDog1
            // 
            this.pbDog1.Image = global::BetHouse.Properties.Resources.dog;
            this.pbDog1.Location = new System.Drawing.Point(61, 22);
            this.pbDog1.Name = "pbDog1";
            this.pbDog1.Size = new System.Drawing.Size(100, 50);
            this.pbDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog1.TabIndex = 2;
            this.pbDog1.TabStop = false;
            // 
            // pbDog2
            // 
            this.pbDog2.Image = global::BetHouse.Properties.Resources.dog;
            this.pbDog2.Location = new System.Drawing.Point(61, 103);
            this.pbDog2.Name = "pbDog2";
            this.pbDog2.Size = new System.Drawing.Size(100, 50);
            this.pbDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog2.TabIndex = 3;
            this.pbDog2.TabStop = false;
            // 
            // pbDog3
            // 
            this.pbDog3.Image = global::BetHouse.Properties.Resources.dog;
            this.pbDog3.Location = new System.Drawing.Point(61, 184);
            this.pbDog3.Name = "pbDog3";
            this.pbDog3.Size = new System.Drawing.Size(100, 50);
            this.pbDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog3.TabIndex = 4;
            this.pbDog3.TabStop = false;
            // 
            // pbDog4
            // 
            this.pbDog4.Image = global::BetHouse.Properties.Resources.dog;
            this.pbDog4.Location = new System.Drawing.Point(61, 265);
            this.pbDog4.Name = "pbDog4";
            this.pbDog4.Size = new System.Drawing.Size(100, 50);
            this.pbDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDog4.TabIndex = 5;
            this.pbDog4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 554);
            this.Controls.Add(this.pbDog4);
            this.Controls.Add(this.pbDog3);
            this.Controls.Add(this.pbDog2);
            this.Controls.Add(this.pbDog1);
            this.Controls.Add(this.pbTrack);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dog Race Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDog4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbTrack;
        private System.Windows.Forms.PictureBox pbDog1;
        private System.Windows.Forms.PictureBox pbDog2;
        private System.Windows.Forms.PictureBox pbDog3;
        private System.Windows.Forms.PictureBox pbDog4;
        private System.Windows.Forms.Label lbPlayer3;
        private System.Windows.Forms.Label lbPlayer2;
        private System.Windows.Forms.Label lbPlayer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numDog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numBet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbSelectLabel;
        private System.Windows.Forms.RadioButton rbPlayer3;
        private System.Windows.Forms.RadioButton rbPlayer2;
        private System.Windows.Forms.RadioButton rbPlayer1;
        private System.Windows.Forms.Label lbet;
    }
}

