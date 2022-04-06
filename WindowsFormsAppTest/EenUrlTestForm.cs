using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;

namespace WindowsFormsAppTest
{
    public partial class EenUrlTestForm : MaterialForm
    {
        private string url;
        private string urlHttp = "";
        private string securityId = "";

        private List<HttpData> _httpDatas = new List<HttpData>();
        private List<WebServiceData> _webserviceDatas = new List<WebServiceData>();
        private List<UrlData> _urlDatas = new List<UrlData>();

        HttpTest _httptest;
        WebserviceTest _webservicetest;
        UrlTest _urltest;
        WebRequest _webRequest;
        TestRoute _testRoute;

        public EenUrlTestForm()
        {
            InitializeComponent();
            _urltest = new UrlTest();
            _webRequest = new WebRequest();
            _testRoute = new TestRoute();
            _httptest = new HttpTest();
            _webservicetest = new WebserviceTest();

            GetHttps();
            GetWebservices();
            GetUrls();

            FillCmbxUrls();
            FillCmbxWebservice();
            FillCmbxHtpp();
        }

        private void GetHttps()
        {
            _httpDatas = _httptest.GetHttpData();
        }

        private void GetWebservices()
        {
            _webserviceDatas = _webservicetest.GetWebServiceDatas(true);
        }

        private void GetUrls()
        {
            _urlDatas = _urltest.GetUrlDatas(true);
        }

        private void FillCmbxHtpp()
        {
            HttpKrMaterialCmbx.FillCmbBoxHttp(_httpDatas);
            HttpKrMaterialCmbx.SelectedItem = ConfigurationManager.AppSettings["http"];
            urlHttp = ConfigurationManager.AppSettings["http"];
        }

        private void FillCmbxWebservice()
        {
            WebserviceKrMaterialCmbx.FillCmbBoxWebservice(_webserviceDatas);
        }

        private void FillCmbxUrls()
        {
            UrlKrMaterialCmbx.FillCmbBoxUrl(_urlDatas);
        }

        private void TestRouteBtn_Click(object sender, EventArgs e)
        {
            ClearBox();
            bool isSoap = false;
            dynamic result = null;
            foreach (WebServiceData item in _webserviceDatas)
            {
                if (item.Id == (int)WebserviceKrMaterialCmbx.SelectedValue)
                {
                    isSoap = item.Soap;
                }
            }
            if (isSoap)
            {
                string host = HttpKrMaterialCmbx.Text + WebserviceKrMaterialCmbx.Text + "/";
                ResponseTextBox.Text = _webRequest.GetWebRequestSoap(host, UrlKrMaterialCmbx.Text);
            }
            else
            {
                var data = _webRequest.GetWebRequestRest((int)WebserviceKrMaterialCmbx.SelectedValue,
                                                     HttpKrMaterialCmbx.Text,
                                                     WebserviceKrMaterialCmbx.Text,
                                                     UrlKrMaterialCmbx.Text,
                                                     securityId);
                result = JObject.Parse(data);

                _testRoute.TestOneRoute(result,
                                    textBoxWebservice,
                                    SslChckBx,
                                    SllCertificaatVervalDatumTxtBx,
                                    checkBoxKraanDLL,
                                    checkBoxKraanIni,
                                    checkBoxKraanDatabase,
                                    ResponseTextBox,
                                    WebserviceKrMaterialCmbx.Text);
            }

        }

        private void UrlKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearBox();
            if (WebserviceKrMaterialCmbx.DataSource != null)
            {
                int idOfSelected = (int)UrlKrMaterialCmbx.SelectedValue;
                UrlData urlData = _urlDatas.Find(u => u.Id == idOfSelected);
                url = urlData.Name;
                securityId = urlData.SecurityId;
            }
        }

        private void checkBoxReadOnly_Click(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = !(sender as CheckBox).Checked;
        }

        private void ClearBox()
        {
            checkBoxKraanDatabase.Checked = false;
            checkBoxKraanDLL.Checked = false;
            checkBoxKraanIni.Checked = false;
            textBoxWebservice.Text = string.Empty;
            ResponseTextBox.Text = string.Empty;
            SslChckBx.Checked = false;
            SllCertificaatVervalDatumTxtBx.Text = string.Empty;
        }
    }
}
