namespace GUI
{
    partial class CustomMessageBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dagiao = new System.Windows.Forms.Button();
            this.btn_dahuy = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 101);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn muốn duyệt đơn hàng?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_dagiao
            // 
            this.btn_dagiao.Location = new System.Drawing.Point(68, 120);
            this.btn_dagiao.Name = "btn_dagiao";
            this.btn_dagiao.Size = new System.Drawing.Size(75, 36);
            this.btn_dagiao.TabIndex = 1;
            this.btn_dagiao.Text = "Đã giao";
            this.btn_dagiao.UseVisualStyleBackColor = true;
            this.btn_dagiao.Click += new System.EventHandler(this.btn_dagiao_Click);
            // 
            // btn_dahuy
            // 
            this.btn_dahuy.Location = new System.Drawing.Point(188, 120);
            this.btn_dahuy.Name = "btn_dahuy";
            this.btn_dahuy.Size = new System.Drawing.Size(75, 36);
            this.btn_dahuy.TabIndex = 2;
            this.btn_dahuy.Text = "Đã hủy";
            this.btn_dahuy.UseVisualStyleBackColor = true;
            this.btn_dahuy.Click += new System.EventHandler(this.btn_dahuy_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(306, 120);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 36);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 182);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dahuy);
            this.Controls.Add(this.btn_dagiao);
            this.Controls.Add(this.panel1);
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông báo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dagiao;
        private System.Windows.Forms.Button btn_dahuy;
        private System.Windows.Forms.Button btn_thoat;
    }
}