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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo("C:\\Users\\ADMIN\\Downloads");
                FileInfo[] fiArr = di.GetFiles();
                foreach (FileInfo fileInfo in fiArr)
                {
                    ListViewItem item = new ListViewItem(fileInfo.Name);
                    item.SubItems.Add(fileInfo.Length.ToString());
                    item.SubItems.Add(fileInfo.Extension);
                    item.SubItems.Add(fileInfo.CreationTime.ToString());
                    listView1.Items.Add(item);
                }
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
