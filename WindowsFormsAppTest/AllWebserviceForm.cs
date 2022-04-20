﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AllWebserviceForm : MaterialForm
    {
        private string _changedWebservice;
        private string _changedSecurityId;
        private string _changedUrl;
        private string _zoekOpWebserviceNaam;

        private int _selectedWebserviceId;
        private int _selectedUrlId;
        private int _selectedHttpId;
        private int _selectedKlantIdForChange;
        private int _selectedWebserviceIdForChange;

        public static int SetValueForWeberviceId = 0;

        private bool _isSoap;

        private List<HttpData> _httpDatas = new List<HttpData>();
        private List<UrlData> _urlDatasByWebservice = new List<UrlData>();
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();
        private List<WebServiceData> _WebserviceDatasForChange = new List<WebServiceData>();
        private List<KlantData> _klantDatas = new List<KlantData>();

        HttpTest _httpTest;
        UrlTest _urltest;
        KlantTest _klantTest;
        WebserviceTest _webserviceTest;
        ErrorProvider _error;

        public AllWebserviceForm()
        {
            InitializeComponent();
            _httpTest = new HttpTest();
            _urltest = new UrlTest();
            _klantTest = new KlantTest();
            _webserviceTest = new WebserviceTest();
            _error = new ErrorProvider();

            GetKlanten();
            GetWebservicesIfZoekOpNaamIsLeeg();
            GetHttps();
        }

        private void GetWebservicesIfZoekOpNaamIsLeeg()
        {
            _webServiceDatas = _webserviceTest.GetWebServiceData();
            _WebserviceDatasForChange = _webserviceTest.GetWebServiceData();
            FillLstBxWebServices();
            FillCmbxWebServices();

            WebserviceTxtBx.Text = _webServiceDatas[0].Name;
            AllWebserviceKrLstBx.SelectedIndex = 0;

            GetUrlsFromWebservice(_webServiceDatas[0].Id);
        }

        private void GetWebservicesIfZoekOpNaamIsGevuld()
        {
            _webServiceDatas = _webserviceTest.GetWebServicesByWebserviceName(_zoekOpWebserviceNaam);
            _WebserviceDatasForChange = _webserviceTest.GetWebServicesByWebserviceName(_zoekOpWebserviceNaam);

            if (_webServiceDatas.Count > 0)
            {
                FillLstBxWebServices();
                FillCmbxWebServices();
                GetUrlsFromWebservice(_webServiceDatas[0].Id);
            }
            else
            {
                AllUrlsKrLstBx.ClearListBox();
                AllWebserviceKrLstBx.ClearListBox();
            }
        }

        private void GetUrlsFromWebservice(int id)
        {
            _urlDatasByWebservice = _urltest.GetAllUrlsByForeignKeyWebservice(id);
            FillLstBxUrlsFromWebservice();
        }

        private void GetKlanten()
        {
            _klantDatas = _klantTest.GetKlantData();
            FillCmbxKlanten();
        }

        private void GetHttps()
        {
            _httpDatas = _httpTest.GetHttpData();
            FillCmbxHttp();
        }

        private void FillLstBxUrlsFromWebservice()
        {
            AllUrlsKrLstBx.FillListBoxUrlData(_urlDatasByWebservice);
            if (_urlDatasByWebservice.Count > 0)
            {
                AllUrlsKrLstBx.SelectedIndex = 0;
                _selectedUrlId = _urlDatasByWebservice[0].Id;
                FillUrlData(_urlDatasByWebservice[0]);

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

        private void FillLstBxWebServices()
        {
            AllWebserviceKrLstBx.FillListBoxWebserviceData(_webServiceDatas);
            if (_webServiceDatas.Count != 0)
            {
                _selectedWebserviceId = _webServiceDatas[0].Id;
            }
        }

        private void FillCmbxWebServices()
        {
            WebserviceKrMaterialCmbx.FillCmbBoxWebservice(_WebserviceDatasForChange);
            WebserviceKrMaterialCmbx.SelectedValue = _selectedWebserviceId;
        }

        private void FillCmbxKlanten()
        {
            KlantKrMaterialCmbx.FillCmbBoxKlant(_klantDatas);
            KlantKrMaterialCmbx.SelectedValue = _klantDatas[0].Id;
        }

        private void FillCmbxHttp()
        {
            HttpKrMaterialCmbx.FillCmbBoxHttp(_httpDatas);
            HttpKrMaterialCmbx.SelectedValue = _httpDatas[0].Id;
        }

        private void AllWebserviceKrLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllWebserviceKrLstBx.Items != null && AllWebserviceKrLstBx.SelectedValue != null)
            {
                int idOfSelected = (int)AllWebserviceKrLstBx.SelectedValue;
                _selectedWebserviceId = idOfSelected;
                GetUrlsFromWebservice(idOfSelected);
                WebServiceData webServiceData = _webServiceDatas.Find(k => k.Id == idOfSelected);
                WebserviceTxtBx.Text = webServiceData.Name;
                SoapWebserviceChkBx.Checked = webServiceData.Soap;

                if (_urlDatasByWebservice.Count > 0)
                {
                    UrlData urlData = _urlDatasByWebservice[0];
                    FillUrlData(urlData);
                }
            }
        }

        private void WebserviceTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (WebserviceTxtBx.Text != string.Empty)
            {
                _error.Clear();
                PasWebserviceAanBtn.Enabled = true;
            }
            else
            {
                _error.SetError(WebserviceTxtBx, ConfigurationManager.AppSettings["LeegTekstVak"]);
                PasWebserviceAanBtn.Enabled = false;
            }
            _changedWebservice = WebserviceTxtBx.Text;
        }

        private void SoapWebserviceChkBx_CheckedChanged(object sender, EventArgs e)
        {
            _isSoap = SoapWebserviceChkBx.Checked;
        }

        private void PasWebserviceAanBtn_Click(object sender, EventArgs e)
        {
            WebServiceData webServiceData = _webServiceDatas.Find(w => w.Name == _changedWebservice);
            if (webServiceData == null)
            {
                _webserviceTest.UpdateWebService((int)AllWebserviceKrLstBx.SelectedValue, _changedWebservice, _isSoap);
                GetKlantenIfZoekOpKlantenNaamIsGevuld();
            }
            else
            {
                _error.SetError(WebserviceTxtBx, ConfigurationManager.AppSettings["BestaatAlInDb"]);
            }
        }

        private void AddWebserviceBtn_Click(object sender, EventArgs e)
        {
            var m = new AddWebserviceForm();
            m.FormClosing += new FormClosingEventHandler(ChildFormClosingAddWebserviceForm);
            m.ShowDialog();
        }

        private void DeleteWebserviceBttn_Click(object sender, EventArgs e)
        {
            _webserviceTest.DeleteWebService((int)AllWebserviceKrLstBx.SelectedValue);
            GetKlantenIfZoekOpKlantenNaamIsGevuld();
        }

        private void ChildFormClosingAddWebserviceForm(object sender, FormClosingEventArgs e)
        {
            GetKlantenIfZoekOpKlantenNaamIsGevuld();
            AllWebserviceKrLstBx.SelectedIndex = AllWebserviceKrLstBx.Items.Count - 1;
            _selectedWebserviceId = _webServiceDatas[_webServiceDatas.Count - 1].Id;
        }

        private void AllUrlsKrLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllUrlsKrLstBx.Items != null && AllUrlsKrLstBx.SelectedValue != null)
            {
                int idOfSelected = (int)AllUrlsKrLstBx.SelectedValue;
                _selectedUrlId = idOfSelected;
                UrlData urlData = _urlDatasByWebservice.Find(k => k.Id == idOfSelected);
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
            if (WebserviceKrMaterialCmbx.DataSource != null)
            {
                _selectedWebserviceIdForChange = (int)WebserviceKrMaterialCmbx.SelectedValue;
            }
        }

        private void KlantKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedKlantIdForChange = (int)KlantKrMaterialCmbx.SelectedValue;
        }

        private void AddUrlByWebserviceBttn_Click(object sender, EventArgs e)
        {
            SetValueForWeberviceId = _selectedWebserviceId;
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
            GetUrlsFromWebservice(_selectedWebserviceId);
        }

        private void DeleteUrlBttn_Click(object sender, EventArgs e)
        {
            _urltest.DeleteUrl((int)AllUrlsKrLstBx.SelectedValue);
            ClearBox();
            GetUrlsFromWebservice(_selectedWebserviceId);
        }

        private void ChildFormClosingAddUrlForm(object sender, FormClosingEventArgs e)
        {
            GetUrlsFromWebservice(SetValueForWeberviceId);
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
            if (_zoekOpWebserviceNaam != string.Empty)
            {
                GetWebservicesIfZoekOpNaamIsGevuld();
            }
            else
            {
                GetWebservicesIfZoekOpNaamIsLeeg();
            }
        }

        private void ZoekOpWebserviceNaamTxtBx_TextChanged(object sender, EventArgs e)
        {
            _zoekOpWebserviceNaam = ZoekOpWebserviceNaamTxtBx.Text;
            GetKlantenIfZoekOpKlantenNaamIsGevuld();
        }
    }
}
