using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Form1 : Form
    {
        private string url;
        private string urlHtpp = "https://wsdev.kraan.com/";
        private string selectedUrl;
        private string changedUrl;
        WebClient wc = new WebClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxUrls.Items.Add("KraanHomeDNARelease/HomeDna.svc/Getwebserviceversion");
            this.httpTextBox.Text = urlHtpp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(urlHtpp + url);
            try
            {
                HttpWebRequest request = HttpWebRequest.Create(urlHtpp + url) as HttpWebRequest;

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    int statusCode = (int)response.StatusCode;
                    if (statusCode >= 100 && statusCode < 400) //Good requests
                    {
                        Console.WriteLine("goed");
                        string data = wc.DownloadString(urlHtpp + url);
                        this.ResponseTextBox.Text = data;
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
            url = comboBoxUrls.SelectedItem.ToString();
            selectedUrl = url;
            UrlChangeTextBox.Text = comboBoxUrls.SelectedItem.ToString();
        }

        private void PasUrlAanButton_Click(object sender, EventArgs e)
        {
            comboBoxUrls.Items.Remove(selectedUrl);
            comboBoxUrls.Items.Clear();
            comboBoxUrls.Text = changedUrl;
            comboBoxUrls.Items.Add(changedUrl);
        }

        private void UrlChangeTextBox_TextChanged(object sender, EventArgs e)
        {
            changedUrl = UrlChangeTextBox.Text.ToString();
        }
    }
}
