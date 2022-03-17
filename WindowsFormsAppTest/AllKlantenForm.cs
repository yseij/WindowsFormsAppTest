using MaterialSkin;
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
            AllKlantKrMaterialLstBx.Clear();
            if (_klantDatas.Count != 0)
            {
                _selectedKlantId = _klantDatas[0].Id;
            }
            foreach (KlantData klantData in _klantDatas)
            {
                MaterialListBoxItem item = new MaterialListBoxItem();
                item.Tag = klantData.Id;
                item.Text = klantData.Name;
                AllKlantKrMaterialLstBx.AddItem(item);
            }
        }

        private void fillLstBxUlsFromKlant()
        {
            AllUrlsKrMaterialLstBx.Clear();
            if (_urlDatasByKlant.Count != 0)
            {
                _selectedUrlId = _urlDatasByKlant[0].Id;
            }
            foreach (UrlData urlData in _urlDatasByKlant)
            {
                MaterialListBoxItem item = new MaterialListBoxItem();
                item.Tag = urlData.Id;
                item.Text = urlData.Name;
                AllUrlsKrMaterialLstBx.AddItem(item);
            }
        }

        private void fillCmbxWebServices()
        {
            WebserviceKrMaterialCmbx.fillCmbBoxWebservice(_webServiceDatas);
            WebserviceKrMaterialCmbx.SelectedValue = _webServiceDatas[0].Id;
        }

        private void fillCmbxKlanten()
        {
            KlantKrMaterialCmbx.fillCmbBoxKlant(_klantDatasForChange);
            KlantKrMaterialCmbx.SelectedValue = _selectedKlantId;
        }

        private void AllKlantKrMaterialLstBx_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            if (AllKlantKrMaterialLstBx.Items != null)
            {
                int idOfSelected = (int)AllKlantKrMaterialLstBx.SelectedItem.Tag;
                _selectedKlantId = idOfSelected;
                getUrlsFromKlant(idOfSelected);
                KlantData klantData = _klantDatas.Find(k => k.Id == idOfSelected);
                KlantTxtBx.Text = klantData.Name;
                WebserviceKrMaterialCmbx.Refresh();
                KlantKrMaterialCmbx.Refresh();
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
            _klantTest.UpdateKlant((int)AllKlantKrMaterialLstBx.SelectedItem.Tag, _changedKlant);
            getKlanten();
        }

        private void DeleteKlantBttn_Click(object sender, EventArgs e)
        {
            _klantTest.DeleteKlant((int)AllKlantKrMaterialLstBx.SelectedItem.Tag);
            getKlanten();
        }

        private void AllUrlsKrMaterialLstBx_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            if (AllUrlsKrMaterialLstBx.Items != null)
            {
                int idOfSelected = (int)AllUrlsKrMaterialLstBx.SelectedItem.Tag;
                _selectedUrlId = idOfSelected;
                UrlData urlData = _urlDatasByKlant.Find(k => k.Id == idOfSelected);
                UrlTxtBx.Text = urlData.Name;
                SecurityIdTxtBx.Text = urlData.SecurityId;
                WebserviceKrMaterialCmbx.SelectedValue = urlData.WebServiceDataId;
                KlantKrMaterialCmbx.SelectedValue = urlData.KlantDataId;
                WebserviceKrMaterialCmbx.Refresh();
                KlantKrMaterialCmbx.Refresh();
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
            _selectedWebserviceIdForChange = (int)WebserviceKrMaterialCmbx.SelectedValue;
        }

        private void KlantCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KlantKrMaterialCmbx.DataSource != null)
            {
                _selectedKlantIdForChange = (int)KlantKrMaterialCmbx.SelectedValue;
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
            _urltest.UpdateUrl((int)AllUrlsKrMaterialLstBx.SelectedItem.Tag,
                    _changedUrl,
                    _changedSecurityId,
                    _selectedWebserviceIdForChange,
                    _selectedKlantIdForChange);
            getUrlsFromKlant(_selectedKlantId);
        }

        private void DeleteUrlBttn_Click(object sender, EventArgs e)
        {
            _urltest.DeleteUrl((int)AllUrlsKrMaterialLstBx.SelectedItem.Tag);
            clearBox();
            getUrlsFromKlant(_selectedKlantId);
        }

        private void ChildFormClosingAddKlantForm(object sender, FormClosingEventArgs e)
        {
            getKlanten();
            AllKlantKrMaterialLstBx.SelectedIndex = AllKlantKrMaterialLstBx.Items.Count - 1;
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
