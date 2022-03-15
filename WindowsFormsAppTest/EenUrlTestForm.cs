using System;
using System.Collections.Generic;
using System.Windows.Forms;
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

        private void TestRouteBtn_Click(object sender, EventArgs e)
        {
            clearBox();
            var data = _webRequest.GetWebRequest((int)UrlsCmbx.SelectedValue, urlHttp, url, securityId);
            dynamic result = JObject.Parse(data);
            _testRoute.testRoute(result,
                                 textBoxWebservice,
                                 SslChckBx,
                                 SllCertificaatVervalDatumTxtBx,
                                 checkBoxKraanDLL,
                                 checkBoxKraanIni,
                                 checkBoxKraanDatabase,
                                 ResponseTextBox,
                                 UrlsCmbx.Text);
        }

        private void HttpCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            urlHttp = HttpCmbx.Text;
        }

        private void UrlsCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearBox();
            if (UrlsCmbx.DataSource != null)
            {
                int idOfSelected = (int)UrlsCmbx.SelectedValue;
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

        private void getUrls()
        {
            _urlDatas = _urltest.GetUrlDatas(true);
        }

        private void fillCmbxUrls()
        {
            UrlsCmbx.DataSource = null;
            UrlsCmbx.DisplayMember = "Name";
            UrlsCmbx.ValueMember = "Id";
            UrlsCmbx.DataSource = _urlDatas;
        }

        private void fillCmbxHtpp()
        {
            HttpCmbx.Items.Clear();
            HttpCmbx.Items.Add("https://wsdev.kraan.com/");
            HttpCmbx.Items.Add("https://ws.kraan.com:444/");
            HttpCmbx.Items.Add("http://");
            HttpCmbx.Items.Add("https://");
            HttpCmbx.SelectedIndex = 0;
        }

        private void checkBoxReadOnly_Click(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = !(sender as CheckBox).Checked;
        }
    }
}
