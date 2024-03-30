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
    public partial class Report_PN : Form
    {
        public Report_PN()
        {
            InitializeComponent();
            
        }

        void loadRP()
        {
            Report_PhieuNhap pn = new Report_PhieuNhap();
            crystalReportViewer1.ReportSource = pn;
            pn.SetDatabaseLogon("sa","123QWEasd", @"LAPTOP-DAC11E8M\SQLEXPRESS", "QL_BACHHOA");
            pn.SetParameterValue("Phieu_Nhap", textBox1.Text);
            crystalReportViewer1.Refresh();
            crystalReportViewer1.DisplayToolbar = false;
            crystalReportViewer1.DisplayStatusBar = false;
            textBox1.Enabled = false;
        }

        public Report_PN(string pn)
        {
            InitializeComponent();
            textBox1.Text = pn.ToString();
        }

        private void Report_PN_Load(object sender, EventArgs e)
        {
            loadRP();
        }
    }
}
