using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btBuoi4
{
    public partial class ListView : Form
    {
        
        public ListView()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.truyendata = new Form2.truyen1(datGiatri);
            frm.ShowDialog();
           
        }
        private void datGiatri (string ma, string ten, string luong)
        {
            ListViewItem it = new ListViewItem(ma);
            it.SubItems.Add(ten);
            it.SubItems.Add(luong);
            lsv1.Items.Add(it);
        }
        private void ListView_Load(object sender, EventArgs e)
        {

        }

        private void lsv1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void suaGiaTri(string ma,string ten,string luong)
        {
            ListViewItem item = lsv1.SelectedItems[0];
            item.SubItems[0].Text = ma;
            item.SubItems[1].Text = ten;
            item.SubItems[2].Text = luong;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            if (lsv1.SelectedItems.Count > 0)
            {

                ListViewItem item = lsv1.SelectedItems[0];
                Form2 form2 = new Form2(item.SubItems[0].Text, item.SubItems[1].Text,
                    item.SubItems[2].Text);
                form2.truyendata = new Form2.truyen1(suaGiaTri);
                form2.ShowDialog();
            }   
                

            
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        
            if (lsv1.SelectedItems.Count > 0)
            {

                DialogResult rs = MessageBox.Show("Ban co chac chan muon xoa dong nay", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    lsv1.Items.RemoveAt(lsv1.SelectedItems[0].Index);
                }
                
            }
            else
            {
                MessageBox.Show("Ban chua chon dong de xoa !");
            }
        
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Ban co chac chan muon thoat", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }   
        }
    }
}
