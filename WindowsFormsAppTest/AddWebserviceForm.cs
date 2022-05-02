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

        ErrorProvider _error;

        WebserviceXml _webserviceXml;
        public AddWebserviceForm()
        {
            InitializeComponent();
            _webserviceXml = new WebserviceXml();
            _error = new ErrorProvider();

            _webServiceDatas = _webserviceXml.GetWebservices();

            AddWebserviceBttn.Enabled = false;
        }

        private void AddWebserviceBttn_Click(object sender, System.EventArgs e)
        {
            if (NewWebserviceNaamTxtBx.Text != string.Empty)
            {
                WebService webServiceData = _webServiceDatas.Find(w => w.Name == NewWebserviceNaamTxtBx.Text);
                if (webServiceData == null)
                {
                    WebService newWebService = new WebService(NewWebserviceNaamTxtBx.Text, SoapWebserviceChkBx.Checked, NewSecurityTxtBx.Text);
                    _webserviceXml.AddWebservice(newWebService);
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
        }
    }
}
