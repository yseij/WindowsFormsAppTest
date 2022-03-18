﻿using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class WebserviceOfKlantForm : MaterialForm
    {
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();
        private List<KlantData> _klantenDatas = new List<KlantData>();
        private List<UrlData> _urlData = new List<UrlData>();

        private int selectedWebserviceIdOfKlantId;
        private int aantalLegeUrls;

        private bool _klant;

        WebserviceTest _webserviceTest;
        UrlTest _urltest;
        KlantTest _klantTest;
        WebRequest _webRequest;
        TestRoute _testRoute;

        public WebserviceOfKlantForm(bool isKlant)
        {
            InitializeComponent();
            _webserviceTest = new WebserviceTest();
            _urltest = new UrlTest();
            _klantTest = new KlantTest();
            _webRequest = new WebRequest();
            _testRoute = new TestRoute();
            _klant = isKlant;


            AantalLegeUrlsTxtBx.Text = string.Empty;

            if (isKlant)
            {
                Text = "Per Klant testen";
                LblWebserviceOfKlant.Text = "Klanten";
                _klantenDatas = _klantTest.GetKlantData();
                FillCmbxKlanten();
            }
            else
            {
                Text = "Per Webservice testen";
                LblWebserviceOfKlant.Text = "Webservice";
                _webServiceDatas = _webserviceTest.GetWebServiceDatas(true);
                FillCmbxWebServices();
            }
        }

        private void FillCmbxWebServices()
        {
            WebserviceOfKlantKrMaterialCmbx.FillCmbBoxWebservice(_webServiceDatas);
        }

        private void FillCmbxKlanten()
        {
            WebserviceOfKlantKrMaterialCmbx.FillCmbBoxKlant(_klantenDatas);
        }

        private void TestAllBtn_Click_1(object sender, EventArgs e)
        {
            ClearBox();
            AantalLegeUrlsTxtBx.Text = string.Empty;
            LegeUrlsTxtBx.Text = string.Empty;
            if (_klant)
            {
                _urlData = _urltest.GetAllUrlsByForeignKeyKlant(selectedWebserviceIdOfKlantId);
            }
            else
            {
                _urlData = _urltest.GetAllUrlsByForeignKeyWebservice(selectedWebserviceIdOfKlantId);
            }
            
            _testRoute.TestMoreRoutes(WebserviceOfKlantKrMaterialCmbx.Text,
                                      TrVwAll,
                                      aantalLegeUrls,
                                      _urlData,
                                      ResponseTextBox,
                                      AantalLegeUrlsTxtBx,
                                      LegeUrlsTxtBx);
        }

        private void WebserviceOfKlantKrMaterialCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWebserviceIdOfKlantId = (int)WebserviceOfKlantKrMaterialCmbx.SelectedValue;
        }

        private void TrVwAll_Click(object sender, EventArgs e)
        {
            if (!ZetLogVastChkBx.Checked)
            {
                if (TrVwAll.HitTest(TrVwAll.PointToClient(Cursor.Position)).Node.Tag != null)
                {
                    ClearBox();
                    dynamic UrlData = TrVwAll.HitTest(TrVwAll.PointToClient(Cursor.Position)).Node.Tag;
                    foreach (JProperty item in UrlData)
                    {
                        if (item.Name != "id")
                        {
                            ResponseTextBox.Text = ResponseTextBox.Text + item.Name + " = " + item.Value + Environment.NewLine;
                        }
                        switch (item.Name)
                        {
                            case "WebserviceVersie":
                                string[] strlist1 = item.Value.ToString().Split(':');
                                textBoxWebservice.Text = strlist1[1];
                                break;
                            case "certVerValDatum":
                                if (item.Value.ToString() != "")
                                {
                                    SslChckBx.Checked = true;
                                    SllCertificaatVervalDatumTxtBx.Text = item.Value.ToString();
                                }
                                break;
                            case "KraanDll":
                                checkBoxKraanDLL.Checked = item.Value.ToString().Contains("True");
                                break;
                            case "KraanIni":
                                checkBoxKraanIni.Checked = item.Value.ToString().Contains("True");
                                break;
                            case "KraanDatabase":
                                checkBoxKraanDatabase.Checked = item.Value.ToString().Contains("True");
                                break;
                        }
                    }
                }
            }

        }
        private void CheckBoxReadOnly_Click(object sender, EventArgs e)
        {
            (sender as CheckBox).Checked = !(sender as CheckBox).Checked;
        }
        private void ClearBox()
        {
            checkBoxKraanDatabase.Checked = false;
            checkBoxKraanDLL.Checked = false;
            checkBoxKraanIni.Checked = false;
            textBoxWebservice.Text = string.Empty;
            ResponseTextBox.Text = string.Empty;
            SllCertificaatVervalDatumTxtBx.Text = string.Empty;
            SslChckBx.Checked = false;
        }
    }
}