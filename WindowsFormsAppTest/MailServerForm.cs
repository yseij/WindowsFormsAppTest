using MaterialSkin.Controls;
using System;

namespace WindowsFormsAppTest
{
    public partial class MailServerForm : MaterialForm
    {
        KrXml _krXml;
        public MailServerForm()
        {
            InitializeComponent();
            _krXml = new KrXml();
            ServerNaamTxtBx.Text = Properties.Settings.Default.MailServerNaam;
            ServerPoortTxtBx.Text = Properties.Settings.Default.MailServerPoort.ToString();
            MailVerzendenVanuitEmailTxtBx.Text = Properties.Settings.Default.MailVerzendenVanuitEmail;
            GebruikersnaamTxtBx.Text = Properties.Settings.Default.MailServerGebruikersnaam;
            WachtwoordTxtBx.Text = Properties.Settings.Default.MailServerWachtwoord;
        }

        private void GegevensOpslaanBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MailServerNaam = ServerNaamTxtBx.Text;
            Properties.Settings.Default.MailServerPoort = Int32.Parse(ServerPoortTxtBx.Text);
            Properties.Settings.Default.MailVerzendenVanuitEmail = MailVerzendenVanuitEmailTxtBx.Text;
            Properties.Settings.Default.MailServerGebruikersnaam = GebruikersnaamTxtBx.Text;
            Properties.Settings.Default.MailServerWachtwoord = WachtwoordTxtBx.Text;
            Properties.Settings.Default.Save();
            _krXml.UpdateXmlFile();
            Close();
        }
    }
}
