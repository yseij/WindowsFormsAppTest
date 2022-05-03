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
        private string _huidigeWebserviceNaam;
        private string _zoekOpWebserviceNaam = string.Empty;

        private Guid _selectedWebserviceId;

        public static int SetValueForWeberviceId = 0;

        private bool _isSoap;

        private List<WebService> _webServiceDatas = new List<WebService>();

        WebserviceXml _webserviceXml;
        ErrorProvider _error;

        public AllWebserviceForm()
        {
            InitializeComponent();
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
                SecurityTxtBx.Text = webServiceData.SecurityId;
                _huidigeWebserviceNaam = webServiceData.Name;
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
        }

        private void PasWebserviceAanBtn_Click(object sender, EventArgs e)
        {
            WebService webService = new WebService((Guid)AllWebserviceKrLstBx.SelectedValue, WebserviceTxtBx.Text, SoapWebserviceChkBx.Checked, SecurityTxtBx.Text);
            if (_huidigeWebserviceNaam == _changedWebservice)
            {
                _webserviceXml.UpdateWebservice((Guid)AllWebserviceKrLstBx.SelectedValue, webService);
            }
            else
            {
                WebService webserviceExist = _webserviceXml.GetKlantenByTheSameName(_changedWebservice);
                if (webserviceExist == null)
                {
                    _webserviceXml.UpdateWebservice((Guid)AllWebserviceKrLstBx.SelectedValue, webService);
                }
                else
                {
                    _error.SetError(WebserviceTxtBx, ConfigurationManager.AppSettings["BestaatAlInDb"]);
                }
            }
            GetWebservicesIfZoekOpKlantenNaamIsGevuld();
        }

        private void AddWebserviceBtn_Click(object sender, EventArgs e)
        {
            var m = new AddWebserviceForm();
            m.FormClosing += new FormClosingEventHandler(ChildFormClosingAddWebserviceForm);
            m.ShowDialog();
        }

        private void DeleteWebserviceBttn_Click(object sender, EventArgs e)
        {
            _webserviceXml.DeleteWebservice((Guid)AllWebserviceKrLstBx.SelectedValue);
            GetWebservicesIfZoekOpKlantenNaamIsGevuld();
        }

        private void ChildFormClosingAddWebserviceForm(object sender, FormClosingEventArgs e)
        {
            GetWebservicesIfZoekOpKlantenNaamIsGevuld();
            AllWebserviceKrLstBx.SelectedIndex = AllWebserviceKrLstBx.Items.Count - 1;
            _selectedWebserviceId = _webServiceDatas[_webServiceDatas.Count - 1].Id;
        }

        private void GetWebservicesIfZoekOpKlantenNaamIsGevuld()
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
            GetWebservicesIfZoekOpKlantenNaamIsGevuld();
        }
    }
}
