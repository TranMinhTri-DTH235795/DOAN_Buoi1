using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.Data
{
    internal class LoaiSanPham
    {
        public int ID { get; set; }
        public string TenLoai { get; set; } // Ví dụ: Bàn phím cơ, Keycap, Phụ kiện
        public string? MoTa { get; set; } // Bổ sung mô tả loại
        public int ThuTuHienThi { get; set; } // Hỗ trợ tùy chỉnh giao diện

        public virtual ObservableCollectionListSource<SanPham> SanPham { get; } = new();
    }
}
