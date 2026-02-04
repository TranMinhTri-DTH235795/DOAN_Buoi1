using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLyCuaHang.Data
{
    internal class QLCHDbContext : DbContext
    {
        public DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public DbSet<HangSanXuat> HangSanXuat { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; }

        // 3 bảng mới bổ sung cho đúng yêu cầu 10 bảng
        public DbSet<Switch> Switch { get; set; }
        public DbSet<PhieuNhap> PhieuNhap { get; set; }
        public DbSet<PhieuBaoHanh> PhieuBaoHanh { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Đảm bảo chuỗi kết nối "QLBHConnection" đã được khai báo trong App.config hoặc Web.config
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLCHConnection"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Cấu hình khóa chính phức hợp cho bảng Chi Tiết Hóa Đơn (nếu cần)
            modelBuilder.Entity<HoaDon_ChiTiet>()
                .HasKey(c => new { c.HoaDonID, c.SanPhamID });

            base.OnModelCreating(modelBuilder);
        }
    }
}
