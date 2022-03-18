using System;using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class SoapRequestForm : Form
    {
        SoapRequest _soapRequest;
        public SoapRequestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _soapRequest = new SoapRequest();
        }
    }
}
