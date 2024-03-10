namespace OOP_Laba1
{
    partial class Laba1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.TimerProgressBar = new System.Windows.Forms.Timer(this.components);
            this.TextBoxStart = new System.Windows.Forms.TextBox();
            this.CheckBoxPinkTheme = new System.Windows.Forms.CheckBox();
            this.CheckedListBox123 = new System.Windows.Forms.CheckedListBox();
            this.ComboBox123 = new System.Windows.Forms.ComboBox();
            this.dateTimePickerGoogle = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.linkLabelGoogle = new System.Windows.Forms.LinkLabel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ExitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ErrorComboBox = new System.Windows.Forms.ErrorProvider(this.components);
            this.DateBox = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelSplitContainer1 = new System.Windows.Forms.Label();
            this.labelSplitContainer2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableButton1 = new System.Windows.Forms.Button();
            this.TableButton2 = new System.Windows.Forms.Button();
            this.TableButton3 = new System.Windows.Forms.Button();
            this.TableButton4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxMessage = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hideShowStartButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorComboBox)).BeginInit();
            this.DateBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ButtonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStart.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.Location = new System.Drawing.Point(501, 213);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(121, 83);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = " Start";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimerProgressBar
            // 
            this.TimerProgressBar.Interval = 1000;
            this.TimerProgressBar.Tick += new System.EventHandler(this.TimerProgressBar_Tick);
            // 
            // TextBoxStart
            // 
            this.TextBoxStart.BackColor = System.Drawing.Color.Coral;
            this.TextBoxStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxStart.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxStart.ForeColor = System.Drawing.Color.White;
            this.TextBoxStart.Location = new System.Drawing.Point(501, 301);
            this.TextBoxStart.Name = "TextBoxStart";
            this.TextBoxStart.Size = new System.Drawing.Size(121, 26);
            this.TextBoxStart.TabIndex = 1;
            this.TextBoxStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ExitToolTip.SetToolTip(this.TextBoxStart, "Try typing \"Exit\" ");
            this.TextBoxStart.UseWaitCursor = true;
            this.TextBoxStart.Visible = false;
            this.TextBoxStart.TextChanged += new System.EventHandler(this.tbStart_TextChanged);
            // 
            // CheckBoxPinkTheme
            // 
            this.CheckBoxPinkTheme.AutoSize = true;
            this.CheckBoxPinkTheme.Location = new System.Drawing.Point(34, 87);
            this.CheckBoxPinkTheme.Name = "CheckBoxPinkTheme";
            this.CheckBoxPinkTheme.Size = new System.Drawing.Size(79, 17);
            this.CheckBoxPinkTheme.TabIndex = 2;
            this.CheckBoxPinkTheme.Text = "Pink theme";
            this.CheckBoxPinkTheme.UseVisualStyleBackColor = true;
            this.CheckBoxPinkTheme.Visible = false;
            this.CheckBoxPinkTheme.CheckedChanged += new System.EventHandler(this.cbPinkTheme_CheckedChanged);
            // 
            // CheckedListBox123
            // 
            this.CheckedListBox123.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckedListBox123.FormattingEnabled = true;
            this.CheckedListBox123.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.CheckedListBox123.Location = new System.Drawing.Point(3, 3);
            this.CheckedListBox123.Name = "CheckedListBox123";
            this.CheckedListBox123.Size = new System.Drawing.Size(38, 67);
            this.CheckedListBox123.TabIndex = 3;
            this.CheckedListBox123.Visible = false;
            
            // 
            // ComboBox123
            // 
            this.ComboBox123.FormattingEnabled = true;
            this.ComboBox123.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "Danger"});
            this.ComboBox123.Location = new System.Drawing.Point(47, 29);
            this.ComboBox123.Name = "ComboBox123";
            this.ComboBox123.Size = new System.Drawing.Size(121, 21);
            this.ComboBox123.TabIndex = 4;
            this.ComboBox123.Visible = false;
            this.ComboBox123.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePickerGoogle
            // 
            this.dateTimePickerGoogle.Location = new System.Drawing.Point(83, 72);
            this.dateTimePickerGoogle.Name = "dateTimePickerGoogle";
            this.dateTimePickerGoogle.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerGoogle.TabIndex = 5;
            this.dateTimePickerGoogle.Value = new System.DateTime(2024, 2, 19, 20, 20, 3, 0);
            this.dateTimePickerGoogle.Visible = false;
            this.dateTimePickerGoogle.CloseUp += new System.EventHandler(this.dateTimePickerGoogle_CloseUp);
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(0, 16);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(350, 53);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Enter your date of birth";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelDate.Visible = false;
            // 
            // linkLabelGoogle
            // 
            this.linkLabelGoogle.AutoSize = true;
            this.linkLabelGoogle.Enabled = false;
            this.linkLabelGoogle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabelGoogle.Location = new System.Drawing.Point(152, 95);
            this.linkLabelGoogle.Name = "linkLabelGoogle";
            this.linkLabelGoogle.Size = new System.Drawing.Size(70, 13);
            this.linkLabelGoogle.TabIndex = 7;
            this.linkLabelGoogle.TabStop = true;
            this.linkLabelGoogle.Text = "Go to Google";
            this.linkLabelGoogle.Visible = false;
            this.linkLabelGoogle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGoogle_LinkClicked);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 28;
            this.listBox.Items.AddRange(new object[] {
            "TrollFace",
            "LOL",
            "AreYouKiddingMe",
            "PokerFace"});
            this.listBox.Location = new System.Drawing.Point(815, 55);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(149, 116);
            this.listBox.TabIndex = 8;
            this.listBox.Visible = false;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBoxGoogle_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(3, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Visible = false;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(983, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 29);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1273, 23);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
            this.flowLayoutPanel1.Controls.Add(this.progressBar1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 465);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1276, 58);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // ErrorComboBox
            // 
            this.ErrorComboBox.ContainerControl = this;
            // 
            // DateBox
            // 
            this.DateBox.Controls.Add(this.labelDate);
            this.DateBox.Controls.Add(this.dateTimePickerGoogle);
            this.DateBox.Controls.Add(this.linkLabelGoogle);
            this.DateBox.Location = new System.Drawing.Point(12, 333);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(356, 111);
            this.DateBox.TabIndex = 15;
            this.DateBox.TabStop = false;
            this.DateBox.Text = "Date";
            this.DateBox.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.splitContainer1.Panel1.Controls.Add(this.labelSplitContainer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.YellowGreen;
            this.splitContainer1.Panel2.Controls.Add(this.labelSplitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(418, 155);
            this.splitContainer1.SplitterDistance = 183;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 16;
            this.splitContainer1.Visible = false;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // labelSplitContainer1
            // 
            this.labelSplitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.labelSplitContainer1.Name = "labelSplitContainer1";
            this.labelSplitContainer1.Size = new System.Drawing.Size(42, 155);
            this.labelSplitContainer1.TabIndex = 25;
            this.labelSplitContainer1.Text = "Try to move splitter";
            this.labelSplitContainer1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSplitContainer2
            // 
            this.labelSplitContainer2.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelSplitContainer2.Location = new System.Drawing.Point(186, 0);
            this.labelSplitContainer2.Name = "labelSplitContainer2";
            this.labelSplitContainer2.Size = new System.Drawing.Size(39, 155);
            this.labelSplitContainer2.TabIndex = 26;
            this.labelSplitContainer2.Text = "Try to move splitter";
            this.labelSplitContainer2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(815, 257);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(432, 187);
            this.tabControl1.TabIndex = 17;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(424, 161);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SplitContainer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(424, 161);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TableLayoutPanel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanel1.Controls.Add(this.TableButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TableButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TableButton3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TableButton4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 155);
            this.tableLayoutPanel1.TabIndex = 18;
            this.tableLayoutPanel1.Visible = false;
            // 
            // TableButton1
            // 
            this.TableButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableButton1.Location = new System.Drawing.Point(3, 3);
            this.TableButton1.Name = "TableButton1";
            this.TableButton1.Size = new System.Drawing.Size(205, 71);
            this.TableButton1.TabIndex = 0;
            this.TableButton1.Text = "Blue";
            this.TableButton1.UseVisualStyleBackColor = true;
            this.TableButton1.Click += new System.EventHandler(this.TableButton1_Click);
            this.TableButton1.MouseEnter += new System.EventHandler(this.TableButton1_MouseEnter);
            // 
            // TableButton2
            // 
            this.TableButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableButton2.Location = new System.Drawing.Point(214, 3);
            this.TableButton2.Name = "TableButton2";
            this.TableButton2.Size = new System.Drawing.Size(201, 71);
            this.TableButton2.TabIndex = 1;
            this.TableButton2.Text = "Green";
            this.TableButton2.UseVisualStyleBackColor = true;
            this.TableButton2.Click += new System.EventHandler(this.TableButton2_Click);
            this.TableButton2.MouseEnter += new System.EventHandler(this.TableButton2_MouseEnter);
            // 
            // TableButton3
            // 
            this.TableButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableButton3.Location = new System.Drawing.Point(3, 80);
            this.TableButton3.Name = "TableButton3";
            this.TableButton3.Size = new System.Drawing.Size(205, 72);
            this.TableButton3.TabIndex = 2;
            this.TableButton3.Text = "Yellow";
            this.TableButton3.UseVisualStyleBackColor = true;
            this.TableButton3.Click += new System.EventHandler(this.TableButton3_Click);
            this.TableButton3.MouseEnter += new System.EventHandler(this.TableButton3_MouseEnter);
            // 
            // TableButton4
            // 
            this.TableButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableButton4.Location = new System.Drawing.Point(214, 80);
            this.TableButton4.Name = "TableButton4";
            this.TableButton4.Size = new System.Drawing.Size(201, 72);
            this.TableButton4.TabIndex = 3;
            this.TableButton4.Text = "Red";
            this.TableButton4.UseVisualStyleBackColor = true;
            this.TableButton4.Click += new System.EventHandler(this.TableButton4_Click);
            this.TableButton4.MouseEnter += new System.EventHandler(this.TableButton4_MouseEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createButtonToolStripMenuItem,
            this.createMessageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 48);
            // 
            // createButtonToolStripMenuItem
            // 
            this.createButtonToolStripMenuItem.Name = "createButtonToolStripMenuItem";
            this.createButtonToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.createButtonToolStripMenuItem.Text = "Create button";
            this.createButtonToolStripMenuItem.Click += new System.EventHandler(this.createButtonToolStripMenuItem_Click);
            // 
            // createMessageToolStripMenuItem
            // 
            this.createMessageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextBoxMessage});
            this.createMessageToolStripMenuItem.Name = "createMessageToolStripMenuItem";
            this.createMessageToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.createMessageToolStripMenuItem.Text = "Create message";
            // 
            // TextBoxMessage
            // 
            this.TextBoxMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxMessage.Name = "TextBoxMessage";
            this.TextBoxMessage.Size = new System.Drawing.Size(100, 23);
            this.TextBoxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxMessage_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paintToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1276, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.hideShowStartButtonToolStripMenuItem});
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.paintToolStripMenuItem.Text = "Paint";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.startToolStripMenuItem.Text = "Start/Stop";
            this.startToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.startToolStripMenuItem_MouseUp);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clearToolStripMenuItem_MouseUp);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.exitToolStripMenuItem_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 443);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1276, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckedListBox123);
            this.panel1.Controls.Add(this.ComboBox123);
            this.panel1.Location = new System.Drawing.Point(34, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 75);
            this.panel1.TabIndex = 23;
            this.panel1.Visible = false;
            // 
            // hideShowStartButtonToolStripMenuItem
            // 
            this.hideShowStartButtonToolStripMenuItem.Name = "hideShowStartButtonToolStripMenuItem";
            this.hideShowStartButtonToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.hideShowStartButtonToolStripMenuItem.Text = "Hide / Show \"Start\" button";
            this.hideShowStartButtonToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hideShowStartButtonToolStripMenuItem_MouseUp);
            // 
            // Laba1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.CheckBoxPinkTheme);
            this.Controls.Add(this.TextBoxStart);
            this.Controls.Add(this.ButtonStart);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Laba1";
            this.Text = "Laba1";
            this.SizeChanged += new System.EventHandler(this.Laba1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Laba1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Laba1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Laba1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Laba1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorComboBox)).EndInit();
            this.DateBox.ResumeLayout(false);
            this.DateBox.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TextBoxMessage_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Timer TimerProgressBar;
        private System.Windows.Forms.TextBox TextBoxStart;
        protected System.Windows.Forms.CheckBox CheckBoxPinkTheme;
        private System.Windows.Forms.CheckedListBox CheckedListBox123;
        private System.Windows.Forms.ComboBox ComboBox123;
        private System.Windows.Forms.DateTimePicker dateTimePickerGoogle;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.LinkLabel linkLabelGoogle;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolTip ExitToolTip;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ErrorProvider ErrorComboBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox DateBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem createButtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox TextBoxMessage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label labelSplitContainer1;
        private System.Windows.Forms.Label labelSplitContainer2;
        private System.Windows.Forms.Button TableButton1;
        private System.Windows.Forms.Button TableButton2;
        private System.Windows.Forms.Button TableButton3;
        private System.Windows.Forms.Button TableButton4;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideShowStartButtonToolStripMenuItem;
    }
}

