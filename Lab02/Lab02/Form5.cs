using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab02
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();

            try
            {
                DirectoryInfo drt = new DirectoryInfo(fbd.SelectedPath);
                FileInfo[] fiArr = drt.GetFiles();

                listView1.Items.Clear();
                foreach (FileInfo fi in fiArr)
                {
                    ListViewItem item = new ListViewItem(fi.Name);
                    item.SubItems.Add(fi.Length.ToString());
                    item.SubItems.Add(fi.Extension);
                    item.SubItems.Add(fi.CreationTime.ToString());
                    listView1.Items.Add(item);
                }
                //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Bạn chưa chọn folder!");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
