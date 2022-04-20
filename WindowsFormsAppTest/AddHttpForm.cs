using MaterialSkin.Controls;
using System;

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
