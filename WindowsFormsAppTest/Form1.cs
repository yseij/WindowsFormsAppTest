using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Form1 : Form
    {
        private string url;
        private string urlHttp = "https://wsdev.kraan.com/";
        private string selectedUrl;
        private string changedUrl;
        private string webserviceVersie;
        private string kraanDll;
        private string kraanIni;
        private string kraanDatabase;


        private int positionKraanDll;
        private int positionKraanIni;
        private int positionDatabaseConnect;
        private int positionDatabaseMelding;

        WebClient _wc;
        ArrayList _arlist;
        UrlTest _urltest;

        public Form1()
        {
            InitializeComponent();
            _wc = new WebClient();
            _arlist = new ArrayList();
            _urltest = new UrlTest();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getUrls();
            TestRouteBtn.Enabled = false;
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
            int selectedIndex = UrlsCmbx.SelectedIndex;
            var x = UrlsCmbx.SelectedItem;
            url = UrlsCmbx.SelectedItem.ToString();
            TestRouteBtn.Enabled = UrlsCmbx.SelectedIndex != -1;
            selectedUrl = url;
            UrlChangeTxtBx.Text = UrlsCmbx.SelectedItem.ToString();

            foreach (string[] item in _arlist)
            {
                if (item[1].Replace("\"", "").Equals(url))
                {
                    SecurityChangeTxtBx.Text = item[2].Replace("\"", "");
                }
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
            foreach (string[] item in _arlist)
            {
                if (item[0].Replace("\"", "").Equals(_arlist[selectedIndex]))
                {
                    _urltest.UpdateUrl(int.Parse(item[0]), changedUrl, SecurityChangeTxtBx.Text);
                }
            }
            getUrls();
            UrlsCmbx.Text = UrlsCmbx.Items[selectedIndex].ToString();
        }

        private void DeleteUrlButton_Click(object sender, EventArgs e)
        {
            foreach (string[] item in _arlist)
            {
                if (item[1].Replace("\"", "").Equals(url))
                {
                    _urltest.DeleteUrl(int.Parse(item[0]));
                    SecurityChangeTxtBx.Text = string.Empty;
                    UrlChangeTxtBx.Text = string.Empty;
                    UrlChangeTxtBx.Text = string.Empty;
                    getUrls();
                }
            }
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
            UrlsCmbx.Items.Clear();
            _arlist = _urltest.GetUrls();
            foreach (string[] item in _arlist)
            {
                UrlsCmbx.Items.Add(item[1].Replace("\"", ""));
            }
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
