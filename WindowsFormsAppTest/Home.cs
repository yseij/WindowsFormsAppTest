using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Home : MaterialForm
    {
        private string _opslaanLogFile => ConfigurationManager.AppSettings["opslaanLogFile"];
        public Home()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
            menuStrip.ForeColor = Color.FromArgb(0, 0, 0);
    }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void BttnUrl_Click(object sender, EventArgs e)
        {
            var m = new EenUrlTestForm();
            m.ShowDialog();
        }

        private void BttnWebservice_Click(object sender, EventArgs e)
        {
            var m = new WebserviceForm();
            m.ShowDialog();
        }

        private void BtnKlant_Click(object sender, EventArgs e)
        {
            var m = new WebServicesByKlantForm();
            m.ShowDialog();
        }

        private void BtnShowUrls_Click(object sender, EventArgs e)
        {
            var m = new AllUrlsForm();
            m.ShowDialog();
        }

        private void BtnShowWebservices_Click(object sender, EventArgs e)
        {

        }

        private void BtnShowKlanten_Click(object sender, EventArgs e)
        {
            var m = new AllKlantenForm();
            m.ShowDialog();
        }

        private void plaatsOpslaanLogFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string SelectedPath = fbd.SelectedPath;
                ConfigurationManager.AppSettings["opslaanLogFile"] = SelectedPath;
            } 
        }
    }
}
