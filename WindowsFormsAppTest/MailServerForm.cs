using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

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

            if (Properties.Settings.Default.MailServerGebruikersnaam == "///")
            {
                GebruikersnaamTxtBx.Text = string.Empty;
            }
            if (Properties.Settings.Default.MailServerWachtwoord == "///")
            {
                WachtwoordTxtBx.Text = string.Empty;
            }
            if (Properties.Settings.Default.MailVerzendenVanuitEmail == "///")
            {
                MailVerzendenVanuitEmailTxtBx.Text = string.Empty;
            }
            if (Properties.Settings.Default.MailServerNaam == "///")
            {
                ServerNaamTxtBx.Text = string.Empty;
            }
        }

        private void GegevensOpslaanBtn_Click(object sender, EventArgs e)
        {
            int mailServerPoort = 0;
            try
            {
                mailServerPoort = Int32.Parse(ServerPoortTxtBx.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("De serverpoort is geen getal");
            }
            if (ServerNaamTxtBx.Text == string.Empty || mailServerPoort == 0 || MailVerzendenVanuitEmailTxtBx.Text == string.Empty)
            {
                MessageBox.Show("De servernaam of serverpoort of mail verzenden vanuit email is leeg");
            }
            else
            {
                if (GebruikersnaamTxtBx.Text == string.Empty)
                {
                    GebruikersnaamTxtBx.Text = "///";
                }
                if (WachtwoordTxtBx.Text == string.Empty)
                {
                    WachtwoordTxtBx.Text = "///";
                }
                Properties.Settings.Default.MailServerNaam = ServerNaamTxtBx.Text;
                Properties.Settings.Default.MailServerPoort = mailServerPoort;
                Properties.Settings.Default.MailVerzendenVanuitEmail = MailVerzendenVanuitEmailTxtBx.Text;
                Properties.Settings.Default.MailServerGebruikersnaam = GebruikersnaamTxtBx.Text;
                Properties.Settings.Default.MailServerWachtwoord = WachtwoordTxtBx.Text;
                Properties.Settings.Default.Save();
                _krXml.UpdateXmlFile();
                Close();
            }
        }
    }
}
