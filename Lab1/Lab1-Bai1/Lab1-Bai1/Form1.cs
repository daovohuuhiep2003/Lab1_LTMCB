namespace Lab1_Bai1
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

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, number;
            bool success1 = int.TryParse(textBox1.Text.Trim(), out number);
            bool success2 = int.TryParse(textBox2.Text.Trim(), out number);
            if (success1 && success2)
            {
                int sum = 0;
                num1 = Int32.Parse(textBox1.Text.Trim());
                num2 = Int32.Parse(textBox2.Text.Trim());
                sum = num1 + num2;
                textBox3.Text = sum.ToString();
            }
            else
            {
                string message = "Vui lòng nhập số nguyên!";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


    }
}