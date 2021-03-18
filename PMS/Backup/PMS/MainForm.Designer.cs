namespace PMS
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.TopHeader = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.StatusBar = new System.Windows.Forms.Label();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.RightTabControl = new System.Windows.Forms.TabControl();
            this.AddTab = new System.Windows.Forms.TabPage();
            this.VersionLbl = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.NewAddressTB = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.NewAddElementLbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.NewEmailTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.NewNameTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.NewAddBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.NewPhoneTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.NewBirthdayPicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.DetailsTab = new System.Windows.Forms.TabPage();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.NoteDatePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.DeleteBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.AddEditLbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.AddNoteBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.NameLbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.NotesTB = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.NameTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.BirthdayLbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.EditBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BirthdayPicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.PhoneTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.AddressTB = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.EmailTB = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.SearchTB = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.SearchBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ElementGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.elementDB = new PMS.ElementDB();
            this.NotesGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elementNoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ElementLbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.NotesLbl = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.elementsTableAdapter = new PMS.ElementDBTableAdapters.ElementsTableAdapter();
            this.tableAdapterManager = new PMS.ElementDBTableAdapters.TableAdapterManager();
            this.elementNoteTableAdapter = new PMS.ElementDBTableAdapters.ElementNoteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            this.kryptonSplitContainer1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.Panel2.SuspendLayout();
            this.kryptonSplitContainer1.SuspendLayout();
            this.RightTabControl.SuspendLayout();
            this.AddTab.SuspendLayout();
            this.DetailsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElementGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementNoteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.TopHeader);
            this.kryptonPanel1.Controls.Add(this.StatusBar);
            this.kryptonPanel1.Controls.Add(this.kryptonSplitContainer1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonPanel1.Size = new System.Drawing.Size(765, 570);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // TopHeader
            // 
            this.TopHeader.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.TopHeader.Location = new System.Drawing.Point(0, 3);
            this.TopHeader.Name = "TopHeader";
            this.TopHeader.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.TopHeader.Size = new System.Drawing.Size(192, 29);
            this.TopHeader.TabIndex = 16;
            this.TopHeader.Text = "CoderToolkit\'s Clinic";
            this.TopHeader.Values.ExtraText = "";
            this.TopHeader.Values.Image = null;
            this.TopHeader.Values.Text = "CoderToolkit\'s Clinic";
            // 
            // StatusBar
            // 
            this.StatusBar.AutoSize = true;
            this.StatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBar.ForeColor = System.Drawing.Color.Red;
            this.StatusBar.Location = new System.Drawing.Point(4, 33);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(158, 17);
            this.StatusBar.TabIndex = 5;
            this.StatusBar.Text = "Welcome to our system!";
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.ContainerBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.IsSplitterFixed = true;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 60);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            this.kryptonSplitContainer1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            // 
            // kryptonSplitContainer1.Panel1
            // 
            this.kryptonSplitContainer1.Panel1.AutoScroll = true;
            this.kryptonSplitContainer1.Panel1.Controls.Add(this.RightTabControl);
            this.kryptonSplitContainer1.Panel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonSplitContainer1.Panel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            // 
            // kryptonSplitContainer1.Panel2
            // 
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.SearchTB);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.SearchBtn);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.ElementGrid);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.NotesGrid);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.ElementLbl);
            this.kryptonSplitContainer1.Panel2.Controls.Add(this.NotesLbl);
            this.kryptonSplitContainer1.Panel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonSplitContainer1.Panel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonSplitContainer1.SeparatorStyle = ComponentFactory.Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(765, 510);
            this.kryptonSplitContainer1.SplitterDistance = 321;
            this.kryptonSplitContainer1.SplitterWidth = 0;
            this.kryptonSplitContainer1.TabIndex = 0;
            // 
            // RightTabControl
            // 
            this.RightTabControl.Controls.Add(this.AddTab);
            this.RightTabControl.Controls.Add(this.DetailsTab);
            this.RightTabControl.Location = new System.Drawing.Point(3, 3);
            this.RightTabControl.Name = "RightTabControl";
            this.RightTabControl.SelectedIndex = 0;
            this.RightTabControl.Size = new System.Drawing.Size(312, 487);
            this.RightTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.RightTabControl.TabIndex = 16;
            this.RightTabControl.TabStop = false;
            this.RightTabControl.SelectedIndexChanged += new System.EventHandler(this.RightTabControl_SelectedIndexChanged);
            // 
            // AddTab
            // 
            this.AddTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AddTab.Controls.Add(this.VersionLbl);
            this.AddTab.Controls.Add(this.NewAddressTB);
            this.AddTab.Controls.Add(this.NewAddElementLbl);
            this.AddTab.Controls.Add(this.NewEmailTB);
            this.AddTab.Controls.Add(this.kryptonLabel2);
            this.AddTab.Controls.Add(this.kryptonLabel10);
            this.AddTab.Controls.Add(this.NewNameTB);
            this.AddTab.Controls.Add(this.kryptonLabel8);
            this.AddTab.Controls.Add(this.kryptonLabel3);
            this.AddTab.Controls.Add(this.NewAddBtn);
            this.AddTab.Controls.Add(this.NewPhoneTB);
            this.AddTab.Controls.Add(this.NewBirthdayPicker);
            this.AddTab.Controls.Add(this.kryptonLabel4);
            this.AddTab.Location = new System.Drawing.Point(4, 22);
            this.AddTab.Name = "AddTab";
            this.AddTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddTab.Size = new System.Drawing.Size(304, 461);
            this.AddTab.TabIndex = 1;
            this.AddTab.Text = "New Patient";
            this.AddTab.UseVisualStyleBackColor = true;
            // 
            // VersionLbl
            // 
            this.VersionLbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.VersionLbl.LinkBehavior = ComponentFactory.Krypton.Toolkit.KryptonLinkBehavior.HoverUnderline;
            this.VersionLbl.Location = new System.Drawing.Point(199, 422);
            this.VersionLbl.Name = "VersionLbl";
            this.VersionLbl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.VersionLbl.Size = new System.Drawing.Size(94, 29);
            this.VersionLbl.TabIndex = 26;
            this.VersionLbl.Text = "PMS v1.0";
            this.VersionLbl.Values.ExtraText = "";
            this.VersionLbl.Values.Image = null;
            this.VersionLbl.Values.Text = "PMS v1.0";
            this.VersionLbl.LinkClicked += new System.EventHandler(this.VersionLbl_LinkClicked);
            // 
            // NewAddressTB
            // 
            this.NewAddressTB.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.NewAddressTB.Location = new System.Drawing.Point(81, 97);
            this.NewAddressTB.Name = "NewAddressTB";
            this.NewAddressTB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.NewAddressTB.Size = new System.Drawing.Size(212, 77);
            this.NewAddressTB.TabIndex = 5;
            // 
            // NewAddElementLbl
            // 
            this.NewAddElementLbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.NewAddElementLbl.Location = new System.Drawing.Point(6, 9);
            this.NewAddElementLbl.Name = "NewAddElementLbl";
            this.NewAddElementLbl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.NewAddElementLbl.Size = new System.Drawing.Size(119, 29);
            this.NewAddElementLbl.TabIndex = 23;
            this.NewAddElementLbl.TabStop = false;
            this.NewAddElementLbl.Text = "New Patient";
            this.NewAddElementLbl.Values.ExtraText = "";
            this.NewAddElementLbl.Values.Image = null;
            this.NewAddElementLbl.Values.Text = "New Patient";
            // 
            // NewEmailTB
            // 
            this.NewEmailTB.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.NewEmailTB.Location = new System.Drawing.Point(81, 206);
            this.NewEmailTB.Name = "NewEmailTB";
            this.NewEmailTB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.NewEmailTB.Size = new System.Drawing.Size(212, 20);
            this.NewEmailTB.TabIndex = 7;
            this.NewEmailTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewNameTB_KeyPress);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(6, 44);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonLabel2.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel2.TabIndex = 16;
            this.kryptonLabel2.TabStop = false;
            this.kryptonLabel2.Text = "Name";
            this.kryptonLabel2.Values.ExtraText = "";
            this.kryptonLabel2.Values.Image = null;
            this.kryptonLabel2.Values.Text = "Name";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonLabel10.Location = new System.Drawing.Point(6, 97);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonLabel10.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel10.TabIndex = 25;
            this.kryptonLabel10.TabStop = false;
            this.kryptonLabel10.Text = "Address";
            this.kryptonLabel10.Values.ExtraText = "";
            this.kryptonLabel10.Values.Image = null;
            this.kryptonLabel10.Values.Text = "Address";
            // 
            // NewNameTB
            // 
            this.NewNameTB.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.NewNameTB.Location = new System.Drawing.Point(81, 44);
            this.NewNameTB.Name = "NewNameTB";
            this.NewNameTB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.NewNameTB.Size = new System.Drawing.Size(212, 20);
            this.NewNameTB.TabIndex = 3;
            this.NewNameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewNameTB_KeyPress);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonLabel8.Location = new System.Drawing.Point(6, 206);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonLabel8.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabel8.TabIndex = 22;
            this.kryptonLabel8.TabStop = false;
            this.kryptonLabel8.Text = "Email";
            this.kryptonLabel8.Values.ExtraText = "";
            this.kryptonLabel8.Values.Image = null;
            this.kryptonLabel8.Values.Text = "Email";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(6, 71);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonLabel3.Size = new System.Drawing.Size(56, 20);
            this.kryptonLabel3.TabIndex = 18;
            this.kryptonLabel3.TabStop = false;
            this.kryptonLabel3.Text = "Birthday";
            this.kryptonLabel3.Values.ExtraText = "";
            this.kryptonLabel3.Values.Image = null;
            this.kryptonLabel3.Values.Text = "Birthday";
            // 
            // NewAddBtn
            // 
            this.NewAddBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.NewAddBtn.Location = new System.Drawing.Point(81, 232);
            this.NewAddBtn.Name = "NewAddBtn";
            this.NewAddBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.NewAddBtn.Size = new System.Drawing.Size(69, 25);
            this.NewAddBtn.TabIndex = 8;
            this.NewAddBtn.Text = "Add";
            this.NewAddBtn.Values.ExtraText = "";
            this.NewAddBtn.Values.Image = null;
            this.NewAddBtn.Values.ImageStates.ImageCheckedNormal = null;
            this.NewAddBtn.Values.ImageStates.ImageCheckedPressed = null;
            this.NewAddBtn.Values.ImageStates.ImageCheckedTracking = null;
            this.NewAddBtn.Values.Text = "Add";
            this.NewAddBtn.Click += new System.EventHandler(this.NewAddBtn_Click);
            // 
            // NewPhoneTB
            // 
            this.NewPhoneTB.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.NewPhoneTB.Location = new System.Drawing.Point(81, 180);
            this.NewPhoneTB.Name = "NewPhoneTB";
            this.NewPhoneTB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.NewPhoneTB.Size = new System.Drawing.Size(144, 20);
            this.NewPhoneTB.TabIndex = 6;
            this.NewPhoneTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewNameTB_KeyPress);
            // 
            // NewBirthdayPicker
            // 
            this.NewBirthdayPicker.CalendarDayOfWeekStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.NewBirthdayPicker.CalendarDayStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.NewBirthdayPicker.CalendarHeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.NewBirthdayPicker.CalendarTodayDate = new System.DateTime(2009, 7, 10, 0, 0, 0, 0);
            this.NewBirthdayPicker.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
            this.NewBirthdayPicker.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.NewBirthdayPicker.Location = new System.Drawing.Point(81, 70);
            this.NewBirthdayPicker.Name = "NewBirthdayPicker";
            this.NewBirthdayPicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.NewBirthdayPicker.Size = new System.Drawing.Size(212, 21);
            this.NewBirthdayPicker.TabIndex = 4;
            this.NewBirthdayPicker.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
            this.NewBirthdayPicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewNameTB_KeyPress);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(6, 180);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonLabel4.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel4.TabIndex = 20;
            this.kryptonLabel4.TabStop = false;
            this.kryptonLabel4.Text = "Phone";
            this.kryptonLabel4.Values.ExtraText = "";
            this.kryptonLabel4.Values.Image = null;
            this.kryptonLabel4.Values.Text = "Phone";
            // 
            // DetailsTab
            // 
            this.DetailsTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DetailsTab.Controls.Add(this.kryptonLabel1);
            this.DetailsTab.Controls.Add(this.NoteDatePicker);
            this.DetailsTab.Controls.Add(this.DeleteBtn);
            this.DetailsTab.Controls.Add(this.AddEditLbl);
            this.DetailsTab.Controls.Add(this.AddNoteBtn);
            this.DetailsTab.Controls.Add(this.NameLbl);
            this.DetailsTab.Controls.Add(this.NotesTB);
            this.DetailsTab.Controls.Add(this.NameTB);
            this.DetailsTab.Controls.Add(this.kryptonLabel9);
            this.DetailsTab.Controls.Add(this.BirthdayLbl);
            this.DetailsTab.Controls.Add(this.EditBtn);
            this.DetailsTab.Controls.Add(this.BirthdayPicker);
            this.DetailsTab.Controls.Add(this.kryptonLabel5);
            this.DetailsTab.Controls.Add(this.PhoneTB);
            this.DetailsTab.Controls.Add(this.AddressTB);
            this.DetailsTab.Controls.Add(this.kryptonLabel6);
            this.DetailsTab.Controls.Add(this.kryptonLabel7);
            this.DetailsTab.Controls.Add(this.EmailTB);
            this.DetailsTab.Location = new System.Drawing.Point(4, 22);
            this.DetailsTab.Name = "DetailsTab";
            this.DetailsTab.Padding = new System.Windows.Forms.Padding(3);
            this.DetailsTab.Size = new System.Drawing.Size(304, 461);
            this.DetailsTab.TabIndex = 0;
            this.DetailsTab.Text = "Details";
            this.DetailsTab.UseVisualStyleBackColor = true;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(6, 271);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonLabel1.Size = new System.Drawing.Size(36, 20);
            this.kryptonLabel1.TabIndex = 19;
            this.kryptonLabel1.Text = "Date";
            this.kryptonLabel1.Values.ExtraText = "";
            this.kryptonLabel1.Values.Image = null;
            this.kryptonLabel1.Values.Text = "Date";
            // 
            // NoteDatePicker
            // 
            this.NoteDatePicker.CalendarDayOfWeekStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.NoteDatePicker.CalendarDayStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.NoteDatePicker.CalendarHeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.NoteDatePicker.CalendarTodayDate = new System.DateTime(2009, 7, 10, 0, 0, 0, 0);
            this.NoteDatePicker.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
            this.NoteDatePicker.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.NoteDatePicker.Location = new System.Drawing.Point(81, 271);
            this.NoteDatePicker.Name = "NoteDatePicker";
            this.NoteDatePicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.NoteDatePicker.Size = new System.Drawing.Size(212, 21);
            this.NoteDatePicker.TabIndex = 18;
            this.NoteDatePicker.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.DeleteBtn.Location = new System.Drawing.Point(156, 232);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.DeleteBtn.Size = new System.Drawing.Size(69, 25);
            this.DeleteBtn.TabIndex = 15;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.Values.ExtraText = "";
            this.DeleteBtn.Values.Image = null;
            this.DeleteBtn.Values.ImageStates.ImageCheckedNormal = null;
            this.DeleteBtn.Values.ImageStates.ImageCheckedPressed = null;
            this.DeleteBtn.Values.ImageStates.ImageCheckedTracking = null;
            this.DeleteBtn.Values.Text = "Delete";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddEditLbl
            // 
            this.AddEditLbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.AddEditLbl.Location = new System.Drawing.Point(6, 9);
            this.AddEditLbl.Name = "AddEditLbl";
            this.AddEditLbl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.AddEditLbl.Size = new System.Drawing.Size(139, 29);
            this.AddEditLbl.TabIndex = 7;
            this.AddEditLbl.Text = "Patient Details";
            this.AddEditLbl.Values.ExtraText = "";
            this.AddEditLbl.Values.Image = null;
            this.AddEditLbl.Values.Text = "Patient Details";
            // 
            // AddNoteBtn
            // 
            this.AddNoteBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.AddNoteBtn.Location = new System.Drawing.Point(81, 415);
            this.AddNoteBtn.Name = "AddNoteBtn";
            this.AddNoteBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.AddNoteBtn.Size = new System.Drawing.Size(86, 25);
            this.AddNoteBtn.TabIndex = 17;
            this.AddNoteBtn.Text = "Add Record";
            this.AddNoteBtn.Values.ExtraText = "";
            this.AddNoteBtn.Values.Image = null;
            this.AddNoteBtn.Values.ImageStates.ImageCheckedNormal = null;
            this.AddNoteBtn.Values.ImageStates.ImageCheckedPressed = null;
            this.AddNoteBtn.Values.ImageStates.ImageCheckedTracking = null;
            this.AddNoteBtn.Values.Text = "Add Record";
            this.AddNoteBtn.Click += new System.EventHandler(this.AddNoteBtn_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.NameLbl.Location = new System.Drawing.Point(6, 44);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.NameLbl.Size = new System.Drawing.Size(43, 20);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name";
            this.NameLbl.Values.ExtraText = "";
            this.NameLbl.Values.Image = null;
            this.NameLbl.Values.Text = "Name";
            // 
            // NotesTB
            // 
            this.NotesTB.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.NotesTB.Location = new System.Drawing.Point(81, 298);
            this.NotesTB.Name = "NotesTB";
            this.NotesTB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.NotesTB.Size = new System.Drawing.Size(212, 111);
            this.NotesTB.TabIndex = 16;
            // 
            // NameTB
            // 
            this.NameTB.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.NameTB.Location = new System.Drawing.Point(81, 44);
            this.NameTB.Name = "NameTB";
            this.NameTB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.NameTB.Size = new System.Drawing.Size(212, 20);
            this.NameTB.TabIndex = 9;
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonLabel9.Location = new System.Drawing.Point(6, 298);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonLabel9.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel9.TabIndex = 12;
            this.kryptonLabel9.Text = "Record";
            this.kryptonLabel9.Values.ExtraText = "";
            this.kryptonLabel9.Values.Image = null;
            this.kryptonLabel9.Values.Text = "Record";
            // 
            // BirthdayLbl
            // 
            this.BirthdayLbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.BirthdayLbl.Location = new System.Drawing.Point(6, 71);
            this.BirthdayLbl.Name = "BirthdayLbl";
            this.BirthdayLbl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.BirthdayLbl.Size = new System.Drawing.Size(56, 20);
            this.BirthdayLbl.TabIndex = 2;
            this.BirthdayLbl.Text = "Birthday";
            this.BirthdayLbl.Values.ExtraText = "";
            this.BirthdayLbl.Values.Image = null;
            this.BirthdayLbl.Values.Text = "Birthday";
            // 
            // EditBtn
            // 
            this.EditBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.EditBtn.Location = new System.Drawing.Point(81, 232);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.EditBtn.Size = new System.Drawing.Size(69, 25);
            this.EditBtn.TabIndex = 14;
            this.EditBtn.Text = "Edit";
            this.EditBtn.Values.ExtraText = "";
            this.EditBtn.Values.Image = null;
            this.EditBtn.Values.ImageStates.ImageCheckedNormal = null;
            this.EditBtn.Values.ImageStates.ImageCheckedPressed = null;
            this.EditBtn.Values.ImageStates.ImageCheckedTracking = null;
            this.EditBtn.Values.Text = "Edit";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // BirthdayPicker
            // 
            this.BirthdayPicker.CalendarDayOfWeekStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.BirthdayPicker.CalendarDayStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.CalendarDay;
            this.BirthdayPicker.CalendarHeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Calendar;
            this.BirthdayPicker.CalendarTodayDate = new System.DateTime(2009, 7, 10, 0, 0, 0, 0);
            this.BirthdayPicker.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
            this.BirthdayPicker.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.BirthdayPicker.Location = new System.Drawing.Point(81, 70);
            this.BirthdayPicker.Name = "BirthdayPicker";
            this.BirthdayPicker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.BirthdayPicker.Size = new System.Drawing.Size(212, 21);
            this.BirthdayPicker.TabIndex = 10;
            this.BirthdayPicker.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.InputControl;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonLabel5.Location = new System.Drawing.Point(6, 180);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonLabel5.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel5.TabIndex = 4;
            this.kryptonLabel5.Text = "Phone";
            this.kryptonLabel5.Values.ExtraText = "";
            this.kryptonLabel5.Values.Image = null;
            this.kryptonLabel5.Values.Text = "Phone";
            // 
            // PhoneTB
            // 
            this.PhoneTB.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.PhoneTB.Location = new System.Drawing.Point(81, 180);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.PhoneTB.Size = new System.Drawing.Size(144, 20);
            this.PhoneTB.TabIndex = 12;
            // 
            // AddressTB
            // 
            this.AddressTB.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.AddressTB.Location = new System.Drawing.Point(81, 97);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.AddressTB.Size = new System.Drawing.Size(212, 77);
            this.AddressTB.TabIndex = 11;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonLabel6.Location = new System.Drawing.Point(6, 206);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonLabel6.Size = new System.Drawing.Size(40, 20);
            this.kryptonLabel6.TabIndex = 6;
            this.kryptonLabel6.Text = "Email";
            this.kryptonLabel6.Values.ExtraText = "";
            this.kryptonLabel6.Values.Image = null;
            this.kryptonLabel6.Values.Text = "Email";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonLabel7.Location = new System.Drawing.Point(6, 97);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonLabel7.Size = new System.Drawing.Size(54, 20);
            this.kryptonLabel7.TabIndex = 8;
            this.kryptonLabel7.Text = "Address";
            this.kryptonLabel7.Values.ExtraText = "";
            this.kryptonLabel7.Values.Image = null;
            this.kryptonLabel7.Values.Text = "Address";
            // 
            // EmailTB
            // 
            this.EmailTB.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.EmailTB.Location = new System.Drawing.Point(81, 206);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.EmailTB.Size = new System.Drawing.Size(212, 20);
            this.EmailTB.TabIndex = 13;
            // 
            // SearchTB
            // 
            this.SearchTB.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Standalone;
            this.SearchTB.Location = new System.Drawing.Point(9, 3);
            this.SearchTB.Multiline = false;
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.SearchTB.Size = new System.Drawing.Size(155, 25);
            this.SearchTB.TabIndex = 1;
            this.SearchTB.WordWrap = false;
            this.SearchTB.Enter += new System.EventHandler(this.SearchTB_Enter);
            this.SearchTB.TextChanged += new System.EventHandler(this.SearchTB_TextChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.SearchBtn.Location = new System.Drawing.Point(170, 3);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver;
            this.SearchBtn.Size = new System.Drawing.Size(69, 25);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.Values.ExtraText = "";
            this.SearchBtn.Values.Image = null;
            this.SearchBtn.Values.ImageStates.ImageCheckedNormal = null;
            this.SearchBtn.Values.ImageStates.ImageCheckedPressed = null;
            this.SearchBtn.Values.ImageStates.ImageCheckedTracking = null;
            this.SearchBtn.Values.Text = "Search";
            // 
            // ElementGrid
            // 
            this.ElementGrid.AllowUserToAddRows = false;
            this.ElementGrid.AllowUserToResizeColumns = false;
            this.ElementGrid.AllowUserToResizeRows = false;
            this.ElementGrid.AutoGenerateColumns = false;
            this.ElementGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ElementGrid.CausesValidation = false;
            this.ElementGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.elementNameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.Address,
            this.Phone,
            this.Email});
            this.ElementGrid.DataSource = this.elementsBindingSource;
            this.ElementGrid.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.List;
            this.ElementGrid.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.ElementGrid.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.List;
            this.ElementGrid.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.List;
            this.ElementGrid.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.List;
            this.ElementGrid.Location = new System.Drawing.Point(9, 69);
            this.ElementGrid.Name = "ElementGrid";
            this.ElementGrid.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.ElementGrid.ReadOnly = true;
            this.ElementGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ElementGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ElementGrid.Size = new System.Drawing.Size(431, 201);
            this.ElementGrid.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.ElementGrid.TabIndex = 0;
            this.ElementGrid.TabStop = false;
            this.ElementGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ElementGrid_RowEnter);
            this.ElementGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ElementGrid_MouseDoubleClick);
            this.ElementGrid.CurrentCellChanged += new System.EventHandler(this.ElementGrid_CurrentCellChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // elementNameDataGridViewTextBoxColumn
            // 
            this.elementNameDataGridViewTextBoxColumn.DataPropertyName = "ElementName";
            this.elementNameDataGridViewTextBoxColumn.FillWeight = 121.8274F;
            this.elementNameDataGridViewTextBoxColumn.HeaderText = "Patient Name";
            this.elementNameDataGridViewTextBoxColumn.Name = "elementNameDataGridViewTextBoxColumn";
            this.elementNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.FillWeight = 78.17259F;
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Visible = false;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Visible = false;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            // 
            // elementsBindingSource
            // 
            this.elementsBindingSource.DataMember = "Elements";
            this.elementsBindingSource.DataSource = this.elementDB;
            // 
            // elementDB
            // 
            this.elementDB.DataSetName = "ElementDB";
            this.elementDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NotesGrid
            // 
            this.NotesGrid.AllowUserToAddRows = false;
            this.NotesGrid.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NotesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.NotesGrid.AutoGenerateColumns = false;
            this.NotesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NotesGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.NotesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.noteDateDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.NotesGrid.DataSource = this.elementNoteBindingSource;
            this.NotesGrid.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.List;
            this.NotesGrid.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.NotesGrid.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.List;
            this.NotesGrid.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.List;
            this.NotesGrid.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.List;
            this.NotesGrid.Location = new System.Drawing.Point(10, 311);
            this.NotesGrid.Name = "NotesGrid";
            this.NotesGrid.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NotesGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.NotesGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NotesGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NotesGrid.Size = new System.Drawing.Size(430, 179);
            this.NotesGrid.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.NotesGrid.TabIndex = 0;
            this.NotesGrid.TabStop = false;
            this.NotesGrid.CurrentCellChanged += new System.EventHandler(this.NotesGrid_CurrentCellChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // noteDateDataGridViewTextBoxColumn
            // 
            this.noteDateDataGridViewTextBoxColumn.DataPropertyName = "NoteDate";
            this.noteDateDataGridViewTextBoxColumn.FillWeight = 57.86802F;
            this.noteDateDataGridViewTextBoxColumn.HeaderText = "Record Date";
            this.noteDateDataGridViewTextBoxColumn.Name = "noteDateDataGridViewTextBoxColumn";
            this.noteDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notesDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.notesDataGridViewTextBoxColumn.FillWeight = 142.132F;
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // elementNoteBindingSource
            // 
            this.elementNoteBindingSource.DataMember = "Elements_ElementNote";
            this.elementNoteBindingSource.DataSource = this.elementsBindingSource;
            // 
            // ElementLbl
            // 
            this.ElementLbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.ElementLbl.Location = new System.Drawing.Point(5, 34);
            this.ElementLbl.Name = "ElementLbl";
            this.ElementLbl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.ElementLbl.Size = new System.Drawing.Size(83, 29);
            this.ElementLbl.TabIndex = 0;
            this.ElementLbl.TabStop = false;
            this.ElementLbl.Text = "Patients";
            this.ElementLbl.Values.ExtraText = "";
            this.ElementLbl.Values.Image = null;
            this.ElementLbl.Values.Text = "Patients";
            // 
            // NotesLbl
            // 
            this.NotesLbl.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.NotesLbl.Location = new System.Drawing.Point(5, 276);
            this.NotesLbl.Name = "NotesLbl";
            this.NotesLbl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple;
            this.NotesLbl.Size = new System.Drawing.Size(82, 29);
            this.NotesLbl.TabIndex = 0;
            this.NotesLbl.TabStop = false;
            this.NotesLbl.Text = "Records";
            this.NotesLbl.Values.ExtraText = "";
            this.NotesLbl.Values.Image = null;
            this.NotesLbl.Values.Text = "Records";
            // 
            // elementsTableAdapter
            // 
            this.elementsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ElementNoteTableAdapter = this.elementNoteTableAdapter;
            this.tableAdapterManager.ElementsTableAdapter = this.elementsTableAdapter;
            this.tableAdapterManager.UpdateOrder = PMS.ElementDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // elementNoteTableAdapter
            // 
            this.elementNoteTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(765, 570);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CoderToolkit\'s Clinic";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            this.kryptonSplitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            this.kryptonSplitContainer1.Panel2.ResumeLayout(false);
            this.kryptonSplitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            this.RightTabControl.ResumeLayout(false);
            this.AddTab.ResumeLayout(false);
            this.AddTab.PerformLayout();
            this.DetailsTab.ResumeLayout(false);
            this.DetailsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElementGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elementNoteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView ElementGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox SearchTB;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox NameTB;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel NameLbl;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel BirthdayLbl;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker BirthdayPicker;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView NotesGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel NotesLbl;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel ElementLbl;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox PhoneTB;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox EmailTB;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox AddressTB;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel AddEditLbl;
        private ComponentFactory.Krypton.Toolkit.KryptonButton EditBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox NotesTB;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonButton AddNoteBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton SearchBtn;
        private ElementDB elementDB;
        private System.Windows.Forms.BindingSource elementsBindingSource;
        private PMS.ElementDBTableAdapters.ElementsTableAdapter elementsTableAdapter;
        private PMS.ElementDBTableAdapters.TableAdapterManager tableAdapterManager;
        private PMS.ElementDBTableAdapters.ElementNoteTableAdapter elementNoteTableAdapter;
        private System.Windows.Forms.BindingSource elementNoteBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonButton DeleteBtn;
        private System.Windows.Forms.TabControl RightTabControl;
        private System.Windows.Forms.TabPage DetailsTab;
        private System.Windows.Forms.TabPage AddTab;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel NewAddElementLbl;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox NewEmailTB;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox NewNameTB;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton NewAddBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox NewPhoneTB;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker NewBirthdayPicker;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private System.Windows.Forms.Label StatusBar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel TopHeader;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker NoteDatePicker;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox NewAddressTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn elementNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel VersionLbl;

    }
}