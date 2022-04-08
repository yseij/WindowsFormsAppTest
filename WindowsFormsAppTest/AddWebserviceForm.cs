using MaterialSkin.Controls;
namespace WindowsFormsAppTest
{
    public partial class AddWebserviceForm : MaterialForm
    {
        private string _newWebserviceNaam;

        private bool _isSoap;

        WebserviceTest _webserviceTest;
        public AddWebserviceForm()
        {
            InitializeComponent();
            _webserviceTest = new WebserviceTest();
        }

        private void AddWebserviceBttn_Click(object sender, System.EventArgs e)
        {
            _webserviceTest.AddWebService(_newWebserviceNaam, _isSoap);
            Close();
        }

        private void NewKlantNaamTxtBx_TextChanged(object sender, System.EventArgs e)
        {
            _newWebserviceNaam = NewKlantNaamTxtBx.Text;
        }

        private void SoapWebserviceChkBx_CheckedChanged(object sender, System.EventArgs e)
        {
            _isSoap = SoapWebserviceChkBx.Checked;
        }
    }
}
