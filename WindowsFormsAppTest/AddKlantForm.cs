using MaterialSkin.Controls;
using System;

namespace WindowsFormsAppTest
{
    public partial class AddKlantForm : MaterialForm
    {
        KlantTest _klantTest;
        public AddKlantForm()
        {
            InitializeComponent();
            _klantTest = new KlantTest();
        }

        private void AddKlantBttn_Click(object sender, EventArgs e)
        {
            _klantTest.AddKlant(NewKlantNaamTxtBx.Text);
            Close();
        }
    }
}
