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

        WebserviceTest _webserviceTest;
        UrlTest _urltest;


        public WebserviceForm()
        {
            InitializeComponent();
            _webserviceTest = new WebserviceTest();
            _urltest = new UrlTest();
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
            }
            TrVwAll.EndUpdate();
        }

        private void WebServiceCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWebserviceId = (int)WebServiceCmbx.SelectedValue;
        }
    }
}
