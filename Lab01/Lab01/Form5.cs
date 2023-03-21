using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] raw_numbers = textBox1.Text.Trim().Split(new string[] { ", " }, StringSplitOptions.None);
            double[] numbers = new double[100];
            double tmp, sum = 0;
            int cnt = 0, dauCnt = 0;
            bool tryparse, checkLT65 = false, checkLT5 = false, checkLT35 = false, checkLT2 = false;
            string data = "";

            foreach (string raw_number in raw_numbers)
            {
                data += "Môn ";
                data += (cnt + 1).ToString() + ": ";
                data += raw_number + "đ           ";
                tryparse = Double.TryParse(raw_number, out tmp);
                if (!tryparse)
                {
                    MessageBox.Show("Đã nhập sai format!");
                    return;
                }
                if (tmp >= 5) dauCnt++;
                if (tmp < 6.5) checkLT65 = true;
                if (tmp < 5) checkLT5 = true;
                if (tmp < 3.5) checkLT35 = true;
                if (tmp < 2) checkLT2 = true;
                sum += tmp;
                numbers[cnt] = tmp;
                cnt++;
            }

            MessageBox.Show("Đã nhập đúng format!");

            string hocLuc;

            if ((sum / cnt) >= 8 && !checkLT65) hocLuc = "Giỏi";
            else if ((sum / cnt) >= 6.5 && !checkLT5) hocLuc = "Khá";
            else if ((sum / cnt) >= 5 && !checkLT35) hocLuc = "TB";
            else if ((sum / cnt) >= 3.5 && !checkLT2) hocLuc = "Yếu";
            else hocLuc = "Kém";

            Array.Sort(numbers, 0, cnt);
            label8.Text = data;
            labelDiemTB.Text = Math.Round((sum / cnt), 2).ToString();
            labelDiemCN.Text = numbers[cnt - 1].ToString() + " đ";
            labelDiemTN.Text = numbers[0].ToString() + " đ";
            labelSMD.Text = dauCnt.ToString();
            labelSMKD.Text = (cnt - dauCnt).ToString();
            labelHocLuc.Text = hocLuc;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
