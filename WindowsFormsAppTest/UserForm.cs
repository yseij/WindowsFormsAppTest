using MaterialSkin.Controls;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class UserForm : MaterialForm
    {
        private string _xmlUserName = @"D:\user.xml";

        KrXml _krXml;
        ErrorProvider _error;
        public UserForm()
        {
            InitializeComponent();
            _krXml = new KrXml();
            _error = new ErrorProvider();

            GegevensOpslaanBtn.Enabled = false;

            UserEmailTxtBx.Text = Properties.Settings.Default.Email;
        }

        private void GegevensOpslaanBtn_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.Email = UserEmailTxtBx.Text;
            Properties.Settings.Default.Save();
            _krXml.UpdateXmlFile(_xmlUserName);
            Close();
        }

        private void UserEmailTxtBx_TextChanged(object sender, System.EventArgs e)
        {
            if (UserEmailTxtBx.Text != string.Empty)
            {
                _error.Clear();
                GegevensOpslaanBtn.Enabled = true;
            }
            else
            {
                GegevensOpslaanBtn.Enabled = false;
                _error.SetError(UserEmailTxtBx, ConfigurationManager.AppSettings["LeegTekstVak"]);
            }
        }
    }
}
