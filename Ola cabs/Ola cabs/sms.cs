using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Ola_cabs
{
    public partial class sms : Form
    {
        string randomCode;
        public static string to;
        public sms()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ///        }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void send_Click(object sender, EventArgs e)
        {

            string from, pass, messagebody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (textBox1.Text).ToString();
            from = "olacabs.verify@gmail.com";
            pass = "lakshan@2000";
            messagebody = $" your otp code is {randomCode}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = "otp code is ";
            SmtpClient smtp = new SmtpClient("smtp.Gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {

                smtp.Send(message);
                MessageBox.Show(" sode succsessfully send");

            }
            catch
            {

                MessageBox.Show(" sode succsessfully send");
            }
        }

        private void verify1_Click(object sender, EventArgs e)
        {
            if (randomCode == (textBox2.Text).ToString())
            {
                to = textBox1.Text;


                MessageBox.Show(" code correct");

                UserDashbord user = new UserDashbord();
                user.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show(" wrong code");


            }
        }
    }
}