using MaterialSkin.Controls;
using System;
using System.Collections.Generic;

namespace WindowsFormsAppTest
{
    public partial class AddUrlForm : MaterialForm
    {
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();
        private List<KlantData> _klantDatas = new List<KlantData>();

        private string _newUrl = " ";
        private string _newSecurityId = " ";
        private int _selectedWebserviceId;
        private int _selectedKlantId;

        WebserviceTest _webserviceTest;
        KlantTest _klantTest;

        private int _klantId;

        public AddUrlForm()
        {
            InitializeComponent();
            _klantId = AllKlantenForm.SetValueForKlantId;
            _webserviceTest = new WebserviceTest();
            _klantTest = new KlantTest();
            _webServiceDatas = _webserviceTest.GetWebServiceDatas(true);
            _klantDatas = _klantTest.GetKlantData();
            fillCmbxWebServices();
            fillCmbxKlanten();
        }

        private void AddUrlForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AddUrlButton_Click(object sender, EventArgs e)
        {
            UrlTest urltest = new UrlTest();
            urltest.AddUrl(_newUrl, _selectedWebserviceId, _selectedKlantId, _newSecurityId);
            Close();
        }

        private void fillCmbxWebServices()
        {
            Combobox combobox = new Combobox(WebServiceCmbx);
            combobox.fillCmbBoxWebservice(_webServiceDatas);
        }

        private void fillCmbxKlanten()
        {
            Combobox combobox = new Combobox(KlantCmbBx);
            combobox.fillCmbBoxKlant(_klantDatas);
            if (_klantId != 0)
            {
                KlantCmbBx.SelectedValue = _klantId;
            }
        }
        private void NewSecurityIdTxtBx_TextChanged(object sender, EventArgs e)
        {
            _newSecurityId = NewSecurityIdTxtBx.Text;
        }

        private void NewUrlTxtBx_TextChanged(object sender, EventArgs e)
        {
            _newUrl = NewUrlTxtBx.Text;
        }

        private void WebServiceCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedWebserviceId = (int)WebServiceCmbx.SelectedValue;
        }

        private void KlantCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedKlantId = (int)KlantCmbBx.SelectedValue;
        }
    }
}
