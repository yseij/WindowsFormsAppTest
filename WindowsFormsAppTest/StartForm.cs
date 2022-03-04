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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void OpenTest1UrlBtn_Click(object sender, EventArgs e)
        {
            var m = new EenUrlTestForm();
            m.Show();
        }

        private void OpenTestWebserviceBtn_Click(object sender, EventArgs e)
        {
            var m = new WebserviceForm();
            m.Show();
        }

        private void OpenTestWebserviceByKlantBtn_Click(object sender, EventArgs e)
        {
            var m = new WebServicesByKlantForm();
            m.Show();
        }

        private void UrlsBtn_Click(object sender, EventArgs e)
        {
            var m = new AllUrlsForm();
            m.Show();
        }

        private void KlantenBtn_Click(object sender, EventArgs e)
        {
            var m = new AllKlantenForm();
            m.Show();
        }
    }
}
