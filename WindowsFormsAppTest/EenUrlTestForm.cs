using System;
using System.Collections.Generic;
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
            _urlDatas = _urltest.GetUrlDatas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getUrls();
            fillCmbxUrls();
            fillCmbxHtpp();
        }

        private void getUrls()
        {
            _urlDatas = _urltest.GetUrlDatas(true);
        }

        private void TestRouteBtn_Click(object sender, EventArgs e)
        {
            clearBox();
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
            urlHttp = (string)HttpKrMaterialCmbx.Text;
        }

        private void UrlKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearBox();
            if (UrlKrMaterialCmbx.DataSource != null)
            {
                int idOfSelected = (int)UrlKrMaterialCmbx.SelectedValue;
                UrlData urlData = _urlDatas.Find(u => u.Id == idOfSelected);
                url = urlData.Name;
                securityId = urlData.SecurityId;
            }
        }

        private void clearBox()
        {
            checkBoxKraanDatabase.Checked = false;
            checkBoxKraanDLL.Checked = false;
            checkBoxKraanIni.Checked = false;
            textBoxWebservice.Text = string.Empty;
            ResponseTextBox.Text = string.Empty;
            SslChckBx.Checked = false;
            SllCertificaatVervalDatumTxtBx.Text = string.Empty;
        }

        private void fillCmbxUrls()
        {
            UrlKrMaterialCmbx.fillCmbBoxUrl(_urlDatas);
        }

        private void fillCmbxHtpp()
        {
            List<string> listOfNames = new List<string>()
            {
                "https://wsdev.kraan.com/",
                "https://ws.kraan.com:444/"
            };
            HttpKrMaterialCmbx.fillCmbBoxRest(listOfNames);
        }

        private void checkBoxReadOnly_Click(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = !(sender as CheckBox).Checked;
        }
    }
}
