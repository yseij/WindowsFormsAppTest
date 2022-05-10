using MaterialSkin.Controls;
using System;
using System.Collections.Generic;

namespace WindowsFormsAppTest
{
    public partial class AllUrlPerKlantForm : MaterialForm
    {
        private string _zoekOpKlantNaam = string.Empty;

        private Guid _selectedKlantId;
        private Guid _selectedUrlId;

        private List<Klant> _klanten = new List<Klant>();

        UrlXml _urlXml;
        KlantXml _klantXml;

        public AllUrlPerKlantForm()
        {
            InitializeComponent();
            _urlXml = new UrlXml();
            _klantXml = new KlantXml();

            GetKlantenIfZoekOpNaamIsLeeg();
            GetUrls();
        }

        private void GetKlantenIfZoekOpNaamIsLeeg()
        {
            _klanten = _klantXml.GetKlanten();
            FillLstBxKlanten();

            if (_klanten.Count != 0)
            {
                AllKlantKrLstBx.SelectedIndex = 0;
            }
        }

        private void GetKlantenIfZoekOpNaamIsGevuld()
        {
            _klanten = _klantXml.GetKlantenByName(_zoekOpKlantNaam);

            if (_klanten.Count > 0)
            {
                FillLstBxKlanten();
                GetUrls();
            }
            else
            {
                AllUrlsKrLstBx.ClearListBox();
                AllKlantKrLstBx.ClearListBox();
            }
        }

        private void FillLstBxKlanten()
        {
            AllKlantKrLstBx.FillListBoxKlantData(_klanten);
            if (_klanten.Count != 0)
            {
                _selectedKlantId = _klanten[0].Id;
            }
        }

        private void GetUrls()
        {
            UrlTxtBx.Text = string.Empty;
            List<Url> urls = _urlXml.GetByKlantId(_selectedKlantId);
            FillLstBxUrls(urls);
        }

        private void FillLstBxUrls(List<Url> urls)
        {
            AllUrlsKrLstBx.FillListBoxUrls(urls);
            if (urls.Count != 0)
            {
                AllUrlsKrLstBx.SelectedIndex = 0;
                _selectedUrlId = urls[0].Id;
                UrlTxtBx.Text = urls[0].Name;
            }
        }

        private void AllKlantKrLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllKlantKrLstBx.Items != null && AllKlantKrLstBx.SelectedValue != null)
            {
                Guid idOfSelected = (Guid)AllKlantKrLstBx.SelectedValue;
                _selectedKlantId = idOfSelected;
                Klant klantData = _klanten.Find(k => k.Id == idOfSelected);
                GetUrls();
            }
        }

        private void DeleteUrlBttn_Click(object sender, EventArgs e)
        {
            _urlXml.DeleteUrl(_selectedUrlId);
            GetUrls();
        }

        private void AllUrlsKrLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllUrlsKrLstBx.Items != null && AllUrlsKrLstBx.SelectedValue != null)
            {
                _selectedUrlId = (Guid)AllUrlsKrLstBx.SelectedValue;
                UrlTxtBx.Text = AllUrlsKrLstBx.Text;
            }
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
