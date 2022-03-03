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
            var m = new Form1();
            m.Show();
        }

        private void OpenTestWebserviceBtn_Click(object sender, EventArgs e)
        {
            var m = new WebserviceForm();
            m.Show();
        }
    }
}
