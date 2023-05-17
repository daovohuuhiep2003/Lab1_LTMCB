using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace Bai3
{
    public partial class TCP_Client : Form
    {
        public TCP_Client()
        {
            InitializeComponent();
        }

        NetworkStream ns;
        TcpClient tcpClient;


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //4 Dùng phương thức Write để gửi dữ liệu đến Server
                Byte[] data = System.Text.Encoding.ASCII.GetBytes("Hello server\n"); 
                ns.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //1 Tạo đối tượng TcpClient
                tcpClient = new TcpClient();
                //2 Kết nối đến Server với 1 địa chỉ IP và Port xác định
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8080);
                tcpClient.Connect(ipEndPoint);
                //3 Tạo luồng để đọc và ghi dữ liệu dựa trên NetworkStream
                ns = tcpClient.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //5 Dùng phương thức Write để gửi dữ liệu mang dấu hiệu kết thúc cho Server biết và đóng kết nối
                Byte[] data1 = System.Text.Encoding.ASCII.GetBytes("quit\n");
                //ns.Write(data1, 0, data1.Length);
                ns.Close();
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
