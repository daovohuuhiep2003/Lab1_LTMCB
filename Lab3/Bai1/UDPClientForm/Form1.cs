using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPClientForm
{
    public partial class Form1 : Form
    {
        private Socket clientSocket;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng Socket
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                // Lấy thông tin IP và cổng từ TextBox
                IPAddress ipAddress = IPAddress.Parse(textBox1.Text);
                int port = int.Parse(textBox2.Text);
                EndPoint ep = new IPEndPoint(ipAddress, port);

                // Gởi thông điệp đến UDP Server
                string message = richTextBox1.Text;
                byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                clientSocket.SendTo(messageBytes, ep);

                // Đóng đối tượng Socket
                clientSocket.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     
    }
}