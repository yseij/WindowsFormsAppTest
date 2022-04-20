using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AddKlantForm : MaterialForm
    {
        private List<KlantData> _klantDatas = new List<KlantData>();

        KlantTest _klantTest;
        ErrorProvider _error;
        public AddKlantForm()
        {
            InitializeComponent();
            _klantTest = new KlantTest();
            _error = new ErrorProvider();

            _klantDatas = _klantTest.GetKlantData();

            AddKlantBttn.Enabled = false;
        }

        private void AddKlantBttn_Click(object sender, EventArgs e)
        {
            if (NewKlantNaamTxtBx.Text != string.Empty)
            {
                KlantData klantData = _klantDatas.Find(w => w.Name == NewKlantNaamTxtBx.Text);
                if (klantData == null)
                {
                    _klantTest.AddKlant(NewKlantNaamTxtBx.Text);
                    Close();
                }
                else
                {
                    _error.SetError(NewKlantNaamTxtBx, ConfigurationManager.AppSettings["BestaatAlInDb"]);
                }
            }
        }

        private void NewKlantNaamTxtBx_TextChanged(object sender, EventArgs e)
        {
            _error.Clear();
            if (NewKlantNaamTxtBx.Text != string.Empty)
            {
                AddKlantBttn.Enabled = true;
            }
            else
            {
                AddKlantBttn.Enabled = false;
            }
        }
    }
}
