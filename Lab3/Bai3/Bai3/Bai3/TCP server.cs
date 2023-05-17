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

namespace Bai3
{
    public partial class TCP_server : Form
    {
        public TCP_server()
        {
            InitializeComponent();
        }
        Socket clientSocket;
        Socket listenerSocket = new Socket(
                    AddressFamily.InterNetwork,
                    SocketType.Stream,
                    ProtocolType.Tcp
                );
        private void button1_Click(object sender, EventArgs e)
        {
            //Xử lý lỗi InvalidOperationException
            try
            {
                
                Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
                serverThread.Start();
            }
            catch (Exception ex ) {
                MessageBox.Show(ex.Message);
            }   
        }

        void StartUnsafeThread()
        {
            try
            {
                int bytesReceived = 0;
                // Khởi tạo mảng byte nhận dữ liệu
                byte[] recv = new byte[1024];
                // Tạo socket bên gởi
                
                // Tạo socket bên nhận, socket này là socket lắng nghe các kết nối tới nó tại địa chỉ IP của máy và port 8080. Đây là 1 TCP/IP socket.
                //AddressFamily: trả về họ địa chỉ của địa chỉ IP hiện hành. Ở đây là địa chỉ Ipv4 nên chọn AddressFamily.InterNetwork
                //SocketType: kiểu kết nối socket, ở đây dùng luồng Stream để nhận dữ liệu 
                //ProtocolType: sử dụng giao thức kết nối nào, ở đây sử dụng kết nối TCP 
                // Ba tham số của hàm đi với nhau khi ta thực hiện kết nối TCP.
                
                IPEndPoint ipepServer = new IPEndPoint(IPAddress.Any, 8080);
                // Gán socket lắng nghe tới địa chỉ IP của máy và port 8080
                try
                {
                    listenerSocket.Bind(ipepServer);
                }
                catch (Exception ex) { }
                // bắt đầu lắng nghe. Socket.Listen(int backlog)
                // với backlog: là độ dài tối đa của hàng đợi các kết nối đang chờ xử lý
                listenerSocket.Listen(-1);
                AppendText("Ready...\r\n");
                //Đồng ý kết nối
                clientSocket = listenerSocket.Accept();
                //Nhận dữ liệu
                AppendText("New client connected\r\n");

                string clientIP = ((IPEndPoint)clientSocket.RemoteEndPoint).Address.ToString();
                int clientPort = ipepServer.Port;
                AppendText("Client connected: " + clientIP + ":" + clientPort + "\r\n");

                while (clientSocket.Connected)
                {
                    string text = "";
                    do
                    {
                        bytesReceived = clientSocket.Receive(recv);
                        text = Encoding.UTF8.GetString(recv, 0, bytesReceived);
                    } while (text[text.Length - 1] != '\n');
                    AppendText(text);
                }
                listenerSocket.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AppendText(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new Action<string>(AppendText), text);
            }
            else
            {
                richTextBox1.AppendText(text);
            }
        }
    }
}
