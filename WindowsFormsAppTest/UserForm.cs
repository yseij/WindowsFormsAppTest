using MaterialSkin.Controls;

namespace WindowsFormsAppTest
{
    public partial class UserForm : MaterialForm
    {
        public UserForm()
        {
            InitializeComponent();
            UserEmailTxtBx.Text = Properties.Settings.Default.Email;
        }

        private void GegevensOpslaanBtn_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.Email = UserEmailTxtBx.Text;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
