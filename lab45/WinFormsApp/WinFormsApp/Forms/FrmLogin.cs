using MyLibrary.Entities;
using MyLibrary.Services;
using System;
using System.Windows.Forms;

namespace MyLibrary.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (await UserService.LoginUser(txtEmail.Text.Trim(), txtPassword.Text.Trim()))
            {
                this.Hide();
                Form frm = CurrentUser.GetInstance().Role == Role.User ? new FormUser() : new FormAdmin();
                frm.FormClosed += (s, args) => this.Close();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Email adress or password is incorrect", "Login error");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            using var popup = new FormRegisterUser();
            this.Enabled = false;

            DialogResult dialogresult = popup.ShowDialog();

            this.Enabled = true;

            switch (dialogresult)
            {
                case DialogResult.OK:
                    MessageBox.Show($"Now you can sign in!", "Success");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Can't add such user.", "Error");
                    break;
            }
        }
    }
}
