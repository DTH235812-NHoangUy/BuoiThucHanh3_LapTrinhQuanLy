namespace QuanLyBanHang.Forms
{
    partial class frmHoaDon_ChiTiet
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxThongTinChung = new System.Windows.Forms.GroupBox();
            this.txtGhiChuHoaDon = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.groupBoxChiTiet = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXacNhanBan = new System.Windows.Forms.Button();
            this.numDonGiaBan = new System.Windows.Forms.NumericUpDown();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.numSoLuongBan = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.dgvHoaDonChiTiet = new System.Windows.Forms.DataGridView();
            this.SanPhamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuuHoaDon = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBoxThongTinChung.SuspendLayout();
            this.groupBoxChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxThongTinChung
            // 
            this.groupBoxThongTinChung.Controls.Add(this.txtGhiChuHoaDon);
            this.groupBoxThongTinChung.Controls.Add(this.lblGhiChu);
            this.groupBoxThongTinChung.Controls.Add(this.cboKhachHang);
            this.groupBoxThongTinChung.Controls.Add(this.lblKhachHang);
            this.groupBoxThongTinChung.Controls.Add(this.cboNhanVien);
            this.groupBoxThongTinChung.Controls.Add(this.lblNhanVien);
            this.groupBoxThongTinChung.Location = new System.Drawing.Point(12, 12);
            this.groupBoxThongTinChung.Name = "groupBoxThongTinChung";
            this.groupBoxThongTinChung.Size = new System.Drawing.Size(776, 100);
            this.groupBoxThongTinChung.TabIndex = 0;
            this.groupBoxThongTinChung.TabStop = false;
            this.groupBoxThongTinChung.Text = "Thông tin hóa đơn";
            // 
            // txtGhiChuHoaDon
            // 
            this.txtGhiChuHoaDon.Location = new System.Drawing.Point(130, 60);
            this.txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            this.txtGhiChuHoaDon.Size = new System.Drawing.Size(630, 20);
            this.txtGhiChuHoaDon.TabIndex = 5;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(20, 63);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(89, 13);
            this.lblGhiChu.TabIndex = 4;
            this.lblGhiChu.Text = "Ghi chú hóa đơn:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(530, 25);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(230, 21);
            this.cboKhachHang.TabIndex = 3;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(430, 28);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(84, 13);
            this.lblKhachHang.TabIndex = 2;
            this.lblKhachHang.Text = "Khách hàng (*):";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(130, 25);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(250, 21);
            this.cboNhanVien.TabIndex = 1;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(20, 28);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(92, 13);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "Nhân viên lập (*):";
            // 
            // groupBoxChiTiet
            // 
            this.groupBoxChiTiet.Controls.Add(this.btnXoa);
            this.groupBoxChiTiet.Controls.Add(this.btnXacNhanBan);
            this.groupBoxChiTiet.Controls.Add(this.numDonGiaBan);
            this.groupBoxChiTiet.Controls.Add(this.lblDonGia);
            this.groupBoxChiTiet.Controls.Add(this.numSoLuongBan);
            this.groupBoxChiTiet.Controls.Add(this.lblSoLuong);
            this.groupBoxChiTiet.Controls.Add(this.cboSanPham);
            this.groupBoxChiTiet.Controls.Add(this.lblSanPham);
            this.groupBoxChiTiet.Location = new System.Drawing.Point(12, 118);
            this.groupBoxChiTiet.Name = "groupBoxChiTiet";
            this.groupBoxChiTiet.Size = new System.Drawing.Size(776, 70);
            this.groupBoxChiTiet.TabIndex = 1;
            this.groupBoxChiTiet.TabStop = false;
            this.groupBoxChiTiet.Text = "Thông tin chi tiết hóa đơn";
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(685, 30);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXacNhanBan
            // 
            this.btnXacNhanBan.Location = new System.Drawing.Point(580, 30);
            this.btnXacNhanBan.Name = "btnXacNhanBan";
            this.btnXacNhanBan.Size = new System.Drawing.Size(95, 23);
            this.btnXacNhanBan.TabIndex = 6;
            this.btnXacNhanBan.Text = "Xác nhận bán";
            this.btnXacNhanBan.UseVisualStyleBackColor = true;
            this.btnXacNhanBan.Click += new System.EventHandler(this.btnXacNhanBan_Click);
            // 
            // numDonGiaBan
            // 
            this.numDonGiaBan.Location = new System.Drawing.Point(440, 32);
            this.numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            this.numDonGiaBan.Name = "numDonGiaBan";
            this.numDonGiaBan.Size = new System.Drawing.Size(120, 20);
            this.numDonGiaBan.TabIndex = 5;
            this.numDonGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDonGiaBan.ThousandsSeparator = true;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(437, 16);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(83, 13);
            this.lblDonGia.TabIndex = 4;
            this.lblDonGia.Text = "Đơn giá bán (*):";
            // 
            // numSoLuongBan
            // 
            this.numSoLuongBan.Location = new System.Drawing.Point(320, 32);
            this.numSoLuongBan.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numSoLuongBan.Name = "numSoLuongBan";
            this.numSoLuongBan.Size = new System.Drawing.Size(100, 20);
            this.numSoLuongBan.TabIndex = 3;
            this.numSoLuongBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSoLuongBan.ThousandsSeparator = true;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(317, 16);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(87, 13);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng bán (*):";
            // 
            // cboSanPham
            // 
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(23, 32);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(270, 21);
            this.cboSanPham.TabIndex = 1;
            this.cboSanPham.SelectionChangeCommitted += new System.EventHandler(this.cboSanPham_SelectionChangeCommitted);
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Location = new System.Drawing.Point(20, 16);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(73, 13);
            this.lblSanPham.TabIndex = 0;
            this.lblSanPham.Text = "Sản phẩm (*):";
            // 
            // dgvHoaDonChiTiet
            // 
            this.dgvHoaDonChiTiet.AllowUserToAddRows = false;
            this.dgvHoaDonChiTiet.AllowUserToDeleteRows = false;
            this.dgvHoaDonChiTiet.AllowUserToOrderColumns = true;
            this.dgvHoaDonChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDonChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SanPhamID,
            this.TenSanPham,
            this.DonGiaBan,
            this.SoLuongBan,
            this.ThanhTien});
            this.dgvHoaDonChiTiet.Location = new System.Drawing.Point(12, 194);
            this.dgvHoaDonChiTiet.MultiSelect = false;
            this.dgvHoaDonChiTiet.Name = "dgvHoaDonChiTiet";
            this.dgvHoaDonChiTiet.ReadOnly = true;
            this.dgvHoaDonChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDonChiTiet.Size = new System.Drawing.Size(776, 200);
            this.dgvHoaDonChiTiet.TabIndex = 2;
            // 
            // SanPhamID
            // 
            this.SanPhamID.DataPropertyName = "SanPhamID";
            this.SanPhamID.HeaderText = "ID";
            this.SanPhamID.Name = "SanPhamID";
            this.SanPhamID.ReadOnly = true;
            // 
            // TenSanPham
            // 
            this.TenSanPham.DataPropertyName = "TenSanPham";
            this.TenSanPham.HeaderText = "Tên sản phẩm";
            this.TenSanPham.Name = "TenSanPham";
            this.TenSanPham.ReadOnly = true;
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            this.DonGiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            this.DonGiaBan.HeaderText = "Đơn giá bán";
            this.DonGiaBan.Name = "DonGiaBan";
            this.DonGiaBan.ReadOnly = true;
            // 
            // SoLuongBan
            // 
            this.SoLuongBan.DataPropertyName = "SoLuongBan";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.SoLuongBan.DefaultCellStyle = dataGridViewCellStyle2;
            this.SoLuongBan.HeaderText = "Số lượng bán";
            this.SoLuongBan.Name = "SoLuongBan";
            this.SoLuongBan.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.Format = "N0";
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // btnLuuHoaDon
            // 
            this.btnLuuHoaDon.Location = new System.Drawing.Point(230, 410);
            this.btnLuuHoaDon.Name = "btnLuuHoaDon";
            this.btnLuuHoaDon.Size = new System.Drawing.Size(110, 30);
            this.btnLuuHoaDon.TabIndex = 3;
            this.btnLuuHoaDon.Text = "Lưu hóa đơn";
            this.btnLuuHoaDon.UseVisualStyleBackColor = true;
            this.btnLuuHoaDon.Click += new System.EventHandler(this.btnLuuHoaDon_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(350, 410);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(110, 30);
            this.btnInHoaDon.TabIndex = 4;
            this.btnInHoaDon.Text = "In hóa đơn...";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(470, 410);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 30);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmHoaDon_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnLuuHoaDon);
            this.Controls.Add(this.dgvHoaDonChiTiet);
            this.Controls.Add(this.groupBoxChiTiet);
            this.Controls.Add(this.groupBoxThongTinChung);
            this.Name = "frmHoaDon_ChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn chi tiết";
            this.Load += new System.EventHandler(this.frmHoaDon_ChiTiet_Load);
            this.groupBoxThongTinChung.ResumeLayout(false);
            this.groupBoxThongTinChung.PerformLayout();
            this.groupBoxChiTiet.ResumeLayout(false);
            this.groupBoxChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxThongTinChung;
        private System.Windows.Forms.TextBox txtGhiChuHoaDon;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.GroupBox groupBoxChiTiet;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXacNhanBan;
        private System.Windows.Forms.NumericUpDown numDonGiaBan;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.NumericUpDown numSoLuongBan;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.DataGridView dgvHoaDonChiTiet;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.DataGridViewTextBoxColumn SanPhamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}