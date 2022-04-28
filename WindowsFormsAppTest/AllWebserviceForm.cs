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

        private Guid _selectedWebserviceId;
        private int _selectedUrlId;
        private int _selectedHttpId;
        private int _selectedKlantIdForChange;
        private int _selectedWebserviceIdForChange;

        public static int SetValueForWeberviceId = 0;

        private bool _isSoap;

        private List<HttpData> _httpDatas = new List<HttpData>();
        private List<WebService> _webServiceDatas = new List<WebService>();
        private List<WebService> _WebserviceDatasForChange = new List<WebService>();
        private List<Klant> _klantDatas = new List<Klant>();

        HttpTest _httpTest;
        KlantTest _klantTest;
        WebserviceTest _webserviceTest;
        ErrorProvider _error;

        public AllWebserviceForm()
        {
            InitializeComponent();
            _httpTest = new HttpTest();
            _klantTest = new KlantTest();
            _webserviceTest = new WebserviceTest();
            _error = new ErrorProvider();

            GetKlanten();
            GetWebservicesIfZoekOpNaamIsLeeg();
        }

        private void GetWebservicesIfZoekOpNaamIsLeeg()
        {
            _webServiceDatas = _webserviceTest.GetWebServiceData();
            _WebserviceDatasForChange = _webserviceTest.GetWebServiceData();
            FillLstBxWebServices();
            FillCmbxWebServices();

            if (_webServiceDatas.Count > 0)
            {
                WebserviceTxtBx.Text = _webServiceDatas[0].Name;
                AllWebserviceKrLstBx.SelectedIndex = 0;

            }
        }

        private void GetWebservicesIfZoekOpNaamIsGevuld()
        {
            _webServiceDatas = _webserviceTest.GetWebServicesByWebserviceName(_zoekOpWebserviceNaam);
            _WebserviceDatasForChange = _webserviceTest.GetWebServicesByWebserviceName(_zoekOpWebserviceNaam);

            if (_webServiceDatas.Count > 0)
            {
                FillLstBxWebServices();
                FillCmbxWebServices();
            }
            else
            {
                AllUrlsKrLstBx.ClearListBox();
                AllWebserviceKrLstBx.ClearListBox();
            }
        }

        private void GetKlanten()
        {
            _klantDatas = _klantTest.GetKlantData();
            FillCmbxKlanten();
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
            if (_klantDatas.Count > 0)
            {
                KlantKrMaterialCmbx.SelectedValue = _klantDatas[0].Id;
            }
        }

        private void AllWebserviceKrLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllWebserviceKrLstBx.Items != null && AllWebserviceKrLstBx.SelectedValue != null)
            {
                Guid idOfSelected = (Guid)AllWebserviceKrLstBx.SelectedValue;
                _selectedWebserviceId = idOfSelected;
                WebService webServiceData = _webServiceDatas.Find(k => k.Id == idOfSelected);
                WebserviceTxtBx.Text = webServiceData.Name;
                SoapWebserviceChkBx.Checked = webServiceData.Soap;
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
            _webserviceTest.UpdateWebService((int)AllWebserviceKrLstBx.SelectedValue, _changedWebservice, _isSoap);
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
