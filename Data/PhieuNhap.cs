using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.Data
{
    internal class PhieuNhap
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public DateTime NgayNhap { get; set; }
        public string? NhaCungCap { get; set; } // Tên đơn vị cung cấp hàng
        public long TongTienNhap { get; set; }
        public string? GhiChu { get; set; }

        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
