using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    class TestRoute
    {
        WebRequest _webRequest;

        public TestRoute()
        {
            _webRequest = new WebRequest();
        }

        public void TestOneRoute(dynamic result,
                              MaterialTextBox2 textBoxWebservice,
                              CheckBox sslChckBx,
                              MaterialTextBox sllCertificaatVervalDatumTxtBx,
                              CheckBox checkBoxKraanDLL,
                              CheckBox checkBoxKraanIni,
                              CheckBox checkBoxKraanDatabase,
                              MaterialMultiLineTextBox2 ResponseTextBox,
                              string selectedText)
        {
            LogFile logFile = new LogFile();
            logFile.MakeLogFile(selectedText);
            foreach (JProperty item in result)
            {
                switch (item.Name)
                {
                    case "WebserviceVersie":
                        string[] strlist = item.Value.ToString().Split(':');
                        textBoxWebservice.Text = strlist[1];
                        logFile.AddTextToLogFile("WebserviceVersie = " + strlist[1] + "\n");
                        break;
                    case "certVerValDatum":
                        if (item.Value.ToString() != "")
                        {
                            sslChckBx.Checked = true;
                            sllCertificaatVervalDatumTxtBx.Text = item.Value.ToString();
                            logFile.AddTextToLogFile("certVerValDatum = " + item.Value.ToString() + "\n");
                        }
                        break;
                    case "KraanDll":
                        checkBoxKraanDLL.Checked = item.Value.ToString().Contains("True");
                        logFile.AddTextToLogFile("KraanDll = " + item.Value.ToString().Contains("True") + "\n");
                        break;
                    case "KraanIni":
                        checkBoxKraanIni.Checked = item.Value.ToString().Contains("True");
                        logFile.AddTextToLogFile("KraanIni = " + item.Value.ToString().Contains("True") + "\n");
                        break;
                    case "KraanDatabase":
                        checkBoxKraanDatabase.Checked = item.Value.ToString().Contains("True");
                        logFile.AddTextToLogFile("KraanDatabase = " + item.Value.ToString().Contains("True") + "\n");
                        break;
                    case "id":
                        break;
                    case "ex":
                        ResponseTextBox.Text = ResponseTextBox.Text + item.Value;
                        logFile.AddTextToLogFile(item.Value.ToString() + "\n");
                        break;
                    default:
                        ResponseTextBox.Text = ResponseTextBox.Text + item.Name + " = " + item.Value + Environment.NewLine;
                        logFile.AddTextToLogFile(item.Name + " = " + item.Value.ToString() + "\n");
                        break;
                }
            }
        }

        public void TestOneRouteSoap(dynamic result,
                              MaterialTextBox webserviceVersie,
                              MaterialTextBox devExpressVersie,
                              MaterialTextBox databaseVersie,
                              string selectedText)
        {
            LogFile logFile = new LogFile();
            logFile.MakeLogFile(selectedText);
            string data = result.Replace("----", "");
            int positionWebserviceVersie = data.IndexOf("Webservice Versie");
            int positionDevExpressVersie = data.IndexOf("DevExpress versie");
            int positionDatabaseVersie = data.IndexOf("DatabaseVersie");
            int dataLengte = data.Length;
            webserviceVersie.Text = data.Substring(positionWebserviceVersie, positionDevExpressVersie - positionWebserviceVersie).Split(':')[1];
            devExpressVersie.Text = data.Substring(positionDevExpressVersie, positionDatabaseVersie - positionDevExpressVersie).Split(':')[1];
            databaseVersie.Text = data.Substring(positionDatabaseVersie, dataLengte - positionDatabaseVersie).Split(':')[1];
        }
    }
}