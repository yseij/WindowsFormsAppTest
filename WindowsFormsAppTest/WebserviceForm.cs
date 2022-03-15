using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class WebserviceForm : MaterialForm
    {
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();
        private List<UrlData> _urlDatasByForeignKey = new List<UrlData>();

        private int selectedWebserviceId;
        private int aantalLegeUrls;

        private string urlHttp = "https://ws.kraan.com:444/";
        private string _filePath;

        private dynamic _result;

        WebserviceTest _webserviceTest;
        UrlTest _urltest;
        WebRequest _webRequest;

        public WebserviceForm()
        {
            InitializeComponent();
            _webserviceTest = new WebserviceTest();
            _urltest = new UrlTest();
            _webRequest = new WebRequest();
            _webServiceDatas = _webserviceTest.GetWebServiceDatas(true);
            AantalLegeUrlsTxtBx.Text = string.Empty;
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

        private void TestAllBtn_Click_1(object sender, EventArgs e)
        {
            int teller = 0;

            _urlDatasByForeignKey = _urltest.GetAllUrlsByForeignKeyWebservice(selectedWebserviceId);
            makeLogFile();
            TrVwAll.Nodes.Clear();
            TrVwAll.BeginUpdate();
            clearBox();
            AantalLegeUrlsTxtBx.Text = string.Empty;
            LegeUrlsTxtBx.Text = string.Empty;
            aantalLegeUrls = 0;
            foreach (UrlData urlData in _urlDatasByForeignKey)
            {
                TreeNode node = new TreeNode();
                node.Text = urlData.Name;
                File.AppendAllText(_filePath, "\n");
                File.AppendAllText(_filePath, urlData.Name + "\n");
                var data = _webRequest.GetWebRequest(urlData.Id, urlHttp, urlData.Name, urlData.SecurityId);
                _result = JObject.Parse(data);
                node.Tag = _result;
                foreach (JProperty item in _result)
                {
                    if (item.Name == "ex")
                    {
                        node.ForeColor = Color.FromArgb(255, 0, 0);
                        TrVwAll.Nodes.Add(node);
                        ResponseTextBox.Text = item.Value.ToString();
                        aantalLegeUrls = aantalLegeUrls + 1;
                        AantalLegeUrlsTxtBx.Text = aantalLegeUrls.ToString();
                        LegeUrlsTxtBx.Text = LegeUrlsTxtBx.Text + " -- " + urlData.Name + Environment.NewLine;
                        File.AppendAllText(_filePath, item.Name + " = " + item.Value.ToString() + "\n");
                    }
                    else if (teller == 0)
                    {
                        TrVwAll.Nodes.Add(node);
                        teller = teller + 1;
                    }
                    else if (item.Name != "id")
                    {
                        TrVwAll.Nodes[TrVwAll.Nodes.Count - 1].Nodes.Add(item.Name + " = " + item.Value);
                        File.AppendAllText(_filePath, item.Name + " = " + item.Value.ToString() + "\n");
                    }
                }
            }
            TrVwAll.EndUpdate();
        }
        private void WebServiceCmbx_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectedWebserviceId = (int)WebServiceCmbx.SelectedValue;
        }

        private void TrVwAll_Click(object sender, EventArgs e)
        {
            if (!ZetLogVastChkBx.Checked)
            {
                if (TrVwAll.HitTest(TrVwAll.PointToClient(Cursor.Position)).Node.Tag != null)
                {
                    clearBox();
                    dynamic UrlData = TrVwAll.HitTest(TrVwAll.PointToClient(Cursor.Position)).Node.Tag;
                    foreach (JProperty item in UrlData)
                    {
                        if (item.Name != "id")
                        {
                            ResponseTextBox.Text = ResponseTextBox.Text + item.Name + " = " + item.Value + Environment.NewLine;
                        }
                        switch (item.Name)
                        {
                            case "WebserviceVersie":
                                string[] strlist1 = item.Value.ToString().Split(':');
                                textBoxWebservice.Text = strlist1[1];
                                break;
                            case "certVerValDatum":
                                if (item.Value.ToString() != "")
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
                        }
                    }
                }
            }

        }
        private void checkBoxReadOnly_Click(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = !(sender as CheckBox).Checked;
        }
        private void clearBox()
        {
            checkBoxKraanDatabase.Checked = false;
            checkBoxKraanDLL.Checked = false;
            checkBoxKraanIni.Checked = false;
            textBoxWebservice.Text = string.Empty;
            ResponseTextBox.Text = string.Empty;
            SllCertificaatVervalDatumTxtBx.Text = string.Empty;
            SslChckBx.Checked = false;
        }

        private void makeLogFile()
        {
            string time = DateTime.Now.ToLongTimeString().Replace(":", "");
            string date = DateTime.Today.ToString("d").Replace("-", "");
            _filePath = @"d:\log_van_" + WebServiceCmbx.Text.Replace("/", "") + "_op_datum_" + date + time + ".txt";
            string createText = "Log van " + WebServiceCmbx.Text + "op datum " + date + Environment.NewLine;
            File.WriteAllText(_filePath, createText);
        }
    }
}
