namespace GUI
{
    partial class ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_dadoitra = new System.Windows.Forms.Button();
            this.btn_dagiao = new System.Windows.Forms.Button();
            this.btn_choxn = new System.Windows.Forms.Button();
            this.btn_daxn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgv_TK = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_tongDT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_TK = new System.Windows.Forms.Button();
            this.cbo_nam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_thang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TK)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btn_dadoitra, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_dagiao, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_choxn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_daxn, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1267, 156);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_dadoitra
            // 
            this.btn_dadoitra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dadoitra.BackgroundImage")));
            this.btn_dadoitra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_dadoitra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dadoitra.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dadoitra.Location = new System.Drawing.Point(951, 3);
            this.btn_dadoitra.Name = "btn_dadoitra";
            this.btn_dadoitra.Size = new System.Drawing.Size(313, 150);
            this.btn_dadoitra.TabIndex = 7;
            this.btn_dadoitra.Text = "Đã đổi trả";
            this.btn_dadoitra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dadoitra.UseVisualStyleBackColor = true;
            this.btn_dadoitra.Click += new System.EventHandler(this.btn_dadoitra_Click);
            this.btn_dadoitra.MouseLeave += new System.EventHandler(this.btn_dadoitra_MouseLeave);
            this.btn_dadoitra.MouseHover += new System.EventHandler(this.btn_dadoitra_MouseHover);
            // 
            // btn_dagiao
            // 
            this.btn_dagiao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_dagiao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dagiao.BackgroundImage")));
            this.btn_dagiao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_dagiao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dagiao.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dagiao.Location = new System.Drawing.Point(3, 3);
            this.btn_dagiao.Name = "btn_dagiao";
            this.btn_dagiao.Size = new System.Drawing.Size(310, 150);
            this.btn_dagiao.TabIndex = 6;
            this.btn_dagiao.Text = "Đã giao";
            this.btn_dagiao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dagiao.UseVisualStyleBackColor = false;
            this.btn_dagiao.Click += new System.EventHandler(this.btn_dagiao_Click);
            this.btn_dagiao.MouseLeave += new System.EventHandler(this.btn_dagiao_MouseLeave);
            this.btn_dagiao.MouseHover += new System.EventHandler(this.btn_dagiao_MouseHover);
            // 
            // btn_choxn
            // 
            this.btn_choxn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_choxn.BackgroundImage")));
            this.btn_choxn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_choxn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_choxn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choxn.Location = new System.Drawing.Point(319, 3);
            this.btn_choxn.Name = "btn_choxn";
            this.btn_choxn.Size = new System.Drawing.Size(310, 150);
            this.btn_choxn.TabIndex = 1;
            this.btn_choxn.Text = "Chờ xác nhận";
            this.btn_choxn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_choxn.UseVisualStyleBackColor = true;
            this.btn_choxn.Click += new System.EventHandler(this.btn_choxn_Click);
            this.btn_choxn.MouseLeave += new System.EventHandler(this.btn_choxn_MouseLeave);
            this.btn_choxn.MouseHover += new System.EventHandler(this.btn_choxn_MouseHover);
            // 
            // btn_daxn
            // 
            this.btn_daxn.BackgroundImage = global::GUI.Properties.Resources.tonghd_128;
            this.btn_daxn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_daxn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_daxn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_daxn.Location = new System.Drawing.Point(635, 3);
            this.btn_daxn.Name = "btn_daxn";
            this.btn_daxn.Size = new System.Drawing.Size(310, 150);
            this.btn_daxn.TabIndex = 2;
            this.btn_daxn.Text = "Đã xác nhận";
            this.btn_daxn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_daxn.UseVisualStyleBackColor = true;
            this.btn_daxn.Click += new System.EventHandler(this.btn_daxn_Click);
            this.btn_daxn.MouseLeave += new System.EventHandler(this.btn_daxn_MouseLeave);
            this.btn_daxn.MouseHover += new System.EventHandler(this.btn_daxn_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 357);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgv_TK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1267, 229);
            this.panel3.TabIndex = 2;
            // 
            // dtgv_TK
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_TK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_TK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_TK.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_TK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_TK.Location = new System.Drawing.Point(0, 0);
            this.dtgv_TK.Name = "dtgv_TK";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_TK.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_TK.RowTemplate.Height = 40;
            this.dtgv_TK.Size = new System.Drawing.Size(1267, 229);
            this.dtgv_TK.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_tongDT);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_TK);
            this.panel2.Controls.Add(this.cbo_nam);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbo_thang);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1267, 128);
            this.panel2.TabIndex = 1;
            // 
            // lbl_tongDT
            // 
            this.lbl_tongDT.AutoSize = true;
            this.lbl_tongDT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tongDT.Location = new System.Drawing.Point(1027, 35);
            this.lbl_tongDT.Name = "lbl_tongDT";
            this.lbl_tongDT.Size = new System.Drawing.Size(24, 27);
            this.lbl_tongDT.TabIndex = 6;
            this.lbl_tongDT.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(820, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng tiền:";
            // 
            // btn_TK
            // 
            this.btn_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TK.Location = new System.Drawing.Point(443, 35);
            this.btn_TK.Name = "btn_TK";
            this.btn_TK.Size = new System.Drawing.Size(174, 47);
            this.btn_TK.TabIndex = 4;
            this.btn_TK.Text = "Thống kê";
            this.btn_TK.UseVisualStyleBackColor = true;
            this.btn_TK.Click += new System.EventHandler(this.btn_TK_Click);
            // 
            // cbo_nam
            // 
            this.cbo_nam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_nam.FormattingEnabled = true;
            this.cbo_nam.Items.AddRange(new object[] {
            "2023"});
            this.cbo_nam.Location = new System.Drawing.Point(186, 74);
            this.cbo_nam.Name = "cbo_nam";
            this.cbo_nam.Size = new System.Drawing.Size(172, 34);
            this.cbo_nam.TabIndex = 3;
            this.cbo_nam.Text = "2023";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm";
            // 
            // cbo_thang
            // 
            this.cbo_thang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_thang.FormattingEnabled = true;
            this.cbo_thang.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbo_thang.Location = new System.Drawing.Point(186, 14);
            this.cbo_thang.Name = "cbo_thang";
            this.cbo_thang.Size = new System.Drawing.Size(172, 34);
            this.cbo_thang.TabIndex = 1;
            this.cbo_thang.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_TK)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgv_TK;
        private System.Windows.Forms.Button btn_choxn;
        private System.Windows.Forms.Button btn_daxn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_TK;
        private System.Windows.Forms.ComboBox cbo_nam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_thang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tongDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_dagiao;
        private System.Windows.Forms.Button btn_dadoitra;
    }
}