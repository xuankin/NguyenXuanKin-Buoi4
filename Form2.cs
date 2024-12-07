using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btBuoi4
{
    public partial class Form2 : Form
    {
        public delegate void truyen1(string ma, string ten, string luong);
        public truyen1 truyendata;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string ma,string ten,string luong)
        {
            InitializeComponent();
            txtMa.Text = ma;
            txtTen.Text = ten;
            txtLuong.Text = luong;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (truyendata != null)
            {
                truyendata(txtMa.Text, txtTen.Text, txtLuong.Text);
                this.Close();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
