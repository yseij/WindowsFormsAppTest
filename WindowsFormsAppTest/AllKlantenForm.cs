using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AllKlantenForm : Form
    {
        private string changedKlant = "";
        private string changedSecurityId = "";
        private string changedUrl = "";
        private int _selectedKlantId;
        private int _selectedUrlId;

        private List<UrlData> _urlDatasByKlant = new List<UrlData>();
        private List<KlantData> _klantDatas = new List<KlantData>();
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
            _klantDatas = _klantTest.GetKlantDatas(true);
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
            _selectedKlantId = _klantDatas[0].Id;
            AllKlantLstBx.DataSource = null;
            AllKlantLstBx.DisplayMember = "Name";
            AllKlantLstBx.ValueMember = "Id";
            AllKlantLstBx.DataSource = _klantDatas;
        }

        private void fillLstBxUlsFromKlant()
        {
            if (_urlDatasByKlant.Count != 0)
            {
                _selectedUrlId = _urlDatasByKlant[0].Id;
            }
            UrlsByKlantLstBx.DataSource = null;
            UrlsByKlantLstBx.DisplayMember = "Name";
            UrlsByKlantLstBx.ValueMember = "Id";
            UrlsByKlantLstBx.DataSource = _urlDatasByKlant;
        }

        private void fillCmbxWebServices()
        {
            WebServiceCmbx.DataSource = null;
            WebServiceCmbx.DisplayMember = "Name";
            WebServiceCmbx.ValueMember = "Id";
            WebServiceCmbx.DataSource = _webServiceDatas;
            WebServiceCmbx.SelectedValue = _webServiceDatas[0].Id;
        }

        private void fillCmbxKlanten()
        {
            KlantCmbBx.DataSource = null;
            KlantCmbBx.DisplayMember = "Name";
            KlantCmbBx.ValueMember = "Id";
            KlantCmbBx.DataSource = _klantDatas;
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

        private void UrlTxtBx_TextChanged(object sender, EventArgs e)
        {
            changedKlant = KlantTxtBx.Text;
        }

        private void PasKlantAanBtn_Click(object sender, EventArgs e)
        {
            _klantTest.UpdateKlant((int)AllKlantLstBx.SelectedValue, changedKlant);
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

        private void PasUrlAanBtn_Click(object sender, EventArgs e)
        {
            _urltest.UpdateUrl((int)UrlsByKlantLstBx.SelectedValue, changedUrl, changedSecurityId);
            getUrlsFromKlant(_selectedKlantId);
        }

        private void DeleteUrlBttn_Click(object sender, EventArgs e)
        {
            _urltest.DeleteUrl((int)UrlsByKlantLstBx.SelectedValue);
            //clearBox();
            getUrlsFromKlant(_selectedKlantId);
        }

        private void SecurityIdTxtBx_TextChanged(object sender, EventArgs e)
        {
            changedSecurityId = SecurityIdTxtBx.Text;
        }

        private void UrlTxtBx_TextChanged_1(object sender, EventArgs e)
        {
            changedUrl = UrlTxtBx.Text;
        }

        private void AddUrlBtn_Click(object sender, EventArgs e)
        {
            var m = new AddKlantForm();
            m.Show();
        }

        private void AddUrlByKlantBttn_Click(object sender, EventArgs e)
        {
            SetValueForKlantId = _selectedKlantId;
            var m = new AddUrlForm();
            m.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            m.Show();
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            getUrlsFromKlant(SetValueForKlantId);
        }
        private void clearBox()
        {
            SecurityIdTxtBx.Text = string.Empty;
            UrlTxtBx.Text = string.Empty;
        }
    }
}
