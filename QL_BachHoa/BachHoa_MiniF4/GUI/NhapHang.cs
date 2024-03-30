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
    public partial class NhapHang : Form
    {
        NhaCungCapBLL bll_ncc = new NhaCungCapBLL();
        SanPhamBLL bll_sp = new SanPhamBLL();
        PhieuNhapBLL bll_pn = new PhieuNhapBLL();
        ChiTiet_PN_BLL bll_ctpn = new ChiTiet_PN_BLL();
       
       
        public NhapHang()
        {
            InitializeComponent();
            load_NCC();
            anButton();
        }

        public void load_NCC()
        {         
            cbo_ncc.DataSource = bll_ncc.load_NCC();
            cbo_ncc.DisplayMember = "TENNCC";
            cbo_ncc.ValueMember = "MANCC";
            
        }
        public void load_TongTien(int mapn)
        {
            lbl_tongnhap2.Text = bll_pn.getTongNhap(mapn).ToString();
        }
        public void load_SP_theoNCC(int mancc)
        {
            dtgv_SP.DataSource = bll_sp.Load_SP_theoNCC(mancc);
            dtgv_SP.AllowUserToAddRows = false;
            this.dtgv_SP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_SP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void load_CTPN(int mapn)
        {
            dtgv_ctpn.DataSource = bll_ctpn.loadPN_theoMa(mapn);
            dtgv_ctpn.AllowUserToAddRows = false;
            this.dtgv_ctpn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_ctpn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            load_NCC();
        }

        private void dtgv_NCC_Click(object sender, EventArgs e)
        {
            //int mancc = int.Parse(dtgv_NCC.CurrentRow.Cells[0].Value.ToString());
            //load_SP_theoNCC(mancc);
        }
        
        private void btn_them_pn_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuNhap pn = new PhieuNhap();
               
                pn.Mancc = int.Parse(cbo_ncc.SelectedValue.ToString());
                pn.Ngaynhap = DateTime.Now;
                pn.Tongnhap = 0;
                pn.Manv = 1;
                bll_pn.themPN_BLL(pn);
                txt_mapn.Text = bll_pn.layMaPN_Moi().ToString();
                int mapn = int.Parse(txt_mapn.Text);
                lbl_ngaynhap2.Text = bll_pn.getNgayNhap(mapn).ToString();
                lbl_tongnhap2.Text = bll_pn.getTongNhap(mapn).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("thêm phiếu nhập thất bại");
            }
            btn_them_sp.Enabled = true;
            
        }

        private void dtgv_SP_Click(object sender, EventArgs e)
        {
            txt_masp.Text = dtgv_SP.CurrentRow.Cells[0].Value.ToString();
            txt_tensp.Text = dtgv_SP.CurrentRow.Cells[1].Value.ToString();
            txt_masp.Enabled = true;
            btn_them_sp.Enabled = true;
        }

        public void setTextBox()
        {
            txt_gianhap.Text = string.Empty;
            txt_sl.Text = string.Empty;
            txt_tensp.Text = string.Empty;
            txt_masp.Text = string.Empty;

        }

        private void btn_them_sp_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTiet_PN ctpn = new ChiTiet_PN();
                ctpn.Mapn = int.Parse(txt_mapn.Text);
                ctpn.Masp = int.Parse(txt_masp.Text);
                ctpn.Sl = int.Parse(txt_sl.Text);
                ctpn.Gianhap = int.Parse(txt_gianhap.Text);
                ctpn.Thanhtien = ctpn.Sl * ctpn.Gianhap;
                bll_ctpn.them_CTPN(ctpn);
                MessageBox.Show("Nhập sản phẩm thành công");
                setTextBox();   
                int mapn = int.Parse(txt_mapn.Text);
                load_CTPN(mapn);
                load_TongTien(mapn);
                int mancc = int.Parse(cbo_ncc.SelectedValue.ToString());
                load_SP_theoNCC(mancc);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm thất bại");
            }
            btn_in.Enabled = true;
           
        }

       

     

        private void txt_gianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số");
            }
        }

        private void txt_sl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số");
            }
        }

       

        private void cbo_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_load_sp_Click(object sender, EventArgs e)
        {
            int mancc = int.Parse(cbo_ncc.SelectedValue.ToString());
            load_SP_theoNCC(mancc);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgv_ctpn_Click(object sender, EventArgs e)
        {
            try
            {
                txt_masp.Text = dtgv_ctpn.CurrentRow.Cells[0].Value.ToString();
                txt_tensp.Text = dtgv_ctpn.CurrentRow.Cells[1].Value.ToString();
                txt_gianhap.Text = dtgv_ctpn.CurrentRow.Cells[3].Value.ToString();
                txt_sl.Text = dtgv_ctpn.CurrentRow.Cells[2].Value.ToString();
                btn_them_sp.Enabled = false;
                btn_xoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!!!");
            }
           
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (h == DialogResult.Yes)
            {
                xoaCTPN();
            }
            btn_xoa.Enabled = false;
        }
        public void xoaCTPN()
        {
            try
            {
                int mancc = int.Parse(cbo_ncc.SelectedValue.ToString());
                int mapn = int.Parse(txt_mapn.Text);
                int masp = int.Parse(txt_masp.Text);
                bll_ctpn.xoaCTPN(mapn, masp);
                MessageBox.Show("Xóa sản phẩm thành công");
                setTextBox();
                load_SP_theoNCC(mancc);
                load_CTPN(mapn);
                load_TongTien(mapn);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa thất bại");
            }
           
        }

        private void cbo_ncc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int mancc = int.Parse(cbo_ncc.SelectedValue.ToString());
            load_SP_theoNCC(mancc);
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            if (txt_mapn.Text == string.Empty)
            {  
                MessageBox.Show("Không tìm thấy phiếu nhập");
            }
            else
            {
                Report_PN ct = new Report_PN(txt_mapn.Text);
                ct.ShowDialog();
                txt_mapn.Text = string.Empty;
                lbl_ngaynhap2.Text = " ";
                txt_masp.Text = string.Empty;
                txt_tensp.Text = string.Empty;
                txt_sl.Text = string.Empty;
                txt_gianhap.Text = string.Empty;
            }
            dtgv_ctpn.DataSource = null;
            dtgv_ctpn.Rows.Clear();
            dtgv_ctpn.Columns.Clear();
            dtgv_ctpn.Refresh();
            lbl_tongnhap2.Text = "0";
            
            
        }

        void anButton()
        {
            btn_them_sp.Enabled = false;
            btn_xoa.Enabled = false;
            btn_in.Enabled = false;
        }

        private void txt_sl_Leave(object sender, EventArgs e)
        {
            if (txt_sl.Text == "0")
            {

                MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sl.Focus();
            }
        }

        
     

       
    }
}
