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
    public partial class Form2 : Form
    {
        private string NewUrl;
        private string NewSecurityID;
        public Form2()
        {
            InitializeComponent();
        }

        private void AddUrlButton_Click(object sender, EventArgs e)
        {
            UrlTest urltest = new UrlTest();
            urltest.AddUrl(NewUrl, NewSecurityID);
            this.Close();
        }

        private void NewSecurityIdTextBox_TextChanged(object sender, EventArgs e)
        {
            NewSecurityID = NewSecurityIdTextBox.Text;
        }

        private void NewUrlTextBox_TextChanged(object sender, EventArgs e)
        {
            NewUrl = NewUrlTextBox.Text;
        }
    }
}
