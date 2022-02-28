﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Form1 : Form
    {
        private string url;
        private string urlHttp = "https://ws.kraan.com:444/";
        private string selectedUrl;
        private string changedUrl;
        private string webserviceVersie;
        private string kraanDll;
        private string kraanIni;
        private string kraanDatabase;


        private int positionKraanDll;
        private int positionKraanIni;
        private int positionDatabaseConnect;
        private int positionDatabaseMelding;

        WebClient wc = new WebClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxUrls.Items.Add("KraanHomeDNA/HomeDna.svc/Getwebserviceversion");
            this.httpTextBox.Text = urlHttp;
        }

        private void button1_ClickAsync(object sender, EventArgs e)
        {
            clearBox();
            try
            {
                HttpWebRequest request = HttpWebRequest.Create(urlHttp + url) as HttpWebRequest;

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    int statusCode = (int)response.StatusCode;
                    if (statusCode >= 100 && statusCode < 400) //Good requests
                    {
                        string data = wc.DownloadString(urlHttp + url);

                        positionKraanDll = data.IndexOf("KraanDLL");
                        positionKraanIni = data.IndexOf("Kraan.ini");
                        positionDatabaseConnect = data.IndexOf("Database connectie");
                        positionDatabaseMelding = data.IndexOf("Database melding");

                        webserviceVersie = data.Substring(0, positionKraanDll);
                        kraanDll = data.Substring(positionKraanDll, positionKraanIni - positionKraanDll);
                        kraanIni = data.Substring(positionKraanIni, positionDatabaseConnect - positionKraanIni);
                        kraanDatabase = data.Substring(positionDatabaseConnect, positionDatabaseMelding - positionDatabaseConnect);

                        String[] spearator = {":"};
                        String[] strlist = webserviceVersie.Split(spearator,
                        StringSplitOptions.RemoveEmptyEntries);
                        textBoxWebservice.Text = strlist[1];

                        if (kraanDll.Contains("True"))
                        {
                            checkBoxKraanDLL.Checked = true;
                        }
                        if (kraanIni.Contains("True"))
                        {
                            checkBoxKraanIni.Checked = true;
                        }
                        if(kraanDatabase.Contains("True"))
                        {
                            checkBoxKraanDatabase.Checked = true;
                        }
                    }
                    else if (statusCode >= 500 && statusCode <= 510) //Server Errors
                    {
                        this.ResponseTextBox.Text = "niet goed";
                    }
                }
            }
            catch (WebException ex)
            {
                this.ResponseTextBox.Text = ex.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearBox();
            url = comboBoxUrls.SelectedItem.ToString();
            selectedUrl = url;
            UrlChangeTextBox.Text = comboBoxUrls.SelectedItem.ToString();
        }

        private void PasUrlAanButton_Click(object sender, EventArgs e)
        {
            clearBox();
            comboBoxUrls.Items.Remove(selectedUrl);
            comboBoxUrls.Items.Clear();
            comboBoxUrls.Text = changedUrl;
            comboBoxUrls.Items.Add(changedUrl);
        }

        private void UrlChangeTextBox_TextChanged(object sender, EventArgs e)
        {
            changedUrl = UrlChangeTextBox.Text.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clearBox()
        {
            checkBoxKraanDatabase.Checked = false;
            checkBoxKraanDLL.Checked = false;
            checkBoxKraanIni.Checked = false;
            textBoxWebservice.Text = string.Empty;
            ResponseTextBox.Text = string.Empty;
        }
    }
}
