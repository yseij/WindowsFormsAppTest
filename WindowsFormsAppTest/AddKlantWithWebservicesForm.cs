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
        private List<WebService> _webserviceDatas = new List<WebService>();
        private Guid _klantId;
        private int _aantalFouten = -1;

        ErrorProvider _error;
        WebserviceXml _webserviceXml;
        KlantXml _klantXml;
        KlantWebserviceXml _klantWebserviceXml;

        public AddKlantWithWebservicesForm(Guid klantId)
        {
            InitializeComponent();
            _error = new ErrorProvider();
            _webserviceXml = new WebserviceXml();
            _klantXml = new KlantXml();
            _klantWebserviceXml = new KlantWebserviceXml();
            _klantId = klantId;

            AddAndUpdateKlantBttn.Enabled = false;

            if (_klantId != Guid.Empty)
            {
                FillKlantData();
                AddAndUpdateKlantBttn.Text = "KLANT AANPASSEN";
            }
            else
            {
                CheckBoxEnable(false, "BasisUrl1");
                CheckBoxEnable(false, "BasisUrl2");
                UrlsGenererenBtn.Enabled = false;
                AddAndUpdateKlantBttn.Text = "KLANT TOEVOEGEN";
            }
            FillTable();
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

            foreach (WebService webService in _webserviceDatas)
            {
                KlantWebservice klantWebservice = new KlantWebservice();
                bool isKlantWebservice = false;
                bool isBasisUrl1 = false;
                bool isBasisUrl2 = false;
                if (_klantId != Guid.Empty)
                {
                    klantWebservice = _klantWebserviceXml.GetByKlantAndByWebservice(_klantId, webService.Id);
                    if (klantWebservice != null)
                    {
                        isKlantWebservice = true;
                        isBasisUrl1 = klantWebservice.BasisUrl1;
                        isBasisUrl2 = klantWebservice.BasisUrl2;
                    }
                }
                TableLayoutWebservice.Controls.Add(new CheckBox()
                {
                    Text = webService.Name,
                    Tag = webService.Id,
                    AutoSize = true,
                    Checked = isKlantWebservice
                }, 0, row);
                TableLayoutWebservice.Controls.Add(new CheckBox()
                {
                    CheckAlign = ContentAlignment.MiddleCenter,
                    Checked = isBasisUrl1,
                    Tag = "BasisUrl1"
                }, 1, row);
                TableLayoutWebservice.Controls.Add(new CheckBox()
                {
                    CheckAlign = ContentAlignment.MiddleCenter,
                    Checked = isBasisUrl2,
                    Tag = "BasisUrl2"
                }, 2, row);
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
            ControleIfKlantIsGoed();
        }

        private void BasisUrl1TxtBx_TextChanged(object sender, EventArgs e)
        {
            bool isGevuld = false;
            if (BasisUrl1TxtBx.Text != string.Empty)
            {
                UrlsGenererenBtn.Enabled = true;
                isGevuld = true;
            }
            else
            {
                UrlsGenererenBtn.Enabled = false;

            }
            CheckBoxEnable(isGevuld, "BasisUrl1");
        }

        private void BasisUrl2TxtBx_TextChanged(object sender, EventArgs e)
        {
            bool isGevuld = false;
            if (BasisUrl2TxtBx.Text != string.Empty)
            {
                UrlsGenererenBtn.Enabled = true;
                isGevuld = true;
            }
            else
            {
                UrlsGenererenBtn.Enabled = false;
            }
            CheckBoxEnable(isGevuld, "BasisUrl2");
        }

        private void CheckBoxEnable(bool isGevuld, string basisurl)
        {
            TableLayoutControlCollection controls = TableLayoutWebservice.Controls;
            foreach (Control c in controls)
            {
                CheckBox checkBox = (CheckBox)c;
                if (checkBox.Tag.ToString() == basisurl)
                {
                    checkBox.Enabled = isGevuld;
                }
            }
        }

        private void AddKlantBttn_Click(object sender, EventArgs e)
        {
            bool isChecked = false;
            bool inError = false;
            string huidigeWebservice = string.Empty;

            if (NewKlantNaamTxtBx.Text != string.Empty || BasisUrl1TxtBx.Text != string.Empty)
            {
                KlantWebservice klantWebservice = new KlantWebservice();
                klantWebservice.BasisUrl1 = false;
                klantWebservice.BasisUrl2 = false;

                Klant klant = new Klant(NewKlantNaamTxtBx.Text, BasisUrl1TxtBx.Text, BasisUrl2TxtBx.Text);
                if (_klantId != Guid.Empty)
                {
                    klantWebservice.Klant = _klantId;
                }
                else
                {
                    Klant klantExist = _klantXml.GetKlantenByTheSameName(NewKlantNaamTxtBx.Text);
                    if (klantExist == null)
                    {
                        _klantXml.AddKlant(klant);
                        klantWebservice.Klant = klant.Id;
                    }
                    else
                    {
                        _error.SetError(NewKlantNaamTxtBx, ConfigurationManager.AppSettings["BestaatAlInDb"]);
                        inError = true;
                    }
                }

                Guid guid = Guid.Empty;

                TableLayoutControlCollection controls = TableLayoutWebservice.Controls;
                foreach (Control c in controls)
                {
                    CheckBox checkBox = (CheckBox)c;
                    if (isChecked == false && c.Tag.ToString() != "BasisUrl1" && c.Tag.ToString() != "BasisUrl2")
                    {
                        if (checkBox.Checked)
                        {
                            isChecked = true;
                            guid = Guid.Parse(checkBox.Tag.ToString());
                            huidigeWebservice = checkBox.Text;
                        }
                    }
                    if (isChecked)
                    {
                        if (checkBox.Checked)
                        {
                            klantWebservice.Webservice = guid;
                            if (c.Tag.ToString() == "BasisUrl1")
                            {
                                klantWebservice.BasisUrl1 = true;
                                klantWebservice.BasisUrl2 = false;
                            }
                            else if (c.Tag.ToString() == "BasisUrl2")
                            {
                                klantWebservice.BasisUrl1 = false;
                                klantWebservice.BasisUrl2 = true;
                            }
                        }
                        if (c.Tag.ToString() == "BasisUrl2")
                        {
                            if (isChecked)
                            {
                                if (klantWebservice.BasisUrl1 == false && klantWebservice.BasisUrl2 == false)
                                {
                                    MessageBoxManager.Yes = "BasisUrl1";
                                    MessageBoxManager.No = "BasisUrl2";
                                    MessageBoxManager.Register();
                                    DialogResult dialogResult = MessageBox.Show("Je moet bij elke webservice die je hebt aangeduid ook een basisurl meegeven, Welke basisUrl wil je bij de " + huidigeWebservice + " webservice gebruiken", "BasisUrl bij webservice", MessageBoxButtons.YesNo);
                                    if (dialogResult == DialogResult.Yes)
                                    {

                                        klantWebservice.BasisUrl1 = true;
                                    }
                                    else if (dialogResult == DialogResult.No)
                                    {
                                        klantWebservice.BasisUrl2 = true;
                                    }
                                    MessageBoxManager.Unregister();
                                }
                                AddKlantWebservice(klantWebservice);
                                klantWebservice.BasisUrl1 = false;
                                klantWebservice.BasisUrl2 = false;
                                klantWebservice.Webservice = Guid.Empty;
                                klantWebservice.Id = Guid.NewGuid();
                            }
                            isChecked = false;
                        }
                    }
                }
                if (!inError)
                {
                    Close();
                }
            }
        }

        private void AddKlantWebservice(KlantWebservice klantWebservice)
        {
            KlantWebservice klantWebservice1 = _klantWebserviceXml.GetByKlantAndByWebservice(klantWebservice.Klant, klantWebservice.Webservice);
            if (klantWebservice1 == null)
            {
                _klantWebserviceXml.AddKlantWebservice(klantWebservice);
            }
        }

        private void UrlsGenererenBtn_Click(object sender, EventArgs e)
        {
            UrlsLstBx.Items.Clear();

            bool isChecked = false;
            string huidigeWebservice = string.Empty;
            string url = "";
            int teller = 0;
            int aantalFouten = 0;

            CheckBox vorigeCheckBox = new CheckBox();
            TableLayoutControlCollection controls = TableLayoutWebservice.Controls;
            foreach (Control c in controls)
            {
                CheckBox checkBox = (CheckBox)c;
                checkBox.BackColor = Color.Transparent;
                if (isChecked == false && c.Tag.ToString() != "BasisUrl1" && c.Tag.ToString() != "BasisUrl2")
                {
                    if (checkBox.Checked)
                    {
                        isChecked = true;
                        huidigeWebservice = c.Text;
                    }
                }
                if (isChecked)
                {
                    if (checkBox.Checked)
                    {
                        if (c.Tag.ToString() == "BasisUrl1")
                        {
                            url = BasisUrl1TxtBx.Text + huidigeWebservice;
                            teller++;
                            UrlsLstBx.Items.Add(url);
                        }
                        else if (c.Tag.ToString() == "BasisUrl2")
                        {
                            url = BasisUrl2TxtBx.Text + huidigeWebservice;
                            teller++;
                            UrlsLstBx.Items.Add(url);
                        }
                    }
                    if (url == string.Empty && teller == 0 && c.Tag.ToString() == "BasisUrl2")
                    {
                        teller++;
                        aantalFouten++;

                        vorigeCheckBox.BackColor = Color.Red;
                        checkBox.BackColor = Color.Red;
                    }
                    if (c.Tag.ToString() == "BasisUrl2")
                    {
                        isChecked = false;
                        teller = 0;
                    }
                    url = string.Empty;
                }
                else
                {
                    if (checkBox.Checked && (c.Tag.ToString() == "BasisUrl1" || c.Tag.ToString() == "BasisUrl2"))
                    {
                        checkBox.BackColor = Color.Red;
                        aantalFouten++;
                    }
                }
                vorigeCheckBox = checkBox;
            }
            if (aantalFouten == 0)
            {
                _aantalFouten = 0;
            }
            ControleIfKlantIsGoed();
        }

        private void ControleIfKlantIsGoed()
        {
            _error.Clear();
            if (NewKlantNaamTxtBx.Text != string.Empty && _aantalFouten == 0)
            {
                AddAndUpdateKlantBttn.Enabled = true;
            }
            else
            {
                AddAndUpdateKlantBttn.Enabled = false;
            }
        }

        private void FillKlantData()
        {
            Klant klant = _klantXml.GetKlantenById(_klantId);
            NewKlantNaamTxtBx.Text = klant.Name;
            BasisUrl1TxtBx.Text = klant.BasisUrl1;
            BasisUrl2TxtBx.Text = klant.BasisUrl2;
        }
    }
}
