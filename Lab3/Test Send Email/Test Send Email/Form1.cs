using System.Net.Mail;
using System.Net;

namespace Test_Send_Email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SEND_EMAIL_Click(object sender, EventArgs e)
        {
            string toAddress = "daovohuuhiep2003@gmail.com";
            string fromAddress = "daovohuuhiep2003@gmail.com";
            string subject = "Test email";
            string body = "This is a test email from C#.";

            using (var message = new MailMessage(fromAddress, toAddress))
            {
                message.Subject = subject;
                message.Body = body;

                using (var client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.Credentials = new NetworkCredential("daovohuuhiep2003@gmail.com", "12345679hiep");
                    client.EnableSsl = true;
                    client.Send(message);
                }
            }
        }
    }
}