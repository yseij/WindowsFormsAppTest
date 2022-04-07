using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
