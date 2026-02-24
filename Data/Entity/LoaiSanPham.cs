using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyBanHang.Data.Entity
{
    public class LoaiSanPham
    {
        public int ID { get; set; }
        public string TenLoai { get; set; }
        public virtual ObservableCollectionListSource<SanPham> SanPham { get; } = new();
    }
}
