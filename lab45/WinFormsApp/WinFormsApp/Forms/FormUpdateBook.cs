using MyLibrary.Entities;
using MyLibrary.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary.Forms
{
    public partial class FormUpdateBook : Form
    {
        private Book Book { get; set; }
        private int AuthorId { get; set; }
        private int PublisherId { get; set; }

        public FormUpdateBook(Book book, int authorId, int publisherId)
        {
            InitializeComponent();
            Book = book;
            AuthorId = authorId;
            PublisherId = publisherId;
            txtBookName.Text = Book.Name;
            txtISBN.Text = Book.ISBN;
            yearPicker.Value = new DateTime(Book.Year, 1, 1);
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            Book.Name = txtBookName.Text;
            Book.ISBN = txtISBN.Text;
            Book.Year = yearPicker.Value.Year;

            AuthorId = (int)comboAuthors.SelectedValue;
            PublisherId = (int)comboPublisher.SelectedValue;
            
            if (!await BookService.UpdateBook(Book.Id, Book.Name, AuthorId, PublisherId, Book.ISBN, Book.Year))
            {
                btnUpdateBook.DialogResult = DialogResult.No;
            }
        }

        private async Task BindAuthorComboBox()
        {
            var bindingSource = new BindingSource
            {
                DataSource = await Helpers.GetAllAuthors()
            };

            comboAuthors.DataSource = bindingSource.DataSource;

            comboAuthors.DisplayMember = "Name";
            comboAuthors.ValueMember = "Id";
        }

        private async Task BindPublisherComboBox()
        {
            var bindingSource = new BindingSource
            {
                DataSource = await Helpers.GetAllPublishers()
            };

            comboPublisher.DataSource = bindingSource.DataSource;

            comboPublisher.DisplayMember = "Name";
            comboPublisher.ValueMember = "Id";
        }

        private async void FormUpdateBook_Load(object sender, EventArgs e)
        {
            await BindAuthorComboBox();
            await BindPublisherComboBox();
            comboAuthors.SelectedValue = AuthorId;
            comboPublisher.SelectedValue = PublisherId;
        }
    }
}
