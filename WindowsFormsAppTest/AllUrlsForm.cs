﻿using System;
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
    public partial class AllUrlsForm : Form
    {
        private string changedSecurityId = "";
        private string changedUrl;
        private int _selectedWebserviceId;
        private int _selectedKlantId;

        private List<UrlData> _urlDatas = new List<UrlData>();
        private List<WebServiceData> _webServiceDatas = new List<WebServiceData>();
        private List<KlantData> _klantDatas = new List<KlantData>();

        UrlTest _urltest;
        WebRequest _webRequest;
        WebserviceTest _webserviceTest;
        KlantTest _klantTest;

        public AllUrlsForm()
        {
            InitializeComponent();
            _urltest = new UrlTest();
            _webRequest = new WebRequest();
            _webserviceTest = new WebserviceTest();
            _klantTest = new KlantTest();

            _webServiceDatas = _webserviceTest.GetWebServiceDatas(true);
            _klantDatas = _klantTest.GetKlantDatas(true);
            _urlDatas = _urltest.GetUrlDatas();

            fillCmbxWebServices();
            fillCmbxKlanten();
        }

        private void AllUrlsForm_Load(object sender, EventArgs e)
        {
            getUrls();
        }

        private void getUrls()
        {
            _urlDatas = _urltest.GetUrlDatas(true);
            fillLstBxls();
        }

        private void fillLstBxls()
        {
            AllUrlsLstBx.DataSource = null;
            AllUrlsLstBx.DisplayMember = "Name";
            AllUrlsLstBx.ValueMember = "Id";
            AllUrlsLstBx.DataSource = _urlDatas;
        }

        private void AllUrlsLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearBox();
            if (AllUrlsLstBx.DataSource != null)
            {
                int idOfSelected = (int)AllUrlsLstBx.SelectedValue;
                UrlData urlData = _urlDatas.Find(u => u.Id == idOfSelected);
                foreach (var webService in _webServiceDatas)
                {
                    if (urlData.WebServiceDataId == webService.Id)
                    {
                        WebServiceCmbx.SelectedItem = webService;
                    }
                }
                foreach (var klant in _klantDatas)
                {
                    if (urlData.KlantDataId == klant.Id)
                    {
                        KlantCmbBx.SelectedItem = klant;
                    }
                }
                UrlTxtBx.Text = urlData.Name;
                SecurityIdTxtBx.Text = urlData.SecurityId;
            }
        }

        private void PasUrlAanBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = AllUrlsLstBx.SelectedIndex;
            int idOfSelected = (int)AllUrlsLstBx.SelectedValue;
            _urltest.UpdateUrl(idOfSelected, changedUrl, changedSecurityId);
            clearBox();
            getUrls();
            AllUrlsLstBx.SelectedIndex = selectedIndex;
        }

        private void clearBox()
        {
            SecurityIdTxtBx.Text = string.Empty;
            UrlTxtBx.Text = string.Empty;
        }

        private void DeleteUrlBttn_Click(object sender, EventArgs e)
        {
            clearBox();
            _urltest.DeleteUrl((int)AllUrlsLstBx.SelectedValue);
            AllUrlsLstBx.SelectedIndex = 0;
            getUrls();
        }

        private void SecurityIdTxtBx_TextChanged(object sender, EventArgs e)
        {
            changedSecurityId = SecurityIdTxtBx.Text;
        }

        private void UrlTxtBx_TextChanged(object sender, EventArgs e)
        {
            changedUrl = UrlTxtBx.Text;
        }

        private void AddUrlBtn_Click(object sender, EventArgs e)
        {
            var m = new AddUrlForm();
            m.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            m.Show();
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            getUrls();
        }

        private void WebServiceCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedWebserviceId = (int)WebServiceCmbx.SelectedValue;
        }

        private void KlantCmbBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedKlantId = (int)KlantCmbBx.SelectedValue;
        }

        private void fillCmbxWebServices()
        {
            WebServiceCmbx.DataSource = null;
            WebServiceCmbx.DisplayMember = "Name";
            WebServiceCmbx.ValueMember = "Id";
            WebServiceCmbx.DataSource = _webServiceDatas;
        }

        private void fillCmbxKlanten()
        {
            KlantCmbBx.DataSource = null;
            KlantCmbBx.DisplayMember = "Name";
            KlantCmbBx.ValueMember = "Id";
            KlantCmbBx.DataSource = _klantDatas;
        }
    }
}
