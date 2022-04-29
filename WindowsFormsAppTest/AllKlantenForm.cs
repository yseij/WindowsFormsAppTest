using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AllKlantenForm : MaterialForm
    {
        private string _changedKlant;
        private string _changedSecurityId;
        private string _changedUrl;
        private string _zoekOpKlantNaam;

        private Guid _selectedKlantId;
        private Guid _selectedKlantIdForChange;
        private Guid _selectedWebserviceIdForChange;
        private Guid _selectedUrlId;

        public static int SetValueForKlantId = 0;

        private List<Klant> _klantDatas = new List<Klant>();
        private List<Klant> _klantDatasForChange = new List<Klant>();
        private List<WebService> _webServiceDatas = new List<WebService>();

        KlantTest _klantTest;
        WebserviceTest _webserviceTest;
        ErrorProvider _error;

        public AllKlantenForm()
        {
            InitializeComponent();
            _klantTest = new KlantTest();
            _webserviceTest = new WebserviceTest();
            _error = new ErrorProvider();

            GetKlantenIfZoekOpNaamIsLeeg();
            GetWebservices();
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
            }
            else
            {
                AllUrlsKrLstBx.ClearListBox();
                AllKlantKrLstBx.ClearListBox();
            }
        }

        private void GetWebservices()
        {
            _webServiceDatas = _webserviceTest.GetWebServiceData();
            FillCmbxWebServices();
        }

        private void FillLstBxKlanten()
        {
            AllKlantKrLstBx.FillListBoxKlantData(_klantDatas);
            if (_klantDatas.Count != 0)
            {
                _selectedKlantId = _klantDatas[0].Id;
            }
        }

        private void FillCmbxWebServices()
        {
            WebserviceKrMaterialCmbx.FillCmbBoxWebservice(_webServiceDatas);
            if (_webServiceDatas.Count > 0)
            {
                WebserviceKrMaterialCmbx.SelectedValue = _webServiceDatas[0].Id;
            }
        }

        private void FillCmbxKlanten()
        {
            KlantKrMaterialCmbx.FillCmbBoxKlant(_klantDatasForChange);
            KlantKrMaterialCmbx.SelectedValue = _selectedKlantId;
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
            var m = new AddKlantWithWebservicesForm();
            m.FormClosing += new FormClosingEventHandler(ChildFormClosingAddKlantForm);
            m.ShowDialog();
        }

        private void PasKlantAanBtn_Click(object sender, EventArgs e)
        {
            _klantTest.UpdateKlant((int)AllKlantKrLstBx.SelectedValue, _changedKlant, BasisUrl1TxtBx.Text, BasisUrl2TxtBx.Text);
            GetKlantenIfZoekOpKlantenNaamIsGevuld();
        }

        private void DeleteKlantBttn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Wilt u de urls van de klant ook verwijderen", "Urls bij klant", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _klantTest.DeleteKlant((int)AllKlantKrLstBx.SelectedValue);
            }
            else if (dialogResult == DialogResult.No)
            {
                _error.SetError(DeleteKlantBttn, "De klant bevat nog urls");
            }
            GetKlantenIfZoekOpKlantenNaamIsGevuld();
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
            _selectedWebserviceIdForChange = (Guid)WebserviceKrMaterialCmbx.SelectedValue;
        }

        private void KlantKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KlantKrMaterialCmbx.DataSource != null)
            {
                _selectedKlantIdForChange = (Guid)KlantKrMaterialCmbx.SelectedValue;
            }
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
    }
}
