using System.Net.Sockets;
using System.Net;
using System.Text;

namespace UDPServerForm
{
    public partial class Form1 : Form
    {
        private Socket serverSocket;
        private EndPoint ep;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Tạo đối tượng Socket
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                // Lấy thông tin IP và cổng từ TextBox
                IPAddress ipAddress = IPAddress.Any;
                int port = int.Parse(textBox1.Text);
                ep = new IPEndPoint(ipAddress, port);

                // Gán đối tượng Socket với địa chỉ IP và cổng để lắng nghe kết nối từ UDP Client
                serverSocket.Bind(ep);
                AppendText("UDP Server is ready");

                // Tạo một thread để lắng nghe kết nối và nhận dữ liệu từ UDP Client
                byte[] buffer = new byte[1024];
                serverSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref ep, new AsyncCallback(ReceiveData), buffer);

                // Disable Button để không thể tạo kết nối mới
                button1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ReceiveData(IAsyncResult ar)
        {
            try
            {
                byte[] buffer = (byte[])ar.AsyncState;
                EndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
                int bytesRead = serverSocket.EndReceiveFrom(ar, ref remoteEP);
                string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                IPEndPoint clientEP = (IPEndPoint)remoteEP;


                // Hiển thị thông điệp nhận được từ UDP Client
                AppendText(clientEP.Address.ToString() + " " + message);

                // Tiếp tục lắng nghe kết nối và nhận dữ liệu từ UDP Client
                buffer = new byte[1024];
                serverSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref ep, new AsyncCallback(ReceiveData), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AppendText(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendText), text);
                return;
            }
            richTextBox1.AppendText(text + Environment.NewLine);
        }
    }
}
