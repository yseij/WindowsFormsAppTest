using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class WebServicesByKlantForm : MaterialForm
    {
        private List<KlantData> _klantDatas = new List<KlantData>();
        private List<UrlData> _urlDatasByForeignKeyKlant = new List<UrlData>();

        private int selectedKlantId;
        private int aantalLegeUrls;

        private string urlHttp = ConfigurationManager.AppSettings["http"];
        private string _filePath;

        private dynamic _result;

        KlantTest _klantTest;
        UrlTest _urltest;
        WebRequest _webRequest;
        TestRoute _testRoute;

        public WebServicesByKlantForm()
        {
            InitializeComponent();
            _klantTest = new KlantTest();
            _urltest = new UrlTest();
            _webRequest = new WebRequest();
            _testRoute = new TestRoute();
            _klantDatas = _klantTest.GetKlantData();
        }

        private void WebServicesByKlantForm_Load(object sender, EventArgs e)
        {
            fillCmbxKlanten();
        }

        private void KlantsCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedKlantId = (int)KlantsCmbx.SelectedValue;
        }

        private void fillCmbxKlanten()
        {
            KlantsCmbx.DataSource = null;
            KlantsCmbx.DisplayMember = "Name";
            KlantsCmbx.ValueMember = "Id";
            KlantsCmbx.DataSource = _klantDatas;
        }

        private void TestAllBtn_Click(object sender, EventArgs e)
        {
            clearBox();
            AantalLegeUrlsTxtBx.Text = string.Empty;
            LegeUrlsTxtBx.Text = string.Empty;
            _urlDatasByForeignKeyKlant = _urltest.GetAllUrlsByForeignKeyKlant(selectedKlantId);
            _testRoute.TestMoreRoutes(KlantsCmbx.Text,
                                      TrVwAll,
                                      aantalLegeUrls,
                                      _urlDatasByForeignKeyKlant,
                                      ResponseTextBox,
                                      AantalLegeUrlsTxtBx,
                                      LegeUrlsTxtBx);
        }

        private void TrVwAll_Click(object sender, EventArgs e)
        {
            if (!ZetLogVastChkBx.Checked)
            {
                if (TrVwAll.HitTest(TrVwAll.PointToClient(Cursor.Position)).Node.Tag != null)
                {
                    clearBox();
                    dynamic UrlData = TrVwAll.HitTest(TrVwAll.PointToClient(Cursor.Position)).Node.Tag;
                    foreach (JProperty item in UrlData)
                    {
                        if (item.Name != "id")
                        {
                            ResponseTextBox.Text = ResponseTextBox.Text + item.Name + " = " + item.Value + Environment.NewLine;
                        }
                        switch (item.Name)
                        {
                            case "WebserviceVersie":
                                string[] strlist1 = item.Value.ToString().Split(':');
                                textBoxWebservice.Text = strlist1[1];
                                break;
                            case "certVerValDatum":
                                if (item.Value.ToString() != "")
                                {
                                    SslChckBx.Checked = true;
                                    SllCertificaatVervalDatumTxtBx.Text = item.Value.ToString();
                                }
                                break;
                            case "KraanDll":
                                checkBoxKraanDLL.Checked = item.Value.ToString().Contains("True");
                                break;
                            case "KraanIni":
                                checkBoxKraanIni.Checked = item.Value.ToString().Contains("True");
                                break;
                            case "KraanDatabase":
                                checkBoxKraanDatabase.Checked = item.Value.ToString().Contains("True");
                                break;
                        }
                    }
                }
            }
        }

        private void checkBoxReadOnly_Click(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = !(sender as CheckBox).Checked;
        }

        private void clearBox()
        {
            checkBoxKraanDatabase.Checked = false;
            checkBoxKraanDLL.Checked = false;
            checkBoxKraanIni.Checked = false;
            textBoxWebservice.Text = string.Empty;
            ResponseTextBox.Text = string.Empty;
            SllCertificaatVervalDatumTxtBx.Text = string.Empty;
            SslChckBx.Checked = false;
        }
    }
}
