namespace GUI_QuanLy
{
    partial class QuanLy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.lblTen_SP = new System.Windows.Forms.Label();
            this.lblMa_SP = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.dgVQuanLy = new System.Windows.Forms.DataGridView();
            this.colMa_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhanLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVQuanLy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.lblNhaCungCap);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblSoLuong);
            this.panel2.Controls.Add(this.lblGia);
            this.panel2.Controls.Add(this.lblDanhMuc);
            this.panel2.Controls.Add(this.lblTen_SP);
            this.panel2.Controls.Add(this.lblMa_SP);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(1000, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 590);
            this.panel2.TabIndex = 6;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(70, 533);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(240, 44);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa Sản Phẩm";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaCungCap.Location = new System.Drawing.Point(153, 470);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(130, 30);
            this.lblNhaCungCap.TabIndex = 13;
            this.lblNhaCungCap.Text = "(Nhà Cung Cấp)";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 30);
            this.label9.TabIndex = 12;
            this.label9.Text = "Nhà Cung Cấp:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(153, 440);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(157, 30);
            this.lblSoLuong.TabIndex = 11;
            this.lblSoLuong.Text = "(Số Lượng)";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGia
            // 
            this.lblGia.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(153, 410);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(70, 30);
            this.lblGia.TabIndex = 10;
            this.lblGia.Text = "(Giá)";
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMuc.Location = new System.Drawing.Point(153, 380);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(200, 30);
            this.lblDanhMuc.TabIndex = 9;
            this.lblDanhMuc.Text = "(Danh Mục)";
            this.lblDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTen_SP
            // 
            this.lblTen_SP.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen_SP.Location = new System.Drawing.Point(153, 350);
            this.lblTen_SP.Name = "lblTen_SP";
            this.lblTen_SP.Size = new System.Drawing.Size(190, 30);
            this.lblTen_SP.TabIndex = 8;
            this.lblTen_SP.Text = "(Tên Sản Phẩm)";
            this.lblTen_SP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMa_SP
            // 
            this.lblMa_SP.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa_SP.Location = new System.Drawing.Point(153, 320);
            this.lblMa_SP.Name = "lblMa_SP";
            this.lblMa_SP.Size = new System.Drawing.Size(190, 30);
            this.lblMa_SP.TabIndex = 7;
            this.lblMa_SP.Text = "(Mã SP)";
            this.lblMa_SP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "Số Lượng:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "Giá:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 30);
            this.label6.TabIndex = 4;
            this.label6.Text = "Danh Mục:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 237);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã SP:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 61);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông Tin Sản Phẩm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelContent.Controls.Add(this.cbDanhMuc);
            this.panelContent.Controls.Add(this.label11);
            this.panelContent.Controls.Add(this.label10);
            this.panelContent.Controls.Add(this.btnTimKiem);
            this.panelContent.Controls.Add(this.cbNhaCungCap);
            this.panelContent.Controls.Add(this.dgVQuanLy);
            this.panelContent.Controls.Add(this.txtSearch);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Location = new System.Drawing.Point(39, 50);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(942, 655);
            this.panelContent.TabIndex = 5;
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Location = new System.Drawing.Point(185, 106);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(178, 28);
            this.cbDanhMuc.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(388, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 52);
            this.label11.TabIndex = 6;
            this.label11.Text = "Nhà Cung Cấp:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 38);
            this.label10.TabIndex = 5;
            this.label10.Text = "Danh Mục:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(721, 106);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(175, 45);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // cbNhaCungCap
            // 
            this.cbNhaCungCap.FormattingEnabled = true;
            this.cbNhaCungCap.Location = new System.Drawing.Point(550, 109);
            this.cbNhaCungCap.Name = "cbNhaCungCap";
            this.cbNhaCungCap.Size = new System.Drawing.Size(148, 28);
            this.cbNhaCungCap.TabIndex = 3;
            // 
            // dgVQuanLy
            // 
            this.dgVQuanLy.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVQuanLy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVQuanLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVQuanLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa_SP,
            this.colTen_SP,
            this.colPhanLoai,
            this.colGia,
            this.colSoLuong,
            this.colNhaCC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVQuanLy.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgVQuanLy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgVQuanLy.Location = new System.Drawing.Point(0, 191);
            this.dgVQuanLy.Name = "dgVQuanLy";
            this.dgVQuanLy.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVQuanLy.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgVQuanLy.RowHeadersWidth = 62;
            this.dgVQuanLy.RowTemplate.Height = 35;
            this.dgVQuanLy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVQuanLy.Size = new System.Drawing.Size(942, 464);
            this.dgVQuanLy.TabIndex = 3;
            this.dgVQuanLy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVQuanLy_CellContentClick);
            // 
            // colMa_SP
            // 
            this.colMa_SP.DataPropertyName = "Ma_SP";
            this.colMa_SP.HeaderText = "Mã SP";
            this.colMa_SP.MinimumWidth = 8;
            this.colMa_SP.Name = "colMa_SP";
            this.colMa_SP.ReadOnly = true;
            this.colMa_SP.Width = 60;
            // 
            // colTen_SP
            // 
            this.colTen_SP.DataPropertyName = "Ten_SP";
            this.colTen_SP.HeaderText = "Tên Sản Phẩm";
            this.colTen_SP.MinimumWidth = 8;
            this.colTen_SP.Name = "colTen_SP";
            this.colTen_SP.ReadOnly = true;
            this.colTen_SP.Width = 147;
            // 
            // colPhanLoai
            // 
            this.colPhanLoai.DataPropertyName = "Phan_Loai";
            this.colPhanLoai.HeaderText = "Phân Loại";
            this.colPhanLoai.MinimumWidth = 8;
            this.colPhanLoai.Name = "colPhanLoai";
            this.colPhanLoai.ReadOnly = true;
            this.colPhanLoai.Width = 146;
            // 
            // colGia
            // 
            this.colGia.DataPropertyName = "Gia";
            dataGridViewCellStyle2.Format = "N0";
            this.colGia.DefaultCellStyle = dataGridViewCellStyle2;
            this.colGia.HeaderText = "Giá";
            this.colGia.MinimumWidth = 8;
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            this.colGia.Width = 146;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.MinimumWidth = 8;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 147;
            // 
            // colNhaCC
            // 
            this.colNhaCC.DataPropertyName = "Nha_CC";
            this.colNhaCC.HeaderText = "Nhà Cung Cấp";
            this.colNhaCC.MinimumWidth = 8;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.ReadOnly = true;
            this.colNhaCC.Width = 146;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(185, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(694, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThem.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1005, 661);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(240, 44);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm Sản Phẩm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1271, 663);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 754);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelContent);
            this.Name = "QuanLy";
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVQuanLy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.Label lblTen_SP;
        private System.Windows.Forms.Label lblMa_SP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbNhaCungCap;
        private System.Windows.Forms.DataGridView dgVQuanLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhanLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhaCC;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button1;
    }
}

