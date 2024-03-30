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
    public partial class frm_NhanVien : Form
    {
        NhomQuyenBLL bll_nhomquyen = new NhomQuyenBLL();
        NhanVienBLL bll_nv = new NhanVienBLL();
        public frm_NhanVien()
        {
            InitializeComponent();
            load_cbo_nhomquyen();
            loadNV();
            anButton();
        }
        public void load_cbo_nhomquyen()
        {
            dtgv_Nhomquyen.DataSource = bll_nhomquyen.GetNhomQuyen();
            
            dtgv_Nhomquyen.AllowUserToAddRows = false;
            this.dtgv_Nhomquyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_Nhomquyen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void loadNV()
        {
            dtgv_NV.DataSource = bll_nv.loadNV();
            dtgv_NV.AllowUserToAddRows = false;
            this.dtgv_NV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_NV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public bool KT_trong()
        {
            string tennv = txt_tenNV.Text;
            string tk = txt_tk.Text;
            string mk = txt_mk.Text;
            string sdt = txt_sdt.Text;
            if (tennv == string.Empty || tk == string.Empty || mk == string.Empty || sdt == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (KT_trong())
            {
                MessageBox.Show("Hãy nhập dữ liệu");
            }
            else
            {
                int? kt = bll_nv.KT_TaiKhoan(txt_tk.Text);
                if (kt == 1)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!!!");
                }
                else
                {
                    themNV();
                }
            }
            btn_luu.Enabled = true;
            
        }
        public void themNV ()
        {
            try
            {
                NhanVien nv = new NhanVien();
                nv.Tennv = txt_tenNV.Text;
                nv.Taikhoan = txt_tk.Text;
                nv.Matkhau = txt_mk.Text;
                nv.Sdt = txt_sdt.Text;
                if (rbtn_nu.Checked == true)
                {
                    nv.Gioitinh = "Nữ";
                }
                else
                {
                    nv.Gioitinh = "Nam";
                }
                nv.Maquyen = int.Parse(txt_nhomquyen.Text);
                bll_nv.themNV(nv);
                MessageBox.Show("Thêm nhân viên thành công");
                loadNV();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thất bại");
            }
           
           
        }

        private void txt_sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số");
            }
        }

        private void txt_sdt_Leave(object sender, EventArgs e)
        {
            if (txt_sdt.Text.Length > 10 || txt_sdt.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                txt_sdt.Focus();
            }
            
        }

        void anButton()
        {
            btn_luu.Enabled = false;
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
        }

        private void dtgv_NV_Click(object sender, EventArgs e)
        {
            txt_tenNV.Text = dtgv_NV.CurrentRow.Cells[1].Value.ToString();
            string gt = dtgv_NV.CurrentRow.Cells[2].Value.ToString();
            if (gt == "Nữ")
            {
                rbtn_nu.Checked = true;
            }
            else
            {
                rbtn_Nam.Checked = true;
            }
            txt_sdt.Text = dtgv_NV.CurrentRow.Cells[3].Value.ToString();
            txt_tk.Text = dtgv_NV.CurrentRow.Cells[4].Value.ToString();
            txt_nhomquyen.Text = dtgv_NV.CurrentRow.Cells[5].Value.ToString();
            txt_mk.Enabled = false;
            txt_sdt.Enabled = false;
            txt_tenNV.Enabled = false;
            txt_tk.Enabled = false;
            rbtn_Nam.Enabled = false;
            rbtn_nu.Enabled = false;
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            rbtn_nu.Checked = false;
            rbtn_Nam.Checked = false;    
            txt_mk.Enabled = true;
            txt_sdt.Enabled = true;
            txt_tenNV.Enabled = true;
            txt_tk.Enabled = true;
            rbtn_Nam.Enabled = true;
            rbtn_nu.Enabled = true;

            txt_mk.Text = string.Empty;
            txt_sdt.Text = string.Empty;
            txt_tenNV.Text = string.Empty;
            txt_tk.Text = string.Empty;
            txt_tenNV.Focus();

            btn_them.Enabled = false;
            btn_luu.Enabled = true;
            btn_sua.Enabled = false;
        }

        public void update_quyen()
        {
            try
            {
                int manv = int.Parse(dtgv_NV.CurrentRow.Cells[0].Value.ToString());
                int maq = int.Parse(txt_nhomquyen.Text);
                bll_nv.suaQuyenNV(maq, manv);
                MessageBox.Show("Cập nhật quyền thành công");
                loadNV();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thất bại");
            }
           
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc cập nhật quyền nhân viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (h == DialogResult.Yes)
            {
                update_quyen();
            }
            
            
        }

        private void dtgv_Nhomquyen_Click(object sender, EventArgs e)
        {
            txt_nhomquyen.Text = dtgv_Nhomquyen.CurrentRow.Cells[0].Value.ToString();

        }



    }
}
