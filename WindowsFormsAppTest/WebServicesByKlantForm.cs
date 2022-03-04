using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class WebServicesByKlantForm : Form
    {
        private List<KlantData> _klantDatas = new List<KlantData>();
        private List<UrlData> _urlDatasByForeignKeyKlant = new List<UrlData>();

        private int selectedKlantId;
        private string url;
        private string urlHttp = "https://wsdev.kraan.com/";
        private string securityId = "";

        KlantTest _klantTest;
        UrlTest _urltest;
        WebRequest _webRequest;
        public WebServicesByKlantForm()
        {
            InitializeComponent();
            _klantTest = new KlantTest();
            _urltest = new UrlTest();
            _webRequest = new WebRequest();
            _klantDatas = _klantTest.GetKlantDatas(true);
        }

        private void WebServicesByKlantForm_Load(object sender, EventArgs e)
        {
            fillCmbxKlanten();
        }

        private void WebServiceCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedKlantId = (int)KlantsCmbx.SelectedValue;
        }

        private void fillCmbxKlanten()
        {
            KlantsCmbx.DataSource = null;
            KlantsCmbx.DisplayMember = "Name";
            KlantsCmbx.ValueMember = "Id";
            KlantsCmbx.DataSource = _klantDatas;
        }

        private void TestAllBtn_Click(object sender, EventArgs e)
        {
            _urlDatasByForeignKeyKlant = _urltest.GetAllUrlsByForeignKeyKlant(selectedKlantId);
            TrVwAll.Nodes.Clear();
            TrVwAll.BeginUpdate();
            foreach (UrlData urlData in _urlDatasByForeignKeyKlant)
            {
                TrVwAll.Nodes.Add(urlData.Name);
                url = urlData.Name;
                securityId = urlData.SecurityId;
                var data = _webRequest.GetWebRequest(urlData.Id, urlHttp, url, securityId);
                
                dynamic result = JObject.Parse(data);
                foreach (JProperty item in result)
                {
                    switch (item.Name)
                    {
                        case "WebserviceVersie":
                            string[] strlist = item.Value.ToString().Split(':');
                            textBoxWebservice.Text = strlist[1];
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
                        default:
                            TrVwAll.Nodes[TrVwAll.Nodes.Count - 1].Nodes.Add(item.Name + " = " + item.Value);
                            break;
                    }
                }
            }
            TrVwAll.EndUpdate();
        }

        private void checkBoxReadOnly_Click(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = !(sender as CheckBox).Checked;
        }
    }
}
