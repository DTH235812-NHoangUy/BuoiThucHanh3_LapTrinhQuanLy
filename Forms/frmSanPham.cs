using QuanLyBanHang.Data.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmSanPham : Form
    {
        QLBHDbContext context = new QLBHDbContext();    // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false;                          // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id;                                         // Lấy mã sản phẩm (dùng cho Sửa và Xóa) 

        // Tạo đường dẫn động đến thư mục Images nằm cùng cấp với file .exe
        string imagesFolder = Path.Combine(Application.StartupPath, "Images");

        public frmSanPham()
        {
            InitializeComponent();

            // Tự động tạo thư mục Images nếu chưa tồn tại trên máy
            if (!Directory.Exists(imagesFolder))
            {
                Directory.CreateDirectory(imagesFolder);
            }
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboHangSanXuat.Enabled = giaTri;
            cboLoaiSanPham.Enabled = giaTri;
            txtTenSanPham.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;

            // ĐÃ FIX: Cho phép nút Đổi ảnh sáng lên khi Thêm/Sửa
            btnDoiAnh.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        public void LayLoaiSanPhamVaoComboBox()
        {
            cboLoaiSanPham.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSanPham.ValueMember = "ID";
            cboLoaiSanPham.DisplayMember = "TenLoai";
        }

        public void LayHangSanXuatVaoComboBox()
        {
            cboHangSanXuat.DataSource = context.HangSanXuat.ToList();
            cboHangSanXuat.ValueMember = "ID";
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayLoaiSanPhamVaoComboBox();
            LayHangSanXuatVaoComboBox();

            dgvSanPham.AutoGenerateColumns = false;

            // Lấy dữ liệu dạng đối tượng vô danh (anonymous) để Binding
            var sp = context.SanPham.Select(r => new
            {
                ID = r.ID,
                LoaiSanPhamID = r.LoaiSanPhamID,
                TenLoai = r.LoaiSanPham.TenLoai,
                HangSanXuatID = r.HangSanXuatID,
                TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                TenSanPham = r.TenSanPham,
                SoLuong = r.SoLuong,
                DonGia = r.DonGia,
                HinhAnh = r.HinhAnh,
                MoTa = r.MoTa
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sp;

            // Binding ComboBox
            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add("SelectedValue", bindingSource, "LoaiSanPhamID", true, DataSourceUpdateMode.Never);

            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add("SelectedValue", bindingSource, "HangSanXuatID", true, DataSourceUpdateMode.Never);

            // Binding Textbox, NumericUpDown
            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", true, DataSourceUpdateMode.Never);

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", true, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", true, DataSourceUpdateMode.Never);

            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", true, DataSourceUpdateMode.Never);

            // Binding Hình Ảnh
            picHinhAnh.DataBindings.Clear();
            Binding hinhAnhBinding = new Binding("ImageLocation", bindingSource, "HinhAnh", true);
            hinhAnhBinding.Format += (s, ev) =>
            {
                if (ev.Value != null && !string.IsNullOrWhiteSpace(ev.Value.ToString()))
                {
                    string fullPath = Path.Combine(imagesFolder, ev.Value.ToString());
                    ev.Value = fullPath;
                }
                else
                {
                    ev.Value = null;
                }
            };
            picHinhAnh.DataBindings.Add(hinhAnhBinding);

            dgvSanPham.DataSource = bindingSource;
        }

        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colHinhAnh" || dgvSanPham.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                if (e.Value != null && !string.IsNullOrWhiteSpace(e.Value.ToString()))
                {
                    string fullPath = Path.Combine(imagesFolder, e.Value.ToString());
                    if (File.Exists(fullPath))
                    {
                        using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                        {
                            Image img = Image.FromStream(fs);
                            e.Value = new Bitmap(img, 40, 40);
                        }
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true); // Gọi hàm này sẽ kích hoạt nút Đổi Ảnh
            cboLoaiSanPham.SelectedIndex = -1;
            cboHangSanXuat.SelectedIndex = -1;
            txtTenSanPham.Clear();
            txtMoTa.Clear();
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
            picHinhAnh.ImageLocation = null;
            picHinhAnh.Image = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["colID"].Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboLoaiSanPham.SelectedValue == null)
                MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cboHangSanXuat.SelectedValue == null)
                MessageBox.Show("Vui lòng chọn hãng sản xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numSoLuong.Value <= 0)
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGia.Value <= 0)
                MessageBox.Show("Đơn giá sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLyThem)
                {
                    SanPham sp = new SanPham
                    {
                        LoaiSanPhamID = Convert.ToInt32(cboLoaiSanPham.SelectedValue),
                        HangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue),
                        TenSanPham = txtTenSanPham.Text,
                        MoTa = txtMoTa.Text,
                        SoLuong = (int)numSoLuong.Value,
                        DonGia = (int)numDonGia.Value,
                        // Lấy tên ảnh đã được copy vào thư mục Images để lưu vào DB
                        HinhAnh = !string.IsNullOrWhiteSpace(picHinhAnh.ImageLocation) ? Path.GetFileName(picHinhAnh.ImageLocation) : null
                    };

                    context.SanPham.Add(sp);
                }
                else
                {
                    SanPham sp = context.SanPham.Find(id);
                    if (sp != null)
                    {
                        sp.LoaiSanPhamID = Convert.ToInt32(cboLoaiSanPham.SelectedValue);
                        sp.HangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue);
                        sp.TenSanPham = txtTenSanPham.Text;
                        sp.MoTa = txtMoTa.Text;
                        sp.SoLuong = (int)numSoLuong.Value;
                        sp.DonGia = (int)numDonGia.Value;

                        if (!string.IsNullOrWhiteSpace(picHinhAnh.ImageLocation))
                        {
                            sp.HinhAnh = Path.GetFileName(picHinhAnh.ImageLocation);
                        }

                        context.SanPham.Update(sp);
                    }
                }

                context.SaveChanges();
                frmSanPham_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;

            if (MessageBox.Show("Xác nhận xóa sản phẩm " + txtTenSanPham.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["colID"].Value);
                SanPham sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    context.SanPham.Remove(sp);
                    context.SaveChanges();
                }

                frmSanPham_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }

        private string GenerateSlug(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return "";
            input = input.ToLower();
            input = Regex.Replace(input, @"\s+", "-");
            input = Regex.Replace(input, @"[^a-z0-9\-]", "");
            input = Regex.Replace(input, @"-+", "-");
            return input.Trim('-');
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
                openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                    string ext = Path.GetExtension(openFileDialog.FileName);

                    string newFileName = GenerateSlug(fileName) + ext;
                    string fileSavePath = Path.Combine(imagesFolder, newFileName);

                    if (openFileDialog.FileName != fileSavePath)
                    {
                        File.Copy(openFileDialog.FileName, fileSavePath, true);
                    }

                    // Cập nhật đường dẫn cho PictureBox. 
                    // Khi bấm Lưu, code sẽ tự động lấy tên file từ đường dẫn này.
                    picHinhAnh.ImageLocation = fileSavePath;

                    // Nếu đang Sửa thì cập nhật ngay vào cơ sở dữ liệu
                    if (!xuLyThem && dgvSanPham.CurrentRow != null)
                    {
                        id = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["colID"].Value);
                        SanPham sp = context.SanPham.Find(id);

                        if (sp != null)
                        {
                            sp.HinhAnh = newFileName;
                            context.SanPham.Update(sp);
                            context.SaveChanges();
                        }
                        // Reload lại grid để load ảnh mới lên bảng
                        frmSanPham_Load(sender, e);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}