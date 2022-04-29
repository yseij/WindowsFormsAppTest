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

        private List<WebService> _webServiceDatas = new List<WebService>();

        KlantXml _klantXml;
        WebserviceXml _webserviceXml;
        ErrorProvider _error;

        public AllWebserviceForm()
        {
            InitializeComponent();
            _klantXml = new KlantXml();
            _webserviceXml = new WebserviceXml();
            _error = new ErrorProvider();

            GetWebservicesIfZoekOpNaamIsLeeg();
        }

        private void GetWebservicesIfZoekOpNaamIsLeeg()
        {
            _webServiceDatas = _webserviceXml.GetWebservices();
            FillLstBxWebServices();

            if (_webServiceDatas.Count > 0)
            {
                WebserviceTxtBx.Text = _webServiceDatas[0].Name;
                AllWebserviceKrLstBx.SelectedIndex = 0;

            }
        }

        private void GetWebservicesIfZoekOpNaamIsGevuld()
        {
            _webServiceDatas = _webserviceXml.GetWebservicesByName(_zoekOpWebserviceNaam);

            if (_webServiceDatas.Count > 0)
            {
                FillLstBxWebServices();
            }
            else
            {
                AllWebserviceKrLstBx.ClearListBox();
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
            //_webserviceXml.UpdateWebService((int)AllWebserviceKrLstBx.SelectedValue, _changedWebservice, _isSoap);
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
            //_webserviceXml.DeleteWebService((int)AllWebserviceKrLstBx.SelectedValue);
            GetKlantenIfZoekOpKlantenNaamIsGevuld();
        }

        private void ChildFormClosingAddWebserviceForm(object sender, FormClosingEventArgs e)
        {
            GetKlantenIfZoekOpKlantenNaamIsGevuld();
            AllWebserviceKrLstBx.SelectedIndex = AllWebserviceKrLstBx.Items.Count - 1;
            _selectedWebserviceId = _webServiceDatas[_webServiceDatas.Count - 1].Id;
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
