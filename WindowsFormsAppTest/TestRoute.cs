﻿using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    class TestRoute
    {
        private string _filePath;
        
        public void testRoute(dynamic result, 
                              TextBox textBoxWebservice,
                              CheckBox sslChckBx,
                              TextBox sllCertificaatVervalDatumTxtBx,
                              CheckBox checkBoxKraanDLL,
                              CheckBox checkBoxKraanIni,
                              CheckBox checkBoxKraanDatabase,
                              TextBox ResponseTextBox,
                              string selectedText)
        {
            string time = DateTime.Now.ToLongTimeString().Replace(":", "");
            string date = DateTime.Today.ToString("d").Replace("-", "");
            _filePath = @"d:\log_van_" + selectedText.Replace("/", "") + "_op_datum_" + date + time + ".txt";
            string createText = "Log van " + selectedText + date + Environment.NewLine;
            File.WriteAllText(_filePath, createText);
            foreach (JProperty item in result)
            {
                switch (item.Name)
                {
                    case "WebserviceVersie":
                        string[] strlist = item.Value.ToString().Split(':');
                        textBoxWebservice.Text = strlist[1];
                        File.AppendAllText(_filePath, "WebserviceVersie = " + strlist[1] + "\n");
                        break;
                    case "certVerValDatum":
                        if (item.Value != null)
                        {
                            sslChckBx.Checked = true;
                            sllCertificaatVervalDatumTxtBx.Text = item.Value.ToString();
                            File.AppendAllText(_filePath, "certVerValDatum = " + item.Value.ToString() + "\n");
                        }
                        break;
                    case "KraanDll":
                        checkBoxKraanDLL.Checked = item.Value.ToString().Contains("True");
                        File.AppendAllText(_filePath, "KraanDll = " + item.Value.ToString().Contains("True") + "\n");
                        break;
                    case "KraanIni":
                        checkBoxKraanIni.Checked = item.Value.ToString().Contains("True");
                        File.AppendAllText(_filePath, "KraanIni = " + item.Value.ToString().Contains("True") + "\n");
                        break;
                    case "KraanDatabase":
                        checkBoxKraanDatabase.Checked = item.Value.ToString().Contains("True");
                        File.AppendAllText(_filePath, "KraanDatabase = " + item.Value.ToString().Contains("True") + "\n");
                        break;
                    case "id":
                        break;
                    case "ex":
                        ResponseTextBox.Text = ResponseTextBox.Text + item.Value;
                        break;
                    default:
                        ResponseTextBox.Text = ResponseTextBox.Text + item.Name + " = " + item.Value + Environment.NewLine;
                        break;
                }
            }
        }
    }
}