using MaterialSkin.Controls;

namespace WindowsFormsAppTest
{
    public partial class UserForm : MaterialForm
    {
        KrXml _krXml;
        public UserForm()
        {
            InitializeComponent();
            _krXml = new KrXml();
            UserEmailTxtBx.Text = Properties.Settings.Default.Email;
        }

        private void GegevensOpslaanBtn_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.Email = UserEmailTxtBx.Text;
            Properties.Settings.Default.Save();
            _krXml.UpdateXmlFile();
            Close();
        }
    }
}
