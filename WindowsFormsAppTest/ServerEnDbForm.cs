using MaterialSkin.Controls;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class ServerEnDbForm : MaterialForm
    {
        ErrorProvider _error;
        public ServerEnDbForm()
        {
            InitializeComponent();
            _error = new ErrorProvider();
        }

        private void ServerEnDatabase_Click(object sender, EventArgs e)
        {
            _error.Clear();
            if (ServerNaamTxtBx.Text != string.Empty)
            {
                if (Properties.Settings.Default.SaveDbPlace != "///")
                {
                    Properties.Settings.Default.ServerNaam = ServerNaamTxtBx.Text;
                    Properties.Settings.Default.Save();
                    Close();
                }
                else
                {
                    _error.SetError(PlaatsDbOpslaanBtn, "Geen plaats voor opslaan opgegeven");
                }
            }
            else
            {
                _error.SetError(ServerNaamTxtBx, "Geef een server naam in");
            }
        }

        private void PlaatsDbOpslaanBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Custom Description";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string SelectedPath = fbd.SelectedPath;
                Properties.Settings.Default.SaveDbPlace = SelectedPath;
            }
        }
    }
}
