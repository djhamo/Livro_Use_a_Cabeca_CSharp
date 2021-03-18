namespace MDIProject
{
    partial class LINQtoSQL
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
            this.txtLinqSql = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLinqSql
            // 
            this.txtLinqSql.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLinqSql.Location = new System.Drawing.Point(0, 0);
            this.txtLinqSql.Multiline = true;
            this.txtLinqSql.Name = "txtLinqSql";
            this.txtLinqSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLinqSql.Size = new System.Drawing.Size(284, 261);
            this.txtLinqSql.TabIndex = 0;
            // 
            // LINQtoSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtLinqSql);
            this.Name = "LINQtoSQL";
            this.Text = "LINQtoSQL";
            this.Load += new System.EventHandler(this.LINQtoSQL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLinqSql;
    }
}