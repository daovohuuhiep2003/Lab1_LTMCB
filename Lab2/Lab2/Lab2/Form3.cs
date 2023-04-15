using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName , FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd(); 
            richTextBox1.Text = content;
            textBox1.Text = ofd.SafeFileName.ToString();
            textBox2.Text = fs.Name.ToString();
            content = content.Replace("\r\n", "\r");
            int a;
            a = richTextBox1.Lines.Count();
            textBox3.Text = a.ToString();
            content = content.Replace('\r', ' ');
            string[] source = content.Split(new char[] { '!', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            textBox4.Text = source.Count().ToString();
            textBox5.Text = content.Length.ToString();
            fs.Close();
        }
    }
}
