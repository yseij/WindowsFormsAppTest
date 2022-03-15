using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AllKlantenForm : MaterialForm
    {
        private string _changedKlant = "";
        private string _changedSecurityId = "";
        private string _changedUrl = "";
        private int _selectedKlantId;
        private int _selectedKlantIdForChange;
        private int _selectedWebserviceIdForChange;
        private int _selectedUrlId;

        private List<UrlData> _urlDatasByKlant = new List<UrlData>();
        private List<KlantData> _klantDatas = new List<KlantData>();
        private List<KlantData> _klantDatasForChange = new List<KlantData>();
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();

        UrlTest _urltest;
        KlantTest _klantTest;
        WebserviceTest _webserviceTest;

        public static int SetValueForKlantId = 0;
        public AllKlantenForm()
        {
            InitializeComponent();
            _urltest = new UrlTest();
            _klantTest = new KlantTest();
            _webserviceTest = new WebserviceTest();

            getKlanten();
            getWebservices();
        }

        private void getKlanten()
        {
            _klantDatas = _klantTest.GetKlantData();
            _klantDatasForChange = _klantTest.GetKlantData();
            fillLstBxKlanten();
            fillCmbxKlanten();
        }

        private void getUrlsFromKlant(int id)
        {
            _urlDatasByKlant = _urltest.GetAllUrlsByForeignKeyKlant(id);
            fillLstBxUlsFromKlant();
        }

        private void getWebservices()
        {
            _webServiceDatas = _webserviceTest.GetWebServiceDatas(true);
            fillCmbxWebServices();
        }
        private void fillLstBxKlanten()
        {
            if (_klantDatas.Count != 0)
            {
                _selectedKlantId = _klantDatas[0].Id;
            }
            AllKlantLstBx.DataSource = null;
            AllKlantLstBx.ValueMember = "Id";
            AllKlantLstBx.DataSource = _klantDatas;
            AllKlantLstBx.DisplayMember = "Name";

        }

        private void fillLstBxUlsFromKlant()
        {
            if (_urlDatasByKlant.Count != 0)
            {
                _selectedUrlId = _urlDatasByKlant[0].Id;
            }
            
            UrlsByKlantLstBx.DataSource = null;
            UrlsByKlantLstBx.ValueMember = "Id";
            UrlsByKlantLstBx.DataSource = _urlDatasByKlant;
            UrlsByKlantLstBx.DisplayMember = "Name";
        }

        private void fillCmbxWebServices()
        {
            WebServiceCmbx.SelectedValue = _webServiceDatas[0].Id;
            WebServiceCmbx.DataSource = null;
            WebServiceCmbx.ValueMember = "Id";
            WebServiceCmbx.DataSource = _webServiceDatas;
            WebServiceCmbx.DisplayMember = "Name";
        }

        private void fillCmbxKlanten()
        {
            KlantCmbBx.DataSource = null;
            KlantCmbBx.ValueMember = "Id";
            KlantCmbBx.DataSource = _klantDatasForChange;
            KlantCmbBx.DisplayMember = "Name";
            KlantCmbBx.SelectedValue = _selectedKlantId;
        }

        private void AllKlantLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllKlantLstBx.DataSource != null)
            {
                int idOfSelected = (int)AllKlantLstBx.SelectedValue;
                _selectedKlantId = idOfSelected;
                getUrlsFromKlant(idOfSelected);
                KlantData klantData = _klantDatas.Find(k => k.Id == idOfSelected);
                KlantTxtBx.Text = klantData.Name;
            }
        }

        private void KlantTxtBx_TextChanged(object sender, EventArgs e)
        {
            _changedKlant = KlantTxtBx.Text;
        }


        private void AddKlantBtn_Click(object sender, EventArgs e)
        {
            var m = new AddKlantForm();
            m.FormClosing += new FormClosingEventHandler(ChildFormClosingAddKlantForm);
            m.ShowDialog();
        }

        private void PasKlantAanBtn_Click(object sender, EventArgs e)
        {
            _klantTest.UpdateKlant((int)AllKlantLstBx.SelectedValue, _changedKlant);
            getKlanten();
        }

        private void DeleteKlantBttn_Click(object sender, EventArgs e)
        {
            _klantTest.DeleteKlant((int)AllKlantLstBx.SelectedValue);
            getKlanten();
        }

        private void UrlsByKlantLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UrlsByKlantLstBx.DataSource != null)
            {
                int idOfSelected = (int)UrlsByKlantLstBx.SelectedValue;
                _selectedUrlId = idOfSelected;
                UrlData urlData = _urlDatasByKlant.Find(k => k.Id == idOfSelected);
                UrlTxtBx.Text = urlData.Name;
                SecurityIdTxtBx.Text = urlData.SecurityId;
                WebServiceCmbx.SelectedValue = urlData.WebServiceDataId;
                KlantCmbBx.SelectedValue = urlData.KlantDataId;
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

        private void WebServiceCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedWebserviceIdForChange = (int)WebServiceCmbx.SelectedValue;
        }

        private void KlantCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KlantCmbBx.DataSource != null)
            {
                _selectedKlantIdForChange = (int)KlantCmbBx.SelectedValue;
            }
        }

        private void AddUrlByKlantBttn_Click(object sender, EventArgs e)
        {
            SetValueForKlantId = _selectedKlantId;
            var m = new AddUrlForm();
            m.FormClosing += new FormClosingEventHandler(ChildFormClosingAddUrlForm);
            m.ShowDialog();
        }

        private void PasUrlAanBtn_Click(object sender, EventArgs e)
        {
            _urltest.UpdateUrl((int)UrlsByKlantLstBx.SelectedValue,
                    _changedUrl,
                    _changedSecurityId,
                    _selectedWebserviceIdForChange,
                    _selectedKlantIdForChange);
            getUrlsFromKlant(_selectedKlantId);
        }

        private void DeleteUrlBttn_Click(object sender, EventArgs e)
        {
            _urltest.DeleteUrl((int)UrlsByKlantLstBx.SelectedValue);
            clearBox();
            getUrlsFromKlant(_selectedKlantId);
        }

        private void ChildFormClosingAddKlantForm(object sender, FormClosingEventArgs e)
        {
            getKlanten();
            AllKlantLstBx.SelectedIndex = AllKlantLstBx.Items.Count - 1;
            _selectedKlantId = _klantDatas[_klantDatas.Count - 1].Id;
        }

        private void ChildFormClosingAddUrlForm(object sender, FormClosingEventArgs e)
        {
            getUrlsFromKlant(SetValueForKlantId);
        }

        private void clearBox()
        {
            SecurityIdTxtBx.Text = string.Empty;
            UrlTxtBx.Text = string.Empty;
        }

        private void AllKlantenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
