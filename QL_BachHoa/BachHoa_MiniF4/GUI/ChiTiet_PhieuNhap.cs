using BLL;
using DTO;
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
    public partial class ChiTiet_PhieuNhap : Form
    {
        NhaCungCapBLL bll_ncc = new NhaCungCapBLL();
        SanPhamBLL bll_sp = new SanPhamBLL();
        PhieuNhapBLL bll_pn = new PhieuNhapBLL();
        ChiTiet_PN_BLL bll_ctpn = new ChiTiet_PN_BLL();
        public ChiTiet_PhieuNhap()
        {
            InitializeComponent();
        }

        public ChiTiet_PhieuNhap(int ma)
        {
            InitializeComponent();
            string mapn = ma.ToString();
            lbl_mapn.Text = ma.ToString();
            DateTime? ngaynhap = bll_pn.getNgayNhap(ma);
            int? tongnhap = bll_pn.getTongNhap(ma);
            int? mancc = bll_pn.getMANCC(ma);
            string tenncc = bll_ncc.getTenNCC(mancc.Value);
            lbl_ncc.Text = tenncc;
            lbl_ngaynhap.Text = ngaynhap.ToString();
            lbl_tongnhap.Text = tongnhap.ToString();
            load_CTPN(ma);
        }

        public void load_CTPN(int mapn)
        {
            dtgv_ctpn.DataSource = bll_ctpn.loadPN_theoMa(mapn);
            dtgv_ctpn.AllowUserToAddRows = false;
            this.dtgv_ctpn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_ctpn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

    }
}
