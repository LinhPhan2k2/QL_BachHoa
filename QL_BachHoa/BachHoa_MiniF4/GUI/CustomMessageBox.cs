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
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btn_dagiao_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btn_dahuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
        public static DialogResult Show()
        {
            CustomMessageBox ms = new CustomMessageBox();
            ms.ShowDialog();
            return ms.DialogResult;
        }
    }
}
