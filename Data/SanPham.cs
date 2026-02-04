using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
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

        // Đặc thù bàn phím
        public string LoaiSwitch { get; set; } // Red, Blue, Brown, Silent...
        public string Layout { get; set; }     // Fullsize, TKL, 65%, 75%
        public string KieuKetNoi { get; set; } // Có dây, Bluetooth, Wireless 2.4G

        public int DonGia { get; set; }
        public int SoLuongTon { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }

        public virtual ObservableCollectionListSource<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new();
        public virtual LoaiSanPham LoaiSanPham { get; set; } = null!;
        public virtual HangSanXuat HangSanXuat { get; set; } = null!;
    }
}
