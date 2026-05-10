namespace BanHang
{
    partial class GioHang
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgVGioHang = new System.Windows.Forms.DataGridView();
            this.colMa_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDLT = new System.Windows.Forms.Button();
            this.lblTong = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVGioHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.dgVGioHang);
            this.panelContent.Location = new System.Drawing.Point(80, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(912, 612);
            this.panelContent.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(840, 66);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sản Phẩm Đã Chọn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgVGioHang
            // 
            this.dgVGioHang.AllowUserToAddRows = false;
            this.dgVGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa_SP,
            this.colTen_SP,
            this.colGia,
            this.colSoLuong,
            this.colThanhTien});
            this.dgVGioHang.Location = new System.Drawing.Point(36, 133);
            this.dgVGioHang.Name = "dgVGioHang";
            this.dgVGioHang.RowHeadersWidth = 62;
            this.dgVGioHang.RowTemplate.Height = 28;
            this.dgVGioHang.Size = new System.Drawing.Size(840, 446);
            this.dgVGioHang.TabIndex = 5;
            this.dgVGioHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVGioHang_CellContentClick);
            // 
            // colMa_SP
            // 
            this.colMa_SP.DataPropertyName = "Ma_SP";
            this.colMa_SP.HeaderText = "Mã SP";
            this.colMa_SP.MinimumWidth = 8;
            this.colMa_SP.Name = "colMa_SP";
            // 
            // colTen_SP
            // 
            this.colTen_SP.DataPropertyName = "Ten_SP";
            this.colTen_SP.HeaderText = "Tên Sản Phẩm";
            this.colTen_SP.MinimumWidth = 8;
            this.colTen_SP.Name = "colTen_SP";
            // 
            // colGia
            // 
            this.colGia.DataPropertyName = "GiaBan";
            this.colGia.HeaderText = "Giá";
            this.colGia.MinimumWidth = 8;
            this.colGia.Name = "colGia";
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.MinimumWidth = 8;
            this.colSoLuong.Name = "colSoLuong";
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.MinimumWidth = 8;
            this.colThanhTien.Name = "colThanhTien";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1143, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(157, 60);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btnXacNhan);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.txtTenKH);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(998, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 612);
            this.panel2.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(5, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 37);
            this.label8.TabIndex = 10;
            this.label8.Text = "Địa Chỉ:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(5, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 37);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 37);
            this.label6.TabIndex = 8;
            this.label6.Text = "SĐT:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên KH:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(105, 320);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(277, 37);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(105, 390);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(277, 37);
            this.txtEmail.TabIndex = 4;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(105, 250);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(277, 37);
            this.txtSDT.TabIndex = 3;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(105, 181);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(277, 37);
            this.txtTenKH.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 87);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông Tin Khách Hàng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnDLT);
            this.panel3.Controls.Add(this.lblTong);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(80, 630);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1326, 79);
            this.panel3.TabIndex = 7;
            // 
            // btnDLT
            // 
            this.btnDLT.Location = new System.Drawing.Point(928, 8);
            this.btnDLT.Name = "btnDLT";
            this.btnDLT.Size = new System.Drawing.Size(157, 60);
            this.btnDLT.TabIndex = 8;
            this.btnDLT.Text = "Xóa";
            this.btnDLT.UseVisualStyleBackColor = true;
            this.btnDLT.Click += new System.EventHandler(this.btnDLT_Click);
            // 
            // lblTong
            // 
            this.lblTong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.Location = new System.Drawing.Point(190, 21);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(200, 41);
            this.lblTong.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 41);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tổng Số Tiền:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 697);
            this.panel1.TabIndex = 8;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(69, 542);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(288, 37);
            this.btnXacNhan.TabIndex = 11;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 754);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelContent);
            this.Name = "GioHang";
            this.Text = "Giỏ Hàng";
            this.Load += new System.EventHandler(this.BanHang_Load);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVGioHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgVGioHang;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Button btnDLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.Button btnXacNhan;
    }
}

