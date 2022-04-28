using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AddHttpForm : MaterialForm
    {
        private List<HttpData> _httpDatas = new List<HttpData>();

        HttpTest _httpTest;
        ErrorProvider _error;
        public AddHttpForm()
        {
            InitializeComponent();
            _httpTest = new HttpTest();
            _error = new ErrorProvider();

            AddHttpBttn.Enabled = false;
        }

        private void AddHttpBttn_Click(object sender, EventArgs e)
        {
            if (NewHttpNaamTxtBx.Text != string.Empty)
            {
                HttpData httpData = _httpDatas.Find(w => w.Name == NewHttpNaamTxtBx.Text);
                if (httpData == null)
                {
                    _httpTest.AddHttp(NewHttpNaamTxtBx.Text);
                    Close();
                }
                else
                {
                    _error.SetError(NewHttpNaamTxtBx, ConfigurationManager.AppSettings["BestaatAlInDb"]);
                }
            }
        }

        private void NewHttpNaamTxtBx_TextChanged(object sender, EventArgs e)
        {
            _error.Clear();
            if (NewHttpNaamTxtBx.Text != string.Empty)
            {
                AddHttpBttn.Enabled = true;
            }
            else
            {
                AddHttpBttn.Enabled = false;
            }
        }
    }
}
