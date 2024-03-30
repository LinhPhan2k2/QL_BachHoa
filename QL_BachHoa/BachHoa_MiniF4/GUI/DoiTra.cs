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
    public partial class DoiTra : Form
    {
        HoaDonBLL bllhd = new HoaDonBLL();
        ChiTietHDBLL bllcthd = new ChiTietHDBLL();
        DoiTraBLL blldt = new DoiTraBLL();
        public DoiTra()
        {
            InitializeComponent();
            LoadData();
            
        }
        private void LoadData()
        {
            hOADONDataGridView.DataSource = bllhd.getHDDT();
            btn_them.Enabled = false;
            btn_xoa.Enabled = false;
            btn_sua.Enabled = false;
            btn_thanhtoan.Enabled = false;
            button2.Enabled = false;

        }

        private void DoiTra_Load(object sender, EventArgs e)
        {
            

        }

        private void hOADONDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button2.Enabled = true; ;
            cHITIET_HDDataGridView.DataSource = bllcthd.getHDDT(hOADONDataGridView.CurrentRow.Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult h1 = MessageBox.Show("Bạn có muốn thêm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h1 == DialogResult.Yes)
            {
                    string masp = cHITIET_HDDataGridView.CurrentRow.Cells[1].Value.ToString();
                    string sl = cHITIET_HDDataGridView.CurrentRow.Cells[2].Value.ToString();
                    string giaban = cHITIET_HDDataGridView.CurrentRow.Cells[3].Value.ToString();
                    int thanhtien = int.Parse(sl) * int.Parse(giaban);
                    int dem = dataGridView1.Rows.Count;
                    int stt = 0;
                    foreach (DataGridViewRow item in dataGridView1.Rows)
                    {
                        if (dem == 1)
                        {
                            dataGridView1.Rows.Add(masp, sl, giaban, thanhtien);
                            return;
                        }
                        else
                        {
                            if (stt == dem - 1)
                            {
                                break;
                            }
                            if (masp == item.Cells[0].Value.ToString())
                            {
                               
                                DialogResult h = MessageBox.Show("Sản phẩm này đã có rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                                
                            }

                        }
                        

                        stt++;
                    }
                    dataGridView1.Rows.Add(masp, sl, giaban, thanhtien);
                    
                
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            DialogResult h1 = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h1 == DialogResult.Yes)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult h1 = MessageBox.Show("Bạn có muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h1 == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {

                    if (item.Cells[0].Value == null)
                    {
                        break;
                    }
                    else
                    {
                        if (int.Parse(item.Cells[1].Value.ToString()) < 1)
                        {
                            DialogResult h = MessageBox.Show("Sản phẩm " + item.Cells[0].Value.ToString() + "-Số lượng đổi trả không được bằng hoặc bé hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (int.Parse(item.Cells[1].Value.ToString()) > int.Parse(cHITIET_HDDataGridView.CurrentRow.Cells[2].Value.ToString()))
                        {
                            DialogResult h = MessageBox.Show("Sản phẩm " + item.Cells[0].Value.ToString() + "-Số lượng đổi trả không được vượt quá số lượng đặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            string giaban = item.Cells[2].Value.ToString();
                            int thanhtien = int.Parse(item.Cells[1].Value.ToString()) * int.Parse(giaban);
                            item.Cells[3].Value = thanhtien;
                        }
                    }


                }

                dataGridView1.Update();
            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            DialogResult h1 = MessageBox.Show("Bạn có muốn đổi trả những sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h1 == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    if (item.Cells[0].Value == null)
                    {
                        break;
                    }
                    if (int.Parse(item.Cells[1].Value.ToString()) > bllhd.QuaSL(int.Parse(item.Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Vui lòng nhập hàng thêm, số lượng trong kho không đủ!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    blldt.Them(cHITIET_HDDataGridView.Rows[0].Cells[0].Value.ToString()
                        , DateTime.Now
                        , int.Parse(item.Cells[0].Value.ToString())
                        , int.Parse(item.Cells[1].Value.ToString())
                        , int.Parse(item.Cells[2].Value.ToString()));
                    bllhd.CapNhatSL(int.Parse(item.Cells[1].Value.ToString()), int.Parse(item.Cells[0].Value.ToString()));
                }
                bllhd.Sua("Đã đổi trả", cHITIET_HDDataGridView.Rows[0].Cells[0].Value.ToString());
                DialogResult h = MessageBox.Show("Đổi trả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.Rows.Clear();
                cHITIET_HDDataGridView.DataSource = null;
                LoadData();

            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            ExcelExport ex = new ExcelExport();
            int i = dataGridView1.Rows.Count;
            List<DoiTraDTO> pListKhoa = new List<DoiTraDTO>();
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (pListKhoa.Count == i - 1)
                {
                    break;
                }
                else
                {
                    DoiTraDTO kh = new DoiTraDTO();
                    kh.Masp = item.Cells[0].Value.ToString();
                    kh.Soluong = item.Cells[1].Value.ToString();
                    kh.Giaban = item.Cells[2].Value.ToString();
                    kh.Thanhtien = item.Cells[3].Value.ToString();
                    pListKhoa.Add(kh);
                }

            }
            string path = string.Empty;
            ex.ExportKhoa(pListKhoa, ref path, false);
            if (!string.IsNullOrEmpty(path))
            {
                DialogResult h1 = MessageBox.Show("Bạn có muốn mở file hông?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (h1 == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(path);
                }
            }
            else
            {
                MessageBox.Show("Saiiiiiiiiii", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
           hOADONDataGridView.DataSource = bllhd.LoadTimKiem(txt_timkiem.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult h1 = MessageBox.Show("Bạn có muốn từ chối yêu cầu đổi trả này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h1 == DialogResult.Yes)
            {
                bllhd.Sua("Không chấp nhận yêu cầu đổi trả", hOADONDataGridView.CurrentRow.Cells[0].Value.ToString());
                DialogResult h = MessageBox.Show("Từ chối đổi trả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }

        }

        private void cHITIET_HDDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ma = int.Parse(cHITIET_HDDataGridView.CurrentRow.Cells[1].Value.ToString());
            textBox1.Text = bllhd.LayTen(ma);
            btn_them.Enabled = true;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int columnIndexToCheck = 1;
            if (e.ColumnIndex == columnIndexToCheck)
            {
                string input = e.FormattedValue as string;
                if (input.Any(char.IsLetter))
                {
                    e.Cancel = true;
                    MessageBox.Show("Vui lòng chỉ nhập số hoặc ký tự không phải chữ cái vào cột này!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_xoa.Enabled = true;
            btn_sua.Enabled = true;
            btn_thanhtoan.Enabled = true;
        }
    }
}
