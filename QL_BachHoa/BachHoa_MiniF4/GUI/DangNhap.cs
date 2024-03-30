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
    public partial class DangNhap : Form
    {
        DangNhapBLL bllDN = new DangNhapBLL();

        public DangNhap()
        {
            InitializeComponent();
        }
        public void Login()
        {
           
            if (string.IsNullOrEmpty(txt_u.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống mã nhân viên");
                this.txt_u.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txt_pass.Text))
            {
                MessageBox.Show("Không được bỏ trống mật khẩu");
                this.txt_pass.Focus();
                return;
            }

            if (bllDN.ktDangNhap(txt_u.Text, txt_pass.Text) == 0)
            {
                MessageBox.Show("Sai tài khoản hoặc password");
                return;
            }
            else
            {
                string quyen = bllDN.layMaQuyen(txt_u.Text);
                string tennv = bllDN.layNhanVien(txt_u.Text);
                Program.mainForm = new TrangChu(int.Parse(quyen), tennv);

                this.Visible = false;

                Program.mainForm.Show();

            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Login();
        }

        private void txt_u_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            //    e.Handled = true;
        }

    }
}
