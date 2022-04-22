using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AllUrlsForm : MaterialForm
    {
        private string _changedSecurityId = string.Empty;
        private string _changedUrl;

        private int _selectedWebserviceId;
        private int _selectedKlantId;
        private int _selectedHttpId;
        private string _zoekOpUrlNaam;

        private List<HttpData> _httpDatas = new List<HttpData>();
        private List<UrlData> _urlDatas = new List<UrlData>();
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();
        private List<KlantData> _klantDatas = new List<KlantData>();

        HttpTest _httpTest;
        UrlTest _urltest;
        WebRequest _webRequest;
        WebserviceTest _webserviceTest;
        KlantTest _klantTest;
        ErrorProvider _error;

        public AllUrlsForm()
        {
            InitializeComponent();
            _httpTest = new HttpTest();
            _urltest = new UrlTest();
            _webRequest = new WebRequest();
            _webserviceTest = new WebserviceTest();
            _klantTest = new KlantTest();
            _error = new ErrorProvider();

            _webServiceDatas = _webserviceTest.GetWebServiceData();
            _klantDatas = _klantTest.GetKlantData();
            _urlDatas = _urltest.GetUrlData();
            _httpDatas = _httpTest.GetHttpData();

            FillCmbxWebServices();
            FillCmbxKlanten();
            FillCmbxHttp();

            GetUrlsIfZoekOpNaamIsLeeg();
        }

        private void GetUrlsIfZoekOpNaamIsLeeg()
        {
            _urlDatas = _urltest.GetUrlData();
            FillLstBxUrls();
        }

        private void GetUrlsIfZoekOpNaamIsGevuld()
        {
            _urlDatas = _urltest.GetUrlDataByUrlName(_zoekOpUrlNaam);

            if (_urlDatas.Count > 0)
            {
                FillLstBxUrls();
            }
            else
            {
                AllUrlsKrLstBx.ClearListBox();
            }
        }

        private void FillLstBxUrls()
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
            _urltest.UpdateUrl(idOfSelected, _changedUrl, _changedSecurityId, _selectedWebserviceId, _selectedKlantId, _selectedHttpId);
            ClearBox();
            GetUrlIfZoekOpUrlIsGevuld();
            AllUrlsKrLstBx.SelectedIndex = selectedIndex;
        }

        private void DeleteUrlBttn_Click(object sender, EventArgs e)
        {
            ClearBox();
            _urltest.DeleteUrl((int)AllUrlsKrLstBx.SelectedValue);
            AllUrlsKrLstBx.SelectedIndex = 0;
            GetUrlIfZoekOpUrlIsGevuld();
        }

        private void AddUrlBtn_Click(object sender, EventArgs e)
        {
            var m = new AddUrlForm();
            m.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            m.ShowDialog();
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            GetUrlIfZoekOpUrlIsGevuld();
        }

        private void SecurityIdTxtBx_TextChanged(object sender, EventArgs e)
        {
            _changedSecurityId = SecurityIdTxtBx.Text;
        }

        private void UrlTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (UrlTxtBx.Text != string.Empty)
            {
                _error.Clear();
                PasUrlAanBtn.Enabled = true;
            }
            else
            {
                _error.SetError(UrlTxtBx, ConfigurationManager.AppSettings["LeegTekstVak"]);
                PasUrlAanBtn.Enabled = false;
            }
            _changedUrl = UrlTxtBx.Text;
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

        private void GetUrlIfZoekOpUrlIsGevuld()
        {
            if (_zoekOpUrlNaam != string.Empty)
            {
                GetUrlsIfZoekOpNaamIsGevuld();
            }
            else
            {
                GetUrlsIfZoekOpNaamIsLeeg();
            }
        }

        private void ZoekOpUrlNaamTxtBx_TextChanged(object sender, EventArgs e)
        {
            _zoekOpUrlNaam = ZoekOpUrlNaamTxtBx.Text;
            GetUrlIfZoekOpUrlIsGevuld();
        }
    }
}
