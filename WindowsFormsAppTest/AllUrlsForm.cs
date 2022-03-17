using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AllUrlsForm : MaterialForm
    {
        private string changedSecurityId = "";
        private string changedUrl;
        private int _selectedWebserviceId;
        private int _selectedKlantId;

        private List<UrlData> _urlDatas = new List<UrlData>();
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();
        private List<KlantData> _klantDatas = new List<KlantData>();

        UrlTest _urltest;
        WebRequest _webRequest;
        WebserviceTest _webserviceTest;
        KlantTest _klantTest;

        public AllUrlsForm()
        {
            InitializeComponent();
            _urltest = new UrlTest();
            _webRequest = new WebRequest();
            _webserviceTest = new WebserviceTest();
            _klantTest = new KlantTest();

            _webServiceDatas = _webserviceTest.GetWebServiceDatas(true);
            _klantDatas = _klantTest.GetKlantData();
            _urlDatas = _urltest.GetUrlDatas();

            fillCmbxWebServices();
            fillCmbxKlanten();
        }

        private void AllUrlsForm_Load(object sender, EventArgs e)
        {
            getUrls();
        }

        private void getUrls()
        {
            _urlDatas = _urltest.GetUrlDatas(true);
            fillLstBxls();
        }

        private void fillLstBxls()
        {
            AllUrlsKrMaterialLstBx.Clear();
            foreach (UrlData urlData in _urlDatas)
            {
                MaterialListBoxItem item = new MaterialListBoxItem();
                item.Tag = urlData.Id;
                item.Text = urlData.Name;
                AllUrlsKrMaterialLstBx.AddItem(item);
            }
        }

        private void AllUrlsKrMaterialLstBx_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            clearBox();
            if (AllUrlsKrMaterialLstBx.Items != null)
            {
                int idOfSelected = (int)AllUrlsKrMaterialLstBx.SelectedItem.Tag;
                UrlData urlData = _urlDatas.Find(u => u.Id == idOfSelected);
                foreach (var webService in _webServiceDatas)
                {
                    if (urlData.WebServiceDataId == webService.Id)
                    {
                        WebserviceKrMaterialCmbx.SelectedItem = webService;
                        WebserviceKrMaterialCmbx.Refresh();
                    }
                }
                foreach (var klant in _klantDatas)
                {
                    if (urlData.KlantDataId == klant.Id)
                    {
                        KlantKrMaterialCmbx.SelectedItem = klant;
                        KlantKrMaterialCmbx.Refresh();
                    }
                }
                UrlTxtBx.Text = urlData.Name;
                SecurityIdTxtBx.Text = urlData.SecurityId;
            }
        }

        private void PasUrlAanBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = AllUrlsKrMaterialLstBx.SelectedIndex;
            int idOfSelected = (int)AllUrlsKrMaterialLstBx.SelectedItem.Tag;
            _urltest.UpdateUrl(idOfSelected, changedUrl, changedSecurityId, _selectedWebserviceId, _selectedKlantId);
            clearBox();
            getUrls();
            AllUrlsKrMaterialLstBx.SelectedIndex = selectedIndex;
        }

        private void DeleteUrlBttn_Click(object sender, EventArgs e)
        {
            clearBox();
            _urltest.DeleteUrl((int)AllUrlsKrMaterialLstBx.SelectedItem.Tag);
            AllUrlsKrMaterialLstBx.SelectedIndex = 0;
            getUrls();
        }

        private void AddUrlBtn_Click(object sender, EventArgs e)
        {
            var m = new AddUrlForm();
            m.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            m.ShowDialog();
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            getUrls();
        }

        private void SecurityIdTxtBx_TextChanged(object sender, EventArgs e)
        {
            changedSecurityId = SecurityIdTxtBx.Text;
        }

        private void UrlTxtBx_TextChanged(object sender, EventArgs e)
        {
            changedUrl = UrlTxtBx.Text;
        }

        private void WebserviceKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedWebserviceId = (int)WebserviceKrMaterialCmbx.SelectedValue;
        }

        private void KlantKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedKlantId = (int)KlantKrMaterialCmbx.SelectedValue;
        }

        private void clearBox()
        {
            SecurityIdTxtBx.Text = string.Empty;
            UrlTxtBx.Text = string.Empty;
        }

        private void fillCmbxWebServices()
        {
            WebserviceKrMaterialCmbx.fillCmbBoxWebservice(_webServiceDatas);
        }

        private void fillCmbxKlanten()
        {
            KlantKrMaterialCmbx.fillCmbBoxKlant(_klantDatas);
        }
    }
}
