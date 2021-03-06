using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class AddKlantWithWebservicesForm : MaterialForm
    {
        private Guid _klantId;

        private int _aantalFouten = -1;
        private int _teller = 0;

        private bool _checkboxAangepast = false;
        private bool _inError = false;

        string[] kraanWebservices = { "AuthService.svc",
                                      "CrmService.svc",
                                      "WorkflowService.svc",
                                      "MaterieelService.svc",
                                      "MaterieelbeheerService.svc",
                                      "UrenService.svc" };

        string[] kraanSalesService = { "MessageServiceSoap.svc",
                                       "MessageServiceSoap31.svc"};

        private List<WebService> _webserviceDatas = new List<WebService>();

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
            }
            else
            {
                CheckBoxEnable(false, "BasisUrl1");
                CheckBoxEnable(false, "BasisUrl2");
                UrlsGenererenBtn.Enabled = false;
            }
            FillTable();
            CheckAutoScroll();
        }

        private void FillTable()
        {
            _webserviceDatas = _webserviceXml.GetAll();

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
            TableLayoutControlCollection tableLayoutControlCollection = TableLayoutWebservice.Controls;
            foreach (Control control in tableLayoutControlCollection)
            {
                CheckBox checkBox = control as CheckBox;
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AddAndUpdateKlantBttn.Enabled = false;
            _checkboxAangepast = true;
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
            AddAndUpdateKlantBttn.Enabled = false;
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
            AddAndUpdateKlantBttn.Enabled = false;
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
            string huidigeWebservice = string.Empty;

            if (NewKlantNaamTxtBx.Text != string.Empty || BasisUrl1TxtBx.Text != string.Empty)
            {
                KlantWebservice klantWebservice = new KlantWebservice();
                klantWebservice.BasisUrl1 = false;
                klantWebservice.BasisUrl2 = false;

                klantWebservice = KlantExist(klantWebservice);
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
                        else
                        {
                            guid = Guid.Parse(checkBox.Tag.ToString());
                            klantWebservice.Webservice = guid;
                            DeleteKlantWebservice(klantWebservice);
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
                            }
                            else if (c.Tag.ToString() == "BasisUrl2")
                            {
                                klantWebservice.BasisUrl2 = true;
                            }
                        }
                        if (c.Tag.ToString() == "BasisUrl2")
                        {
                            if (isChecked)
                            {
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
                if (!_inError)
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
            else if (klantWebservice1.BasisUrl1 != klantWebservice.BasisUrl1 || klantWebservice1.BasisUrl2 != klantWebservice.BasisUrl2)
            {
                _klantWebserviceXml.UpdateKlantWebservice(klantWebservice.Klant, klantWebservice.Webservice, klantWebservice);
            }
        }

        private void DeleteKlantWebservice(KlantWebservice klantWebservice)
        {
            KlantWebservice klantWebservice1 = _klantWebserviceXml.GetByKlantAndByWebservice(klantWebservice.Klant, klantWebservice.Webservice);
            if (klantWebservice1 != null)
            {
                _klantWebserviceXml.DeleteByKlantWebservice(klantWebservice1.Id);
            }
        }

        private void UrlsGenererenBtn_Click(object sender, EventArgs e)
        {
            UrlsLstBx.Items.Clear();

            bool isChecked = false;
            string huidigeWebservice = string.Empty;
            string url = string.Empty;
            int aantalFouten = 0;
            int HuidigeTabIndex;

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
                        HuidigeTabIndex = c.TabIndex;
                        CheckWebservice(huidigeWebservice, HuidigeTabIndex);
                    }
                }
                if (isChecked)
                {
                    if (checkBox.Checked &&
                    huidigeWebservice != "Kraan2Webservices" &&
                    huidigeWebservice != "KraanWerkbonWebservice" &&
                    huidigeWebservice != "KraanSalesService" &&
                    huidigeWebservice != "KraanHandheld" &&
                    huidigeWebservice != "KraanHomeDNA")
                    {
                        url = SetUrl(checkBox, huidigeWebservice);
                        if (url != string.Empty)
                        {
                            UrlsLstBx.Items.Add(url);
                        }
                    }
                    if (url == string.Empty && _teller == 0 && c.Tag.ToString() == "BasisUrl2")
                    {
                        _teller++;
                        aantalFouten++;

                        vorigeCheckBox.BackColor = Color.Red;
                        checkBox.BackColor = Color.Red;
                    }
                    if (c.Tag.ToString() == "BasisUrl2")
                    {
                        isChecked = false;
                        _teller = 0;
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
            _aantalFouten = -1;
        }

        private void CheckWebservice(string huidigeWebservice, int HuidigeTabIndex)
        {
            if (huidigeWebservice == "Kraan2Webservices")
            {
                UrlsGenererenKraan2Webservice(HuidigeTabIndex, huidigeWebservice);
            }
            else if (huidigeWebservice == "KraanSalesService")
            {
                UrlsGenererenKraanSalesService(HuidigeTabIndex, huidigeWebservice);
            }
            else if (huidigeWebservice == "KraanWerkbonWebservice")
            {
                UrlsGenererenKraanWerkbonWebservice(HuidigeTabIndex, huidigeWebservice);
            }
            else if (huidigeWebservice == "KraanHandheld")
            {
                UrlsGenererenKraanHandheld(HuidigeTabIndex, huidigeWebservice);
            }
            else if (huidigeWebservice == "KraanHomeDNA")
            {
                UrlsGenererenKraanHomeDna(HuidigeTabIndex, huidigeWebservice);
            }
        }

        private void UrlsGenererenKraan2Webservice(int tabIndex, string huidigeWebservice)
        {
            TableLayoutControlCollection controls = TableLayoutWebservice.Controls;
            string basisUrl = string.Empty;
            for (int i = 1; i < 3; i++)
            {
                CheckBox c = (CheckBox)controls[tabIndex + i];
                if (c.Checked)
                {
                    basisUrl = SetUrl(c, huidigeWebservice);
                    for (int a = 0; a < kraanWebservices.Length; a++)
                    {
                        string url = basisUrl + "/" + kraanWebservices[a];
                        UrlsLstBx.Items.Add(url);
                    }
                }
            }
        }

        private void UrlsGenererenKraanSalesService(int tabIndex, string huidigeWebservice)
        {
            TableLayoutControlCollection controls = TableLayoutWebservice.Controls;
            string basisUrl = string.Empty;
            for (int i = 1; i < 3; i++)
            {
                CheckBox c = (CheckBox)controls[tabIndex + i];
                if (c.Checked)
                {
                    basisUrl = SetUrl(c, huidigeWebservice);
                    for (int a = 0; a < kraanSalesService.Length; a++)
                    {
                        string url = basisUrl + "/" + kraanSalesService[a];
                        UrlsLstBx.Items.Add(url);
                    }
                }
            }
        }

        private void UrlsGenererenKraanWerkbonWebservice(int tabIndex, string huidigeWebservice)
        {
            TableLayoutControlCollection controls = TableLayoutWebservice.Controls;
            string basisUrl = string.Empty;
            for (int i = 1; i < 3; i++)
            {
                CheckBox c = (CheckBox)controls[tabIndex + i];
                if (c.Checked)
                {
                    basisUrl = SetUrl(c, huidigeWebservice);
                    string url = basisUrl + "/Webservice.svc";
                    UrlsLstBx.Items.Add(url);
                }
            }
        }

        private void UrlsGenererenKraanHandheld(int tabIndex, string huidigeWebservice)
        {
            TableLayoutControlCollection controls = TableLayoutWebservice.Controls;
            string basisUrl = string.Empty;
            for (int i = 1; i < 3; i++)
            {
                CheckBox c = (CheckBox)controls[tabIndex + i];
                if (c.Checked)
                {
                    basisUrl = SetUrl(c, huidigeWebservice);
                    string url = basisUrl + "/HandheldService.svc/rest/GetVersion";
                    UrlsLstBx.Items.Add(url);
                }
            }
        }

        private void UrlsGenererenKraanHomeDna(int tabIndex, string huidigeWebservice)
        {
            TableLayoutControlCollection controls = TableLayoutWebservice.Controls;
            string basisUrl = string.Empty;
            for (int i = 1; i < 3; i++)
            {
                CheckBox c = (CheckBox)controls[tabIndex + i];
                if (c.Checked)
                {
                    basisUrl = SetUrl(c, huidigeWebservice);
                    string url = basisUrl + "/HomeDna.svc/GetWebserviceVersion";
                    UrlsLstBx.Items.Add(url);
                }
            }
        }

        private string SetUrl(CheckBox c, string huidigeWebservice)
        {
            if (BasisUrl1TxtBx.Text != string.Empty && !BasisUrl1TxtBx.Text.EndsWith("/"))
            {
                BasisUrl1TxtBx.Text += "/";
            }
            if (BasisUrl2TxtBx.Text != string.Empty && !BasisUrl2TxtBx.Text.EndsWith("/"))
            {
                BasisUrl2TxtBx.Text += "/";
            }
            string url = string.Empty;
            if (c.Tag.ToString() == "BasisUrl1")
            {
                url = BasisUrl1TxtBx.Text + huidigeWebservice;
                _teller++;
            }
            else if (c.Tag.ToString() == "BasisUrl2")
            {
                url = BasisUrl2TxtBx.Text + huidigeWebservice;
                _teller++;
            }
            return url;
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

        private KlantWebservice KlantExist(KlantWebservice klantWebservice)
        {
            _inError = false;
            Klant klant = new Klant(NewKlantNaamTxtBx.Text, BasisUrl1TxtBx.Text, BasisUrl2TxtBx.Text);
            if (_klantId != Guid.Empty)
            {
                klantWebservice.Klant = _klantId;
            }
            klant = CheckBasisUrl(klant);
            Klant klantExist = _klantXml.GetKlantenByTheSameName(NewKlantNaamTxtBx.Text);
            if (klantExist != null 
                && (klantExist.BasisUrl1 != klant.BasisUrl1 
                || klantExist.BasisUrl2 != klant.BasisUrl2 
                || _checkboxAangepast))
            {
                _klantXml.UpdateKlant(klantExist.Id, klant);
            }
            else if (klantExist != null)
            {
                _error.SetError(NewKlantNaamTxtBx, ConfigurationManager.AppSettings["BestaatAlInDb"]);
                _inError = true;
            }
            else
            {
                _klantXml.AddKlant(klant);
                klantWebservice.Klant = klant.Id;
            }

            return klantWebservice;
        }

        private Klant CheckBasisUrl(Klant klant)
        {
            if (klant.BasisUrl1 != string.Empty)
            {
                if (!klant.BasisUrl1.EndsWith("/"))
                {
                    klant.BasisUrl1 += "/";
                }
            }
            if (klant.BasisUrl2 != string.Empty)
            {
                if (!klant.BasisUrl2.EndsWith("/"))
                {
                    klant.BasisUrl2 += "/";
                }
            }
            return klant;
        }

        private void AnnulerenKlantBttn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckAutoScroll()
        {
            if (TableLayoutWebservice.VerticalScroll.Visible)
            {
                TableLayoutHeader.Width = TableLayoutWebservice.Width - 18;
            }
            else
            {
                TableLayoutHeader.Width = TableLayoutWebservice.Width;
            }
        }
    }
}
