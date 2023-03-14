using MyLibrary.Entities;
using MyLibrary.Services;
using System;
using System.Windows.Forms;

namespace MyLibrary.Forms
{
    public partial class FormRegisterUser : Form
    {
        public FormRegisterUser()
        {
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (!await UserService.RegisterUser(txtFrstName.Text,
                txtLstName.Text,
                txtRegEmail.Text,
                txtRegPass.Text,
                txtBirthday.Value,
                Role.User))
            {
                btnRegister.DialogResult = DialogResult.No;
            }
        }
    }
}
