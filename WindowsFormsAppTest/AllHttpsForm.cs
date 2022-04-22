using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AllHttpsForm : MaterialForm
    {
        private List<HttpData> _httpDatas = new List<HttpData>();

        HttpTest _httpTest;
        ErrorProvider _error;
        public AllHttpsForm()
        {
            InitializeComponent();
            _httpTest = new HttpTest();
            _error = new ErrorProvider();

            GetHttps();
        }

        private void GetHttps()
        {
            _httpDatas = _httpTest.GetHttpData();
            FillLstBxHttps();
        }

        private void FillLstBxHttps()
        {
            AllHttpsKrLstBx.FillListBoxHttpData(_httpDatas);
            if (_httpDatas.Count > 0)
            {
                AllHttpsKrLstBx.SelectedIndex = 0;
                FillHttpData(_httpDatas[0]);
            }
        }
        private void AllHttpsKrLstBx_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (AllHttpsKrLstBx.Items != null && AllHttpsKrLstBx.SelectedValue != null)
            {
                int idOfSelected = (int)AllHttpsKrLstBx.SelectedValue;
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
            _httpTest.DeleteHttp((int)AllHttpsKrLstBx.SelectedValue);
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
            int selectedIndex = AllHttpsKrLstBx.SelectedIndex;
            int idOfSelected = (int)AllHttpsKrLstBx.SelectedValue;
            _httpTest.UpdateHttp(idOfSelected, HttpTxtBx.Text);
            GetHttps();
            AllHttpsKrLstBx.SelectedIndex = selectedIndex;
        }

        private void HttpTxtBx_TextChanged(object sender, System.EventArgs e)
        {
            if (HttpTxtBx.Text != string.Empty)
            {
                PasHttpAanBtn.Enabled = true;
            }
            else
            {
                _error.SetError(HttpTxtBx, ConfigurationManager.AppSettings["LeegTekstVak"]);
                PasHttpAanBtn.Enabled = false;
            }
        }
    }
}
