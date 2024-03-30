using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class BanHang : Form
    {
        private int tongtien = 0;
        public BanHang()
        {
            InitializeComponent();
        }

        private void sANPHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sANPHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_BACHHOADataSet);

        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            this.sANPHAMTableAdapter.Fill(this.qL_BACHHOADataSet.SANPHAM);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult h1 = MessageBox.Show("Bạn có muốn thêm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h1 == DialogResult.Yes)
            {
                if (textBox1.Text == "" || int.Parse(textBox1.Text.Trim()) <= 0 || int.Parse(textBox1.Text.Trim()) >= 1000 || textBox1.TextLength>=5)
                {
                    DialogResult h = MessageBox.Show("Vui lòng nhập đúng số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string masp = sANPHAMDataGridView.CurrentRow.Cells[0].Value.ToString();
                    string tensp = sANPHAMDataGridView.CurrentRow.Cells[1].Value.ToString();
                    string sl = textBox1.Text;
                    string giaban = sANPHAMDataGridView.CurrentRow.Cells[3].Value.ToString();
                    int thanhtien = int.Parse(sl) * int.Parse(giaban);
                    dataGridView1.Rows.Add(masp, tensp, sl, giaban, thanhtien);
                    tongtien += thanhtien;
                    label1.Text = "" + tongtien + "đ";
                }
            }
           
           
           
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
             DialogResult h1 = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (h1 == DialogResult.Yes)
             {
                 tongtien -= int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                 dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
             }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
             DialogResult h1 = MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (h1 == DialogResult.Yes)
             {
                 tongtien = 0;
                 foreach (DataGridViewRow item in dataGridView1.Rows)
                 {
                     if (item.Cells[0].Value == null)
                     {
                         break;
                     }
                     string giaban = item.Cells[3].Value.ToString();
                     int thanhtien = int.Parse(item.Cells[2].Value.ToString()) * int.Parse(giaban);
                     item.Cells[4].Value = thanhtien;
                     tongtien += thanhtien;

                 }
                 label1.Text = "" + tongtien + "đ";

                 dataGridView1.Update();
             }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
             DialogResult h1 = MessageBox.Show("Bạn có muốn thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (h1 == DialogResult.Yes)
             {

             }
        }
    }
}
