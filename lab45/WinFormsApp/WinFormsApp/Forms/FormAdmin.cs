using MyLibrary.Entities;
using MyLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary.Forms
{
    public partial class FormAdmin : Form
    {
        private List<Book> Books { get; set; } = new List<Book>();
        private List<Author> Authors { get; set; } = new List<Author>();
        private List<Publisher> Publishers { get; set; } = new List<Publisher>();
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            listRole.SelectionMode = SelectionMode.One;
            listRole.SelectedIndex = 1;
            UpdateUsersListView();
            UpdateBooksListView();
            BindAuthorComboBox();
            BindPublisherComboBox();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (await UserService.RegisterUser(txtFrstName.Text,
                txtLstName.Text,
                txtRegEmail.Text,
                txtRegPass.Text,
                txtBirthday.Value,
                listRole.SelectedItem.ToString().Equals("User") ? Role.User : Role.Admin))
            {
                MessageBox.Show("New user has deen added!", "Success!");
                UpdateUsersListView();
            }
            else
            {
                MessageBox.Show("Can't add such user!", "Failed!");
            }
        }

        private async void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedItems.Count == 1)
            {
                int id = Convert.ToInt32(listUsers.SelectedItems[0].Text);

                if (await Helpers.DeleteUser(id))
                {
                    MessageBox.Show($"User with id = {id} was deleted!", "Success!");
                    UpdateUsersListView();
                }
                else
                {
                    MessageBox.Show("Some error occured!", "Failed!");
                }
            }
        }

        private async void UpdateUsersListView()
        {
            listUsers.Items.Clear();
            await foreach (var user in Helpers.GetAllUsers())
            {
                listUsers.Items.Add(new ListViewItem(
                    new[]
                    {
                        user.Id.ToString(),
                        $"{user.FirstName} {user.LastName}",
                        user.Email,
                        user.Password,
                        user.Role.ToString()
                    }));
            }
        }

        private async void UpdateBooksListView()
        {
            listBooks.Items.Clear();
            Books.Clear();
            await foreach (var book in BookService.GetAllBooks())
            {
                listBooks.Items.Add(new ListViewItem(
                    new[]
                    {
                        book.Id.ToString(),
                        book.Name,
                        book.Author,
                        book.Publisher,
                        book.Year.ToString(),
                        book.ISBN,
                        book.InUse.ToString()
                    }));

                Books.Add(book);
            }
        }

        private async void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedItems.Count == 1)
            {
                using var popup = new FormUpdateUser(
                    await ParseUser(Convert.ToInt32(listUsers.SelectedItems[0].Text)));
                this.Enabled = false;

                DialogResult dialogresult = popup.ShowDialog();

                this.Enabled = true;

                switch (dialogresult)
                {
                    case DialogResult.OK:
                        MessageBox.Show($"User with id = {popup.User.Id} was updated!", "Success");
                        UpdateUsersListView();
                        break;
                    case DialogResult.No:
                        MessageBox.Show("Some errors occured while attempting to update user.", "Error");
                        break;
                }
            }
        }

        private async void BindAuthorComboBox()
        {
            Authors = await Helpers.GetAllAuthors();
            var bindingSource = new BindingSource
            {
                DataSource = Authors
            };

            comboAuthors.DataSource = bindingSource.DataSource;

            comboAuthors.DisplayMember = "Name";
            comboAuthors.ValueMember = "Id";
        }

        private async void BindPublisherComboBox()
        {
            Publishers = await Helpers.GetAllPublishers();
            var bindingSource = new BindingSource
            {
                DataSource = Publishers
            };

            comboPublisher.DataSource = bindingSource.DataSource;

            comboPublisher.DisplayMember = "Name";
            comboPublisher.ValueMember = "Id";
        }

        private static async Task<User> ParseUser(int id) => await Helpers.GetUser(id);

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            if (await BookService.AddBook(
                txtBookName.Text,
                (int)comboAuthors.SelectedValue,
                (int)comboPublisher.SelectedValue,
                txtISBN.Text,
                yearPicker.Value.Year
                ))
            {
                MessageBox.Show("New book has deen added!", "Success!");
                UpdateBooksListView();
            }
            else
            {
                MessageBox.Show("Can't add such book!", "Failed!");
            }
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (listBooks.SelectedItems.Count == 1)
            {
                int id = Convert.ToInt32(listBooks.SelectedItems[0].Text);

                if (await BookService.DeleteBook(id))
                {
                    MessageBox.Show($"Book with id = {id} was deleted!", "Success!");
                    UpdateBooksListView();
                }
                else
                {
                    MessageBox.Show("Some error occured!", "Failed!");
                }
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (listBooks.SelectedItems.Count == 1)
            {
                int id = Convert.ToInt32(listBooks.SelectedItems[0].Text);
                var book = Books.FirstOrDefault(b => b.Id == id);
                using var popup = new FormUpdateBook(book,
                    Authors.Find(a => a.Name.Equals(book.Author)).Id,
                    Publishers.Find(a => a.Name.Equals(book.Publisher)).Id);
                this.Enabled = false;

                DialogResult dialogresult = popup.ShowDialog();
               
                this.Enabled = true;

                switch (dialogresult)
                {
                    case DialogResult.OK:
                        MessageBox.Show($"Book with id = {id} was updated!", "Success");
                        UpdateBooksListView();
                        break;
                    case DialogResult.No:
                        MessageBox.Show("Some errors occured while attempting to update the book.", "Error");
                        break;
                }
            }
        }

        private void listRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtLstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFrstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
