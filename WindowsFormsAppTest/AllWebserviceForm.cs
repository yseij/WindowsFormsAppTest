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

        public static int SetValueForWeberviceId = 0;

        private List<WebService> _webServiceDatas = new List<WebService>();

        WebserviceXml _webserviceXml;
        KlantWebserviceXml _klantWebserviceXml;
        UrlXml _urlXml;
        ErrorProvider _error;

        public AllWebserviceForm()
        {
            InitializeComponent();
            _webserviceXml = new WebserviceXml();
            _klantWebserviceXml = new KlantWebserviceXml();
            _urlXml = new UrlXml();
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
        }

        private void AllWebserviceKrLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllWebserviceKrLstBx.Items != null && AllWebserviceKrLstBx.SelectedValue != null)
            {
                Guid idOfSelected = (Guid)AllWebserviceKrLstBx.SelectedValue;
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
            List<KlantWebservice> klantWebservices = _klantWebserviceXml.GetByWebservice((Guid)AllWebserviceKrLstBx.SelectedValue);
            List<Url> urls = new List<Url>();
            foreach (KlantWebservice klantWebservice in klantWebservices)
            {
                List<Url> urlsByKlantWebservice = _urlXml.GetByKlantWebserviceId(klantWebservice.Id);
                foreach (Url url in urlsByKlantWebservice)
                {
                    urls.Add(url);
                }
            }
            if (klantWebservices.Count == 0 && urls.Count == 0)
            {
                _webserviceXml.DeleteWebservice((Guid)AllWebserviceKrLstBx.SelectedValue);
                GetWebservicesIfZoekOpKlantenNaamIsGevuld();
            }
            else
            {
                MessageBox.Show("Er zijn nog urls die deze webservice gebruiken");
            }
        }

        private void ChildFormClosingAddWebserviceForm(object sender, FormClosingEventArgs e)
        {
            GetWebservicesIfZoekOpKlantenNaamIsGevuld();
            AllWebserviceKrLstBx.SelectedIndex = AllWebserviceKrLstBx.Items.Count - 1;
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
