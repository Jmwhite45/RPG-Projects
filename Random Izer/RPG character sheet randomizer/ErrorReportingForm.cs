using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;
using System.Windows.Forms;
using static RPG_character_sheet_randomizer.Vars;
using static RPG_character_sheet_randomizer.InOut;

namespace RPG_character_sheet_randomizer
{
    public partial class ErrorReportingForm : Form
    {
        public ErrorReportingForm()
        {
            InitializeComponent();
        }
        public static ErrorReportingForm ERF;

        public void init()
        {
            BackgroundImage = frmref.BackgroundImage;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(FileName.Text != "")
            {
                if(InOut.alreadyExist(FileName.Text) == false)
                {
                    InOut.Save(FileName.Text);
                }
                email(ErrorMessage.Text, FileName.Text);
            }
            else
            {
                email(ErrorMessage.Text);
            }
        }
        public void email(string message, string file)
        {
            Attachment attach = new Attachment(file);
            MailMessage mail = new MailMessage("ErrorReport@RandomIzer.com", "theredmage39@gmail.com");
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.google.com";
            mail.Subject = "Error from Random Izer";
            mail.Body = "Error Type: "+ ErrorType.SelectedValue +NewLine + message + NewLine + NewLine + NewLine + "Patch: " + patch;
            mail.Attachments.Add(attach);
            client.Send(mail);
        }
        public void email(string message)
        {
            MailMessage mail = new MailMessage("ErrorReport@RandomIzer.com", "theredmage39@gmail.com");
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.google.com";
            mail.Subject = "Error from Random Izer";
            mail.Body = message + NewLine + NewLine + NewLine + "Patch: " + patch;
            client.Send(mail);
        }
        private void ExitError_Click(object sender, EventArgs e)
        {
            ErrorForm.Hide();
        }
    }
}
