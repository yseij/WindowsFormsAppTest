using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AllKlantenForm : MaterialForm
    {
        private string _changedKlant;
        private string _changedSecurityId;
        private string _changedUrl;
        private string _zoekOpKlantNaam;

        private int _selectedKlantId;
        private int _selectedKlantIdForChange;
        private int _selectedWebserviceIdForChange;
        private int _selectedUrlId;
        private int _selectedHttpId;

        public static int SetValueForKlantId = 0;

        private List<HttpData> _httpDatas = new List<HttpData>();
        private List<UrlData> _urlDatasByKlant = new List<UrlData>();
        private List<KlantData> _klantDatas = new List<KlantData>();
        private List<KlantData> _klantDatasForChange = new List<KlantData>();
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();

        HttpTest _httpTest;
        UrlTest _urltest;
        KlantTest _klantTest;
        WebserviceTest _webserviceTest;

        public AllKlantenForm()
        {
            InitializeComponent();
            _httpTest = new HttpTest();
            _urltest = new UrlTest();
            _klantTest = new KlantTest();
            _webserviceTest = new WebserviceTest();

            GetKlantenIfZoekOpNaamIsLeeg();
            GetWebservices();
            GetHttps();
        }

        private void GetKlantenIfZoekOpNaamIsLeeg()
        {
            _klantDatas = _klantTest.GetKlantData();
            _klantDatasForChange = _klantTest.GetKlantData();
            FillLstBxKlanten();
            FillCmbxKlanten();

            if (_klantDatas.Count != 0)
            {
                KlantTxtBx.Text = _klantDatas[0].Name;
                AllKlantKrLstBx.SelectedIndex = 0;

                GetUrlsFromKlant(_klantDatas[0].Id);
            }
        }

        private void GetKlantenIfZoekOpNaamIsGevuld()
        {
            _klantDatas = _klantTest.GetKlantDataByKlantName(_zoekOpKlantNaam);
            _klantDatasForChange = _klantTest.GetKlantData();

            if (_klantDatas.Count > 0)
            {
                FillLstBxKlanten();
                FillCmbxKlanten();
                GetUrlsFromKlant(_klantDatas[0].Id);
            }
            else
            {
                AllUrlsKrLstBx.ClearListBox();
                AllKlantKrLstBx.ClearListBox();
            }
        }

        private void GetUrlsFromKlant(int id)
        {
            _urlDatasByKlant = _urltest.GetAllUrlsByForeignKeyKlant(id);
            FillLstBxUlsFromKlant();
        }

        private void GetWebservices()
        {
            _webServiceDatas = _webserviceTest.GetWebServiceData();
            FillCmbxWebServices();
        }

        private void GetHttps()
        {
            _httpDatas = _httpTest.GetHttpData();
            FillCmbxHttp();
        }

        private void FillLstBxKlanten()
        {
            AllKlantKrLstBx.FillListBoxKlantData(_klantDatas);
            if (_klantDatas.Count != 0)
            {
                _selectedKlantId = _klantDatas[0].Id;
            }
        }

        private void FillLstBxUlsFromKlant()
        {
           AllUrlsKrLstBx.FillListBoxUrlData(_urlDatasByKlant);
           if (_urlDatasByKlant.Count > 0)
            {
                AllUrlsKrLstBx.SelectedIndex = 0;
                _selectedUrlId = _urlDatasByKlant[0].Id;
                FillUrlData(_urlDatasByKlant[0]);

                PasUrlAanBtn.Enabled = true;
                DeleteUrlBttn.Enabled = true;
            }
            else
            {
                SecurityIdTxtBx.Text = string.Empty;
                UrlTxtBx.Text = string.Empty;
                _selectedUrlId = 0;
                PasUrlAanBtn.Enabled = false;
                DeleteUrlBttn.Enabled = false;
            }
        }

        private void FillCmbxWebServices()
        {
            WebserviceKrMaterialCmbx.FillCmbBoxWebservice(_webServiceDatas);
            WebserviceKrMaterialCmbx.SelectedValue = _webServiceDatas[0].Id;
        }

        private void FillCmbxKlanten()
        {
            KlantKrMaterialCmbx.FillCmbBoxKlant(_klantDatasForChange);
            KlantKrMaterialCmbx.SelectedValue = _selectedKlantId;
        }

        private void FillCmbxHttp()
        {
            HttpKrMaterialCmbx.FillCmbBoxHttp(_httpDatas);
        }

        private void AllKlantKrLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllKlantKrLstBx.Items != null && AllKlantKrLstBx.SelectedValue != null)
            {
                int idOfSelected = (int)AllKlantKrLstBx.SelectedValue;
                _selectedKlantId = idOfSelected;
                GetUrlsFromKlant(idOfSelected);
                KlantData klantData = _klantDatas.Find(k => k.Id == idOfSelected);
                KlantTxtBx.Text = klantData.Name;

                if (_urlDatasByKlant.Count > 0)
                {
                    UrlData urlData = _urlDatasByKlant[0];
                    FillUrlData(urlData);
                }
            }
        }

        private void KlantTxtBx_TextChanged(object sender, EventArgs e)
        {
            _changedKlant = KlantTxtBx.Text;
        }

        private void AddKlantBtn_Click(object sender, EventArgs e)
        {
            var m = new AddKlantForm();
            m.FormClosing += new FormClosingEventHandler(ChildFormClosingAddKlantForm);
            m.ShowDialog();
        }

        private void PasKlantAanBtn_Click(object sender, EventArgs e)
        {
            _klantTest.UpdateKlant((int)AllKlantKrLstBx.SelectedValue, _changedKlant);
            GetKlantenIfZoekOpKlantenNaamIsGevuld();
        }

        private void DeleteKlantBttn_Click(object sender, EventArgs e)
        {
            _klantTest.DeleteKlant((int)AllKlantKrLstBx.SelectedValue);
            GetKlantenIfZoekOpKlantenNaamIsGevuld();
        }

        private void AllUrlsKrLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllUrlsKrLstBx.Items != null && AllUrlsKrLstBx.SelectedValue != null)
            {
                int idOfSelected = (int)AllUrlsKrLstBx.SelectedValue;
                _selectedUrlId = idOfSelected;
                UrlData urlData = _urlDatasByKlant.Find(k => k.Id == idOfSelected);
                FillUrlData(urlData);
            }
        }

        private void SecurityIdTxtBx_TextChanged(object sender, EventArgs e)
        {
            _changedSecurityId = SecurityIdTxtBx.Text;
        }

        private void UrlTxtBx_TextChanged(object sender, EventArgs e)
        {
            _changedUrl = UrlTxtBx.Text;
        }

        private void HttpKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedHttpId = (int)HttpKrMaterialCmbx.SelectedValue;
        }

        private void WebserviceKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedWebserviceIdForChange = (int)WebserviceKrMaterialCmbx.SelectedValue;
        }

        private void KlantKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KlantKrMaterialCmbx.DataSource != null)
            {
                _selectedKlantIdForChange = (int)KlantKrMaterialCmbx.SelectedValue;
            }
        }

        private void AddUrlByKlantBttn_Click(object sender, EventArgs e)
        {
            SetValueForKlantId = _selectedKlantId;
            var m = new AddUrlForm();
            m.FormClosing += new FormClosingEventHandler(ChildFormClosingAddUrlForm);
            m.ShowDialog();
        }

        private void PasUrlAanBtn_Click(object sender, EventArgs e)
        {
            _urltest.UpdateUrl((int)AllUrlsKrLstBx.SelectedValue,
                    _changedUrl,
                    _changedSecurityId,
                    _selectedWebserviceIdForChange,
                    _selectedKlantIdForChange,
                    _selectedHttpId);
            GetUrlsFromKlant(_selectedKlantId);
        }

        private void DeleteUrlBttn_Click(object sender, EventArgs e)
        {
            _urltest.DeleteUrl((int)AllUrlsKrLstBx.SelectedValue);
            ClearBox();
            GetUrlsFromKlant(_selectedKlantId);
        }

        private void ChildFormClosingAddKlantForm(object sender, FormClosingEventArgs e)
        {
            GetKlantenIfZoekOpKlantenNaamIsGevuld();
            AllKlantKrLstBx.SelectedIndex = AllKlantKrLstBx.Items.Count - 1;
            _selectedKlantId = _klantDatas[_klantDatas.Count - 1].Id;
        }

        private void ChildFormClosingAddUrlForm(object sender, FormClosingEventArgs e)
        {
            GetUrlsFromKlant(SetValueForKlantId);
        }

        private void FillUrlData(UrlData urlData)
        {
            UrlTxtBx.Text = urlData.Name;
            SecurityIdTxtBx.Text = urlData.SecurityId;
            HttpKrMaterialCmbx.SelectedValue = urlData.HttpDataId;
            WebserviceKrMaterialCmbx.SelectedValue = urlData.WebServiceDataId;
            KlantKrMaterialCmbx.SelectedValue = urlData.KlantDataId;
            WebserviceKrMaterialCmbx.Refresh();
            KlantKrMaterialCmbx.Refresh();
        }

        private void ClearBox()
        {
            SecurityIdTxtBx.Text = string.Empty;
            UrlTxtBx.Text = string.Empty;
        }

        private void GetKlantenIfZoekOpKlantenNaamIsGevuld()
        {
            if (_zoekOpKlantNaam != string.Empty)
            {
                GetKlantenIfZoekOpNaamIsGevuld();
            }
            else
            {
                GetKlantenIfZoekOpNaamIsLeeg();
            }
        }

        private void ZoekOpKlantNaamTxtBx_TextChanged(object sender, EventArgs e)
        {
            _zoekOpKlantNaam = ZoekOpKlantNaamTxtBx.Text;
            GetKlantenIfZoekOpKlantenNaamIsGevuld();
        }
    }
}
