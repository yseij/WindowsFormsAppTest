using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AddUrlForm : Form
    {
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();

        private string _newUrl;
        private string _newSecurityId;
        private int _selectedWebserviceId;

        WebserviceTest _webserviceTest;

        public AddUrlForm()
        {
            InitializeComponent();
            _webserviceTest = new WebserviceTest();
            _webServiceDatas = _webserviceTest.GetWebServiceDatas(true);
            fillCmbxWebServices();
        }

        private void AddUrlButton_Click(object sender, EventArgs e)
        {
            UrlTest urltest = new UrlTest();
            urltest.AddUrl(_newUrl, _newSecurityId, _selectedWebserviceId);
            Close();
        }

        private void NewSecurityIdTextBox_TextChanged(object sender, EventArgs e)
        {
            _newSecurityId = NewSecurityIdTextBox.Text;
        }

        private void NewUrlTextBox_TextChanged(object sender, EventArgs e)
        {
            _newUrl = NewUrlTextBox.Text;
        }

        private void WebServiceCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedWebserviceId = (int)WebServiceCmbx.SelectedValue;
        }

        private void fillCmbxWebServices()
        {
            WebServiceCmbx.DataSource = null;
            WebServiceCmbx.DisplayMember = "Name";
            WebServiceCmbx.ValueMember = "Id";
            WebServiceCmbx.DataSource = _webServiceDatas;
        }
    }
}
