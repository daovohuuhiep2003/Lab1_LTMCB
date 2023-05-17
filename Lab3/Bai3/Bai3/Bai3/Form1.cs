namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread serverThread = new Thread(() =>
            {
                Application.Run(new TCP_server());
            });
            serverThread.Start();
            serverThread.IsBackground = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread clientThread = new Thread(() =>
            {
                Application.Run(new TCP_Client());
            });
            clientThread.Start();
            clientThread.IsBackground = true;
           
        }
    }
}