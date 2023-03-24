namespace Lab1_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2, num3, number;
            bool success1 = float.TryParse(textBox1.Text.Trim(), out number);
            bool success2 = float.TryParse(textBox2.Text.Trim(), out number);
            bool success3 = float.TryParse(textBox3.Text.Trim(), out number);
            if (success1 && success2 && success3)
            {
                float max = 0, min = 0;
                num1 = float.Parse(textBox1.Text.Trim());
                num2 = float.Parse(textBox2.Text.Trim());
                num3 = float.Parse(textBox3.Text.Trim());
                max = Math.Max(num1, Math.Max(num2, num3));
                textBox4.Text = max.ToString();
                min = Math.Min(num1, Math.Min(num2, num3));
                textBox5.Text = min.ToString();
            }
            else
            {
                string message = "Vui lòng nhập số!";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}