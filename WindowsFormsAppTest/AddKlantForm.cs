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

        private void NewSecurityIdTextBox_TextChanged(object sender, EventArgs e)
        {
            _newKlantNaam = NewKlantNaamTxtBx.Text;
        }
    }
}
