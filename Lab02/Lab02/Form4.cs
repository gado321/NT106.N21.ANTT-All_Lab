using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        [Serializable]
        public class Student
        {
            public string MSSV;
            public string HoTen;
            public string DienThoai;
            public float DiemToan;
            public float DiemVan;
            public float DTB;
            public Student(string MSSV, string HoTen, string DienThoai, float DiemToan, float DiemVan)
            {
                this.MSSV = MSSV;
                this.HoTen = HoTen;
                this.DienThoai = DienThoai;
                this.DiemToan = DiemToan;
                this.DiemVan = DiemVan;
                this.DTB = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            
            Student s = new Student(textBox1.Text, textBox2.Text, textBox3.Text, float.Parse(textBox4.Text), float.Parse(textBox5.Text));
            bf.Serialize(fs, s);
            fs.Close();

            //try
            //{
                
            //}
            //catch (Exception exp)
            //{
            //    MessageBox.Show("Chọn file đi em");
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
