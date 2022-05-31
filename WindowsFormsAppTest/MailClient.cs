using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    class MailClient
    {
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            // Get the unique identifier for this asynchronous operation.
            string token = (string)e.UserState;

            if (e.Cancelled)
            {
                Console.WriteLine("[{0}] Send canceled.", token);
            }
            if (e.Error != null)
            {
                Console.WriteLine("[{0}] {1}", token, e.Error.ToString() + "hier ben ik");
            }
            else
            {
                Console.WriteLine("Message sent.");
            }
        }

        public static void SendMail(string title, string text, string FilePath)
        {
            string UserEmail = Properties.Settings.Default.Email;
            // Command-line argument must be the SMTP host.
            SmtpClient client = new SmtpClient(Properties.Settings.Default.MailServerNaam, 
                                               Properties.Settings.Default.MailServerPoort);
            // Specify the email sender.
            // Create a mailing address that includes a UTF8 character
            // in the display name.
            MailAddress from = new MailAddress(Properties.Settings.Default.MailVerzendenVanuitEmail,
               "Foutmelding " + title,
            System.Text.Encoding.UTF8);
            // Set destinations for the email message.
            MailAddress to = new MailAddress(UserEmail);
            // Specify the message content.
            MailMessage message = new MailMessage(from, to);
            // Include some non-ASCII characters in body and subject.
            message.Body = text;
            message.Subject = "Foutmelding " + title;
            message.Attachments.Add(new Attachment(FilePath));
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            // Set the method that is called back when the send operation ends.
            client.SendCompleted += new
            SendCompletedEventHandler(SendCompletedCallback);
            // The userState can be any object that allows your callback
            // method to identify this send operation.
            // For this example, the userToken is a string constant.
            if (Properties.Settings.Default.MailServerGebruikersnaam != "///" 
                && Properties.Settings.Default.MailServerWachtwoord != "///")
            {
                client.Credentials = new NetworkCredential(Properties.Settings.Default.MailServerGebruikersnaam,
                                                           Properties.Settings.Default.MailServerWachtwoord);
            }
            try
            {
                client.Send(message);
                string answer = Console.ReadLine();
                message.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
