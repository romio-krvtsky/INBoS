using MyLibrary.Entities;
using MyLibrary.Services;
using System;
using System.Windows.Forms;

namespace MyLibrary.Forms
{
    public partial class FormUpdateUser : Form
    {
        public User User { get; set; }

        public FormUpdateUser(User user)
        {
            InitializeComponent();
            User = user;
            txtFrstName.Text = User.FirstName;
            txtLstName.Text = User.LastName;
            txtRegEmail.Text = User.Email;
            txtRegPass.Text = User.Password;
            listRole.SelectedItem = User.Role == Role.User ? "User" : "Admin";
            txtBirthday.Value = User.Birthday;
        }

        private async void btnUpdateUser_Click(object sender, EventArgs e)
        {
            User.FirstName = txtFrstName.Text;
            User.LastName = txtLstName.Text;
            User.Email = txtRegEmail.Text;
            User.Password = txtRegPass.Text;
            User.Role = listRole.SelectedItem.ToString().Equals("User") ? Role.User : Role.Admin;
            User.Birthday = txtBirthday.Value;
            if (!await UserService.UpdateUser(User))
            {
                btnUpdateUser.DialogResult = DialogResult.No;
            }
        }
    }
}
