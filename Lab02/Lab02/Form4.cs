using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
        }

        [Serializable]
        public class Student
        {
            private string MSSV;
            private string HoTen;
            private string DienThoai;
            private float DiemToan;
            private float DiemVan;
            private float DiemTB;
            public Student(string MSSV, string HoTen, string DienThoai, float DiemToan, float DiemVan)
            {
                this.MSSV = MSSV;
                this.HoTen = HoTen;
                this.DienThoai = DienThoai;
                this.DiemToan = DiemToan;
                this.DiemVan = DiemVan;
                DiemTB = 0;
            }

            public string Show(bool check)
            {
                if (!check)
                    return $"{MSSV}\n{HoTen}\n{DienThoai}\n{DiemToan.ToString(".0###########")}\n{DiemVan.ToString(".0###########")}\n\n\n";
                return $"{MSSV}\n{HoTen}\n{DienThoai}\n{DiemToan.ToString(".0###########")}\n{DiemVan.ToString(".0###########")}\n{DiemTB.ToString(".0###########")}\n\n";
            }

            public void CalAvg()
            {
                DiemTB = (DiemToan + DiemVan) / 2;
            }
        }

        List<Student> students = new List<Student>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    // Check MSSV
                    string.IsNullOrEmpty(textBox1.Text) || textBox1.TextLength != 8 || !Regex.IsMatch(textBox1.Text, "^[0-9]+$") ||
                    // Check HoTen
                    string.IsNullOrEmpty(textBox2.Text) || !Regex.IsMatch(textBox2.Text, "^[a-zA-Z]+$") ||
                    // Check DienThoai
                    string.IsNullOrEmpty(textBox3.Text) || textBox3.TextLength != 10 || !Regex.IsMatch(textBox3.Text, "^[0-9]+$") ||
                    // Check DiemToan
                    (float.Parse(textBox4.Text, CultureInfo.CurrentCulture) > 10 || float.Parse(textBox4.Text, CultureInfo.CurrentCulture) < 0)||
                    // Check DiemVan
                    (float.Parse(textBox5.Text, CultureInfo.CurrentCulture) > 10 || float.Parse(textBox5.Text, CultureInfo.CurrentCulture) < 0))
                {
                    throw new ArgumentException("Invalid input");
                }

                

                students.Add(new Student(textBox1.Text, textBox2.Text, textBox3.Text, float.Parse(textBox4.Text, NumberStyles.Any, CultureInfo.CurrentCulture), float.Parse(textBox5.Text, NumberStyles.Any, CultureInfo.CurrentCulture)));
                richTextBox1.Text = "Added information's student:\n";
                richTextBox1.Text += students[students.Count - 1].Show(false);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            catch
            {
                MessageBox.Show("Thông tin vừa nhập chưa đúng!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            if (students.Count != 0)
            {
                FileStream fs = new FileStream("D:\\Documents\\Learning materials\\HK4\\Lap trinh mang can ban\\NT106.N21.ANTT-All_Lab\\Lab02\\input4.txt", FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();

                MessageBox.Show("Đã lưu thông tin các sinh viên vào file input.txt");
                bf.Serialize(fs, students);
                fs.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin sinh viên!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fsInput = new FileStream("D:\\Documents\\Learning materials\\HK4\\Lap trinh mang can ban\\NT106.N21.ANTT-All_Lab\\Lab02\\input4.txt", FileMode.OpenOrCreate);

            FileStream fsOutput = new FileStream("D:\\Documents\\Learning materials\\HK4\\Lap trinh mang can ban\\NT106.N21.ANTT-All_Lab\\Lab02\\output4.txt", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();

                students.Clear();
                students = (List<Student>)bf.Deserialize(fsInput);
                richTextBox1.Clear();
                students.ForEach(s => richTextBox1.Text += s.Show(false));

                MessageBox.Show("Đã tính điểm trung bình cho các sinh viên và lưu thông tin vào file output.txt");
                students.ForEach(s => s.CalAvg());
                bf.Serialize(fsOutput, students);
            }
            catch
            {
                MessageBox.Show("Không có thông tin để tính");
            }
            fsInput.Close();
            fsOutput.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("D:\\Documents\\Learning materials\\HK4\\Lap trinh mang can ban\\NT106.N21.ANTT-All_Lab\\Lab02\\output4.txt", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();

                students.Clear();
                students = (List<Student>)bf.Deserialize(fs);
                richTextBox1.Clear();
                students.ForEach(s => richTextBox1.Text += s.Show(true));
            }
            catch
            {
                MessageBox.Show("Không có thông tin!");
            }
            fs.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream fsInput = new FileStream("D:\\Documents\\Learning materials\\HK4\\Lap trinh mang can ban\\NT106.N21.ANTT-All_Lab\\Lab02\\input4.txt", FileMode.OpenOrCreate);
            fsInput.SetLength(0);
            fsInput.Close();

            FileStream fsOutput = new FileStream("D:\\Documents\\Learning materials\\HK4\\Lap trinh mang can ban\\NT106.N21.ANTT-All_Lab\\Lab02\\output4.txt", FileMode.OpenOrCreate);
            fsOutput.SetLength(0);
            fsOutput.Close();

            MessageBox.Show("Đã xoá dữ liệu thông tin sinh viên!");
            richTextBox1.Clear();
        }
    }
}
