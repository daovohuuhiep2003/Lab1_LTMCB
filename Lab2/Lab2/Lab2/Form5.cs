using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static Lab2.Form5;
using static System.Formats.Asn1.AsnWriter;

namespace Lab2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        [Serializable]
        public class HocVien
        {
            public string MSSV { get; set; }
            public string Hoten { get; set; }
            public string Dienthoai { get; set; }
            public float Diemtoan { get; set; }
            public float Diemvan { get; set; }
            public float DTB
            {
                get
                {
                    return (Diemtoan + Diemvan) / 2;
                }
            }
            public HocVien()
            {
                MSSV = string.Empty;
                Hoten = string.Empty;
                Dienthoai = string.Empty;
                Diemtoan = 0;
                Diemvan = 0;

            }
        }
        [Serializable]
        public class HocVienOUT
        {
            public string MSSV { get; set; }
            public string Hoten { get; set; }
            public string Dienthoai { get; set; }
            public float Diemtoan { get; set; }
            public float Diemvan { get; set; }
            public float DTB
            {
                get; set;
            }
            public HocVienOUT()
            {
                MSSV = string.Empty;
                Hoten = string.Empty;
                Dienthoai = string.Empty;
                Diemtoan = 0;
                Diemvan = 0;
                DTB = 0;
            }
        }
        [Serializable]
        public class StudentList : List<HocVien>
        {
            public StudentList() : base() { }
            public StudentList(IEnumerable<HocVien> collection) : base(collection) { }
        }
        [Serializable]
        public class StudentListOUT : List<HocVienOUT>
        {
            public StudentListOUT() : base() { }
            public StudentListOUT(IEnumerable<HocVienOUT> collection) : base(collection) { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)
                    || string.IsNullOrEmpty(textBox3.Text) || (float.Parse(textBox4.Text) > 10 && float.Parse(textBox4.Text) < 0)
                                                                || (float.Parse(textBox5.Text) > 10 && float.Parse(textBox5.Text) < 0))
                {
                    throw new ArgumentException("Invalid input");
                }
                HocVien hocVien = new HocVien();
                hocVien.MSSV = textBox1.Text;
                hocVien.Hoten = textBox2.Text;
                hocVien.Dienthoai = textBox3.Text;
                hocVien.Diemtoan = float.Parse(textBox4.Text);
                hocVien.Diemvan = float.Parse(textBox5.Text);
                StudentList studentList;
                if (File.Exists("input.txt") && new FileInfo("input.txt").Length == 0)
                {
                    studentList = new StudentList();
                }
                else
                {
                    if (!File.Exists("input.txt"))
                    {
                        studentList = new StudentList();
                    }
                    else
                    {
                        // Nếu tệp tin tồn tại, đọc dữ liệu từ tệp tin
                        using (FileStream stream = File.OpenRead("input.txt"))
                        {
                            BinaryFormatter formatter = new BinaryFormatter();
                            studentList = (StudentList)formatter.Deserialize(stream);
                        }
                    }
                }

                // Thêm sinh viên mới vào danh sách
                studentList.Add(hocVien);
                richTextBox1.Clear();
                richTextBox1.AppendText($"MSSV: {hocVien.MSSV}, Hoten: {hocVien.Hoten}, sdt: {hocVien.Dienthoai}, " +
                    $"DiemToan: {hocVien.Diemtoan}, DiemVan: {hocVien.Diemvan}\n");


                // Ghi toàn bộ danh sách vào tệp tin
                using (FileStream stream = new FileStream("input.txt", FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, studentList);
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
            richTextBox1.Clear();
            try
            {
                using (FileStream stream = File.OpenRead("input.txt"))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    List<HocVien> studentList = (List<HocVien>)formatter.Deserialize(stream);

                    using (FileStream stream1 = new FileStream("output.txt", FileMode.Create))
                    {
                        BinaryFormatter formatter1 = new BinaryFormatter();
                        StudentListOUT studentList2 = new StudentListOUT();
                        foreach (HocVien student in studentList)
                        {
                            HocVienOUT hv = new HocVienOUT();
                            hv.MSSV = student.MSSV;
                            hv.Hoten = student.Hoten;
                            hv.Dienthoai = student.Dienthoai;
                            hv.Diemtoan = student.Diemtoan;
                            hv.Diemvan = student.Diemvan;
                            hv.DTB = student.DTB;
                            studentList2.Add(hv);
                        }
                        formatter1.Serialize(stream1, studentList2);
                    }
                }
                using (FileStream stream = File.OpenRead("output.txt"))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    List<HocVienOUT> studentList = (List<HocVienOUT>)formatter.Deserialize(stream);

                    foreach (HocVienOUT student in studentList)
                    {
                        richTextBox1.AppendText($"MSSV: {student.MSSV}, Hoten: {student.Hoten}, sdt: {student.Dienthoai}," +
                            $" DiemToan: {student.Diemtoan}, DiemVan: {student.Diemvan}, DTB: {student.DTB},\n");
                    }
                }

                
            }
            catch
            {
                string message = "Error!";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
        }

    }
}
