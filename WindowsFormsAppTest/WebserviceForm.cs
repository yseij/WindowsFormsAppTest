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
    public partial class WebserviceForm : MaterialForm
    {
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();
        private List<UrlData> _urlDatasByForeignKey = new List<UrlData>();

        private int selectedWebserviceId;
        private int aantalLegeUrls;

        private string urlHttp = ConfigurationManager.AppSettings["http"];

        private dynamic _result;

        WebserviceTest _webserviceTest;
        UrlTest _urltest;
        WebRequest _webRequest;
        TestRoute _testRoute;

        public WebserviceForm()
        {
            InitializeComponent();
            _webserviceTest = new WebserviceTest();
            _urltest = new UrlTest();
            _webRequest = new WebRequest();
            _testRoute = new TestRoute();
            _webServiceDatas = _webserviceTest.GetWebServiceDatas(true);
            AantalLegeUrlsTxtBx.Text = string.Empty;
        }

        private void WebserviceForm_Load(object sender, EventArgs e)
        {
            fillCmbxWebServices();
        }

        private void fillCmbxWebServices()
        {
            ComboboxTest combobox = new ComboboxTest(WebServiceCmbx);
            combobox.fillCmbBoxWebservice(_webServiceDatas);
        }

        private void TrVwAll_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void TestAllBtn_Click_1(object sender, EventArgs e)
        {
            clearBox();
            _urlDatasByForeignKey = _urltest.GetAllUrlsByForeignKeyWebservice(selectedWebserviceId);
            _testRoute.TestMoreRoutes(WebServiceCmbx.Text,
                                      TrVwAll,
                                      aantalLegeUrls,
                                      _urlDatasByForeignKey,
                                      ResponseTextBox,
                                      AantalLegeUrlsTxtBx,
                                      LegeUrlsTxtBx);
        }
        private void WebServiceCmbx_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectedWebserviceId = (int)WebServiceCmbx.SelectedValue;
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
