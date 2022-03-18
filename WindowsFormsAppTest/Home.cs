﻿using MaterialSkin;
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
        private string _keuzeNaam = "";

        private dynamic _result;

        private List<KlantData> _klantDatas = new List<KlantData>();
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();

        private List<UrlData> _urlDatas = new List<UrlData>();

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

            ToolStripMenuItem1.Enabled = false;

            FillKlantenDropDown();
            FillWebserviceDropDown();

            GetSettings();

            TestTijdCheck();
            AanOfUitCheck();
            HttpCheck();
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
                WebserviceKeuzeToolStripMenuItem.Enabled = false;
                ToolStripMenuItem1.Enabled = true;
                foreach (ToolStripMenuItem toolStripMenuItem in KlantKeuzeToolStripMenuItem.DropDownItems)
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
                ToolStripMenuItem1.Enabled = true;
                KlantKeuzeToolStripMenuItem.Enabled = false;
                foreach (ToolStripMenuItem toolStripMenuItem in WebserviceKeuzeToolStripMenuItem.DropDownItems)
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
            var m = new WebserviceOfKlantForm(false);
            m.ShowDialog();
        }

        private void BtnKlant_Click(object sender, EventArgs e)
        {
            var m = new WebserviceOfKlantForm(true);
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

        private void PlaatsOpslaanLogFileToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void MinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("testTijd", "15");
            TestTijdCheck();
        }

        private void MinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("testTijd", "30");
            TestTijdCheck();
        }

        private void MinToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("testTijd", "60");
            TestTijdCheck();
        }

        private void Httpswskraancom444ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("http", "https://ws.kraan.com:444/");
            HttpCheck();
        }

        private void HttpswsdevkraancomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("http", "https://wsdev.kraan.com/");
            HttpCheck();
        }

        private void AanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("testTijdAanOfUit", "aan");
            AanOfUitCheck();
        }

        private void UitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZetConfEnProp("testTijdAanOfUit", "uit");
            AanOfUitCheck();
        }

        private void ZetConfEnProp(string name, string waarde)
        {
            ConfigurationManager.AppSettings[name] = waarde;
            Properties.Settings.Default.AanOfUit = waarde;
        }

        private void PlaatsOpslaanLogFileToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            plaatsOpslaanLogFileToolStripMenuItem.ToolTipText = ConfigurationManager.AppSettings["opslaanLogFile"]; ;
        }

        private void TestTijdCheck()
        {
            switch (ConfigurationManager.AppSettings["testTijd"])
            {
                case "15":
                    MinToolStripMenuItem.Checked = true;
                    MinToolStripMenuItem1.Checked = false;
                    MinToolStripMenuItem2.Checked = false;
                    break;
                case "30":
                    MinToolStripMenuItem.Checked = false;
                    MinToolStripMenuItem1.Checked = true;
                    MinToolStripMenuItem2.Checked = false;
                    break;
                case "60":
                    MinToolStripMenuItem.Checked = false;
                    MinToolStripMenuItem1.Checked = false;
                    MinToolStripMenuItem2.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void AanOfUitCheck()
        {
            switch (ConfigurationManager.AppSettings["testTijdAanOfUit"])
            {
                case "aan":
                    AanToolStripMenuItem.Checked = true;
                    UitToolStripMenuItem.Checked = false;
                    break;
                case "uit":
                    AanToolStripMenuItem.Checked = false;
                    UitToolStripMenuItem.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void HttpCheck()
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

        private void FillKlantenDropDown()
        {
            _klantDatas = _klantTest.GetKlantData();
            foreach (KlantData klantData in _klantDatas)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Tag = klantData.Id;
                item.Text = klantData.Name;
                KlantKeuzeToolStripMenuItem.DropDownItems.Add(item);

                item.Click += new EventHandler(ClickItemDropdownKlant);
            }
        }

        private void ClickItemDropdownKlant(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem toolStripMenuItem in KlantKeuzeToolStripMenuItem.DropDownItems)
            {
                toolStripMenuItem.Checked = false;
            }

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (_klantKeuzeId == (int)item.Tag)
            {
                _klantKeuzeId = 0;

                WebserviceKeuzeToolStripMenuItem.Enabled = true;
                ToolStripMenuItem1.Enabled = false;
            }
            else
            {

                _klantKeuzeId = (int)item.Tag;
                _klantKeuzeNaam = item.Text;
                item.Checked = true;

                ToolStripMenuItem1.Enabled = true;
                WebserviceKeuzeToolStripMenuItem.Enabled = false;
            }
            Properties.Settings.Default.KlantKeuze = _klantKeuzeId;
        }

        private void FillWebserviceDropDown()
        {
            _webServiceDatas = _webserviceTest.GetWebServiceDatas(true);
            foreach (WebServiceData webServiceData in _webServiceDatas)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Tag = webServiceData.Id;
                item.Text = webServiceData.Name;
                WebserviceKeuzeToolStripMenuItem.DropDownItems.Add(item);

                item.Click += new EventHandler(ClickItemDropdownWebservice);
            }
        }

        private void ClickItemDropdownWebservice(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem toolStripMenuItem in WebserviceKeuzeToolStripMenuItem.DropDownItems)
            {
                toolStripMenuItem.Checked = false;
            }

            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (_webserviceKeuzeId == (int)item.Tag)
            {
                _webserviceKeuzeId = 0;

                KlantKeuzeToolStripMenuItem.Enabled = true;
                ToolStripMenuItem1.Enabled = false;
            }
            else
            {
                _webserviceKeuzeId = (int)item.Tag;
                _webserviceKeuzeNaam = item.Text;
                item.Checked = true;

                ToolStripMenuItem1.Enabled = true;
                KlantKeuzeToolStripMenuItem.Enabled = false;
            }
            Properties.Settings.Default.WebserviceKeuze = _webserviceKeuzeId;
        }

        public void RouteTest()
        {
            if (ConfigurationManager.AppSettings["testTijdAanOfUit"] == "aan")
            {
                if (_webserviceKeuzeId != 0)
                {
                    _urlDatas = _urltest.GetAllUrlsByForeignKeyWebservice(_webserviceKeuzeId);
                    _keuzeNaam = _webserviceKeuzeNaam;


                }
                else if(_klantKeuzeId != 0)
                {
                    _urlDatas = _urltest.GetAllUrlsByForeignKeyKlant(_klantKeuzeId);
                    _keuzeNaam = _klantKeuzeNaam;
                }
                RouteTestAfterKeuze(_urlDatas, _keuzeNaam);
            } 
        }

        private void RouteTestAfterKeuze(List<UrlData> urlDatas, string keuzeNaam)
        {
            int teller = 0;
            foreach (UrlData urlData in urlDatas)
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
                            logFile.MakeLogFile(keuzeNaam);
                        }
                        logFile.AddTextToLogFile(urlData.Name + " --> " + item.Value.ToString() + Environment.NewLine);
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
