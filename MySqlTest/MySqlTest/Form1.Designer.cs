namespace MySqlTest
{
    partial class MySqlTest
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_carrega = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(735, 441);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(672, 12);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 1;
            this.bt_ok.Text = "Vai";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_carrega
            // 
            this.bt_carrega.Location = new System.Drawing.Point(562, 12);
            this.bt_carrega.Name = "bt_carrega";
            this.bt_carrega.Size = new System.Drawing.Size(75, 23);
            this.bt_carrega.TabIndex = 2;
            this.bt_carrega.Text = "Mostra";
            this.bt_carrega.UseVisualStyleBackColor = true;
            this.bt_carrega.Click += new System.EventHandler(this.bt_carrega_Click);
            // 
            // MySqlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 494);
            this.Controls.Add(this.bt_carrega);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MySqlTest";
            this.Text = "Conexão com a Tabela Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_carrega;

    }
}

