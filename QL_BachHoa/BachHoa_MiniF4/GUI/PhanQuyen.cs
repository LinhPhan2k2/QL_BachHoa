using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class PhanQuyen : Form
    {
        NhomQuyenBLL bllNhomQuyen = new NhomQuyenBLL();
        CT_QuyenBLL bllCTQuyen = new CT_QuyenBLL();
        public PhanQuyen()
        {
            InitializeComponent();
        }
        public void loadData()
        {

            nHOMQUYENDataGridView.DataSource = bllNhomQuyen.GetNhomQuyen();
          

        }

        private void PhanQuyen_Load(object sender, EventArgs e)
        {

            loadData();
        }


        private void nHOMQUYENDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cHITIET_QUYENDataGridView.DataSource = bllCTQuyen.GetCTQuyen(int.Parse(nHOMQUYENDataGridView.CurrentRow.Cells[0].Value.ToString()));
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string strMaNhom = nHOMQUYENDataGridView.CurrentRow.Cells[0].Value.ToString();
            string strMaMH = cHITIET_QUYENDataGridView.CurrentRow.Cells[0].Value.ToString();
            int coQuyen = int.Parse(cHITIET_QUYENDataGridView.CurrentRow.Cells[2].Value.ToString());
            bllCTQuyen.Update_PhanQuyen(coQuyen, int.Parse(strMaMH));
            MessageBox.Show("Đã sửa thành công!");
        }

        private void nHOMQUYENDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = nHOMQUYENDataGridView.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = nHOMQUYENDataGridView.CurrentRow.Cells[1].Value.ToString();
            cHITIET_QUYENDataGridView.DataSource = bllCTQuyen.GetCTQuyen(int.Parse(nHOMQUYENDataGridView.CurrentRow.Cells[0].Value.ToString()));
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            int Max = 0;
            int i = nHOMQUYENDataGridView.Rows.Count;
            foreach (DataGridViewRow item in nHOMQUYENDataGridView.Rows)
            {
                if (item.Cells[0].Value == null)
                {
                    break;
                }
                if(int.Parse(item.Cells[0].Value.ToString())>Max)
                {
                    Max = int.Parse(item.Cells[0].Value.ToString());
                }
            }
            bllNhomQuyen.ThemQuyen(textBox2.Text);
            bllCTQuyen.Insert_PQ(0, Max + 1, "SF_SANPHAM");
            bllCTQuyen.Insert_PQ(0, Max + 1, "SF_NHANVIEN");
            bllCTQuyen.Insert_PQ(0, Max + 1, "SF_NHAPHANG");
            bllCTQuyen.Insert_PQ(0, Max + 1, "SF_BANHANG");
            bllCTQuyen.Insert_PQ(0, Max + 1, "SF_DOITRA");
            bllCTQuyen.Insert_PQ(0, Max + 1, "SF_THONGKE");
            bllCTQuyen.Insert_PQ(0, Max + 1, "SF_PHANQUYEN");
            MessageBox.Show("Đã thêm thành công!");
            loadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bllNhomQuyen.SuaQuyen(textBox2.Text, int.Parse(textBox1.Text));
            MessageBox.Show("Đã sửa thành công!");
            loadData();
        }

      
    }
}
