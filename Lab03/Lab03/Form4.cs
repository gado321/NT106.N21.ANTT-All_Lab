using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openForm = new Form4_ClientThread();
            openForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var openForm = new Form4_ServerThread();
            openForm.Show();
        }
    }
}
