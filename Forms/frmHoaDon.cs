using QuanLyBanHang.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmHoaDon : Form
    {
        // Khởi tạo biến ngữ cảnh CSDL
        QLBHDbContext context = new QLBHDbContext();

        // Lấy mã hóa đơn (dùng cho Sửa và Xóa)
        int id;

        public frmHoaDon()
        {
            InitializeComponent();

            // Đăng ký các sự kiện (Events)
            this.Load += frmHoaDon_Load;
            this.btnLapHoaDon.Click += btnLapHoaDon_Click;
            this.btnSua.Click += btnSua_Click;
            this.btnXoa.Click += btnXoa_Click;
            this.btnThoat.Click += btnThoat_Click;
            this.dgvHoaDon.CellContentClick += dgvHoaDon_CellContentClick;
        }

        // Tải dữ liệu vào DataGridView
        private void LoadData()
        {
            try
            {
                dgvHoaDon.AutoGenerateColumns = false;

                // LẤY DỮ LIỆU VÀ FIX LỖI System.Int16
                var hd = context.HoaDon.Select(r => new
                {
                    ID = r.ID,
                    NhanVienID = r.NhanVienID,
                    // Lấy tên nhân viên và khách hàng từ Navigation Property
                    TenNhanVien = r.NhanVien.HoVaTen,
                    KhachHangID = r.KhachHangID,
                    TenKhachHang = r.KhachHang.HoVaTen,
                    NgayLap = r.NgayLap,

                    // FIX LỖI TẠI ĐÂY: Ép kiểu SoLuongBan (short) sang double để EF Core tính toán được Sum
                    TongTien = r.HoaDon_ChiTiet.Any()
                               ? r.HoaDon_ChiTiet.Sum(ct => (double)ct.SoLuongBan * ct.DonGiaBan)
                               : 0,

                    XemChiTiet = "Xem chi tiết"
                }).ToList();

                dgvHoaDon.DataSource = hd;
            }
            catch (Exception ex)
            {
                // InnerException thường chứa chi tiết lỗi thật sự nếu ex.Message quá chung chung
                string errorMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Lỗi khi tải dữ liệu: " + errorMsg, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
            }
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null)
            {
                if (int.TryParse(dgvHoaDon.CurrentRow.Cells["ID"].Value?.ToString(), out id))
                {
                    using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
                    {
                        chiTiet.ShowDialog();
                    }
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể lấy mã hóa đơn hợp lệ!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null)
            {
                if (int.TryParse(dgvHoaDon.CurrentRow.Cells["ID"].Value?.ToString(), out id))
                {
                    if (MessageBox.Show($"Bạn có chắc chắn muốn xóa hóa đơn có mã {id} không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            var hoaDonXoa = context.HoaDon.Find(id);
                            if (hoaDonXoa != null)
                            {
                                // Xóa chi tiết hóa đơn trước
                                var chiTietHD = context.HoaDon_ChiTiet.Where(ct => ct.HoaDonID == id).ToList();
                                if (chiTietHD.Any())
                                {
                                    context.HoaDon_ChiTiet.RemoveRange(chiTietHD);
                                }

                                context.HoaDon.Remove(hoaDonXoa);
                                context.SaveChanges();

                                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHoaDon.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                if (int.TryParse(dgvHoaDon.Rows[e.RowIndex].Cells["ID"].Value?.ToString(), out id))
                {
                    using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
                    {
                        chiTiet.ShowDialog();
                    }
                    LoadData();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}