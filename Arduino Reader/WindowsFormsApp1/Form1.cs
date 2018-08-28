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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
                  
        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

                 string s = client.DownloadString("http:example");
            // string s = System.IO.File.ReadAllText(@"C:\Users\twhitten\Documents\5PYKWUE0.json");
            //  richTextBox4.Text = s;

            dynamic obj = JsonConvert.DeserializeObject(s);
            richTextBox4.Text = obj.Data.Field1;
            richTextBox2.Text = obj.Data.Field2;
            richTextBox3.Text = obj.Data.Field3;
        }

      
    }
}
