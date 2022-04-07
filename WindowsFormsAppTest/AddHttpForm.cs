using MaterialSkin.Controls;
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
    public partial class AddHttpForm : MaterialForm
    {
        HttpTest _httpTest;
        public AddHttpForm()
        {
            InitializeComponent();
            _httpTest = new HttpTest();
        }

        private void AddHttpBttn_Click(object sender, EventArgs e)
        {
            _httpTest.AddHttp(NewHttpNaamTxtBx.Text);
            Close();
        }
    }
}
