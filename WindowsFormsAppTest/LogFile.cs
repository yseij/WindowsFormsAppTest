using System;
using System.Configuration;
using System.IO;
using System.Windows;

namespace WindowsFormsAppTest
{
    class LogFile
    {
        public LogFile()
        {
            Date = DateTime.Today.ToString("d").Replace("-", "");
            Time = DateTime.Now.ToLongTimeString().Replace(":", "");
        }
        public string Date { get; set; }
        public string Time { get; set; }
        public string FilePath { get; set; }

        public void MakeLogFile(string Name)
        {
            try
            {
                FilePath = @"" + ConfigurationManager.AppSettings["SaveLogFilePlace"] + "\\" + Name.Replace("/", "") + "_op_datum_" + Date + Time + ".txt";
                string createText = "Log van " + Name + " op datum " + Date + Environment.NewLine;
                File.WriteAllText(FilePath, createText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kies een andere plaats voor het opslaan van de log files '\n' foutcode: " + ex.Message);
            }  
        }

        public void AddTextToLogFile(string text)
        {
            try
            {
                File.AppendAllText(FilePath, text);
            }
            catch
            {
                
            }
        }
    }
}
