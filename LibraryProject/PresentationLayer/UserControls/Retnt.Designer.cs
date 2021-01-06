namespace PresentationLayer.UserControls
{
    partial class Retnt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxJmbgUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNameUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSurnameUser = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxUserBy = new System.Windows.Forms.ComboBox();
            this.textBoxUserSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.IdBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTitleBooks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfIssue = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerReturnBooks = new System.Windows.Forms.DateTimePicker();
            this.buttonIssue = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxBooksBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBooksSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(769, 400);
            this.splitContainer1.SplitterDistance = 376;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.dataGridViewUser, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(376, 400);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JMBG,
            this.Name,
            this.Surname,
            this.Email,
            this.Password,
            this.Role});
            this.dataGridViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUser.Location = new System.Drawing.Point(3, 35);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.Size = new System.Drawing.Size(370, 322);
            this.dataGridViewUser.TabIndex = 0;
            this.dataGridViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellClick);
            // 
            // JMBG
            // 
            this.JMBG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.Name = "JMBG";
            this.JMBG.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxJmbgUser, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNameUser, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSurnameUser, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 363);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.14286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.85714F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(370, 34);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "JMBG:";
            // 
            // textBoxJmbgUser
            // 
            this.textBoxJmbgUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJmbgUser.Location = new System.Drawing.Point(64, 3);
            this.textBoxJmbgUser.MaxLength = 13;
            this.textBoxJmbgUser.Name = "textBoxJmbgUser";
            this.textBoxJmbgUser.Size = new System.Drawing.Size(55, 20);
            this.textBoxJmbgUser.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name:";
            // 
            // textBoxNameUser
            // 
            this.textBoxNameUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameUser.Location = new System.Drawing.Point(186, 3);
            this.textBoxNameUser.Name = "textBoxNameUser";
            this.textBoxNameUser.Size = new System.Drawing.Size(55, 20);
            this.textBoxNameUser.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Surname:";
            // 
            // textBoxSurnameUser
            // 
            this.textBoxSurnameUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSurnameUser.Location = new System.Drawing.Point(308, 3);
            this.textBoxSurnameUser.Name = "textBoxSurnameUser";
            this.textBoxSurnameUser.Size = new System.Drawing.Size(59, 20);
            this.textBoxSurnameUser.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.comboBoxUserBy, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxUserSearch, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(370, 26);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // comboBoxUserBy
            // 
            this.comboBoxUserBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUserBy.FormattingEnabled = true;
            this.comboBoxUserBy.Location = new System.Drawing.Point(3, 3);
            this.comboBoxUserBy.Name = "comboBoxUserBy";
            this.comboBoxUserBy.Size = new System.Drawing.Size(105, 21);
            this.comboBoxUserBy.TabIndex = 0;
            // 
            // textBoxUserSearch
            // 
            this.textBoxUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUserSearch.Location = new System.Drawing.Point(188, 3);
            this.textBoxUserSearch.Name = "textBoxUserSearch";
            this.textBoxUserSearch.Size = new System.Drawing.Size(179, 20);
            this.textBoxUserSearch.TabIndex = 1;
            this.textBoxUserSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUserSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewBooks, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(389, 400);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBook,
            this.Title,
            this.ISBN,
            this.Author,
            this.YearOfIssue,
            this.Quantity});
            this.dataGridViewBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBooks.Location = new System.Drawing.Point(3, 35);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.Size = new System.Drawing.Size(383, 322);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellClick);
            // 
            // IdBook
            // 
            this.IdBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdBook.HeaderText = "IdBook";
            this.IdBook.Name = "IdBook";
            this.IdBook.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // YearOfIssue
            // 
            this.YearOfIssue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.YearOfIssue.HeaderText = "YearOfIssue";
            this.YearOfIssue.Name = "YearOfIssue";
            this.YearOfIssue.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.477026F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.02221F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.95405F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.15849F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.06891F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66516F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.65416F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxTitleBooks, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerDateOfIssue, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerReturnBooks, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonIssue, 6, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 363);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.14286F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.85714F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(383, 34);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Title:";
            // 
            // textBoxTitleBooks
            // 
            this.textBoxTitleBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitleBooks.Location = new System.Drawing.Point(31, 3);
            this.textBoxTitleBooks.Name = "textBoxTitleBooks";
            this.textBoxTitleBooks.Size = new System.Drawing.Size(55, 20);
            this.textBoxTitleBooks.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 26);
            this.label7.TabIndex = 2;
            this.label7.Text = "Date of Issue:";
            // 
            // dateTimePickerDateOfIssue
            // 
            this.dateTimePickerDateOfIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDateOfIssue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateOfIssue.Location = new System.Drawing.Point(149, 3);
            this.dateTimePickerDateOfIssue.Name = "dateTimePickerDateOfIssue";
            this.dateTimePickerDateOfIssue.Size = new System.Drawing.Size(63, 20);
            this.dateTimePickerDateOfIssue.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "Return date:";
            // 
            // dateTimePickerReturnBooks
            // 
            this.dateTimePickerReturnBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerReturnBooks.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReturnBooks.Location = new System.Drawing.Point(264, 3);
            this.dateTimePickerReturnBooks.Name = "dateTimePickerReturnBooks";
            this.dateTimePickerReturnBooks.Size = new System.Drawing.Size(57, 20);
            this.dateTimePickerReturnBooks.TabIndex = 5;
            // 
            // buttonIssue
            // 
            this.buttonIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIssue.Location = new System.Drawing.Point(327, 3);
            this.buttonIssue.Name = "buttonIssue";
            this.buttonIssue.Size = new System.Drawing.Size(53, 20);
            this.buttonIssue.TabIndex = 6;
            this.buttonIssue.Text = "Issue";
            this.buttonIssue.UseVisualStyleBackColor = true;
            this.buttonIssue.Click += new System.EventHandler(this.buttonIssue_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.comboBoxBooksBy, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxBooksSearch, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(383, 26);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // comboBoxBooksBy
            // 
            this.comboBoxBooksBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBooksBy.FormattingEnabled = true;
            this.comboBoxBooksBy.Location = new System.Drawing.Point(3, 3);
            this.comboBoxBooksBy.Name = "comboBoxBooksBy";
            this.comboBoxBooksBy.Size = new System.Drawing.Size(108, 21);
            this.comboBoxBooksBy.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.Location = new System.Drawing.Point(140, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search:";
            // 
            // textBoxBooksSearch
            // 
            this.textBoxBooksSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBooksSearch.Location = new System.Drawing.Point(193, 3);
            this.textBoxBooksSearch.Name = "textBoxBooksSearch";
            this.textBoxBooksSearch.Size = new System.Drawing.Size(187, 20);
            this.textBoxBooksSearch.TabIndex = 0;
            this.textBoxBooksSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBooksSearch_KeyDown);
            // 
            // Retnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.splitContainer1);
          //  this.Name = "Retnt";
            this.Size = new System.Drawing.Size(769, 400);
            this.Load += new System.EventHandler(this.Retnt_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox comboBoxUserBy;
        private System.Windows.Forms.TextBox textBoxUserSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox comboBoxBooksBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBooksSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxJmbgUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNameUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSurnameUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTitleBooks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfIssue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnBooks;
        private System.Windows.Forms.Button buttonIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}
