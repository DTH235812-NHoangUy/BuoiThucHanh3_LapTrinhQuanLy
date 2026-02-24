namespace QuanLyBanHang.Forms // Đảm bảo namespace trùng với project của bạn
{
    partial class frmHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle cellStyleNgayLap = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyleTongTien = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyleChiTiet = new System.Windows.Forms.DataGridViewCellStyle();

            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHangID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XemChiTiet = new System.Windows.Forms.DataGridViewLinkColumn();

            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnLapHoaDon = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NhanVienID,
            this.KhachHangID,
            this.NgayLap,
            this.TongTien,
            this.XemChiTiet});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(950, 390);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NhanVienID
            // 
            this.NhanVienID.DataPropertyName = "NhanVienID";
            this.NhanVienID.HeaderText = "Mã nhân viên";
            this.NhanVienID.Name = "NhanVienID";
            // 
            // KhachHangID
            // 
            this.KhachHangID.DataPropertyName = "KhachHangID";
            this.KhachHangID.HeaderText = "Mã khách hàng";
            this.KhachHangID.Name = "KhachHangID";
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            cellStyleNgayLap.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            cellStyleNgayLap.Format = "dd/MM/yyyy";
            this.NgayLap.DefaultCellStyle = cellStyleNgayLap;
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            cellStyleTongTien.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            cellStyleTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cellStyleTongTien.ForeColor = System.Drawing.Color.Blue;
            cellStyleTongTien.Format = "N0";
            this.TongTien.DefaultCellStyle = cellStyleTongTien;
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // XemChiTiet
            // 
            this.XemChiTiet.DataPropertyName = "XemChiTiet";
            cellStyleChiTiet.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.XemChiTiet.DefaultCellStyle = cellStyleChiTiet;
            this.XemChiTiet.HeaderText = "Chi tiết";
            this.XemChiTiet.Name = "XemChiTiet";
            this.XemChiTiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.XemChiTiet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnXuat);
            this.panelBottom.Controls.Add(this.btnTimKiem);
            this.panelBottom.Controls.Add(this.btnThoat);
            this.panelBottom.Controls.Add(this.btnXoa);
            this.panelBottom.Controls.Add(this.btnSua);
            this.panelBottom.Controls.Add(this.btnInHoaDon);
            this.panelBottom.Controls.Add(this.btnLapHoaDon);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 390);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(950, 60);
            this.panelBottom.TabIndex = 1;
            // 
            // btnXuat
            // 
            this.btnXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXuat.Location = new System.Drawing.Point(768, 15);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(90, 30);
            this.btnXuat.TabIndex = 6;
            this.btnXuat.Text = "Xuất Excel...";
            this.btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Location = new System.Drawing.Point(672, 15);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 30);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm...";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Location = new System.Drawing.Point(586, 15);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 30);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Location = new System.Drawing.Point(500, 15);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Location = new System.Drawing.Point(414, 15);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 30);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa...";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInHoaDon.Location = new System.Drawing.Point(318, 15);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(90, 30);
            this.btnInHoaDon.TabIndex = 1;
            this.btnInHoaDon.Text = "In hóa đơn...";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLapHoaDon.Location = new System.Drawing.Point(192, 15);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(120, 30);
            this.btnLapHoaDon.TabIndex = 0;
            this.btnLapHoaDon.Text = "Lập hóa đơn mới...";
            this.btnLapHoaDon.UseVisualStyleBackColor = true;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.panelBottom);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";

            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnLapHoaDon;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXuat;

        // Khai báo các cột
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHangID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewLinkColumn XemChiTiet;
    }
}