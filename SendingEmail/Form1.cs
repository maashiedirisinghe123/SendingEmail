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
using System.IO;


namespace SendingEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        MailMessage mail = new MailMessage("malshas558@gmail.com", ToTxtBox.Text);
            mail.Subject = SubTxtBox.Text;
            mail.Body = BodyTxtBox.Text;
            foreach (String filename in openFileDialog1.FileNames)
            {
                if(File.Exists(filename))
                {
                    string fname = Path.GetFileName(filename);
                    mail.Attachments.Add(new Attachment(filename));

                }
            }
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            System.Net.NetworkCredential nc = new NetworkCredential("malshas558@gmail.com", "cygfjcwvrdrfcivt");
            smtp.EnableSsl = true;
            smtp.Credentials = nc;
            smtp.Send(mail);
            label1.Text = "Mail has been sent Successfully " +ToTxtBox.Text;


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();

            foreach (String filename in openFileDialog1.FileNames)
            {
                MessageBox.Show(filename);
                label3.Text = filename.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}