namespace QuanLyBanHang.Forms
{
    partial class frmNhanVien
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
            btnXuat = new Button();
            btnTimKiem = new Button();
            btnNhap = new Button();
            lblDiaChi = new Label();
            lblSDT = new Label();
            txtDiaChi = new TextBox();
            txtDienThoai = new TextBox();
            btnThoat = new Button();
            gpbDanhSach = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            btnHuybo = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtHoVaTen = new TextBox();
            lblTenNV = new Label();
            gpbThongTinNhanVien = new GroupBox();
            cboQuyenHan = new ComboBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            lblQuyenHan = new Label();
            lblMK = new Label();
            lblTenDangNhap = new Label();
            btnXoa = new Button();
            gpbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            gpbThongTinNhanVien.SuspendLayout();
            SuspendLayout();
            // 
            // btnXuat
            // 
            btnXuat.ForeColor = Color.Black;
            btnXuat.Location = new Point(877, 91);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(89, 29);
            btnXuat.TabIndex = 6;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.ForeColor = Color.Black;
            btnTimKiem.Location = new Point(877, 23);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(89, 29);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnNhap
            // 
            btnNhap.ForeColor = Color.Black;
            btnNhap.Location = new Point(877, 57);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(89, 29);
            btnNhap.TabIndex = 12;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(4, 91);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(78, 20);
            lblDiaChi.TabIndex = 11;
            lblDiaChi.Text = "Địa chỉ (*):";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(4, 61);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(120, 20);
            lblSDT.TabIndex = 10;
            lblSDT.Text = "Số điện thoại (*):";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(130, 88);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(209, 27);
            txtDiaChi.TabIndex = 9;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(130, 58);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(209, 27);
            txtDienThoai.TabIndex = 8;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(781, 91);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(89, 29);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // gpbDanhSach
            // 
            gpbDanhSach.Controls.Add(dataGridView);
            gpbDanhSach.Location = new Point(5, 132);
            gpbDanhSach.Name = "gpbDanhSach";
            gpbDanhSach.Size = new Size(972, 403);
            gpbDanhSach.TabIndex = 5;
            gpbDanhSach.TabStop = false;
            gpbDanhSach.Text = "Danh sách khách hàng:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, TenDangNhap, QuyenHan });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(966, 377);
            dataGridView.TabIndex = 1;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 25.30435F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.FillWeight = 124.366913F;
            HoVaTen.HeaderText = "Họ và Tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.FillWeight = 112.190414F;
            DienThoai.HeaderText = "Điện Thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.FillWeight = 128.342239F;
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.FillWeight = 104.898041F;
            TenDangNhap.HeaderText = "Tên Đăng Nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.FillWeight = 104.898041F;
            QuyenHan.HeaderText = "Quyền Hạn";
            QuyenHan.MinimumWidth = 6;
            QuyenHan.Name = "QuyenHan";
            // 
            // btnHuybo
            // 
            btnHuybo.Location = new Point(781, 57);
            btnHuybo.Name = "btnHuybo";
            btnHuybo.Size = new Size(89, 29);
            btnHuybo.TabIndex = 6;
            btnHuybo.Text = "Hủy bỏ";
            btnHuybo.UseVisualStyleBackColor = true;
            btnHuybo.Click += btnHuybo_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(781, 23);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(89, 29);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(686, 57);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(89, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(686, 23);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(89, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(130, 24);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(209, 27);
            txtHoVaTen.TabIndex = 1;
            // 
            // lblTenNV
            // 
            lblTenNV.AutoSize = true;
            lblTenNV.Location = new Point(4, 27);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(98, 20);
            lblTenNV.TabIndex = 0;
            lblTenNV.Text = "Họ và Tên (*):";
            // 
            // gpbThongTinNhanVien
            // 
            gpbThongTinNhanVien.Controls.Add(cboQuyenHan);
            gpbThongTinNhanVien.Controls.Add(txtMatKhau);
            gpbThongTinNhanVien.Controls.Add(txtTenDangNhap);
            gpbThongTinNhanVien.Controls.Add(lblQuyenHan);
            gpbThongTinNhanVien.Controls.Add(lblMK);
            gpbThongTinNhanVien.Controls.Add(lblTenDangNhap);
            gpbThongTinNhanVien.Controls.Add(btnXuat);
            gpbThongTinNhanVien.Controls.Add(btnTimKiem);
            gpbThongTinNhanVien.Controls.Add(btnNhap);
            gpbThongTinNhanVien.Controls.Add(lblDiaChi);
            gpbThongTinNhanVien.Controls.Add(lblSDT);
            gpbThongTinNhanVien.Controls.Add(txtDiaChi);
            gpbThongTinNhanVien.Controls.Add(txtDienThoai);
            gpbThongTinNhanVien.Controls.Add(btnThoat);
            gpbThongTinNhanVien.Controls.Add(btnHuybo);
            gpbThongTinNhanVien.Controls.Add(btnLuu);
            gpbThongTinNhanVien.Controls.Add(btnXoa);
            gpbThongTinNhanVien.Controls.Add(btnSua);
            gpbThongTinNhanVien.Controls.Add(btnThem);
            gpbThongTinNhanVien.Controls.Add(txtHoVaTen);
            gpbThongTinNhanVien.Controls.Add(lblTenNV);
            gpbThongTinNhanVien.Location = new Point(6, 3);
            gpbThongTinNhanVien.Name = "gpbThongTinNhanVien";
            gpbThongTinNhanVien.Size = new Size(972, 156);
            gpbThongTinNhanVien.TabIndex = 4;
            gpbThongTinNhanVien.TabStop = false;
            gpbThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản Lí", "Nhân Viên" });
            cboQuyenHan.Location = new Point(471, 91);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(181, 28);
            cboQuyenHan.TabIndex = 18;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(471, 58);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(181, 27);
            txtMatKhau.TabIndex = 17;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(471, 24);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(181, 27);
            txtTenDangNhap.TabIndex = 16;
            // 
            // lblQuyenHan
            // 
            lblQuyenHan.AutoSize = true;
            lblQuyenHan.Location = new Point(346, 91);
            lblQuyenHan.Name = "lblQuyenHan";
            lblQuyenHan.Size = new Size(105, 20);
            lblQuyenHan.TabIndex = 15;
            lblQuyenHan.Text = "Quyền Hạn (*):";
            // 
            // lblMK
            // 
            lblMK.AutoSize = true;
            lblMK.Location = new Point(346, 61);
            lblMK.Name = "lblMK";
            lblMK.Size = new Size(95, 20);
            lblMK.TabIndex = 14;
            lblMK.Text = "Mật Khẩu (*):";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new Point(345, 27);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(130, 20);
            lblTenDangNhap.TabIndex = 13;
            lblTenDangNhap.Text = "Tên đăng nhập (*):";
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(686, 91);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(89, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 544);
            Controls.Add(gpbDanhSach);
            Controls.Add(gpbThongTinNhanVien);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân Viên";
            Load += frmNhanVien_Load;
            gpbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            gpbThongTinNhanVien.ResumeLayout(false);
            gpbThongTinNhanVien.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnXuat;
        private Button btnTimKiem;
        private Button btnNhap;
        private Label lblDiaChi;
        private Label lblSDT;
        private TextBox txtDiaChi;
        private TextBox txtDienThoai;
        private Button btnThoat;
        private GroupBox gpbDanhSach;
        private DataGridView dataGridView;
        private Button btnHuybo;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtHoVaTen;
        private Label lblTenNV;
        private GroupBox gpbThongTinNhanVien;
        private Button btnXoa;
        private Label lblQuyenHan;
        private Label lblMK;
        private Label lblTenDangNhap;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private ComboBox cboQuyenHan;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
    }
}