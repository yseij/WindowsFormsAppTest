using MaterialSkin.Controls;
using System;

namespace WindowsFormsAppTest
{
    public partial class ErrorForm : MaterialForm
    {
        string errorMessage = string.Empty;
        public ErrorForm(string error)
        {
            InitializeComponent();
            errorMessage = error;
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            ErrorMessage.Text = errorMessage;
        }
    }
}
