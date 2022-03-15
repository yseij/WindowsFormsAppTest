using MaterialSkin.Controls;
using System;

namespace WindowsFormsAppTest
{
    public partial class AddKlantForm : MaterialForm
    {
        private string _newKlantNaam;

        KlantTest _klantTest;
        public AddKlantForm()
        {
            InitializeComponent();
            _klantTest = new KlantTest();
        }

        private void AddKlantBttn_Click(object sender, EventArgs e)
        {
            _klantTest.AddKlant(_newKlantNaam);
            Close();
        }

        private void NewKlantNaamTxtBx_TextChanged(object sender, EventArgs e)
        {
            _newKlantNaam = NewKlantNaamTxtBx.Text;
        }
    }
}
