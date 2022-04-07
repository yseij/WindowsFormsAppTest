using MaterialSkin.Controls;
using System;
using System.Collections.Generic;

namespace WindowsFormsAppTest
{
    public partial class AddUrlForm : MaterialForm
    {
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();
        private List<KlantData> _klantDatas = new List<KlantData>();
        private List<HttpData> _httpDatas = new List<HttpData>();

        private string _newUrl = " ";
        private string _newSecurityId = " ";
        private int _selectedWebserviceId;
        private int _selectedKlantId;
        private int _selectedHttpId;

        WebserviceTest _webserviceTest;
        KlantTest _klantTest;
        HttpTest _httpTest;

        private int _klantId;
        private int _webserviceId;
        private int _httpId;

        public AddUrlForm()
        {
            InitializeComponent();
            _klantId = AllKlantenForm.SetValueForKlantId;
            _webserviceId = AllWebserviceForm.SetValueForWeberviceId;
            _webserviceTest = new WebserviceTest();
            _klantTest = new KlantTest();
            _webServiceDatas = _webserviceTest.GetWebServiceDatas(true);
            _klantDatas = _klantTest.GetKlantData();
            _httpDatas = _httpTest.GetHttpData();

            FillCmbxWebServices();
            FillCmbxKlanten();
            FillCmbxHttp();
        }

        private void FillCmbxWebServices()
        {
            WebserviceKrMaterialCmbx.FillCmbBoxWebservice(_webServiceDatas);
            if (_webserviceId != 0)
            {
                WebserviceKrMaterialCmbx.SelectedValue = _webserviceId;
            }
        }

        private void FillCmbxKlanten()
        {
            KlantenKrMaterialCmbx.FillCmbBoxKlant(_klantDatas);
            if (_klantId != 0)
            {
                KlantenKrMaterialCmbx.SelectedValue = _klantId;
            }
        }

        private void FillCmbxHttp()
        {
            HttpkrMaterialCmbbx.FillCmbBoxHttp(_httpDatas);
            if (_httpId != 0)
            {
                HttpkrMaterialCmbbx.SelectedValue = _httpId;
            }
        }

        private void AddUrlButton_Click(object sender, EventArgs e)
        {
            UrlTest urltest = new UrlTest();
            urltest.AddUrl(_newUrl, _selectedWebserviceId, _selectedKlantId, _newSecurityId, _selectedHttpId);
            Close();
        }

        private void NewSecurityIdTxtBx_TextChanged(object sender, EventArgs e)
        {
            _newSecurityId = NewSecurityIdTxtBx.Text;
        }

        private void NewUrlTxtBx_TextChanged(object sender, EventArgs e)
        {
            _newUrl = NewUrlTxtBx.Text;
        }

        private void WebserviceKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedWebserviceId = (int)WebserviceKrMaterialCmbx.SelectedValue;
        }

        private void KlantenKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedKlantId = (int)KlantenKrMaterialCmbx.SelectedValue;
        }

        private void HttpkrMaterialCmbbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedHttpId = (int)HttpkrMaterialCmbbx.SelectedValue;
        }
    }
}
