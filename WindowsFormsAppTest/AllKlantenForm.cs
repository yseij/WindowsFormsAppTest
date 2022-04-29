using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsAppTest
{
    public partial class AllKlantenForm : MaterialForm
    {
        private string _changedKlant;
        private string _changedSecurityId;
        private string _changedUrl;
        private string _zoekOpKlantNaam = string.Empty;

        private Guid _selectedKlantId;
        private Guid _selectedKlantIdForChange;
        private Guid _selectedWebserviceIdForChange;
        private Guid _selectedUrlId;

        public static int SetValueForKlantId = 0;

        private List<Klant> _klantDatas = new List<Klant>();
        private List<Klant> _klantDatasForChange = new List<Klant>();
        private List<WebService> _webServiceDatas = new List<WebService>();

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
        }

        private void GetKlantenIfZoekOpNaamIsLeeg()
        {
            _klantDatas = _klantXml.GetKlanten();
            _klantDatasForChange = _klantXml.GetKlanten();
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
            _klantDatasForChange = _klantXml.GetKlanten();

            if (_klantDatas.Count > 0)
            {
                FillLstBxKlanten();
            }
            else
            {
                AllWebserviceKrLstBx.ClearListBox();
                AllKlantKrLstBx.ClearListBox();
            }
        }

        private void FillLstBxKlanten()
        {
            AllKlantKrLstBx.FillListBoxKlantData(_klantDatas);
            if (_klantDatas.Count != 0)
            {
                _selectedKlantId = _klantDatas[0].Id;
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
            Klant klant = new Klant(_changedKlant, BasisUrl1TxtBx.Text, BasisUrl2TxtBx.Text);
            _klantXml.UpdateKlant((Guid)AllKlantKrLstBx.SelectedValue, klant);
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

        }

        private void WebservicesToevoegenAanKlant_Click(object sender, EventArgs e)
        {
            var m = new AddKlantWithWebservicesForm((Guid)AllKlantKrLstBx.SelectedValue);
            m.ShowDialog();
        }
    }
}
