using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.Data
{
    internal class NhanVien
    {
        public int ID { get; set; }
        public string HoVaTen { get; set; }
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public DateTime? NgaySinh { get; set; }
        public bool LaQuanLy { get; set; } // true: Quản lý, false: Nhân viên bán hàng

        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
    }
}
