using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHang.Data
{
    internal class Switch
    {
        public int ID { get; set; }
        public string TenSwitch { get; set; } // Ví dụ: Cherry MX Red, Akko CS Jelly Pink
        public string HangSanXuat { get; set; } // Ví dụ: Cherry, Gateron, Kailh
        public string? DacTinh { get; set; } // Clicky, Linear, Tactile

        public virtual ObservableCollectionListSource<SanPham> SanPham { get; } = new();
    }
}
