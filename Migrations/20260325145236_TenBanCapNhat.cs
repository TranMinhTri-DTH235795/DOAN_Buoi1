using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyCuaHang.Migrations
{
    /// <inheritdoc />
    public partial class TenBanCapNhat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KieuKetNoi",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "Layout",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "LoaiSwitch",
                table: "SanPham");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KieuKetNoi",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Layout",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LoaiSwitch",
                table: "SanPham",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
