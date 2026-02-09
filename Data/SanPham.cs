using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.Data
{
    internal class SanPham
    {
        public int ID { get; set; }
        public int HangSanXuatID { get; set; }
        public int LoaiSanPhamID { get; set; }
        public string TenSanPham { get; set; }

        public int DonGia { get; set; }
        public int SoLuongTon { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }

        public virtual ObservableCollectionListSource<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new();
        public virtual LoaiSanPham LoaiSanPham { get; set; } = null!;
        public virtual HangSanXuat HangSanXuat { get; set; } = null!;

    }
     [NotMapped] // Đánh dấu để Entity Framework không tạo bảng này trong DB
    public class DanhSachSanPham
    {
        public int ID { get; set; }

        // Thông tin Sản phẩm
        public string TenSanPham { get; set; }
        public int DonGia { get; set; }
        public int SoLuongTon { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }

        // Thông tin từ bảng Hãng Sản Xuất
        public int HangSanXuatID { get; set; }
        public string TenHangSanXuat { get; set; } // Hiển thị tên thay vì ID

        // Thông tin từ bảng Loại Sản Phẩm
        public int LoaiSanPhamID { get; set; }
        public string TenLoai { get; set; } // Hiển thị tên loại
    }
}
