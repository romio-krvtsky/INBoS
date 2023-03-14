
namespace MyLibrary.Forms
{
    partial class FormAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.comboPublisher = new System.Windows.Forms.ComboBox();
            this.comboAuthors = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.yearPicker = new System.Windows.Forms.DateTimePicker();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBooks = new System.Windows.Forms.ListView();
            this.clmnBookId = new System.Windows.Forms.ColumnHeader();
            this.clmnBookName = new System.Windows.Forms.ColumnHeader();
            this.clmnAuthor = new System.Windows.Forms.ColumnHeader();
            this.clmnPublisher = new System.Windows.Forms.ColumnHeader();
            this.clmnYear = new System.Windows.Forms.ColumnHeader();
            this.clmnISBN = new System.Windows.Forms.ColumnHeader();
            this.clmnInUse = new System.Windows.Forms.ColumnHeader();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listUsers = new System.Windows.Forms.ListView();
            this.clmnId = new System.Windows.Forms.ColumnHeader();
            this.clmnName = new System.Windows.Forms.ColumnHeader();
            this.clmnEmail = new System.Windows.Forms.ColumnHeader();
            this.clmnPass = new System.Windows.Forms.ColumnHeader();
            this.clmnRole = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.listRole = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLstName = new System.Windows.Forms.TextBox();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.txtRegPass = new System.Windows.Forms.TextBox();
            this.txtFrstName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(17, 20);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1280, 765);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUpdateBook);
            this.tabPage1.Controls.Add(this.btnDeleteBook);
            this.tabPage1.Controls.Add(this.comboPublisher);
            this.tabPage1.Controls.Add(this.comboAuthors);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.yearPicker);
            this.tabPage1.Controls.Add(this.btnAddBook);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.txtISBN);
            this.tabPage1.Controls.Add(this.txtBookName);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.listBooks);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1272, 727);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateBook.Location = new System.Drawing.Point(9, 527);
            this.btnUpdateBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(143, 62);
            this.btnUpdateBook.TabIndex = 51;
            this.btnUpdateBook.Text = "Update";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteBook.Location = new System.Drawing.Point(179, 527);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(143, 62);
            this.btnDeleteBook.TabIndex = 50;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // comboPublisher
            // 
            this.comboPublisher.FormattingEnabled = true;
            this.comboPublisher.Location = new System.Drawing.Point(990, 228);
            this.comboPublisher.Name = "comboPublisher";
            this.comboPublisher.Size = new System.Drawing.Size(268, 33);
            this.comboPublisher.TabIndex = 49;
            // 
            // comboAuthors
            // 
            this.comboAuthors.FormattingEnabled = true;
            this.comboAuthors.Location = new System.Drawing.Point(990, 163);
            this.comboAuthors.Name = "comboAuthors";
            this.comboAuthors.Size = new System.Drawing.Size(268, 33);
            this.comboAuthors.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(840, 295);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 32);
            this.label11.TabIndex = 45;
            this.label11.Text = "Year";
            // 
            // yearPicker
            // 
            this.yearPicker.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearPicker.CustomFormat = "yyyy";
            this.yearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearPicker.Location = new System.Drawing.Point(990, 295);
            this.yearPicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yearPicker.MaxDate = new System.DateTime(2021, 9, 28, 0, 0, 0, 0);
            this.yearPicker.MinDate = new System.DateTime(1753, 1, 25, 0, 0, 0, 0);
            this.yearPicker.Name = "yearPicker";
            this.yearPicker.ShowUpDown = true;
            this.yearPicker.Size = new System.Drawing.Size(268, 31);
            this.yearPicker.TabIndex = 44;
            this.yearPicker.Value = new System.DateTime(2021, 9, 28, 0, 0, 0, 0);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddBook.Location = new System.Drawing.Point(1053, 433);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(143, 62);
            this.btnAddBook.TabIndex = 43;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(840, 232);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 32);
            this.label12.TabIndex = 42;
            this.label12.Text = "Publisher";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(840, 362);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 32);
            this.label13.TabIndex = 41;
            this.label13.Text = "ISBN";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(1004, 28);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(189, 36);
            this.label14.TabIndex = 40;
            this.label14.Text = "Add new book";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(840, 163);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 32);
            this.label15.TabIndex = 39;
            this.label15.Text = "Author";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(840, 98);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 32);
            this.label16.TabIndex = 38;
            this.label16.Text = "Name";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(990, 365);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtISBN.MaxLength = 10;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(268, 31);
            this.txtISBN.TabIndex = 35;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(990, 98);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(268, 31);
            this.txtBookName.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(360, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 36);
            this.label9.TabIndex = 27;
            this.label9.Text = "Books";
            // 
            // listBooks
            // 
            this.listBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnBookId,
            this.clmnBookName,
            this.clmnAuthor,
            this.clmnPublisher,
            this.clmnYear,
            this.clmnISBN,
            this.clmnInUse});
            this.listBooks.FullRowSelect = true;
            this.listBooks.GridLines = true;
            this.listBooks.HideSelection = false;
            this.listBooks.Location = new System.Drawing.Point(9, 77);
            this.listBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBooks.MultiSelect = false;
            this.listBooks.Name = "listBooks";
            this.listBooks.Size = new System.Drawing.Size(767, 416);
            this.listBooks.TabIndex = 0;
            this.listBooks.UseCompatibleStateImageBehavior = false;
            this.listBooks.View = System.Windows.Forms.View.Details;
            // 
            // clmnBookId
            // 
            this.clmnBookId.Text = "Id";
            this.clmnBookId.Width = 65;
            // 
            // clmnBookName
            // 
            this.clmnBookName.Text = "Name";
            this.clmnBookName.Width = 160;
            // 
            // clmnAuthor
            // 
            this.clmnAuthor.Text = "Author";
            this.clmnAuthor.Width = 160;
            // 
            // clmnPublisher
            // 
            this.clmnPublisher.Text = "Publisher";
            this.clmnPublisher.Width = 160;
            // 
            // clmnYear
            // 
            this.clmnYear.Text = "Year";
            this.clmnYear.Width = 65;
            // 
            // clmnISBN
            // 
            this.clmnISBN.Text = "ISBN";
            this.clmnISBN.Width = 75;
            // 
            // clmnInUse
            // 
            this.clmnInUse.Text = "In use";
            this.clmnInUse.Width = 70;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUpdateUser);
            this.tabPage2.Controls.Add(this.btnDeleteUser);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.listUsers);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.listRole);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtBirthday);
            this.tabPage2.Controls.Add(this.btnRegister);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtLstName);
            this.tabPage2.Controls.Add(this.txtRegEmail);
            this.tabPage2.Controls.Add(this.txtRegPass);
            this.tabPage2.Controls.Add(this.txtFrstName);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1272, 727);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Users";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateUser.Location = new System.Drawing.Point(931, 485);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(143, 62);
            this.btnUpdateUser.TabIndex = 37;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteUser.Location = new System.Drawing.Point(1101, 485);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(143, 62);
            this.btnDeleteUser.TabIndex = 36;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(807, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 36);
            this.label8.TabIndex = 35;
            this.label8.Text = "All users";
            // 
            // listUsers
            // 
            this.listUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnId,
            this.clmnName,
            this.clmnEmail,
            this.clmnPass,
            this.clmnRole});
            this.listUsers.FullRowSelect = true;
            this.listUsers.GridLines = true;
            this.listUsers.HideSelection = false;
            this.listUsers.Location = new System.Drawing.Point(513, 83);
            this.listUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listUsers.MultiSelect = false;
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(751, 374);
            this.listUsers.TabIndex = 34;
            this.listUsers.UseCompatibleStateImageBehavior = false;
            this.listUsers.View = System.Windows.Forms.View.Details;
            // 
            // clmnId
            // 
            this.clmnId.Text = "Id";
            this.clmnId.Width = 65;
            // 
            // clmnName
            // 
            this.clmnName.Text = "Name";
            this.clmnName.Width = 200;
            // 
            // clmnEmail
            // 
            this.clmnEmail.Text = "Email";
            this.clmnEmail.Width = 200;
            // 
            // clmnPass
            // 
            this.clmnPass.Text = "Password";
            this.clmnPass.Width = 180;
            // 
            // clmnRole
            // 
            this.clmnRole.Text = "Role";
            this.clmnRole.Width = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 403);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Role";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listRole
            // 
            this.listRole.FormattingEnabled = true;
            this.listRole.ItemHeight = 25;
            this.listRole.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.listRole.Location = new System.Drawing.Point(169, 403);
            this.listRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listRole.Name = "listRole";
            this.listRole.Size = new System.Drawing.Size(268, 54);
            this.listRole.TabIndex = 32;
            this.listRole.SelectedIndexChanged += new System.EventHandler(this.listRole_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 220);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "Birthday";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBirthday
            // 
            this.txtBirthday.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBirthday.Location = new System.Drawing.Point(169, 220);
            this.txtBirthday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBirthday.MaxDate = new System.DateTime(2021, 9, 28, 0, 0, 0, 0);
            this.txtBirthday.MinDate = new System.DateTime(1900, 12, 25, 0, 0, 0, 0);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(268, 31);
            this.txtBirthday.TabIndex = 30;
            this.txtBirthday.Value = new System.DateTime(2021, 9, 28, 0, 0, 0, 0);
            this.txtBirthday.ValueChanged += new System.EventHandler(this.txtBirthday_ValueChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Location = new System.Drawing.Point(231, 485);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(143, 62);
            this.btnRegister.TabIndex = 29;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 285);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 32);
            this.label5.TabIndex = 28;
            this.label5.Text = "Email adress";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 32);
            this.label4.TabIndex = 27;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(184, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 36);
            this.label3.TabIndex = 26;
            this.label3.Text = "Register new user";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 32);
            this.label6.TabIndex = 25;
            this.label6.Text = "Last name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 32);
            this.label7.TabIndex = 24;
            this.label7.Text = "First name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtLstName
            // 
            this.txtLstName.Location = new System.Drawing.Point(169, 152);
            this.txtLstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLstName.Name = "txtLstName";
            this.txtLstName.Size = new System.Drawing.Size(268, 31);
            this.txtLstName.TabIndex = 23;
            this.txtLstName.TextChanged += new System.EventHandler(this.txtLstName_TextChanged);
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Location = new System.Drawing.Point(169, 285);
            this.txtRegEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(268, 31);
            this.txtRegEmail.TabIndex = 22;
            this.txtRegEmail.TextChanged += new System.EventHandler(this.txtRegEmail_TextChanged);
            // 
            // txtRegPass
            // 
            this.txtRegPass.Location = new System.Drawing.Point(169, 355);
            this.txtRegPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegPass.Name = "txtRegPass";
            this.txtRegPass.Size = new System.Drawing.Size(268, 31);
            this.txtRegPass.TabIndex = 21;
            this.txtRegPass.TextChanged += new System.EventHandler(this.txtRegPass_TextChanged);
            // 
            // txtFrstName
            // 
            this.txtFrstName.Location = new System.Drawing.Point(169, 83);
            this.txtFrstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFrstName.Name = "txtFrstName";
            this.txtFrstName.Size = new System.Drawing.Size(268, 31);
            this.txtFrstName.TabIndex = 20;
            this.txtFrstName.TextChanged += new System.EventHandler(this.txtFrstName_TextChanged);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 805);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAdmin";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLstName;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.TextBox txtRegPass;
        private System.Windows.Forms.TextBox txtFrstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtBirthday;
        private System.Windows.Forms.ListBox listRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listUsers;
        private System.Windows.Forms.ColumnHeader clmnId;
        private System.Windows.Forms.ColumnHeader clmnName;
        private System.Windows.Forms.ColumnHeader clmnEmail;
        private System.Windows.Forms.ColumnHeader clmnPass;
        private System.Windows.Forms.ColumnHeader clmnRole;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.ListView listBooks;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader clmnBookId;
        private System.Windows.Forms.ColumnHeader clmnBookName;
        private System.Windows.Forms.ColumnHeader clmnAuthor;
        private System.Windows.Forms.ColumnHeader clmnPublisher;
        private System.Windows.Forms.ColumnHeader clmnYear;
        private System.Windows.Forms.ColumnHeader clmnISBN;
        private System.Windows.Forms.ColumnHeader clmnInUse;
        private System.Windows.Forms.ComboBox comboAuthors;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker yearPicker;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.ComboBox comboPublisher;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
    }
}