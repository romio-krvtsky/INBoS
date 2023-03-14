
namespace MyLibrary.Forms
{
    partial class FormUpdateBook
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
            this.comboPublisher = new System.Windows.Forms.ComboBox();
            this.comboAuthors = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.yearPicker = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboPublisher
            // 
            this.comboPublisher.FormattingEnabled = true;
            this.comboPublisher.Location = new System.Drawing.Point(114, 135);
            this.comboPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.comboPublisher.Name = "comboPublisher";
            this.comboPublisher.Size = new System.Drawing.Size(206, 23);
            this.comboPublisher.TabIndex = 61;
            // 
            // comboAuthors
            // 
            this.comboAuthors.FormattingEnabled = true;
            this.comboAuthors.Location = new System.Drawing.Point(114, 96);
            this.comboAuthors.Margin = new System.Windows.Forms.Padding(2);
            this.comboAuthors.Name = "comboAuthors";
            this.comboAuthors.Size = new System.Drawing.Size(206, 23);
            this.comboAuthors.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(26, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 21);
            this.label11.TabIndex = 59;
            this.label11.Text = "Year";
            // 
            // yearPicker
            // 
            this.yearPicker.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearPicker.CustomFormat = "yyyy";
            this.yearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearPicker.Location = new System.Drawing.Point(114, 175);
            this.yearPicker.MaxDate = new System.DateTime(2021, 9, 28, 0, 0, 0, 0);
            this.yearPicker.MinDate = new System.DateTime(1753, 1, 25, 0, 0, 0, 0);
            this.yearPicker.Name = "yearPicker";
            this.yearPicker.ShowUpDown = true;
            this.yearPicker.Size = new System.Drawing.Size(206, 23);
            this.yearPicker.TabIndex = 58;
            this.yearPicker.Value = new System.DateTime(2021, 9, 28, 0, 0, 0, 0);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdateBook.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateBook.Location = new System.Drawing.Point(220, 258);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(100, 37);
            this.btnUpdateBook.TabIndex = 57;
            this.btnUpdateBook.Text = "Update";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(26, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 21);
            this.label12.TabIndex = 56;
            this.label12.Text = "Publisher";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(26, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 21);
            this.label13.TabIndex = 55;
            this.label13.Text = "ISBN";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(159, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 25);
            this.label14.TabIndex = 54;
            this.label14.Text = "UpdateBook";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(26, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 21);
            this.label15.TabIndex = 53;
            this.label15.Text = "Author";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(26, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 21);
            this.label16.TabIndex = 52;
            this.label16.Text = "Name";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(114, 217);
            this.txtISBN.MaxLength = 10;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(206, 23);
            this.txtISBN.TabIndex = 51;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(114, 57);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(206, 23);
            this.txtBookName.TabIndex = 50;
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelUpdate.Location = new System.Drawing.Point(114, 258);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(100, 37);
            this.btnCancelUpdate.TabIndex = 62;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            // 
            // FormUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 365);
            this.Controls.Add(this.btnCancelUpdate);
            this.Controls.Add(this.comboPublisher);
            this.Controls.Add(this.comboAuthors);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.yearPicker);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtBookName);
            this.Name = "FormUpdateBook";
            this.Text = "FormUpdateBook";
            this.Load += new System.EventHandler(this.FormUpdateBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPublisher;
        private System.Windows.Forms.ComboBox comboAuthors;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker yearPicker;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btnCancelUpdate;
    }
}