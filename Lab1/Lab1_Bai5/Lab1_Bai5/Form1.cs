using System.Diagnostics.Eventing.Reader;
using System.Runtime.Intrinsics.X86;

namespace Lab1_Bai5
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
                string[] numberStrings = textBox1.Text.Split(' ');
                float[] floats = new float[numberStrings.Length];
                for (int i = 0; i < numberStrings.Length; i++)
                    floats[i] = float.Parse(numberStrings[i]);
                for (int i = 0; i < numberStrings.Length; i++)
                {
                    int labelWidth = 100;
                    int labelHeight = 20;
                    int margin = 5;
                    int labelCount = groupBox1.Controls.OfType<Label>().Count() + 6; // đếm số lượng Label hiện có trong GroupBox
                    int x = margin + (labelWidth + margin) * (labelCount % 6); // tính toán tọa độ x của Label mới
                    int y = margin + (labelHeight + margin) * (labelCount / 6); // tính toán tọa độ y của Label mới
                    string s = "Môn ";
                    s += (i + 1).ToString() + ": " + floats[i].ToString();
                    Label newLabel = new Label();
                    newLabel.Location = new Point(x, y);
                    newLabel.Text = s;
                    groupBox1.Controls.Add(newLabel);
                }

                float avg, max, pass, min, not_pass;
                string HocLuc;
                bool flat1 = false, flat2 = false, flat3 = false, flat4 = false;

                avg = floats.Average();
                max = floats.Max();
                min = floats.Min();
                pass = 0;
                not_pass = 0;

                for (int i = 0; i < numberStrings.Length; i++)
                {
                    if (floats[i] < 5)
                        not_pass++;
                    else pass++;
                    if (floats[i] < 6.5)
                        flat1 = true;
                    if (floats[i] < 5)
                        flat2 = true;
                    if (floats[i] < 3.5)
                        flat3 = true;
                    if (floats[i] < 2)
                        flat4 = true;
                }

                if (avg >= 8 && !flat1)
                    HocLuc = "Giỏi";
                else if (avg >= 6.5 && !flat2)
                    HocLuc = "Khá";
                else if (avg >= 5 && !flat3)
                    HocLuc = "TB";
                else if (avg >= 3.5 && !flat4)
                    HocLuc = "Yếu";
                else
                    HocLuc = "Kém";

                label3.Text += avg.ToString();
                label4.Text += max.ToString();
                label5.Text += pass.ToString();
                label6.Text += HocLuc.ToString();
                label7.Text += min.ToString();
                label8.Text += not_pass.ToString();
            }
            catch
            {
                string message = "Vui lòng nhập đúng dữ liệu!";
                string title = "Warning";
                MessageBox.Show(message, title);
                textBox1.Text = string.Empty;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.Clear();
            label3.Text = "Điểm trung bình: ";
            label4.Text = "Môn có điểm cao nhất: ";
            label5.Text = "Số môn đậu: ";
            label6.Text = "Học lực: ";
            label7.Text = "Môn có điểm thấp nhất: ";
            label8.Text = "Số môn không đậu: ";
            textBox1.Text = string.Empty;
        }

    }
}