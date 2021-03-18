namespace MDIProject
{
    partial class UserInfo
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
            this.lblContry = new System.Windows.Forms.Label();
            this.txtContry = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lstContry = new System.Windows.Forms.ListBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.chkPostalMail = new System.Windows.Forms.CheckBox();
            this.chkEMail = new System.Windows.Forms.CheckBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemoveContry = new System.Windows.Forms.Button();
            this.btnRemoveState = new System.Windows.Forms.Button();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblContry
            // 
            this.lblContry.Location = new System.Drawing.Point(12, 26);
            this.lblContry.Name = "lblContry";
            this.lblContry.Size = new System.Drawing.Size(71, 13);
            this.lblContry.TabIndex = 0;
            this.lblContry.Text = "Enter Contry";
            // 
            // txtContry
            // 
            this.txtContry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContry.Location = new System.Drawing.Point(97, 19);
            this.txtContry.Name = "txtContry";
            this.txtContry.Size = new System.Drawing.Size(129, 20);
            this.txtContry.TabIndex = 1;
            // 
            // lblState
            // 
            this.lblState.Location = new System.Drawing.Point(12, 65);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(60, 13);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Enter State";
            // 
            // txtState
            // 
            this.txtState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtState.Location = new System.Drawing.Point(97, 58);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(129, 20);
            this.txtState.TabIndex = 3;
            // 
            // lstContry
            // 
            this.lstContry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstContry.FormattingEnabled = true;
            this.lstContry.Location = new System.Drawing.Point(280, 12);
            this.lstContry.Name = "lstContry";
            this.lstContry.Size = new System.Drawing.Size(129, 82);
            this.lstContry.TabIndex = 4;
            // 
            // cboState
            // 
            this.cboState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(280, 117);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(129, 21);
            this.cboState.TabIndex = 5;
            // 
            // chkPostalMail
            // 
            this.chkPostalMail.AutoSize = true;
            this.chkPostalMail.Location = new System.Drawing.Point(15, 96);
            this.chkPostalMail.Name = "chkPostalMail";
            this.chkPostalMail.Size = new System.Drawing.Size(77, 17);
            this.chkPostalMail.TabIndex = 6;
            this.chkPostalMail.Text = "Postal Mail";
            this.chkPostalMail.UseVisualStyleBackColor = true;
            // 
            // chkEMail
            // 
            this.chkEMail.AutoSize = true;
            this.chkEMail.Location = new System.Drawing.Point(15, 120);
            this.chkEMail.Name = "chkEMail";
            this.chkEMail.Size = new System.Drawing.Size(55, 17);
            this.chkEMail.TabIndex = 7;
            this.chkEMail.Text = "E-Mail";
            this.chkEMail.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(99, 96);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(48, 17);
            this.rdbMale.TabIndex = 8;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(99, 120);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(59, 17);
            this.rdbFemale.TabIndex = 9;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(12, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemoveContry
            // 
            this.btnRemoveContry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveContry.Location = new System.Drawing.Point(105, 165);
            this.btnRemoveContry.Name = "btnRemoveContry";
            this.btnRemoveContry.Size = new System.Drawing.Size(95, 23);
            this.btnRemoveContry.TabIndex = 11;
            this.btnRemoveContry.Text = "Remove Contry";
            this.btnRemoveContry.UseVisualStyleBackColor = true;
            this.btnRemoveContry.Click += new System.EventHandler(this.btnRemoveContry_Click);
            // 
            // btnRemoveState
            // 
            this.btnRemoveState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveState.Location = new System.Drawing.Point(220, 165);
            this.btnRemoveState.Name = "btnRemoveState";
            this.btnRemoveState.Size = new System.Drawing.Size(86, 23);
            this.btnRemoveState.TabIndex = 12;
            this.btnRemoveState.Text = "Remove State";
            this.btnRemoveState.UseVisualStyleBackColor = true;
            this.btnRemoveState.Click += new System.EventHandler(this.btnRemoveState_Click);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowDetails.Location = new System.Drawing.Point(327, 165);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(100, 23);
            this.btnShowDetails.TabIndex = 13;
            this.btnShowDetails.Text = "Show Details";
            this.btnShowDetails.UseVisualStyleBackColor = true;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 212);
            this.Controls.Add(this.btnShowDetails);
            this.Controls.Add(this.btnRemoveState);
            this.Controls.Add(this.btnRemoveContry);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.chkEMail);
            this.Controls.Add(this.chkPostalMail);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.lstContry);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtContry);
            this.Controls.Add(this.lblContry);
            this.MinimumSize = new System.Drawing.Size(455, 251);
            this.Name = "UserInfo";
            this.Text = "UserInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContry;
        private System.Windows.Forms.TextBox txtContry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.ListBox lstContry;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.CheckBox chkPostalMail;
        private System.Windows.Forms.CheckBox chkEMail;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemoveContry;
        private System.Windows.Forms.Button btnRemoveState;
        private System.Windows.Forms.Button btnShowDetails;
    }
}