﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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
            _urlDatasByForeignKey = _urltest.GetAllUrlsByForeignKeyWebservice(selectedWebserviceId);
            TrVwAll.Nodes.Clear();
            TrVwAll.BeginUpdate();
            foreach (UrlData urlData in _urlDatasByForeignKey)
            {
                TrVwAll.Nodes.Add(urlData.Name);
                url = urlData.Name;
                securityId = urlData.SecurityId;
                var data = _webRequest.GetWebRequest(urlHttp, url, securityId);
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
                            TrVwAll.Nodes[TrVwAll.Nodes.Count - 1].Nodes.Add(item.Name + " " + item.Value);
                            break;
                    }


                }
            }
            TrVwAll.EndUpdate();
        }

        private void WebServiceCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWebserviceId = (int)WebServiceCmbx.SelectedValue;
        }

        private void TrVwAll_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(TrVwAll.HitTest(TrVwAll.PointToClient(Cursor.Position)).Node);
        }
        private void checkBoxReadOnly_Click(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = !(sender as CheckBox).Checked;
        }


    }
}
