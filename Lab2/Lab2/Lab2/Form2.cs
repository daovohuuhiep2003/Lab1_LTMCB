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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd(); richTextBox1.Text = content;
                fs.Close();
            }
            catch
            {
                string message = "Error!";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                string content = sr.ReadToEnd();
                richTextBox1.Text = content;
                fs.Close();
                richTextBox1.Text = content;
                content = content.ToUpper();
                StreamWriter sw = new StreamWriter("Output.txt");
                sw.Write(content);
                sw.Close();
            }
            catch 
            {
                string message = "Error!";
                string title = "Warning";
                MessageBox.Show(message, title);
            }  
        }
    }
}
