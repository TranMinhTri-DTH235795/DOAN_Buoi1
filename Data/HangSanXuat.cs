using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.Data
{
    internal class HangSanXuat
    {
        public int ID { get; set; }
        public string TenHang { get; set; }
        public string? QuocGia { get; set; } // Thêm để phân biệt hàng nội địa/nhập khẩu
        public string? ThongTinLienHe { get; set; }

        public virtual ObservableCollectionListSource<SanPham> SanPham { get; } = new();
    }
}
