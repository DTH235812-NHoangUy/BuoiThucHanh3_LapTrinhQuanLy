using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class frmLoaiSanPham : Form
    {
        QLBHDbContext context = new QLBHDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lấy mã loại sản phẩm (dùng cho Sửa và Xóa)

        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenLoai.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<LoaiSanPham> lsp = context.LoaiSanPham.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lsp;

            txtTenLoai.DataBindings.Clear();
            txtTenLoai.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);
            dgvLoaiSanPham.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Đã sửa lỗi: Bật tính năng để nhập liệu
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenLoai.DataBindings.Clear(); // Xóa ràng buộc dữ liệu cũ để nhập mới
            txtTenLoai.Text = ""; // Làm rỗng Textbox
            txtTenLoai.Focus(); // Đưa con trỏ chuột vào Textbox
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            if (dgvLoaiSanPham.CurrentRow != null)
            {
                id = Convert.ToInt32(dgvLoaiSanPham.CurrentRow.Cells["ID"].Value.ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (xuLyThem)
                {
                    LoaiSanPham lsp = new LoaiSanPham();
                    lsp.TenLoai = txtTenLoai.Text;
                    context.LoaiSanPham.Add(lsp);
                    context.SaveChanges();
                }
                else
                {
                    LoaiSanPham lsp = context.LoaiSanPham.Find(id);
                    if (lsp != null)
                    {
                        lsp.TenLoai = txtTenLoai.Text;
                        context.LoaiSanPham.Update(lsp);
                        context.SaveChanges();
                    }
                }
                // Sau khi lưu xong thì load lại dữ liệu
                frmLoaiSanPham_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại sản phẩm?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvLoaiSanPham.CurrentRow != null)
                {
                    id = Convert.ToInt32(dgvLoaiSanPham.CurrentRow.Cells["ID"].Value.ToString());
                    LoaiSanPham lsp = context.LoaiSanPham.Find(id);
                    if (lsp != null)
                    {
                        context.LoaiSanPham.Remove(lsp);
                        context.SaveChanges();
                    }
                    frmLoaiSanPham_Load(sender, e);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // Đổi thành this.Close() để đóng form hiện tại thay vì tắt toàn bộ ứng dụng (Application.Exit)
        }
    }
}