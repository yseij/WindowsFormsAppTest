using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Home : MaterialForm
    {
        private int _webserviceKeuzeId = 0;
        private string _webserviceKeuzeNaam = "";
        private int _klantKeuzeId = 0;
        private string _klantKeuzeNaam = "";

        private dynamic _result;

        private List<KlantData> _klantDatas = new List<KlantData>();
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();

        private List<UrlData> _urlDatasByForeignKey = new List<UrlData>();
        private List<UrlData> _urlDatasByForeignKeyKlant = new List<UrlData>();

        KlantTest _klantTest;
        WebserviceTest _webserviceTest;
        UrlTest _urltest;
        WebRequest _webRequest;
        public Home()
        {
            InitializeComponent();
            _klantTest = new KlantTest();
            _webserviceTest = new WebserviceTest();
            _urltest = new UrlTest();
            _webRequest = new WebRequest();

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

            toolStripMenuItem1.Enabled = false;

            fillKlantenDropDown();
            fillWebserviceDropDown();

            GetSettings();

            testTijdCheck();
            aanOfUitCheck();
            httpCheck();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void GetSettings()
        {
            ConfigurationManager.AppSettings["testTijd"] = Properties.Settings.Default.Tijd;
            ConfigurationManager.AppSettings["http"] = Properties.Settings.Default.SoortHttp;
            ConfigurationManager.AppSettings["testTijdAanOfUit"] = Properties.Settings.Default.AanOfUit;
            ConfigurationManager.AppSettings["opslaanLogFile"] = Properties.Settings.Default.SaveLogFilePlace;

            int klantKeuze = Properties.Settings.Default.KlantKeuze;
            if (klantKeuze != 0)
            {
                webserviceKeuzeToolStripMenuItem.Enabled = false;
                toolStripMenuItem1.Enabled = true;
                foreach (ToolStripMenuItem toolStripMenuItem in klantKeuzeToolStripMenuItem.DropDownItems)
                {
                    if ((int)toolStripMenuItem.Tag == klantKeuze)
                    {
                        toolStripMenuItem.Checked = true;
                        _klantKeuzeId = (int)toolStripMenuItem.Tag;
                        _klantKeuzeNaam = toolStripMenuItem.Text;
                    }
                    else
                    {
                        toolStripMenuItem.Checked = false;
                    }
                }
            }

            int webserviceKeuze = Properties.Settings.Default.WebserviceKeuze;
            if (webserviceKeuze != 0)
            {
                toolStripMenuItem1.Enabled = true;
                klantKeuzeToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem toolStripMenuItem in webserviceKeuzeToolStripMenuItem.DropDownItems)
                {
                    if ((int)toolStripMenuItem.Tag == webserviceKeuze)
                    {
                        toolStripMenuItem.Checked = true;
                        _webserviceKeuzeId = (int)toolStripMenuItem.Tag;
                        _webserviceKeuzeNaam = toolStripMenuItem.Text;
                    }
                    else
                    {
                        toolStripMenuItem.Checked = false;
                    }
                }
            }   
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
                Properties.Settings.Default.SaveLogFilePlace = SelectedPath;
            }
        }

        private void minToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["testTijd"] = "15";
            Properties.Settings.Default.Tijd = "15";
            testTijdCheck();
        }

        private void minToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["testTijd"] = "30";
            Properties.Settings.Default.Tijd = "30";
            testTijdCheck();
        }

        private void minToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["testTijd"] = "60";
            Properties.Settings.Default.Tijd = "60";
            testTijdCheck();
        }

        private void httpswskraancom444ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["http"] = "https://ws.kraan.com:444/";
            Properties.Settings.Default.SoortHttp = "https://ws.kraan.com:444/";
            httpCheck();
        }

        private void httpswsdevkraancomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["http"] = "https://wsdev.kraan.com/";
            Properties.Settings.Default.SoortHttp = "https://wsdev.kraan.com/";
            httpCheck();
        }

        private void aanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["testTijdAanOfUit"] = "aan";
            Properties.Settings.Default.AanOfUit = "aan";
            aanOfUitCheck();
        }

        private void uitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigurationManager.AppSettings["testTijdAanOfUit"] = "uit";
            Properties.Settings.Default.AanOfUit = "uit";
            aanOfUitCheck();
        }

        private void plaatsOpslaanLogFileToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            plaatsOpslaanLogFileToolStripMenuItem.ToolTipText = ConfigurationManager.AppSettings["opslaanLogFile"]; ;
        }

        private void testTijdCheck()
        {
            switch (ConfigurationManager.AppSettings["testTijd"])
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
            switch (ConfigurationManager.AppSettings["testTijdAanOfUit"])
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
            switch (ConfigurationManager.AppSettings["http"])
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

        private void fillKlantenDropDown()
        {
            _klantDatas = _klantTest.GetKlantData();
            foreach (KlantData klantData in _klantDatas)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Tag = klantData.Id;
                item.Text = klantData.Name;
                klantKeuzeToolStripMenuItem.DropDownItems.Add(item);

                item.Click += new EventHandler(ClickItemDropdownKlant);
            }
        }

        private void ClickItemDropdownKlant(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem toolStripMenuItem in klantKeuzeToolStripMenuItem.DropDownItems)
            {
                toolStripMenuItem.Checked = false;
            }

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (_klantKeuzeId == (int)item.Tag)
            {
                _klantKeuzeId = 0;
                webserviceKeuzeToolStripMenuItem.Enabled = true;
                toolStripMenuItem1.Enabled = false;
            }
            else
            {

                _klantKeuzeId = (int)item.Tag;
                _klantKeuzeNaam = item.Text;
                item.Checked = true;
                toolStripMenuItem1.Enabled = true;
                webserviceKeuzeToolStripMenuItem.Enabled = false;
            }
            Properties.Settings.Default.KlantKeuze = _klantKeuzeId;
        }

        private void fillWebserviceDropDown()
        {
            _webServiceDatas = _webserviceTest.GetWebServiceDatas(true);
            foreach (WebServiceData webServiceData in _webServiceDatas)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Tag = webServiceData.Id;
                item.Text = webServiceData.Name;
                webserviceKeuzeToolStripMenuItem.DropDownItems.Add(item);

                item.Click += new EventHandler(ClickItemDropdownWebservice);
            }
        }

        private void ClickItemDropdownWebservice(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem toolStripMenuItem in webserviceKeuzeToolStripMenuItem.DropDownItems)
            {
                toolStripMenuItem.Checked = false;
            }

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (_webserviceKeuzeId == (int)item.Tag)
            {
                _webserviceKeuzeId = 0;
                klantKeuzeToolStripMenuItem.Enabled = true;
                toolStripMenuItem1.Enabled = false;
            }
            else
            {
                _webserviceKeuzeId = (int)item.Tag;
                _webserviceKeuzeNaam = item.Text;
                item.Checked = true;
                toolStripMenuItem1.Enabled = true;
                klantKeuzeToolStripMenuItem.Enabled = false;
            }
            Properties.Settings.Default.WebserviceKeuze = _webserviceKeuzeId;
        }

        public void routeTest()
        {
            if (ConfigurationManager.AppSettings["testTijdAanOfUit"] == "aan")
            {
                int teller = 0;
                if (_webserviceKeuzeId != 0)
                {
                    _urlDatasByForeignKey = _urltest.GetAllUrlsByForeignKeyWebservice(_webserviceKeuzeId);
                    foreach (UrlData urlData in _urlDatasByForeignKey)
                    {
                        var data = _webRequest.GetWebRequest(urlData.Id, ConfigurationManager.AppSettings["http"], urlData.Name, urlData.SecurityId);
                        _result = JObject.Parse(data);
                        foreach (JProperty item in _result)
                        {
                            if (item.Name == "ex")
                            {
                                LogFile logFile = new LogFile();
                                if (teller == 0)
                                {
                                    teller = teller + 1;
                                    logFile.makeLogFile(_webserviceKeuzeNaam);
                                }
                                    logFile.addTextToLogFile(urlData.Name + " --> " + item.Value.ToString() + Environment.NewLine);
                            }
                        }
                    }
                }
                else if(_klantKeuzeId != 0)
                {
                    _urlDatasByForeignKeyKlant = _urltest.GetAllUrlsByForeignKeyKlant(_klantKeuzeId);
                    foreach (UrlData urlData in _urlDatasByForeignKeyKlant)
                    {
                        var data = _webRequest.GetWebRequest(urlData.Id, ConfigurationManager.AppSettings["http"], urlData.Name, urlData.SecurityId);
                        _result = JObject.Parse(data);
                        foreach (JProperty item in _result)
                        {
                            if (item.Name == "ex")
                            {
                                LogFile logFile = new LogFile();
                                if (teller == 0)
                                {
                                    teller = teller + 1;
                                    logFile.makeLogFile(_klantKeuzeNaam);
                                }
                                logFile.addTextToLogFile(urlData.Name + " --> " + item.Value.ToString() + Environment.NewLine);
                            }
                        }
                    }
                }
            } 
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
