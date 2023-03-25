namespace Lab1_Bai3
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



        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        string[] VNNum = { "", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười" };
        private string NumTrans(int number)
        {

            if (number < 10)
                return VNNum[number];
            else if (number == 15)
                return "Mười Lăm";
            else if (number >= 10 && number < 20)
                return "Mười " + VNNum[number % 10];
            else
            {
                string text = "";

                if ((number / 1000000000) > 0)
                {
                    text += NumTrans(number / 1000000000) + " Tỷ ";
                    number %= 1000000000;
                }

                if ((number / 1000000) > 0)
                {
                    text += NumTrans(number / 1000000) + " Triệu ";
                    number %= 1000000;
                }

                if ((number / 1000) > 0)
                {
                    text += NumTrans(number / 1000) + " Nghìn ";
                    number %= 1000;
                }

                if ((number / 100) > 0)
                {
                    text += NumTrans(number / 100) + " Trăm ";
                    number %= 100;
                }

                if (number > 9 && number < 100 && number % 10 == 0 && number != 10)
                {
                    text += NumTrans(number / 10) + " Mươi ";
                }
                else if (number > 19 && number < 100 && number % 10 != 0 && number % 5 != 0)
                    text += NumTrans(number / 10) + " Mươi " + NumTrans(number % 10);
                else if (number > 19 && number % 10 != 0 && number % 5 == 0)
                    text += NumTrans(number / 10) + " Mươi " + "Lăm";
                else
                    text += NumTrans(number);
                return text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textBox1.Text.Trim());
                if (num < 0)
                    textBox2.Text = "Âm " + NumTrans(num * (-1));
                else
                    textBox2.Text = NumTrans(num);
            }
            catch
            {
                string message = "Vui lòng nhập đúng kiểu dữ liệu!";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
