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
    public partial class frm_SanPham : Form
    {
        NhomHangBLL bll_nhomhang = new NhomHangBLL();
        SanPhamBLL bll_sanpham = new SanPhamBLL();
        NhaCungCapBLL bll_ncc = new NhaCungCapBLL();
        NhomHangBLL bll_nh = new NhomHangBLL();
        public frm_SanPham()
        {
            InitializeComponent();
            load_NhomHang();
            load_cbo();
            anButton();
        }

        public void load_NhomHang()
        {
            DataTable nodecha = new DataTable();
            nodecha = bll_nhomhang.load_NhomHang();   
            for (int i = 0; i < nodecha.Rows.Count; i++)
            {
                trv_NhomSP.Nodes.Add(nodecha.Rows[i][0].ToString() + " -- " + nodecha.Rows[i][1].ToString());
            }
        }

        private void trv_NhomSP_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode t = this.trv_NhomSP.SelectedNode;
            string chuoi = t.Text;
            var item = chuoi.Split(' '); 
            string a = item[0];
            int manh = int.Parse(a);
            dtgv_SP.DataSource = bll_sanpham.Load_SP_theoNH(manh);
            dtgv_SP.AllowUserToAddRows = false;
            this.dtgv_SP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_SP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            anButton();
        }

        private void dtgv_SP_Click(object sender, EventArgs e)
        {
            try
            {
                txt_KL.ReadOnly = true;
                txt_TenSP.ReadOnly = true;
                txt_SL.ReadOnly = true;
                cbo_nhacc.Enabled = false;
                cbo_nhomhang.Enabled = false;
                btn_anh.Enabled = false;
                txt_gia.Text = dtgv_SP.CurrentRow.Cells[5].Value.ToString();
                txt_TenSP.Text = dtgv_SP.CurrentRow.Cells[2].Value.ToString();
                txt_SL.Text = dtgv_SP.CurrentRow.Cells[3].Value.ToString();
                txt_KL.Text = dtgv_SP.CurrentRow.Cells[4].Value.ToString();
                txt_gia.Focus();
                string masp = dtgv_SP.CurrentRow.Cells[1].Value.ToString();
                string path = @"..\..\Images\SanPham\" + masp + @"\01.jpg";
                Image img = Image.FromFile(path);
                pictureBox1.Image = img;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ảnh");
            }
            btn_sua.Enabled = true;
            btn_them.Enabled = true;

        }

        public void setTextBox()
        {
            txt_gia.Text = string.Empty;
            txt_KL.Text = string.Empty;
            txt_SL.Text = string.Empty;
            txt_TenSP.Text = string.Empty;
        }

        public void update_giaSP()
        {
            int gia = int.Parse(txt_gia.Text);
            int masp = int.Parse(dtgv_SP.CurrentRow.Cells[1].Value.ToString());
            bll_sanpham.update_GiaSP(gia, masp);
        }

        public void loadSP_theoNhomHang()
        {
            int manh = 1;
            dtgv_SP.DataSource = bll_sanpham.Load_SP_theoNH(manh);
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            try 
            {
                
                update_giaSP();
                MessageBox.Show("Cập nhật giá sản phẩm thành công");
                loadSP_theoNhomHang();
                setTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật giá thất bại");
            }
            btn_sua.Enabled = false;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            setTextBox();   
            txt_TenSP.Focus();
            txt_KL.ReadOnly = false;
            txt_TenSP.ReadOnly = false;
            txt_SL.ReadOnly = false;
            cbo_nhacc.Enabled = true;
            cbo_nhomhang.Enabled = true;
            btn_anh.Enabled = true;
            pictureBox1.Image = null;
            btn_them.Enabled = false;
            btn_luu.Enabled = true;
            btn_sua.Enabled = false;
        }

        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        


   
        void load_cbo()
        {
            cbo_nhacc.DataSource = bll_ncc.load_NCC();
            cbo_nhacc.DisplayMember = "TENNCC";
            cbo_nhacc.ValueMember = "MANCC";
            cbo_nhomhang.DataSource = bll_nh.load_NhomHang();
            cbo_nhomhang.DisplayMember = "TENNH";
            cbo_nhomhang.ValueMember = "MANH";
        }

        public void themSP()
        {
            try
            {
                SanPham s = new SanPham();
                
                s.Tensp = txt_TenSP.Text;
                s.Mancc = int.Parse(cbo_nhacc.SelectedValue.ToString());
                s.Soluong = int.Parse(txt_SL.Text);
                s.Khoiluong = txt_KL.Text;
                s.Manh = int.Parse(cbo_nhomhang.SelectedValue.ToString());
                s.Giaban = int.Parse(txt_gia.Text);
                s.Luotban = 0;
                s.Hinh = "1";
                bll_sanpham.themSP(s);
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại!!!");
            }
           

        }
        void anButton()
        {
            btn_anh.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_luu.Enabled = false;
        }

        private void txt_SL_TextChanged_1(object sender, EventArgs e)
        {
            //if (!IsPositiveInteger(txt_SL.Text))
            //{
                
            //    MessageBox.Show("Vui lòng nhập số nguyên dương.");
            //    txt_SL.Text = string.Empty; 
            //}
        }

        private void txt_gia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
            
        }

        private void txt_SL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(" Dữ liệu không hợp lệ");
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (bll_sanpham.KT_TrungTenSP(txt_TenSP.Text) == 1)
            {
                MessageBox.Show("Tên sản phẩm đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_TenSP.Focus();
            }
            else
            {
                themSP();
                setTextBox();
            }
            
            btn_them.Enabled = true;
        }

        private void btn_anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                string img = "";
                img = dialog.FileName.ToString();
                pictureBox1.ImageLocation = img;
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void txt_gia_Leave(object sender, EventArgs e)
        {
            if (txt_gia.Text == "0")    
            {
                MessageBox.Show("Giá không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_gia.Focus();
            }
            else if (txt_gia.Text.Length < 4)
            {
                MessageBox.Show("Giá không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_gia.Focus();
            }
        }

        private void txt_SL_Leave(object sender, EventArgs e)
        {
            if (txt_SL.Text == "0")
            {
                MessageBox.Show("Số lượng không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SL.Focus();
            }
        }

        
    }
}
