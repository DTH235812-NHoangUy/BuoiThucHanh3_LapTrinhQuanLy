using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Data;
using QuanLyBanHang.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyBanHang.Forms
{
    public partial class frmNhanVien : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        bool xuLyThem = false;
        int id;

        private readonly BindingSource bindingSource = new BindingSource();

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuybo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void LoadData(IEnumerable<NhanVien> items)
        {
            bindingSource.DataSource = items.ToList();

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", true, DataSourceUpdateMode.OnPropertyChanged);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", true, DataSourceUpdateMode.OnPropertyChanged);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", true, DataSourceUpdateMode.OnPropertyChanged);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", true, DataSourceUpdateMode.OnPropertyChanged);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("SelectedIndex", bindingSource, "QuyenHan", true, DataSourceUpdateMode.OnPropertyChanged);

            dataGridView.DataSource = bindingSource;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            cboQuyenHan.Items.Clear();
            cboQuyenHan.Items.Add("Quản lý");
            cboQuyenHan.Items.Add("Nhân viên");

            LoadData(context.NhanVien.ToList());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboQuyenHan.SelectedIndex = -1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);

            if (bindingSource.Current is NhanVien nv)
            {
                id = nv.ID;
                txtHoVaTen.Text = nv.HoVaTen;
                txtDienThoai.Text = nv.DienThoai;
                txtDiaChi.Text = nv.DiaChi;
                txtTenDangNhap.Text = nv.TenDangNhap;
                cboQuyenHan.SelectedIndex = nv.QuyenHan ? 0 : 1;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboQuyenHan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn quyền hạn cho nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xuLyThem)
            {
                if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                NhanVien nv = new NhanVien
                {
                    HoVaTen = txtHoVaTen.Text,
                    DienThoai = txtDienThoai.Text,
                    DiaChi = txtDiaChi.Text,
                    TenDangNhap = txtTenDangNhap.Text,
                    MatKhau = BC.HashPassword(txtMatKhau.Text),
                    QuyenHan = cboQuyenHan.SelectedIndex == 0
                };
                context.NhanVien.Add(nv);
            }
            else
            {
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    nv.HoVaTen = txtHoVaTen.Text;
                    nv.DienThoai = txtDienThoai.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.TenDangNhap = txtTenDangNhap.Text;
                    nv.QuyenHan = cboQuyenHan.SelectedIndex == 0;

                    if (!string.IsNullOrEmpty(txtMatKhau.Text))
                        nv.MatKhau = BC.HashPassword(txtMatKhau.Text);
                }
            }

            context.SaveChanges();
            frmNhanVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is NhanVien nv)
            {
                if (MessageBox.Show($"Xác nhận xóa nhân viên {nv.HoVaTen}?",
                                    "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        context.NhanVien.Remove(nv);
                        context.SaveChanges();

                        // Reset lại ID sau khi xóa
                        context.Database.ExecuteSqlRaw("DBCC CHECKIDENT ('NhanVien', RESEED, 0)");

                        MessageBox.Show("Xóa nhân viên thành công và đã reset lại ID!",
                                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmNhanVien_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnHuybo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string searchTerm = Microsoft.VisualBasic.Interaction.InputBox("Nhập từ khóa tìm kiếm (họ tên, điện thoại, địa chỉ):", "Tìm kiếm nhân viên", "");

            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadData(context.NhanVien.ToList());
                BatTatChucNang(false);
                return;
            }

            string lower = searchTerm.ToLower();

            var results = context.NhanVien
                .Where(k =>
                    (k.HoVaTen ?? "").ToLower().Contains(lower) ||
                    (k.DienThoai ?? "").ToLower().Contains(lower) ||
                    (k.DiaChi ?? "").ToLower().Contains(lower))
                .ToList();

            if (results.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(context.NhanVien.ToList());
            }
            else
            {
                LoadData(results);
            }

            BatTatChucNang(false);
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "Chọn file CSV chứa danh sách nhân viên",
                Multiselect = false
            };

            if (ofd.ShowDialog() != DialogResult.OK) return;

            string path = ofd.FileName;
            List<string> lines;
            try
            {
                lines = File.ReadAllLines(path, Encoding.UTF8).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể đọc file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lines.Count == 0) return;

            static List<string> ParseCsvLine(string line)
            {
                var result = new List<string>();
                var cur = new StringBuilder();
                bool inQuotes = false;

                for (int i = 0; i < line.Length; i++)
                {
                    char c = line[i];
                    if (inQuotes)
                    {
                        if (c == '"')
                        {
                            // Handle escaped double quote "" -> "
                            if (i + 1 < line.Length && line[i + 1] == '"')
                            {
                                cur.Append('"');
                                i++; // skip the escaped quote
                            }
                            else
                            {
                                // end of quoted section
                                inQuotes = false;
                            }
                        }
                        else
                        {
                            cur.Append(c);
                        }
                    }
                    else
                    {
                        if (c == '"')
                        {
                            inQuotes = true;
                        }
                        else if (c == ',')
                        {
                            // field separator
                            result.Add(cur.ToString());
                            cur.Clear();
                        }
                        else
                        {
                            cur.Append(c);
                        }
                    }
                }

                // add last field
                result.Add(cur.ToString());
                return result;
            }

            var headerFields = ParseCsvLine(lines[0]);
            bool hasHeader = headerFields.Any(h => h.Trim().ToLower().Contains("ten") || h.Trim().ToLower().Contains("ho"));
            int startLine = hasHeader ? 1 : 0;

            int added = 0, skipped = 0;
            string defaultPassword = BC.HashPassword("123456");

            for (int i = startLine; i < lines.Count; i++)
            {
                var fields = ParseCsvLine(lines[i]);
                if (fields.Count < 1) { skipped++; continue; }

                string ten = "", sdt = "", diachi = "";

                if (hasHeader)
                {
                    for (int c = 0; c < headerFields.Count && c < fields.Count; c++)
                    {
                        string col = headerFields[c].Trim().ToLower();
                        string val = fields[c].Trim();
                        if (col.Contains("ten") || col.Contains("ho")) ten = val;
                        else if (col.Contains("sdt") || col.Contains("dien")) sdt = val;
                        else if (col.Contains("diachi") || col.Contains("dia chi")) diachi = val;
                    }
                }
                else
                {
                    ten = fields[0].Trim();
                    sdt = fields.Count > 1 ? fields[1].Trim() : "";
                    diachi = fields.Count > 2 ? fields[2].Trim() : "";
                }

                if (string.IsNullOrWhiteSpace(ten)) { skipped++; continue; }

                try
                {
                    NhanVien nv = new NhanVien
                    {
                        HoVaTen = ten,
                        DienThoai = sdt,
                        DiaChi = diachi,
                        TenDangNhap = !string.IsNullOrEmpty(sdt) ? sdt : "nv_" + Guid.NewGuid().ToString().Substring(0, 5),
                        MatKhau = defaultPassword,
                        QuyenHan = false
                    };
                    context.NhanVien.Add(nv);
                    added++;
                }
                catch { skipped++; }
            }

            try
            {
                context.SaveChanges();
                LoadData(context.NhanVien.ToList());
                MessageBox.Show($"Thành công! Đã thêm: {added}, Bỏ qua: {skipped}.\nTên đăng nhập mặc định là SĐT, mật khẩu là '123456'.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.InnerException?.Message ?? ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = "DanhSachNhanVien.csv",
                Title = "Chọn nơi lưu file CSV"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("ID,HoVaTen,DienThoai,DiaChi,TenDangNhap,QuyenHan");

                var danhSach = (List<NhanVien>)bindingSource.DataSource;

                foreach (var nv in danhSach)
                {
                    string hoTen = $"\"{nv.HoVaTen}\"";
                    string dienThoai = $"\"{nv.DienThoai}\"";
                    string diaChi = $"\"{nv.DiaChi}\"";
                    string tenDN = $"\"{nv.TenDangNhap}\"";
                    string quyen = nv.QuyenHan ? "Quản lý" : "Nhân viên";

                    sb.AppendLine($"{nv.ID},{hoTen},{dienThoai},{diaChi},{tenDN},{quyen}");
                }

                File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
