using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Form1 : Form
    {
        private string url;
        private string urlHttp = "https://wsdev.kraan.com/";
        private string changedUrl;
        private string selectedUrl;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            getUrls();
            httpTextBox.Text = urlHttp;
        }


        private void TestRouteBtn_Click(object sender, EventArgs e)
        {
            clearBox();
            getWebRequest();
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
            _urltest.DeleteUrl((int)UrlsCmbx.SelectedValue);

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
            UrlsCmbx.DataSource = null;
            _urlDatas = _urltest.GetUrlDatas(true);
            UrlsCmbx.DisplayMember = "Name";
            UrlsCmbx.ValueMember = "Id";
            UrlsCmbx.DataSource = _urlDatas;
        }

        private void getWebRequest()
        {
            try
            {
                HttpWebRequest request = HttpWebRequest.Create(urlHttp + url) as HttpWebRequest;

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    int statusCode = (int)response.StatusCode;
                    if (statusCode >= 100 && statusCode < 400) //Good requests
                    {
                        string data = _wc.DownloadString(urlHttp + url);
                        ResponseTextBox.Text = data;

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
