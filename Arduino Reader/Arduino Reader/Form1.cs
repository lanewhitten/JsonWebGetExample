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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
            
                WebBrowser browser = new WebBrowser();
                browser.Navigate(textBox2.Text);
                HtmlDocument doc = browser.Document;
                //doc.InvokeScript("someScript");
                Console.WriteLine(doc.ToString());
            

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            WebClient client = new WebClient();

            string s = client.DownloadString(textBox1.Text);
            richTextBox1.Text = s;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
