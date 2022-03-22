using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AllWebserviceForm : MaterialForm
    {
        private string _changedWebservice = "";
        private int _selectedWebserviceId;
        private int _selectedUrlId;
        private int _selectedKlantIdForChange;
        private int _selectedWebserviceIdForChange;

        private List<UrlData> _urlDatasByWebservice = new List<UrlData>();
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();
        private List<WebServiceData> _WebserviceDatasForChange = new List<WebServiceData>();
        private List<KlantData> _klantDatas = new List<KlantData>();

        UrlTest _urltest;
        KlantTest _klantTest;
        WebserviceTest _webserviceTest;

        public AllWebserviceForm()
        {
            InitializeComponent();
            _urltest = new UrlTest();
            _klantTest = new KlantTest();
            _webserviceTest = new WebserviceTest();

            GetKlanten();
            GetWebservices();
        }

        private void GetWebservices()
        {
            _webServiceDatas = _webserviceTest.GetWebServiceDatas(true);
            _WebserviceDatasForChange = _webserviceTest.GetWebServiceDatas(true);
            FillLstBxWebServices();
            FillCmbxWebServices();

            WebserviceTxtBx.Text = _webServiceDatas[0].Name;
            AllWebserviceKrMaterialLstBx.SelectedIndex = 0;
        }

        private void GetUrlsFromWebservice(int id)
        {
            _urlDatasByWebservice = _urltest.GetAllUrlsByForeignKeyWebservice(id);
            FillLstBxUrlsFromWebservice();
        }

        private void GetKlanten()
        {
            _klantDatas = _klantTest.GetKlantData();
            FillCmbxKlanten();
        }

        private void FillLstBxUrlsFromWebservice()
        {
            AllUrlsKrMaterialLstBx.FillListBoxUrlData(_urlDatasByWebservice);
            if (_urlDatasByWebservice.Count > 0)
            {
                AllUrlsKrMaterialLstBx.FillListBoxUrlData(_urlDatasByWebservice);
                AllUrlsKrMaterialLstBx.SelectedIndex = 0;
            }
            if (_urlDatasByWebservice.Count != 0)
            {
                _selectedUrlId = _urlDatasByWebservice[0].Id;
            }
        }

        private void FillLstBxWebServices()
        {
            AllWebserviceKrMaterialLstBx.FillListBoxWebserviceData(_webServiceDatas);
            if (_webServiceDatas.Count != 0)
            {
                _selectedWebserviceId = _webServiceDatas[0].Id;
            }
        }

        private void FillCmbxWebServices()
        {
            WebserviceKrMaterialCmbx.FillCmbBoxWebservice(_WebserviceDatasForChange);
            WebserviceKrMaterialCmbx.SelectedValue = _selectedWebserviceId;
        }

        private void FillCmbxKlanten()
        {
            KlantKrMaterialCmbx.FillCmbBoxKlant(_klantDatas);
            KlantKrMaterialCmbx.SelectedValue = _klantDatas[0].Id;
        }

        private void AllWebserviceKrMaterialLstBx_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {
            if (AllWebserviceKrMaterialLstBx.Items != null)
            {
                int idOfSelected = (int)AllWebserviceKrMaterialLstBx.SelectedItem.Tag;
                _selectedWebserviceId = idOfSelected;
                GetUrlsFromWebservice(idOfSelected);
                WebServiceData webServiceData = _webServiceDatas.Find(k => k.Id == idOfSelected);
                WebserviceTxtBx.Text = webServiceData.Name;

                if (_urlDatasByWebservice.Count > 0)
                {
                    UrlData urlData = _urlDatasByWebservice[0];
                    FillUrlData(urlData);
                }
            }
        }

        private void FillUrlData(UrlData urlData)
        {
            UrlTxtBx.Text = urlData.Name;
            SecurityIdTxtBx.Text = urlData.SecurityId;
            WebserviceKrMaterialCmbx.SelectedValue = urlData.WebServiceDataId;
            KlantKrMaterialCmbx.SelectedValue = urlData.KlantDataId;
            WebserviceKrMaterialCmbx.Refresh();
            KlantKrMaterialCmbx.Refresh();
        }

        private void WebserviceTxtBx_TextChanged(object sender, System.EventArgs e)
        {
            _changedWebservice = WebserviceTxtBx.Text;
        }

        private void PasWebserviceAanBtn_Click(object sender, System.EventArgs e)
        {
            _webserviceTest.UpdateWebService((int)AllWebserviceKrMaterialLstBx.SelectedItem.Tag, _changedWebservice);
            GetWebservices();
        }

        private void AddWebserviceBtn_Click(object sender, System.EventArgs e)
        {
            var m = new AddWebserviceForm();
            m.FormClosing += new FormClosingEventHandler(ChildFormClosingAddWebserviceForm);
            m.ShowDialog();
        }

        private void DeleteWebserviceBttn_Click(object sender, System.EventArgs e)
        {
            _webserviceTest.DeleteWebService((int)AllWebserviceKrMaterialLstBx.SelectedItem.Tag);
            GetWebservices();
        }

        private void ChildFormClosingAddWebserviceForm(object sender, FormClosingEventArgs e)
        {
            GetWebservices();
            AllWebserviceKrMaterialLstBx.SelectedIndex = AllWebserviceKrMaterialLstBx.Items.Count - 1;
            _selectedWebserviceId = _webServiceDatas[_webServiceDatas.Count - 1].Id;
        }
    }
}
