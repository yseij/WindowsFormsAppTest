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

        private List<UrlData> _urlDatas = new List<UrlData>();

        UrlTest _urltest;
        WebRequest _webRequest;
        TestRoute _testRoute;

        public EenUrlTestForm()
        {
            InitializeComponent();
            _urltest = new UrlTest();
            _webRequest = new WebRequest();
            _testRoute = new TestRoute();

            GetUrls();
            FillCmbxUrls();
            FillCmbxHtpp();
        }

        private void GetUrls()
        {
            _urlDatas = _urltest.GetUrlDatas(true);
        }

        private void FillCmbxUrls()
        {
            UrlKrMaterialCmbx.FillCmbBoxUrl(_urlDatas);
        }

        private void FillCmbxHtpp()
        {
            List<string> listOfNames = new List<string>()
            {
                "https://wsdev.kraan.com/",
                "https://ws.kraan.com:444/"
            };
            HttpKrMaterialCmbx.FillCmbBoxRest(listOfNames);
            HttpKrMaterialCmbx.SelectedItem = ConfigurationManager.AppSettings["http"];
        }

        private void TestRouteBtn_Click(object sender, EventArgs e)
        {
            ClearBox();
            var data = _webRequest.GetWebRequest((int)UrlKrMaterialCmbx.SelectedValue, urlHttp, url, securityId);
            dynamic result = JObject.Parse(data);
            _testRoute.TestOneRoute(result,
                                    textBoxWebservice,
                                    SslChckBx,
                                    SllCertificaatVervalDatumTxtBx,
                                    checkBoxKraanDLL,
                                    checkBoxKraanIni,
                                    checkBoxKraanDatabase,
                                    ResponseTextBox,
                                    UrlKrMaterialCmbx.Text);
        }

        private void HttpKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            urlHttp = HttpKrMaterialCmbx.Text;
        }

        private void UrlKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearBox();
            if (UrlKrMaterialCmbx.DataSource != null)
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
