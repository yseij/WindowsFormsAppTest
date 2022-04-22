using MaterialSkin.Controls;
using System;

namespace WindowsFormsAppTest
{
    public partial class Sales31CredentialsForm : MaterialForm
    {
        public MaterialMaskedTextBox _usernameTxtBx;
        public MaterialMaskedTextBox _passwordTxtBx;
        public Sales31CredentialsForm()
        {
            InitializeComponent();
        }

        private void DoorgaanBtn_Click(object sender, EventArgs e)
        {
            _usernameTxtBx = UserNameTxtBx;
            _passwordTxtBx = PasswordTxtBx;
            Close();
        }
    }
}
