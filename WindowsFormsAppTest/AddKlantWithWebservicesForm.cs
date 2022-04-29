using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsAppTest
{
    public partial class AddKlantWithWebservicesForm : MaterialForm
    {
        private List<XElement> _klantDatas = new List<XElement>();
        private List<XElement> _webserviceDatas = new List<XElement>();

        ErrorProvider _error;
        WebserviceXml _webserviceXml;
        KlantXml _klantXml;
        KlantWebserviceXml _klantWebserviceXml;

        public AddKlantWithWebservicesForm()
        {
            InitializeComponent();
            _error = new ErrorProvider();
            _webserviceXml = new WebserviceXml();
            _klantXml = new KlantXml();
            _klantWebserviceXml = new KlantWebserviceXml();

            FillTable();
            AddKlantBttn.Enabled = false;
        }

        private void FillTable()
        {
            _webserviceDatas = _webserviceXml.GetWebservices();

            TableLayoutHeader.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            TableLayoutWebservice.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            TableLayoutHeader.Controls.Add(new Label() { Text = "Webservice", TextAlign = ContentAlignment.MiddleCenter }, 0, 0);
            TableLayoutHeader.Controls.Add(new Label() { Text = "BasisUrl1", TextAlign = ContentAlignment.MiddleCenter }, 1, 0);
            TableLayoutHeader.Controls.Add(new Label() { Text = "BasisUrl2", TextAlign = ContentAlignment.MiddleCenter }, 2, 0);

            int row = 0;

            foreach (XElement item in _webserviceDatas)
            {
                TableLayoutWebservice.Controls.Add(new CheckBox()
                {
                    Text = item.Attribute("Name").Value,
                    CheckAlign = ContentAlignment.MiddleLeft,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Tag = item.Attribute("Id").Value
                },
                    0,
                    row);
                TableLayoutWebservice.Controls.Add(new CheckBox() { CheckAlign = ContentAlignment.MiddleCenter, Tag = "BasisUrl1" }, 1, row);
                TableLayoutWebservice.Controls.Add(new CheckBox() { CheckAlign = ContentAlignment.MiddleCenter, Tag = "BasisUrl2" }, 2, row);
                row++;
            }
            TableLayoutRowStyleCollection styles =
                TableLayoutWebservice.RowStyles;
            foreach (RowStyle style in styles)
            {
                style.SizeType = SizeType.Absolute;
                style.Height = 25;
            }
        }

        private void NewKlantNaamTxtBx_TextChanged(object sender, EventArgs e)
        {
            _error.Clear();
            if (NewKlantNaamTxtBx.Text != string.Empty)
            {
                AddKlantBttn.Enabled = true;
            }
            else
            {
                AddKlantBttn.Enabled = false;
            }
        }

        private void BasisUrl1TxtBx_TextChanged(object sender, EventArgs e)
        {
            _error.Clear();
            if (BasisUrl1TxtBx.Text != string.Empty)
            {
                AddKlantBttn.Enabled = true;
            }
            else
            {
                AddKlantBttn.Enabled = false;
            }
        }

        private void AddKlantBttn_Click(object sender, EventArgs e)
        {
            bool isChecked = false;
            XElement klantExist = null;
            _klantDatas = _klantXml.GetKlanten();
            if (NewKlantNaamTxtBx.Text != string.Empty || BasisUrl1TxtBx.Text != string.Empty)
            {
                Klant klant = new Klant(NewKlantNaamTxtBx.Text, BasisUrl1TxtBx.Text, BasisUrl2TxtBx.Text);
                klantExist = _klantDatas.Find(k => k.Attribute("Name").Value == NewKlantNaamTxtBx.Text);
                if (klantExist == null)
                {
                    _klantXml.AddKlant(klant);
                }
                else
                {
                    _error.SetError(NewKlantNaamTxtBx, ConfigurationManager.AppSettings["BestaatAlInDb"]);
                }

                KlantWebservice klantWebservice = new KlantWebservice();
                klantWebservice.Klant = klant.Id;
                klantWebservice.BasisUrl1 = false;
                klantWebservice.BasisUrl2 = false;

                Guid guid = Guid.Empty;

                TableLayoutControlCollection controls = TableLayoutWebservice.Controls;
                foreach (Control c in controls)
                {
                    CheckBox checkBox = (CheckBox)c;
                    if (isChecked == false && c.Tag.ToString() != "BasisUrl1" && c.Tag.ToString() != "BasisUrl2")
                    {
                        if (klantWebservice.BasisUrl1 == true || klantWebservice.BasisUrl2 == true && klantWebservice.Webservice != Guid.Empty)
                        {
                            _klantWebserviceXml.AddKlantWebservice(klantWebservice);
                        }
                        else
                        {
                            //MessageBoxButtons button1 = MessageBoxButtons.OK;
                            //MessageBox.Show("Je moet bij elke webservice die je hebt aangeduid ook een basisurl meegeven");
                            //DialogResult dialogResult = MessageBox.Show("Je moet bij elke webservice die je hebt aangeduid ook een basisurl meegeven", "BasisUrl bij webservice", MessageBoxButtons.);
                            //if (dialogResult == DialogResult.Yes)
                            //{
                            //    _klantTest.DeleteKlant((int)AllKlantKrLstBx.SelectedValue);
                            //}
                            //else if (dialogResult == DialogResult.No)
                            //{
                            //    _error.SetError(DeleteKlantBttn, "De klant bevat nog urls");
                            //}
                        }
                        if (checkBox.Checked)
                        {
                            isChecked = true;
                            guid = Guid.Parse(checkBox.Tag.ToString());
                        }
                    }
                    if (isChecked)
                    {
                        if (checkBox.Checked)
                        {
                            if (c.Tag.ToString() == "BasisUrl1")
                            {
                                klantWebservice.Webservice = guid;
                                klantWebservice.BasisUrl1 = true;
                                klantWebservice.BasisUrl2 = false;
                            }
                            else if (c.Tag.ToString() == "BasisUrl2")
                            {
                                klantWebservice.Webservice = guid;
                                klantWebservice.BasisUrl1 = false;
                                klantWebservice.BasisUrl2 = true;
                            }
                        }
                        if (c.Tag.ToString() == "BasisUrl2")
                        {
                            isChecked = false;
                        }
                    }
                }
                _klantWebserviceXml.AddKlantWebservice(klantWebservice);
                Close();
            }
        }
    }
}
