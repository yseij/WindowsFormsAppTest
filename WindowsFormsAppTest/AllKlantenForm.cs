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
        private string changedUrl;
        private int _selectedKlantId;

        private List<UrlData> _urlDatasByKlant = new List<UrlData>();
        private List<KlantData> _klantDatas = new List<KlantData>();

        UrlTest _urltest;
        KlantTest _klantTest;
        public AllKlantenForm()
        {
            InitializeComponent();
            _urltest = new UrlTest();
            _klantTest = new KlantTest();

            getKlanten();
        }

        private void getKlanten()
        {
            _klantDatas = _klantTest.GetKlantDatas(true);
            fillCmbxKlanten();
        }

        private void getUrlsFromKlant(int id)
        {
            _urlDatasByKlant = _urltest.GetAllUrlsByForeignKeyKlant(id);
            fillLstBxUlsFromKlant();
        }
        private void fillCmbxKlanten()
        {
            AllKlantLstBx.DataSource = null;
            AllKlantLstBx.DisplayMember = "Name";
            AllKlantLstBx.ValueMember = "Id";
            AllKlantLstBx.DataSource = _klantDatas;
        }

        private void fillLstBxUlsFromKlant()
        {
            UrlsByKlantLstBx.DataSource = null;
            UrlsByKlantLstBx.DisplayMember = "Name";
            UrlsByKlantLstBx.ValueMember = "Id";
            UrlsByKlantLstBx.DataSource = _urlDatasByKlant;
        }

        private void AllKlantLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllKlantLstBx.DataSource != null)
            {
                int idOfSelected = (int)AllKlantLstBx.SelectedValue;
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
    }
}
