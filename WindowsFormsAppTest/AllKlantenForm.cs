﻿using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AllKlantenForm : MaterialForm
    {
        private string _changedKlant;
        private string _zoekOpKlantNaam = string.Empty;
        private string _huidigeKlantNaam = string.Empty;

        private Guid _selectedKlantId;

        private List<Klant> _klantDatas = new List<Klant>();
        private List<WebService> _webServiceDatas = new List<WebService>();
        private List<KlantWebservice> _webServiceKlantDatas = new List<KlantWebservice>();

        KlantXml _klantXml;
        WebserviceXml _webserviceXml;
        KlantWebserviceXml _klantWebserviceXml;
        ErrorProvider _error;

        public AllKlantenForm()
        {
            InitializeComponent();
            _klantXml = new KlantXml();
            _webserviceXml = new WebserviceXml();
            _klantWebserviceXml = new KlantWebserviceXml();
            _error = new ErrorProvider();

            GetKlantenIfZoekOpNaamIsLeeg();
            GetWebservices();
        }

        private void GetKlantenIfZoekOpNaamIsLeeg()
        {
            _klantDatas = _klantXml.GetKlanten();
            FillLstBxKlanten();

            if (_klantDatas.Count != 0)
            {
                KlantTxtBx.Text = _klantDatas[0].Name;
                AllKlantKrLstBx.SelectedIndex = 0;
            }
        }

        private void GetKlantenIfZoekOpNaamIsGevuld()
        {
            _klantDatas = _klantXml.GetKlantenByName(_zoekOpKlantNaam);

            if (_klantDatas.Count > 0)
            {
                FillLstBxKlanten();
                GetWebservices();
            }
            else
            {
                AllWebserviceKrLstBx.ClearListBox();
                AllKlantKrLstBx.ClearListBox();
            }
        }

        private void GetWebservices()
        {
            _webServiceDatas = _webserviceXml.GetWebservices();
            FillLstBxWebservices();
        }

        private void FillLstBxKlanten()
        {
            AllKlantKrLstBx.FillListBoxKlantData(_klantDatas);
            if (_klantDatas.Count != 0)
            {
                _selectedKlantId = _klantDatas[0].Id;
            }
        }

        private void FillLstBxWebservices()
        {
            _webServiceKlantDatas = _klantWebserviceXml.GetByKlant(_selectedKlantId);
            List<WebService> webServices = new List<WebService>();
            foreach (WebService webService in _webServiceDatas)
            {
                foreach (KlantWebservice klantWebservice in _webServiceKlantDatas)
                {
                    if (webService.Id == klantWebservice.Webservice)
                    {
                        webServices.Add(webService);
                    }
                }
            }
            AllWebserviceKrLstBx.FillListBoxWebserviceData(webServices);
            if (webServices.Count != 0)
            {
                WebserviceTxtBx.Text = webServices[0].Name;
                SoapWebserviceChkBx.Checked = webServices[0].Soap;
            }
        }

        private void AllKlantKrLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllKlantKrLstBx.Items != null && AllKlantKrLstBx.SelectedValue != null)
            {
                Guid idOfSelected = (Guid)AllKlantKrLstBx.SelectedValue;
                _selectedKlantId = idOfSelected;
                Klant klantData = _klantDatas.Find(k => k.Id == idOfSelected);
                KlantTxtBx.Text = klantData.Name;
                BasisUrl1TxtBx.Text = klantData.BasisUrl1;
                BasisUrl2TxtBx.Text = klantData.BasisUrl2;
                _huidigeKlantNaam = klantData.Name;
                GetWebservices();
            }
        }

        private void KlantTxtBx_TextChanged(object sender, EventArgs e)
        {
            if (KlantTxtBx.Text != string.Empty)
            {
                _error.Clear();
                PasKlantAanBtn.Enabled = true;
            }
            else
            {
                _error.SetError(KlantTxtBx, ConfigurationManager.AppSettings["LeegTekstVak"]);
                PasKlantAanBtn.Enabled = false;
            }
            _changedKlant = KlantTxtBx.Text;
        }

        private void AddKlantBtn_Click(object sender, EventArgs e)
        {
            var m = new AddKlantWithWebservicesForm(Guid.Empty);
            m.FormClosing += new FormClosingEventHandler(ChildFormClosingAddKlantForm);
            m.ShowDialog();
        }

        private void PasKlantAanBtn_Click(object sender, EventArgs e)
        {
            Klant klant = new Klant((Guid)AllKlantKrLstBx.SelectedValue, _changedKlant, BasisUrl1TxtBx.Text, BasisUrl2TxtBx.Text);
            if (_huidigeKlantNaam == KlantTxtBx.Text)
            {
                _klantXml.UpdateKlant((Guid)AllKlantKrLstBx.SelectedValue, klant);
            }
            else
            {
                Klant klantExist = _klantXml.GetKlantenByTheSameName(KlantTxtBx.Text);
                if (klantExist == null)
                {
                    _klantXml.UpdateKlant((Guid)AllKlantKrLstBx.SelectedValue, klant);
                }
                else
                {
                    _error.SetError(KlantTxtBx, ConfigurationManager.AppSettings["BestaatAlInDb"]);
                }
            }
            GetKlantenIfZoekOpKlantenNaamIsGevuld();
        }

        private void DeleteKlantBttn_Click(object sender, EventArgs e)
        {
            _klantXml.DeleteKlant((Guid)AllKlantKrLstBx.SelectedValue);
            _klantWebserviceXml.DeleteByKlant((Guid)AllKlantKrLstBx.SelectedValue);
            GetKlantenIfZoekOpKlantenNaamIsGevuld();
        }

        private void ChildFormClosingAddKlantForm(object sender, FormClosingEventArgs e)
        {
            GetKlantenIfZoekOpKlantenNaamIsGevuld();
            AllKlantKrLstBx.SelectedIndex = AllKlantKrLstBx.Items.Count - 1;
            _selectedKlantId = _klantDatas[_klantDatas.Count - 1].Id;
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

        private void PasWebserviceAanBtn_Click(object sender, EventArgs e)
        {
            WebService webService = _webserviceXml.GetKlantenByTheSameName(WebserviceTxtBx.Text);

            WebService newWebService = new WebService(WebserviceTxtBx.Text, SoapWebserviceChkBx.Checked, "");
            if (webService == null)
            {
                _webserviceXml.UpdateWebservice((Guid)AllWebserviceKrLstBx.SelectedValue, newWebService);
                GetWebservices();
            }
            else
            {
                _error.SetError(WebserviceTxtBx, ConfigurationManager.AppSettings["BestaatAlInDb"]);
            }
        }

        private void WebservicesToevoegenAanKlant_Click(object sender, EventArgs e)
        {
            var m = new AddKlantWithWebservicesForm((Guid)AllKlantKrLstBx.SelectedValue);
            m.FormClosing += new FormClosingEventHandler(ChildFormClosingAddWebserviceToKlantForm);
            m.ShowDialog();
        }

        private void ChildFormClosingAddWebserviceToKlantForm(object sender, FormClosingEventArgs e)
        {
            GetWebservices();
        }

        private void AllWebserviceKrLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllWebserviceKrLstBx.Items != null && AllWebserviceKrLstBx.SelectedValue != null)
            {
                Guid idOfSelected = (Guid)AllWebserviceKrLstBx.SelectedValue;
                WebService webService = _webServiceDatas.Find(w => w.Id == idOfSelected);
                WebserviceTxtBx.Text = webService.Name;
                SoapWebserviceChkBx.Checked = webService.Soap;
            }
        }

        private void AddWebserviceBtn_Click(object sender, EventArgs e)
        {
            var m = new AddWebserviceForm();
            m.ShowDialog();
        }
    }
}
