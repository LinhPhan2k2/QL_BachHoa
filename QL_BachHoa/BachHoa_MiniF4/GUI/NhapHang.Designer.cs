namespace GUI
{
    partial class NhapHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgv_SP = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_ncc = new System.Windows.Forms.ComboBox();
            this.txt_mapn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.lbl_tongnhap2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_gianhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.btn_them_sp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_ctpn = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_ngaynhap2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_them_pn = new System.Windows.Forms.Button();
            this.lbl_ngaynhap = new System.Windows.Forms.Label();
            this.lbl_tongnhap = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SP)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ctpn)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgv_SP);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbo_ncc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 788);
            this.panel2.TabIndex = 23;
            // 
            // dtgv_SP
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_SP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_SP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_SP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_SP.Location = new System.Drawing.Point(12, 184);
            this.dtgv_SP.Name = "dtgv_SP";
            this.dtgv_SP.RowTemplate.Height = 40;
            this.dtgv_SP.Size = new System.Drawing.Size(742, 548);
            this.dtgv_SP.TabIndex = 24;
            this.dtgv_SP.Click += new System.EventHandler(this.dtgv_SP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 22);
            this.label6.TabIndex = 44;
            this.label6.Text = "Nhà cung cấp";
            // 
            // cbo_ncc
            // 
            this.cbo_ncc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ncc.FormattingEnabled = true;
            this.cbo_ncc.Location = new System.Drawing.Point(193, 33);
            this.cbo_ncc.Name = "cbo_ncc";
            this.cbo_ncc.Size = new System.Drawing.Size(512, 30);
            this.cbo_ncc.TabIndex = 42;
            this.cbo_ncc.SelectedIndexChanged += new System.EventHandler(this.cbo_ncc_SelectedIndexChanged);
            this.cbo_ncc.SelectionChangeCommitted += new System.EventHandler(this.cbo_ncc_SelectionChangeCommitted);
            // 
            // txt_mapn
            // 
            this.txt_mapn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mapn.Location = new System.Drawing.Point(390, 46);
            this.txt_mapn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mapn.Multiline = true;
            this.txt_mapn.Name = "txt_mapn";
            this.txt_mapn.Size = new System.Drawing.Size(54, 39);
            this.txt_mapn.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 26);
            this.label5.TabIndex = 29;
            this.label5.Text = "Phiếu nhập ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1704, 788);
            this.panel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(764, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(940, 788);
            this.panel3.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_in);
            this.panel5.Controls.Add(this.btn_xoa);
            this.panel5.Controls.Add(this.lbl_tongnhap2);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txt_gianhap);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txt_sl);
            this.panel5.Controls.Add(this.txt_tensp);
            this.panel5.Controls.Add(this.txt_masp);
            this.panel5.Controls.Add(this.btn_them_sp);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.dtgv_ctpn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 144);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(940, 644);
            this.panel5.TabIndex = 31;
            // 
            // btn_in
            // 
            this.btn_in.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in.Image = ((System.Drawing.Image)(resources.GetObject("btn_in.Image")));
            this.btn_in.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_in.Location = new System.Drawing.Point(479, 274);
            this.btn_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(111, 52);
            this.btn_in.TabIndex = 23;
            this.btn_in.Text = "In";
            this.btn_in.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(278, 274);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(135, 52);
            this.btn_xoa.TabIndex = 58;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // lbl_tongnhap2
            // 
            this.lbl_tongnhap2.AutoSize = true;
            this.lbl_tongnhap2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tongnhap2.ForeColor = System.Drawing.Color.Red;
            this.lbl_tongnhap2.Location = new System.Drawing.Point(594, 610);
            this.lbl_tongnhap2.Name = "lbl_tongnhap2";
            this.lbl_tongnhap2.Size = new System.Drawing.Size(20, 22);
            this.lbl_tongnhap2.TabIndex = 57;
            this.lbl_tongnhap2.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(26, 610);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 22);
            this.label7.TabIndex = 56;
            this.label7.Text = "Tổng nhập";
            // 
            // txt_gianhap
            // 
            this.txt_gianhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gianhap.Location = new System.Drawing.Point(287, 207);
            this.txt_gianhap.Name = "txt_gianhap";
            this.txt_gianhap.Size = new System.Drawing.Size(303, 30);
            this.txt_gianhap.TabIndex = 55;
            this.txt_gianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gianhap_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 54;
            this.label4.Text = "Giá nhập";
            // 
            // txt_sl
            // 
            this.txt_sl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sl.Location = new System.Drawing.Point(287, 145);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(303, 30);
            this.txt_sl.TabIndex = 53;
            this.txt_sl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sl_KeyPress);
            this.txt_sl.Leave += new System.EventHandler(this.txt_sl_Leave);
            // 
            // txt_tensp
            // 
            this.txt_tensp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tensp.Location = new System.Drawing.Point(287, 81);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.ReadOnly = true;
            this.txt_tensp.Size = new System.Drawing.Size(303, 30);
            this.txt_tensp.TabIndex = 52;
            // 
            // txt_masp
            // 
            this.txt_masp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_masp.Location = new System.Drawing.Point(287, 19);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.ReadOnly = true;
            this.txt_masp.Size = new System.Drawing.Size(303, 30);
            this.txt_masp.TabIndex = 51;
            // 
            // btn_them_sp
            // 
            this.btn_them_sp.Image = ((System.Drawing.Image)(resources.GetObject("btn_them_sp.Image")));
            this.btn_them_sp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them_sp.Location = new System.Drawing.Point(84, 274);
            this.btn_them_sp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them_sp.Name = "btn_them_sp";
            this.btn_them_sp.Size = new System.Drawing.Size(138, 52);
            this.btn_them_sp.TabIndex = 40;
            this.btn_them_sp.Text = "Thêm";
            this.btn_them_sp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them_sp.UseVisualStyleBackColor = true;
            this.btn_them_sp.Click += new System.EventHandler(this.btn_them_sp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 50;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 48;
            this.label1.Text = "Mã sản phẩm";
            // 
            // dtgv_ctpn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_ctpn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_ctpn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_ctpn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_ctpn.Location = new System.Drawing.Point(31, 354);
            this.dtgv_ctpn.Name = "dtgv_ctpn";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_ctpn.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv_ctpn.RowTemplate.Height = 40;
            this.dtgv_ctpn.Size = new System.Drawing.Size(743, 234);
            this.dtgv_ctpn.TabIndex = 24;
            this.dtgv_ctpn.Click += new System.EventHandler(this.dtgv_ctpn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_ngaynhap2);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.btn_them_pn);
            this.panel4.Controls.Add(this.txt_mapn);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lbl_ngaynhap);
            this.panel4.Controls.Add(this.lbl_tongnhap);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(940, 144);
            this.panel4.TabIndex = 30;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // lbl_ngaynhap2
            // 
            this.lbl_ngaynhap2.AutoSize = true;
            this.lbl_ngaynhap2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaynhap2.Location = new System.Drawing.Point(394, 105);
            this.lbl_ngaynhap2.Name = "lbl_ngaynhap2";
            this.lbl_ngaynhap2.Size = new System.Drawing.Size(18, 25);
            this.lbl_ngaynhap2.TabIndex = 49;
            this.lbl_ngaynhap2.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(233, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 26);
            this.label8.TabIndex = 48;
            this.label8.Text = "Ngày nhập";
            // 
            // btn_them_pn
            // 
            this.btn_them_pn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them_pn.Image = ((System.Drawing.Image)(resources.GetObject("btn_them_pn.Image")));
            this.btn_them_pn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them_pn.Location = new System.Drawing.Point(31, 46);
            this.btn_them_pn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them_pn.Name = "btn_them_pn";
            this.btn_them_pn.Size = new System.Drawing.Size(185, 52);
            this.btn_them_pn.TabIndex = 27;
            this.btn_them_pn.Text = "Tạo phiếu nhập";
            this.btn_them_pn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them_pn.UseVisualStyleBackColor = true;
            this.btn_them_pn.Click += new System.EventHandler(this.btn_them_pn_Click);
            // 
            // lbl_ngaynhap
            // 
            this.lbl_ngaynhap.AutoSize = true;
            this.lbl_ngaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngaynhap.Location = new System.Drawing.Point(443, 27);
            this.lbl_ngaynhap.Name = "lbl_ngaynhap";
            this.lbl_ngaynhap.Size = new System.Drawing.Size(0, 25);
            this.lbl_ngaynhap.TabIndex = 45;
            // 
            // lbl_tongnhap
            // 
            this.lbl_tongnhap.AutoSize = true;
            this.lbl_tongnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tongnhap.Location = new System.Drawing.Point(594, 26);
            this.lbl_tongnhap.Name = "lbl_tongnhap";
            this.lbl_tongnhap.Size = new System.Drawing.Size(0, 25);
            this.lbl_tongnhap.TabIndex = 47;
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 788);
            this.Controls.Add(this.panel1);
            this.Name = "NhapHang";
            this.Text = "NhapHang";
            this.Load += new System.EventHandler(this.NhapHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ctpn)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgv_SP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_ncc;
        private System.Windows.Forms.Button btn_them_sp;
        private System.Windows.Forms.Button btn_them_pn;
        private System.Windows.Forms.TextBox txt_mapn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_tongnhap;
        private System.Windows.Forms.Label lbl_ngaynhap;
        private System.Windows.Forms.DataGridView dtgv_ctpn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_gianhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tongnhap2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label lbl_ngaynhap2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_in;


    }
}