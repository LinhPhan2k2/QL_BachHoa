using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class TrangChu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        DangNhapBLL bllDN = new DangNhapBLL();
        public TrangChu(int Mess, string Tennv)
        {
            InitializeComponent();
            random = new Random();
            this.WindowState = FormWindowState.Maximized;
            label1.Text = Tennv;
            LoadPQ(Mess);
        }
        private void LoadPQ(int mess)
        {
            List<Button> btn = new List<Button>();
            btn.Add(button1);
            btn.Add(button2);
            btn.Add(button3);
            btn.Add(button4);
            btn.Add(button5);
            btn.Add(button6);
            btn.Add(button7);
            DataTable dsQuyen = bllDN.layManHinh(mess);
            foreach (Button menu in btn)
            {
                    foreach (DataRow mh in dsQuyen.Rows)
                    {
                        if (string.Equals(mh[1].ToString(), menu.Tag) && int.Parse(mh[2].ToString()) == 1)
                        {
                            menu.Enabled = true;
                            menu.Visible = true;
                            break;
                        }
                        else
                        {
                            menu.Enabled = false;
                            menu.Visible = false;
                        }
                }
            }
        
       
        }
        //Constructor

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //panel_title.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor= ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel_Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.White;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_main.Controls.Add(childForm);
            this.panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DuyetDonHang(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoiTra(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_SanPham(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_NhanVien(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhapHang(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKe(), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PhanQuyen(), sender);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button8_Click_1(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (h == DialogResult.Yes)
            {
                Program.loginForm = new DangNhap();

                this.Visible = false;

                Program.loginForm.Show();
            }
        }
          


        

    }
}
