using MaterialSkin.Controls;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AddWebserviceForm : MaterialForm
    {
        private string _newWebserviceNaam;

        private bool _isSoap;

        private List<WebService> _webServiceDatas = new List<WebService>();

        WebserviceTest _webserviceTest;
        ErrorProvider _error;
        public AddWebserviceForm()
        {
            InitializeComponent();
            _webserviceTest = new WebserviceTest();
            _error = new ErrorProvider();

            _webServiceDatas = _webserviceTest.GetWebServiceData();

            AddWebserviceBttn.Enabled = false;
        }

        private void AddWebserviceBttn_Click(object sender, System.EventArgs e)
        {
            if (NewWebserviceNaamTxtBx.Text != string.Empty)
            {
                WebService webServiceData = _webServiceDatas.Find(w => w.Name == NewWebserviceNaamTxtBx.Text);
                if (webServiceData == null)
                {
                    _webserviceTest.AddWebService(_newWebserviceNaam, _isSoap);
                    Close();
                }
                else
                {
                    _error.SetError(NewWebserviceNaamTxtBx, ConfigurationManager.AppSettings["BestaatAlInDb"]);
                }
            }
        }

        private void NewKlantNaamTxtBx_TextChanged(object sender, System.EventArgs e)
        {
            _error.Clear();
            if (NewWebserviceNaamTxtBx.Text != string.Empty)
            {
                AddWebserviceBttn.Enabled = true;
            }
            else
            {
                AddWebserviceBttn.Enabled = false;
            }
            _newWebserviceNaam = NewWebserviceNaamTxtBx.Text;
        }

        private void SoapWebserviceChkBx_CheckedChanged(object sender, System.EventArgs e)
        {
            _isSoap = SoapWebserviceChkBx.Checked;
        }
    }
}
