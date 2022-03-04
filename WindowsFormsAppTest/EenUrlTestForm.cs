using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsAppTest
{
    public partial class EenUrlTestForm : Form
    {
        private string url;
        private string urlHttp = "";
        private string securityId = "";

        private List<UrlData> _urlDatas = new List<UrlData>();

        UrlTest _urltest;
        WebRequest _webRequest;

        public EenUrlTestForm()
        {
            InitializeComponent();
            _urltest = new UrlTest();
            _webRequest = new WebRequest();
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
            foreach (JProperty item in result)
            {
                switch (item.Name)
                {
                    case "WebserviceVersie":
                        string[] strlist = item.Value.ToString().Split(':');
                        textBoxWebservice.Text = strlist[1];
                        break;
                    case "certVerValDatum":
                        if (item.Value != null)
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
                    case "id":
                        break;
                    case "ex":
                        ResponseTextBox.Text = ResponseTextBox.Text + item.Value;
                        break;
                    default:
                        ResponseTextBox.Text = ResponseTextBox.Text + item.Name + " = " + item.Value + Environment.NewLine;
                        break;
                }
            }
        }

        private void HttpCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            urlHttp = HttpCmbx.Text;
        }

        private void UrlsCmbBx_SelectedIndexChanged(object sender, EventArgs e)
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
            HttpCmbx.SelectedIndex = 0;
        }

        private void checkBoxReadOnly_Click(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = !(sender as CheckBox).Checked;
        }
    }
}
