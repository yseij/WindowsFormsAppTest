using System;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void OpenTest1UrlBtn_Click(object sender, EventArgs e)
        {
            var m = new EenUrlTestForm();
            m.ShowDialog();
        }

        private void OpenTestWebserviceBtn_Click(object sender, EventArgs e)
        {
            var m = new WebserviceForm();
            m.ShowDialog();
        }

        private void OpenTestWebserviceByKlantBtn_Click(object sender, EventArgs e)
        {
            var m = new WebServicesByKlantForm();
            m.ShowDialog();
        }

        private void UrlsBtn_Click(object sender, EventArgs e)
        {
            var m = new AllUrlsForm();
            m.ShowDialog();
        }

        private void KlantenBtn_Click(object sender, EventArgs e)
        {
            var m = new AllKlantenForm();
            m.ShowDialog();
        }

        private void SoapTestBtn_Click(object sender, EventArgs e)
        {
            SoapRequest soapRequest = new SoapRequest();
        }
    }
}
