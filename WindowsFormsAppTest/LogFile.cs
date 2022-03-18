using System;
using System.Configuration;
using System.IO;

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
            FilePath = @""+ ConfigurationManager.AppSettings["opslaanLogFile"] + "\\" + Name.Replace("/", "") + "_op_datum_" + Date + Time + ".txt";
            string createText = "Log van " + Name + " op datum " + Date + Environment.NewLine;
            File.WriteAllText(FilePath, createText);
        }

        public void AddTextToLogFile(string text)
        {
            File.AppendAllText(FilePath, text);
        }
    }
}
