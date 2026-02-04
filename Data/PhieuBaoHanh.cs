using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.Data
{
    internal class PhieuBaoHanh
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; } // Liên kết với hóa đơn đã mua
        public int SanPhamID { get; set; } // Sản phẩm cụ thể cần bảo hành
        public DateTime NgayNhan { get; set; }
        public string TinhTrangLoi { get; set; } // Ví dụ: Liệt phím, Hỏng led
        public string? CachXuLy { get; set; }    // Ví dụ: Thay switch mới, Hàn lại mạch
        public string TrangThai { get; set; }   // Đang sửa, Đã xong, Đã trả khách
        public DateTime? NgayTraDuKien { get; set; }

        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual SanPham SanPham { get; set; } = null!;
    }
}
