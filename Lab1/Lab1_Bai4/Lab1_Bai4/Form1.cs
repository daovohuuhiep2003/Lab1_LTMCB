using System.Globalization;

namespace Lab1_Bai4
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
                int NumDec;
                string NumHex, NumBin;
                if (comboBox1.SelectedItem.ToString() == "Dec")
                    NumDec = int.Parse(textBox1.Text.Trim());
                else if (comboBox1.SelectedItem.ToString() == "Hex")
                    NumDec = Convert.ToInt32(textBox1.Text.Trim(), 16);
                else if (comboBox1.SelectedItem.ToString() == "Bin")
                    NumDec = Convert.ToInt32(textBox1.Text.Trim(), 2);
                else
                {
                    int zero = 0;
                    NumDec = (1 / zero);
                }

                if (comboBox2.SelectedItem.ToString() == "Dec")
                    textBox2.Text = NumDec.ToString();
                else if (comboBox2.SelectedItem.ToString() == "Hex")
                {
                    NumHex = Convert.ToString(NumDec, 16).ToUpper();
                    textBox2.Text = NumHex.ToString();
                }
                else if (comboBox2.SelectedItem.ToString() == "Bin")
                {
                    NumBin = Convert.ToString(NumDec, 2);
                    textBox2.Text = NumBin.ToString();
                }
                else
                {
                    int zero = 0;
                    NumDec = (1 / zero);
                }

            }
            catch
            {
                string message = "Error!";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}