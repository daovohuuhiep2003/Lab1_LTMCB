using System.Diagnostics;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"E:\HocKi4\Lập_trình_mạng_căn_bản\Lab_LTMCB\Lab1\Lab1-Bai1\Lab1-Bai1\bin\Debug\net6.0-windows\Lab1_Bai1.exe";
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"E:\HocKi4\Lập_trình_mạng_căn_bản\Lab_LTMCB\Lab1\Lab1_Bai2\Lab1_Bai2\bin\Debug\net6.0-windows\Lab1_Bai2.exe";
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"E:\HocKi4\Lập_trình_mạng_căn_bản\Lab_LTMCB\Lab1\Lab1_Bai3\Lab1_Bai3\bin\Debug\net6.0-windows\Lab1_Bai3.exe";
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"E:\HocKi4\Lập_trình_mạng_căn_bản\Lab_LTMCB\Lab1\Lab1_Bai4\Lab1_Bai4\bin\Debug\net6.0-windows\Lab1_Bai4.exe";
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"E:\HocKi4\Lập_trình_mạng_căn_bản\Lab_LTMCB\Lab1\Lab1_Bai5\Lab1_Bai5\bin\Debug\net6.0-windows\Lab1_Bai5.exe";
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}