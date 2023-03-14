using MyLibrary.Services;
using System;
using System.Windows.Forms;

namespace MyLibrary.Forms
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            UpdateAvailableBooksListView();
            UpdateTakenBooksListView();
        }

        private async void btnTake_Click(object sender, EventArgs e)
        {
            if (listAvailableBooks.SelectedItems.Count == 1)
            {
                int id = Convert.ToInt32(listAvailableBooks.SelectedItems[0].Tag);
                if (await BookService.TakeBook(id))
                {
                    MessageBox.Show($"Enjoy new book!", "Success!");
                    UpdateAvailableBooksListView();
                    UpdateTakenBooksListView();
                }
                else
                {
                    MessageBox.Show($"Hmm.. Looks like something went wrong :(", "Failed!");
                }
            }
        }

        private async void UpdateAvailableBooksListView()
        {
            listAvailableBooks.Items.Clear();
            await foreach (var book in BookService.GetAllBooks())
            {
                if (!book.InUse)
                {
                    listAvailableBooks.Items.Add(new ListViewItem(
                        new[]
                        {
                            book.Name,
                            book.Author,
                            book.Publisher,
                            book.Year.ToString()
                        })).Tag = book.Id;
                }
            }
        }

        private async void UpdateTakenBooksListView()
        {
            listTakenBooks.Items.Clear();
            await foreach (var book in BookService.GetBooksForCurrentUser())
            {
                listTakenBooks.Items.Add(new ListViewItem(
                    new[]
                    {
                        book.Name,
                        book.Author,
                        book.Publisher,
                        book.Year.ToString()
                    })).Tag = book.Id; 
            }
        }

        private async void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (listTakenBooks.SelectedItems.Count == 1)
            {
                int id = Convert.ToInt32(listTakenBooks.SelectedItems[0].Tag);
                if (await BookService.ReturnBook(id))
                {
                    MessageBox.Show($"Now you can choose another one more book!", "Success!");
                    UpdateAvailableBooksListView();
                    UpdateTakenBooksListView();
                }
                else
                {
                    MessageBox.Show($"Hmm.. Looks like something went wrong :(", "Failed!");
                }
            }
        }
    }
}
