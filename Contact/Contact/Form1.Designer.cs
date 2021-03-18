namespace Contact
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
            System.Windows.Forms.Label contactIdLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label client_Label;
            System.Windows.Forms.Label last_CallLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contactDBDataSet = new Contact.ContactDBDataSet();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleTableAdapter = new Contact.ContactDBDataSetTableAdapters.PeopleTableAdapter();
            this.tableAdapterManager = new Contact.ContactDBDataSetTableAdapters.TableAdapterManager();
            this.peopleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.peopleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contactIdTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.client_CheckBox = new System.Windows.Forms.CheckBox();
            this.last_CallDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bt_ok = new System.Windows.Forms.Button();
            contactIdLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            client_Label = new System.Windows.Forms.Label();
            last_CallLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingNavigator)).BeginInit();
            this.peopleBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactIdLabel
            // 
            contactIdLabel.AutoSize = true;
            contactIdLabel.Location = new System.Drawing.Point(13, 37);
            contactIdLabel.Name = "contactIdLabel";
            contactIdLabel.Size = new System.Drawing.Size(75, 17);
            contactIdLabel.TabIndex = 2;
            contactIdLabel.Text = "Contact Id:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(13, 65);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(49, 17);
            nomeLabel.TabIndex = 4;
            nomeLabel.Text = "Nome:";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Location = new System.Drawing.Point(13, 93);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(71, 17);
            companyLabel.TabIndex = 6;
            companyLabel.Text = "Company:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(13, 121);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(68, 17);
            telefoneLabel.TabIndex = 8;
            telefoneLabel.Text = "Telefone:";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(13, 149);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(51, 17);
            e_mailLabel.TabIndex = 10;
            e_mailLabel.Text = "E-mail:";
            // 
            // client_Label
            // 
            client_Label.AutoSize = true;
            client_Label.Location = new System.Drawing.Point(13, 179);
            client_Label.Name = "client_Label";
            client_Label.Size = new System.Drawing.Size(55, 17);
            client_Label.TabIndex = 12;
            client_Label.Text = "Client?:";
            // 
            // last_CallLabel
            // 
            last_CallLabel.AutoSize = true;
            last_CallLabel.Location = new System.Drawing.Point(13, 208);
            last_CallLabel.Name = "last_CallLabel";
            last_CallLabel.Size = new System.Drawing.Size(66, 17);
            last_CallLabel.TabIndex = 14;
            last_CallLabel.Text = "Last Call:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Contact.Properties.Resources.LuthorinaFunnyAngle;
            this.pictureBox1.Location = new System.Drawing.Point(443, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contactDBDataSet
            // 
            this.contactDBDataSet.DataSetName = "ContactDBDataSet";
            this.contactDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.contactDBDataSet;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PeopleTableAdapter = this.peopleTableAdapter;
            this.tableAdapterManager.UpdateOrder = Contact.ContactDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // peopleBindingNavigator
            // 
            this.peopleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.peopleBindingNavigator.BindingSource = this.peopleBindingSource;
            this.peopleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.peopleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.peopleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.peopleBindingNavigatorSaveItem});
            this.peopleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.peopleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.peopleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.peopleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.peopleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.peopleBindingNavigator.Name = "peopleBindingNavigator";
            this.peopleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.peopleBindingNavigator.Size = new System.Drawing.Size(619, 27);
            this.peopleBindingNavigator.TabIndex = 1;
            this.peopleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // peopleBindingNavigatorSaveItem
            // 
            this.peopleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.peopleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("peopleBindingNavigatorSaveItem.Image")));
            this.peopleBindingNavigatorSaveItem.Name = "peopleBindingNavigatorSaveItem";
            this.peopleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.peopleBindingNavigatorSaveItem.Text = "Save Data";
            this.peopleBindingNavigatorSaveItem.Click += new System.EventHandler(this.peopleBindingNavigatorSaveItem_Click_1);
            // 
            // contactIdTextBox
            // 
            this.contactIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "ContactId", true));
            this.contactIdTextBox.Location = new System.Drawing.Point(94, 34);
            this.contactIdTextBox.Name = "contactIdTextBox";
            this.contactIdTextBox.Size = new System.Drawing.Size(321, 22);
            this.contactIdTextBox.TabIndex = 3;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(94, 62);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(321, 22);
            this.nomeTextBox.TabIndex = 5;
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Company", true));
            this.companyTextBox.Location = new System.Drawing.Point(94, 90);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(321, 22);
            this.companyTextBox.TabIndex = 7;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(94, 118);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(321, 22);
            this.telefoneTextBox.TabIndex = 9;
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.peopleBindingSource, "E-mail", true));
            this.e_mailTextBox.Location = new System.Drawing.Point(94, 146);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(321, 22);
            this.e_mailTextBox.TabIndex = 11;
            // 
            // client_CheckBox
            // 
            this.client_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.peopleBindingSource, "Client?", true));
            this.client_CheckBox.Location = new System.Drawing.Point(94, 174);
            this.client_CheckBox.Name = "client_CheckBox";
            this.client_CheckBox.Size = new System.Drawing.Size(321, 24);
            this.client_CheckBox.TabIndex = 13;
            this.client_CheckBox.UseVisualStyleBackColor = true;
            // 
            // last_CallDateTimePicker
            // 
            this.last_CallDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.peopleBindingSource, "Last Call", true));
            this.last_CallDateTimePicker.Location = new System.Drawing.Point(94, 204);
            this.last_CallDateTimePicker.Name = "last_CallDateTimePicker";
            this.last_CallDateTimePicker.Size = new System.Drawing.Size(321, 22);
            this.last_CallDateTimePicker.TabIndex = 15;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(484, 143);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 16;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 242);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(contactIdLabel);
            this.Controls.Add(this.contactIdTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(e_mailLabel);
            this.Controls.Add(this.e_mailTextBox);
            this.Controls.Add(client_Label);
            this.Controls.Add(this.client_CheckBox);
            this.Controls.Add(last_CallLabel);
            this.Controls.Add(this.last_CallDateTimePicker);
            this.Controls.Add(this.peopleBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lista de Contatos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingNavigator)).EndInit();
            this.peopleBindingNavigator.ResumeLayout(false);
            this.peopleBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ContactDBDataSet contactDBDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private ContactDBDataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private ContactDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator peopleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton peopleBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox contactIdTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.CheckBox client_CheckBox;
        private System.Windows.Forms.DateTimePicker last_CallDateTimePicker;
        private System.Windows.Forms.Button bt_ok;
    }
}

