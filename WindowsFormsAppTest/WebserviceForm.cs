using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class WebserviceForm : Form
    {
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();
        private List<UrlData> _urlDatasByForeignKey = new List<UrlData>();

        private int selectedWebserviceId;
        private string url;
        private string urlHttp = "https://wsdev.kraan.com/";
        private string securityId = "";
        private string webserviceVersie;
        private string kraanDll;
        private string kraanIni;
        private string kraanDatabase;

        private int positionKraanDll;
        private int positionKraanIni;
        private int positionDatabaseConnect;
        private int positionDatabaseMelding;

        WebserviceTest _webserviceTest;
        UrlTest _urltest;
        WebClient _wc;


        public WebserviceForm()
        {
            InitializeComponent();
            _webserviceTest = new WebserviceTest();
            _urltest = new UrlTest();
            _wc = new WebClient();
            _webServiceDatas = _webserviceTest.GetWebServiceDatas(true);
        }

        private void WebserviceForm_Load(object sender, EventArgs e)
        {
            fillCmbxWebServices();
        }

        private void fillCmbxWebServices()
        {
            WebServiceCmbx.DataSource = null;
            WebServiceCmbx.DisplayMember = "Name";
            WebServiceCmbx.ValueMember = "Id";
            WebServiceCmbx.DataSource = _webServiceDatas;
        }

        private void TrVwAll_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
        }

        private void TestAllBtn_Click(object sender, EventArgs e)
        {
            _urlDatasByForeignKey = _urltest.GetAllUrlsByForeignKey(selectedWebserviceId);
            TrVwAll.Nodes.Clear();
            TrVwAll.BeginUpdate();
            foreach (UrlData urlData in _urlDatasByForeignKey)
            {
                TrVwAll.Nodes.Add(urlData.Name);
                url = urlData.Name;
                securityId = urlData.SecurityId; 
                getWebRequest(TrVwAll.Nodes.Count);
            }
            TrVwAll.EndUpdate();
        }

        private void WebServiceCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWebserviceId = (int)WebServiceCmbx.SelectedValue;
        }

        private void getWebRequest(int laatsteNode)
        {
            string webRequestUrl;
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
                    int statusCode = (int)response.StatusCode;
                    Console.WriteLine(statusCode);
                    if (statusCode >= 100 && statusCode < 400) //Good requests
                    {
                        var data = _wc.DownloadString(uri);
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
                                TrVwAll.Nodes[laatsteNode - 1].Nodes.Add(item.Name + " " + item.Value);
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

        private void TrVwAll_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(TrVwAll.HitTest(TrVwAll.PointToClient(Cursor.Position)).Node);
        }
    }
}
