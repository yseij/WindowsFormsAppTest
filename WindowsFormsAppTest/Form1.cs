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
    public partial class Form1 : Form
    {
        private string url;
        private string urlHttp = "";
        private string securityId = "";
        private string changedUrl;
        private string webserviceVersie;
        private string kraanDll;
        private string kraanIni;
        private string kraanDatabase;

        private int positionKraanDll;
        private int positionKraanIni;
        private int positionDatabaseConnect;
        private int positionDatabaseMelding;

        private List<UrlData> _urlDatas = new List<UrlData>();

        WebClient _wc;
        UrlTest _urltest;

        public Form1()
        {
            InitializeComponent();
            _wc = new WebClient();
            _urltest = new UrlTest();
            _urlDatas = _urltest.GetUrlDatas();
        }

        private void _wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            PrgrsBrTestUrl.Value = e.ProgressPercentage;
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
            _ = getWebRequestAsync();
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
                UrlChangeTxtBx.Text = urlData.Name;
                SecurityChangeTxtBx.Text = urlData.SecurityId;
                url = UrlsCmbx.Text;
                securityId = SecurityChangeTxtBx.Text;
            }
        }

        private void UrlChangeTxtBx_TextChanged(object sender, EventArgs e)
        {
            changedUrl = UrlChangeTxtBx.Text;
        }

        private void PasUrlAanBttn_Click(object sender, EventArgs e)
        {
            clearBox();
            int selectedIndex = UrlsCmbx.SelectedIndex;
            int idOfSelected = (int)UrlsCmbx.SelectedValue;
            _urltest.UpdateUrl(idOfSelected, changedUrl, SecurityChangeTxtBx.Text);
            getUrls();
            UrlsCmbx.SelectedIndex = selectedIndex;
        }

        private void DeleteUrlButton_Click(object sender, EventArgs e)
        {
            clearBox();
            _urltest.DeleteUrl((int)UrlsCmbx.SelectedValue);
            UrlsCmbx.SelectedIndex = 0;
            getUrls();
        }

        private void AddUrlBttn_Click(object sender, EventArgs e)
        {
            var m = new Form2();
            m.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            m.Show();
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            getUrls();
        }

        private void clearBox()
        {
            checkBoxKraanDatabase.Checked = false;
            checkBoxKraanDLL.Checked = false;
            checkBoxKraanIni.Checked = false;
            textBoxWebservice.Text = string.Empty;
            ResponseTextBox.Text = string.Empty;
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

        void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            PrgrsBrTestUrl.Increment(e.ProgressPercentage);
        }

        void wb_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            PrgrsBrTestUrl.Increment(100);
        }

        private async Task getWebRequestAsync()
        {
            PrgrsBrTestUrl.Value = 0;
            string webRequestUrl ;
            if (securityId != string.Empty)
            {
                webRequestUrl = urlHttp + url + securityId;
            }
            else
            {
                webRequestUrl = urlHttp + url;
            }
            Uri uri = new Uri(webRequestUrl);
            try
            {
                HttpWebRequest request = HttpWebRequest.Create(webRequestUrl) as HttpWebRequest;

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    X509Certificate cert = request.ServicePoint.Certificate;
                    int statusCode = (int)response.StatusCode;
                    Console.WriteLine(statusCode);
                    if (statusCode >= 100 && statusCode < 400) //Good requests
                    {
                        _wc.DownloadProgressChanged += DownloadProgressChanged;
                        _wc.DownloadStringCompleted += wb_DownloadStringCompleted;
                        var data = await _wc.DownloadStringTaskAsync(uri);
                        if (data.Count(d => d == '{') > 1)
                        {
                            int Pos1 = data.IndexOf('{');
                            int Pos2 = data.IndexOf("}");
                            data = data.Substring(Pos1, Pos2 - Pos1 + 1);
                        }
                        if (securityId == string.Empty)
                        {
                            positionKraanDll = data.IndexOf("KraanDLL");
                            positionKraanIni = data.IndexOf("Kraan.ini");
                            positionDatabaseConnect = data.IndexOf("Database connectie");
                            positionDatabaseMelding = data.IndexOf("Database melding");

                            webserviceVersie = data.Substring(0, positionKraanDll);
                            kraanDll = data.Substring(positionKraanDll, positionKraanIni - positionKraanDll);
                            kraanIni = data.Substring(positionKraanIni, positionDatabaseConnect - positionKraanIni);
                            kraanDatabase = data.Substring(positionDatabaseConnect, positionDatabaseMelding - positionDatabaseConnect);

                            string[] strlist = webserviceVersie.Split(':');
                            textBoxWebservice.Text = strlist[1];

                            checkBoxKraanDLL.Checked = kraanDll.Contains("True");
                            checkBoxKraanIni.Checked = kraanIni.Contains("True");
                            checkBoxKraanDatabase.Checked = kraanDatabase.Contains("True");
                            ResponseTextBox.Text = data;
                        }
                        else
                        {
                            dynamic result = JObject.Parse(data);
                            foreach (JProperty item in result)
                            {
                                ResponseTextBox.Text = ResponseTextBox.Text + item.Name + " = " + item.Value + Environment.NewLine;
                            }
                        }
                    }
                    else if (statusCode >= 500 && statusCode <= 510) //Server Errors
                    {
                        ResponseTextBox.Text = "niet goed";
                    }
                }
            }
            catch (WebException ex)
            {
                ResponseTextBox.Text = ex.ToString();
            }
        }

        private void checkBoxReadOnly_Click(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = !(sender as CheckBox).Checked;
        }
    }
}
