using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AddUrlForm : MaterialForm
    {
        private string _newUrl;
        private string _newSecurityId = string.Empty;

        private int _selectedWebserviceId;
        private int _selectedKlantId;
        private int _selectedHttpId;
        private int _klantId;
        private int _webserviceId;

        private int _httpId = 0;

        private List<WebService> _webServiceDatas = new List<WebService>();
        private List<Klant> _klantDatas = new List<Klant>();
        private List<HttpData> _httpDatas = new List<HttpData>();
        private List<UrlData> _urlDatas = new List<UrlData>();

        WebserviceTest _webserviceTest;
        KlantTest _klantTest;
        HttpTest _httpTest;

        ErrorProvider _error;

        public AddUrlForm()
        {
            InitializeComponent();
            _klantId = AllKlantenForm.SetValueForKlantId;
            _webserviceId = AllWebserviceForm.SetValueForWeberviceId;
            _webserviceTest = new WebserviceTest();
            _klantTest = new KlantTest();
            _httpTest = new HttpTest();
            _error = new ErrorProvider();

            _webServiceDatas = _webserviceTest.GetWebServiceData();
            _klantDatas = _klantTest.GetKlantData();

            FillCmbxWebServices();
            FillCmbxKlanten();
            FillCmbxHttp();

            AddUrlButton.Enabled = false;
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

        private void NewSecurityIdTxtBx_TextChanged(object sender, EventArgs e)
        {
            _newSecurityId = NewSecurityIdTxtBx.Text;
        }

        private void NewUrlTxtBx_TextChanged(object sender, EventArgs e)
        {
            _error.Clear();
            if (NewUrlTxtBx.Text != string.Empty)
            {
                AddUrlButton.Enabled = true;
            }
            else
            {
                AddUrlButton.Enabled = false;
            }
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
