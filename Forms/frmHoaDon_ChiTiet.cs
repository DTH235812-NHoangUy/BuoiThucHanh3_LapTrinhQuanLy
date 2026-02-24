using QuanLyBanHang.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmHoaDon_ChiTiet : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        int id; // ID hóa đơn
        BindingList<DanhSachHoaDon_ChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>();

        public frmHoaDon_ChiTiet(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }

        #region Các hàm lấy dữ liệu
        public void LayNhanVienVaoComboBox()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
            cboNhanVien.SelectedIndex = -1; // Không chọn mặc định
        }

        public void LayKhachHangVaoComboBox()
        {
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoVaTen";
            cboKhachHang.SelectedIndex = -1;
        }

        public void LaySanPhamVaoComboBox()
        {
            cboSanPham.DataSource = context.SanPham.ToList();
            cboSanPham.ValueMember = "ID";
            cboSanPham.DisplayMember = "TenSanPham";
            cboSanPham.SelectedIndex = -1;
        }
        #endregion

        private void BatTatChucNang()
        {
            // Nút lưu và in chỉ sáng khi có ít nhất 1 mặt hàng trong lưới
            bool coDuLieu = dgvHoaDonChiTiet.Rows.Count > 0;
            btnLuuHoaDon.Enabled = coDuLieu;
            btnInHoaDon.Enabled = (id != 0 && coDuLieu); // Chỉ cho in nếu hóa đơn đã được lưu vào DB
            btnXoa.Enabled = coDuLieu;
        }

        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            LayNhanVienVaoComboBox();
            LayKhachHangVaoComboBox();
            LaySanPhamVaoComboBox();
            dgvHoaDonChiTiet.AutoGenerateColumns = false;

            if (id != 0) // Chế độ Sửa
            {
                this.Text = "Chỉnh sửa hóa đơn mã: " + id;
                var hoaDon = context.HoaDon.FirstOrDefault(r => r.ID == id);
                if (hoaDon != null)
                {
                    cboNhanVien.SelectedValue = hoaDon.NhanVienID;
                    cboKhachHang.SelectedValue = hoaDon.KhachHangID;
                    txtGhiChuHoaDon.Text = hoaDon.GhiChuHoaDon;
                }

                var ct = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).Select(r => new DanhSachHoaDon_ChiTiet
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    SanPhamID = r.SanPhamID,
                    TenSanPham = r.SanPham.TenSanPham,
                    SoLuongBan = r.SoLuongBan,
                    DonGiaBan = r.DonGiaBan,
                    ThanhTien = Convert.ToInt32(r.SoLuongBan * r.DonGiaBan)
                }).ToList();
                hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(ct);
            }
            else
            {
                this.Text = "Tạo mới hóa đơn";
            }

            dgvHoaDonChiTiet.DataSource = hoaDonChiTiet;
            BatTatChucNang();
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maSanPham = (int)cboSanPham.SelectedValue;
            var itemTonTai = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);

            if (itemTonTai != null)
            {
                itemTonTai.SoLuongBan = (short)numSoLuongBan.Value;
                itemTonTai.DonGiaBan = (int)numDonGiaBan.Value;
                itemTonTai.ThanhTien = (int)(numSoLuongBan.Value * numDonGiaBan.Value);
                dgvHoaDonChiTiet.Refresh();
            }
            else
            {
                hoaDonChiTiet.Add(new DanhSachHoaDon_ChiTiet
                {
                    SanPhamID = maSanPham,
                    TenSanPham = cboSanPham.Text,
                    SoLuongBan = (short)numSoLuongBan.Value,
                    DonGiaBan = (int)numDonGiaBan.Value,
                    ThanhTien = (int)(numSoLuongBan.Value * numDonGiaBan.Value)
                });
            }
            BatTatChucNang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonChiTiet.CurrentRow != null)
            {
                var item = (DanhSachHoaDon_ChiTiet)dgvHoaDonChiTiet.CurrentRow.DataBoundItem;
                hoaDonChiTiet.Remove(item);
                BatTatChucNang();
            }
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null || cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên và khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                HoaDon hd;
                if (id == 0) // Thêm mới
                {
                    hd = new HoaDon();
                    hd.NgayLap = DateTime.Now;
                    context.HoaDon.Add(hd);
                }
                else // Cập nhật
                {
                    hd = context.HoaDon.Find(id);
                    // Xóa chi tiết cũ để ghi đè lại
                    var details = context.HoaDon_ChiTiet.Where(x => x.HoaDonID == id);
                    context.HoaDon_ChiTiet.RemoveRange(details);
                }

                hd.NhanVienID = (int)cboNhanVien.SelectedValue;
                hd.KhachHangID = (int)cboKhachHang.SelectedValue;
                hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;

                context.SaveChanges(); // Lưu để lấy ID nếu là thêm mới

                // Thêm chi tiết mới
                foreach (var item in hoaDonChiTiet)
                {
                    context.HoaDon_ChiTiet.Add(new HoaDon_ChiTiet
                    {
                        HoaDonID = hd.ID,
                        SanPhamID = item.SanPhamID,
                        SoLuongBan = item.SoLuongBan,
                        DonGiaBan = item.DonGiaBan
                    });
                }
                context.SaveChanges();
                id = hd.ID; // Cập nhật lại id form sau khi lưu thành công

                MessageBox.Show("Lưu hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BatTatChucNang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Vui lòng lưu hóa đơn trước khi in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show("Chức năng in đang được chuẩn bị. (Mã HD: " + id + ")", "In ấn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Tại đây bạn có thể gọi Form Report hoặc xuất file Excel/PDF
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonChiTiet.Rows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Dữ liệu chưa được lưu (nếu có thay đổi). Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No) return;
            }
            this.Close();
        }

        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue != null)
            {
                int maSP = (int)cboSanPham.SelectedValue;
                var sp = context.SanPham.Find(maSP);
                if (sp != null)
                {
                    numDonGiaBan.Value = sp.DonGia;
                    numSoLuongBan.Value = 1;
                }
            }
        }
    }
}