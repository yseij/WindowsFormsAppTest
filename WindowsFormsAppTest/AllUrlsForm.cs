using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AllUrlsForm : MaterialForm
    {
        private string changedSecurityId = "";
        private string changedUrl;
        private int _selectedWebserviceId;
        private int _selectedKlantId;
        private int _selectedHttpId;
        private int _scrollbarTeller = 0;

        private List<HttpData> _httpDatas = new List<HttpData>();
        private List<UrlData> _urlDatas = new List<UrlData>();
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();
        private List<KlantData> _klantDatas = new List<KlantData>();

        HttpTest _httpTest;
        UrlTest _urltest;
        WebRequest _webRequest;
        WebserviceTest _webserviceTest;
        KlantTest _klantTest;

        public AllUrlsForm()
        {
            InitializeComponent();
            _httpTest = new HttpTest();
            _urltest = new UrlTest();
            _webRequest = new WebRequest();
            _webserviceTest = new WebserviceTest();
            _klantTest = new KlantTest();

            _webServiceDatas = _webserviceTest.GetWebServiceData();
            _klantDatas = _klantTest.GetKlantData();
            _urlDatas = _urltest.GetUrlData();
            _httpDatas = _httpTest.GetHttpData();

            FillCmbxWebServices();
            FillCmbxKlanten();
            FillCmbxHttp();

            GetUrls();
        }

        private void GetUrls()
        {
            _urlDatas = _urltest.GetUrlData();
            FillLstBxls();
            AllUrlsKrLstBx.Select();
            AllUrlsKrLstBx.SelectedIndex = 10;
        }

        private void FillLstBxls()
        {
            AllUrlsKrLstBx.FillListBoxUrlData(_urlDatas);
            if (_urlDatas.Count > 0)
            {
                AllUrlsKrLstBx.SelectedIndex = 0;
                FillUrlData(_urlDatas[0]);
            }
        }

        private void FillCmbxWebServices()
        {
            WebserviceKrMaterialCmbx.FillCmbBoxWebservice(_webServiceDatas);
        }

        private void FillCmbxKlanten()
        {
            KlantKrMaterialCmbx.FillCmbBoxKlant(_klantDatas);
        }

        private void FillCmbxHttp()
        {
            HttpKrMaterialCmbx.FillCmbBoxHttp(_httpDatas);
        }

        private void AllUrlsKrLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearBox();
            if (AllUrlsKrLstBx.Items != null && AllUrlsKrLstBx.SelectedValue != null)
            {
                int idOfSelected = (int)AllUrlsKrLstBx.SelectedValue;
                UrlData urlData = _urlDatas.Find(u => u.Id == idOfSelected);
                foreach (var webService in _webServiceDatas)
                {
                    if (urlData.WebServiceDataId == webService.Id)
                    {
                        WebserviceKrMaterialCmbx.SelectedItem = webService;
                        WebserviceKrMaterialCmbx.Refresh();
                    }
                }
                foreach (var klant in _klantDatas)
                {
                    if (urlData.KlantDataId == klant.Id)
                    {
                        KlantKrMaterialCmbx.SelectedItem = klant;
                        KlantKrMaterialCmbx.Refresh();
                    }
                }
                foreach (var http in _httpDatas)
                {
                    if (urlData.HttpDataId == http.Id)
                    {
                        HttpKrMaterialCmbx.SelectedItem = http;
                        HttpKrMaterialCmbx.Refresh();
                    }
                }
                UrlTxtBx.Text = urlData.Name;
                SecurityIdTxtBx.Text = urlData.SecurityId;
            }
        }

        private void PasUrlAanBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = AllUrlsKrLstBx.SelectedIndex;
            int idOfSelected = (int)AllUrlsKrLstBx.SelectedValue;
            _urltest.UpdateUrl(idOfSelected, changedUrl, changedSecurityId, _selectedWebserviceId, _selectedKlantId, _selectedHttpId);
            ClearBox();
            GetUrls();
            AllUrlsKrLstBx.SelectedIndex = selectedIndex;
        }

        private void DeleteUrlBttn_Click(object sender, EventArgs e)
        {
            ClearBox();
            _urltest.DeleteUrl((int)AllUrlsKrLstBx.SelectedValue);
            AllUrlsKrLstBx.SelectedIndex = 0;
            GetUrls();
        }

        private void AddUrlBtn_Click(object sender, EventArgs e)
        {
            var m = new AddUrlForm();
            m.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            m.ShowDialog();
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            GetUrls();
        }

        private void SecurityIdTxtBx_TextChanged(object sender, EventArgs e)
        {
            changedSecurityId = SecurityIdTxtBx.Text;
        }

        private void UrlTxtBx_TextChanged(object sender, EventArgs e)
        {
            changedUrl = UrlTxtBx.Text;
        }

        private void HttpKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedHttpId = (int)HttpKrMaterialCmbx.SelectedValue;
        }

        private void WebserviceKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedWebserviceId = (int)WebserviceKrMaterialCmbx.SelectedValue;
        }

        private void KlantKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedKlantId = (int)KlantKrMaterialCmbx.SelectedValue;
        }

        private void ClearBox()
        {
            SecurityIdTxtBx.Text = string.Empty;
            UrlTxtBx.Text = string.Empty;
        }

        private void FillUrlData(UrlData urlData)
        {
            UrlTxtBx.Text = urlData.Name;
            SecurityIdTxtBx.Text = urlData.SecurityId;
            WebserviceKrMaterialCmbx.SelectedValue = urlData.WebServiceDataId;
            KlantKrMaterialCmbx.SelectedValue = urlData.KlantDataId;
            WebserviceKrMaterialCmbx.Refresh();
            KlantKrMaterialCmbx.Refresh();
        }
    }
}
