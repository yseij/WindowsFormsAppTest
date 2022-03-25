using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AllWebserviceForm : MaterialForm
    {
        private string _changedWebservice = "";
        private string _changedSecurityId = "";
        private string _changedUrl = "";
        private string _zoekOpWebserviceNaam = "";
        private int _selectedWebserviceId;
        private int _selectedUrlId;
        private int _selectedKlantIdForChange;
        private int _selectedWebserviceIdForChange;

        private List<UrlData> _urlDatasByWebservice = new List<UrlData>();
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();
        private List<WebServiceData> _WebserviceDatasForChange = new List<WebServiceData>();
        private List<KlantData> _klantDatas = new List<KlantData>();

        UrlTest _urltest;
        KlantTest _klantTest;
        WebserviceTest _webserviceTest;

        public static int SetValueForWeberviceId = 0;
        public AllWebserviceForm()
        {
            InitializeComponent();
            _urltest = new UrlTest();
            _klantTest = new KlantTest();
            _webserviceTest = new WebserviceTest();

            GetKlanten();
            GetWebservicesIfZoekOpNaamIsLeeg();
        }

        private void GetWebservicesIfZoekOpNaamIsLeeg()
        {
            _webServiceDatas = _webserviceTest.GetWebServiceDatas(true);
            _WebserviceDatasForChange = _webserviceTest.GetWebServiceDatas(true);
            FillLstBxWebServices();
            FillCmbxWebServices();

            WebserviceTxtBx.Text = _webServiceDatas[0].Name;
            AllWebserviceKrMaterialLstBx.SelectedIndex = 0;

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
                AllUrlsKrMaterialLstBx.ClearListBox();
                AllWebserviceKrMaterialLstBx.ClearListBox();
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

        private void FillLstBxUrlsFromWebservice()
        {
            AllUrlsKrMaterialLstBx.FillListBoxUrlData(_urlDatasByWebservice);
            if (_urlDatasByWebservice.Count > 0)
            {
                AllUrlsKrMaterialLstBx.SelectedIndex = 0;
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
            AllWebserviceKrMaterialLstBx.FillListBoxWebserviceData(_webServiceDatas);
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

        private void AllWebserviceKrMaterialLstBx_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {
            if (AllWebserviceKrMaterialLstBx.Items != null)
            {
                int idOfSelected = (int)AllWebserviceKrMaterialLstBx.SelectedItem.Tag;
                _selectedWebserviceId = idOfSelected;
                GetUrlsFromWebservice(idOfSelected);
                WebServiceData webServiceData = _webServiceDatas.Find(k => k.Id == idOfSelected);
                WebserviceTxtBx.Text = webServiceData.Name;

                if (_urlDatasByWebservice.Count > 0)
                {
                    UrlData urlData = _urlDatasByWebservice[0];
                    FillUrlData(urlData);
                }
            }
        }

        private void WebserviceTxtBx_TextChanged(object sender, System.EventArgs e)
        {
            _changedWebservice = WebserviceTxtBx.Text;
        }

        private void PasWebserviceAanBtn_Click(object sender, System.EventArgs e)
        {
            _webserviceTest.UpdateWebService((int)AllWebserviceKrMaterialLstBx.SelectedItem.Tag, _changedWebservice);
            GetKlantenIfZoekOpKlantenNaamIsGevuld();
        }

        private void AddWebserviceBtn_Click(object sender, EventArgs e)
        {
            var m = new AddWebserviceForm();
            m.FormClosing += new FormClosingEventHandler(ChildFormClosingAddWebserviceForm);
            m.ShowDialog();
        }

        private void DeleteWebserviceBttn_Click(object sender, EventArgs e)
        {
            _webserviceTest.DeleteWebService((int)AllWebserviceKrMaterialLstBx.SelectedItem.Tag);
            GetKlantenIfZoekOpKlantenNaamIsGevuld();
        }

        private void ChildFormClosingAddWebserviceForm(object sender, FormClosingEventArgs e)
        {
            GetKlantenIfZoekOpKlantenNaamIsGevuld();
            AllWebserviceKrMaterialLstBx.SelectedIndex = AllWebserviceKrMaterialLstBx.Items.Count - 1;
            _selectedWebserviceId = _webServiceDatas[_webServiceDatas.Count - 1].Id;
        }

        private void AllUrlsKrMaterialLstBx_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            if (AllUrlsKrMaterialLstBx.Items != null)
            {
                int idOfSelected = (int)AllUrlsKrMaterialLstBx.SelectedItem.Tag;
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
            _urltest.UpdateUrl((int)AllUrlsKrMaterialLstBx.SelectedItem.Tag,
                    _changedUrl,
                    _changedSecurityId,
                    _selectedWebserviceIdForChange,
                    _selectedKlantIdForChange);
            GetUrlsFromWebservice(_selectedWebserviceId);
        }

        private void DeleteUrlBttn_Click(object sender, EventArgs e)
        {
            _urltest.DeleteUrl((int)AllUrlsKrMaterialLstBx.SelectedItem.Tag);
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
