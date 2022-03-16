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
        private string _confOpslaanLogFile = ConfigurationManager.AppSettings["opslaanLogFile"];
        private string _confTestTijd = ConfigurationManager.AppSettings["testTijd"];
        private string _confTestTijdAanOfUit = ConfigurationManager.AppSettings["testTijdAanOfUit"];
        private string _confHttp = ConfigurationManager.AppSettings["http"];
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

            testTijdCheck();
            aanOfUitCheck();
            httpCheck();
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
                _confOpslaanLogFile = SelectedPath;
            }
        }

        private void minToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _confTestTijd = "15";
            testTijdCheck();
        }

        private void minToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _confTestTijd = "30";
            testTijdCheck();
        }

        private void minToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _confTestTijd = "60";
            testTijdCheck();
        }

        private void httpswskraancom444ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _confHttp = "https://ws.kraan.com:444/";
            httpCheck();
        }

        private void httpswsdevkraancomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _confHttp = "https://wsdev.kraan.com/";
            httpCheck();
        }

        private void aanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _confTestTijdAanOfUit = "aan";
            aanOfUitCheck();
        }

        private void uitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _confTestTijdAanOfUit = "uit";
            aanOfUitCheck();
        }

        private void testTijdCheck()
        {
            switch (_confTestTijd)
            {
                case "15":
                    minToolStripMenuItem.Checked = true;
                    minToolStripMenuItem1.Checked = false;
                    minToolStripMenuItem2.Checked = false;
                    break;
                case "30":
                    minToolStripMenuItem.Checked = false;
                    minToolStripMenuItem1.Checked = true;
                    minToolStripMenuItem2.Checked = false;
                    break;
                case "60":
                    minToolStripMenuItem.Checked = false;
                    minToolStripMenuItem1.Checked = false;
                    minToolStripMenuItem2.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void aanOfUitCheck()
        {
            switch (_confTestTijdAanOfUit)
            {
                case "aan":
                    aanToolStripMenuItem.Checked = true;
                    uitToolStripMenuItem.Checked = false;
                    break;
                case "uit":
                    aanToolStripMenuItem.Checked = false;
                    uitToolStripMenuItem.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void httpCheck()
        {
            switch (_confHttp)
            {
                case "https://ws.kraan.com:444/":
                    httpswskraancom444ToolStripMenuItem.Checked = true;
                    httpswsdevkraancomToolStripMenuItem.Checked = false;
                    break;
                case "https://wsdev.kraan.com/":
                    httpswskraancom444ToolStripMenuItem.Checked = false;
                    httpswsdevkraancomToolStripMenuItem.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void plaatsOpslaanLogFileToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            plaatsOpslaanLogFileToolStripMenuItem.ToolTipText = _confOpslaanLogFile;
        }
    }
}
