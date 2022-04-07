using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AllHttpsForm : MaterialForm
    {
        private List<HttpData> _httpDatas = new List<HttpData>();

        HttpTest _httpTest;
        public AllHttpsForm()
        {
            InitializeComponent();
            _httpTest = new HttpTest();
            
            GetHttps();
        }

        private void GetHttps()
        {
            _httpDatas = _httpTest.GetHttpData();
            FillLstBxHttps();
        }

        private void FillLstBxHttps()
        {
            AllHttpsKrMaterialLstBx.FillListBoxHttpData(_httpDatas);
            if (_httpDatas.Count > 0)
            {
                AllHttpsKrMaterialLstBx.SelectedIndex = 0;
                FillHttpData(_httpDatas[0]);
            }
        }

        private void AllHttpsKrMaterialLstBx_SelectedIndexChanged(object sender, MaterialSkin.MaterialListBoxItem selectedItem)
        {
            if (AllHttpsKrMaterialLstBx.Items != null)
            {
                int idOfSelected = (int)AllHttpsKrMaterialLstBx.SelectedItem.Tag;
                HttpData httpData = _httpDatas.Find(u => u.Id == idOfSelected);
                FillHttpData(httpData);
            }
        }

        private void FillHttpData(HttpData httpData)
        {
            HttpTxtBx.Text = httpData.Name;
        }

        private void DeleteHttpBttn_Click(object sender, System.EventArgs e)
        {
            _httpTest.DeleteHttp((int)AllHttpsKrMaterialLstBx.SelectedItem.Tag);
            GetHttps();
        }

        private void AddHttpBtn_Click(object sender, System.EventArgs e)
        {
            var m = new AddHttpForm();
            m.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            m.ShowDialog();
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            GetHttps();
        }

        private void PasHttpAanBtn_Click(object sender, System.EventArgs e)
        {
            int selectedIndex = AllHttpsKrMaterialLstBx.SelectedIndex;
            int idOfSelected = (int)AllHttpsKrMaterialLstBx.SelectedItem.Tag;
            _httpTest.UpdateHttp(idOfSelected, HttpTxtBx.Text);
            GetHttps();
            AllHttpsKrMaterialLstBx.SelectedIndex = selectedIndex;
        }
    }
}
