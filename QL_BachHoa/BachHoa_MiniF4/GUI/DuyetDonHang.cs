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


namespace GUI
{
    public partial class DuyetDonHang : Form
    {
        DuyetDH_BLL bll_duyetdh = new DuyetDH_BLL();
        HoaDonBLL bll_hoadon = new HoaDonBLL();
        public DuyetDonHang()
        {
            InitializeComponent();
            loadDH();
        }
        void fillDTGV()
        {
            dtgv_dh.AllowUserToAddRows = false;
            this.dtgv_dh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_dh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtgv_cthd.AllowUserToAddRows = false;
            this.dtgv_cthd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_cthd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        void loadDH()
        {
            dtgv_dh.DataSource = bll_duyetdh.loadDH();
            fillDTGV();
        }

        private void DuyetDonHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BACHHOADataSet.Linh_DuyetDH' table. You can move, or remove it, as needed.
            this.linh_DuyetDHTableAdapter.Fill(this.qL_BACHHOADataSet.Linh_DuyetDH);

        }

        private void dtgv_dh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           

        }

        private void dtgv_cthd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgv_dh_Click(object sender, EventArgs e)
        {
            string mahd = dtgv_dh.CurrentRow.Cells[0].Value.ToString();
            dtgv_cthd.DataSource = bll_duyetdh.loadCTHD(mahd);
            fillDTGV();
        }

        void ColorButton()
        {
           
        }

        private void dtgv_dh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahd = dtgv_dh.CurrentRow.Cells[0].Value.ToString();
            string tt = dtgv_dh.CurrentRow.Cells[4].Value.ToString();
            if (string.Compare(tt, "Chờ xác nhận", true) == 0)
            {
                DialogResult h = MessageBox.Show("Bạn có chắc xác nhận đơn hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (h == DialogResult.Yes)
                {
                    bll_hoadon.Sua("Đã xác nhận", mahd);
                    
                }
            }
            else if (string.Compare(tt, "Đã xác nhận", true) == 0)
            {
                DialogResult t = CustomMessageBox.Show();
                if ( t == DialogResult.Yes)
                {
                    bll_hoadon.Sua("Đã giao", mahd);
                    
                }
                else if ( t == DialogResult.No)
                {
                    bll_hoadon.Sua("Đã hủy", mahd);
                }


            }
            
            loadDH();
            
            //CustomMessageBox c = new CustomMessageBox();
            //c.Show();
            //DialogResult h = MessageBox.Show("Bạn có chắc duyệt đơn hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (h == DialogResult.Yes)
            //{
            //    string mahd = dtgv_dh.CurrentRow.Cells[0].Value.ToString();
            //    string tt = dtgv_dh.CurrentRow.Cells[4].Value.ToString();
            //    if (string.Compare(tt, "Chờ xác nhận", true) == 0)
            //    {
            //        bll_hoadon.Sua("Đã xác nhận", mahd);
            //    }
            //    if (string.Compare(tt, "Đã xác nhận", true) == 0)
            //    {
            //        bll_hoadon.Sua("Đã giao", mahd);
            //    }
            //    loadDH();
            //}
        }
    }
}
