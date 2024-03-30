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
    public partial class ThongKe : Form
    {
        HoaDonBLL bll_hd = new HoaDonBLL();
        ThongKe_BLL bll_tk = new ThongKe_BLL();
        
        public ThongKe()
        {
            InitializeComponent();
        }

        void loadcbo()
        {
            
            //cbo_thang.DataSource = bll_hd.layThang();
            //cbo_thang.DisplayMember = "THANG";
            //cbo_thang.ValueMember = "THANG";
            ////RemoveDuplicateItemsFromComboBox(cbo_thang);
            //cbo_nam.DataSource = bll_hd.layNam();
            //cbo_nam.DisplayMember = "NAM";
            //cbo_nam.ValueMember = "NAM";
            ////RemoveDuplicateItemsFromComboBox(cbo_nam);
        }

        //private void RemoveDuplicateItemsFromComboBox(ComboBox comboBox)
        //{
        //    HashSet<string> uniqueItems = new HashSet<string>();

        //    for (int i = comboBox.Items.Count - 1; i >= 0; i--)
        //    {
        //        if (!uniqueItems.Add(comboBox.Items[i].ToString()))
        //        {
        //            comboBox.Items.RemoveAt(i);
        //        }
        //    }
        //}
        

        private void ThongKe_Load(object sender, EventArgs e)
        {
            //loadcbo();
            dtgv_TK.DataSource = bll_tk.loadThongKe(8, 2023);
            lbl_tongDT.Text = bll_hd.TongDT(8, 2023).ToString();
            dtgv_TK.AllowUserToAddRows = false;
            this.dtgv_TK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_TK.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_TK_Click(object sender, EventArgs e)
        {
            if (cbo_thang.Text == string.Empty || cbo_nam.Text == string.Empty)
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                int thang = int.Parse(cbo_thang.Text);
                int nam = int.Parse(cbo_nam.Text);
                dtgv_TK.DataSource = bll_tk.loadThongKe(thang, nam);
                lbl_tongDT.Text = bll_hd.TongDT(thang, nam).ToString();
            }
           
        }

        private void btn_dagiao_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cbo_thang.Text);
            int nam = int.Parse(cbo_nam.Text);
            int dagiao = int.Parse(bll_tk.DonDaGiao(thang, nam).ToString());
           MessageBox.Show("Tổng số đơn hàng đã giao " + dagiao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btn_choxn_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cbo_thang.Text);
            int nam = int.Parse(cbo_nam.Text);
            int choxn = int.Parse(bll_tk.DonChoXN(thang, nam).ToString());
            MessageBox.Show("Tổng số đơn hàng chờ xác nhận " + choxn, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btn_daxn_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cbo_thang.Text);
            int nam = int.Parse(cbo_nam.Text);
            int daxn = int.Parse(bll_tk.DonDaXN(thang, nam).ToString());
            MessageBox.Show("Tổng số đơn hàng đã xác nhận " + daxn, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btn_dadoitra_Click(object sender, EventArgs e)
        {
            int thang = int.Parse(cbo_thang.Text);
            int nam = int.Parse(cbo_nam.Text);
            int dadt = int.Parse(bll_tk.DonDaDoiTra(thang, nam).ToString());
            MessageBox.Show("Tổng số đơn hàng đã đổi trả " + dadt, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btn_dagiao_MouseHover(object sender, EventArgs e)
        {
            btn_dagiao.BackColor = Color.LimeGreen;
        }

        private void btn_dagiao_MouseLeave(object sender, EventArgs e)
        {
            btn_dagiao.BackColor = SystemColors.ControlLight;
        }

        private void btn_choxn_MouseHover(object sender, EventArgs e)
        {
            btn_choxn.BackColor = Color.Tomato;
        }

        private void btn_choxn_MouseLeave(object sender, EventArgs e)
        {
            btn_choxn.BackColor = SystemColors.ControlLight;
        }

        private void btn_daxn_MouseLeave(object sender, EventArgs e)
        {
            btn_daxn.BackColor = SystemColors.ControlLight;
        }

        private void btn_daxn_MouseHover(object sender, EventArgs e)
        {
            btn_daxn.BackColor = Color.DeepSkyBlue;
        }

        private void btn_dadoitra_MouseLeave(object sender, EventArgs e)
        {
            btn_dadoitra.BackColor = SystemColors.ControlLight;
        }

        private void btn_dadoitra_MouseHover(object sender, EventArgs e)
        {
            btn_dadoitra.BackColor = Color.OrangeRed;
        }

       

       
    }
}
