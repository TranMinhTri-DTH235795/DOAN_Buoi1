using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyCuaHang.Migrations
{
    /// <inheritdoc />
    public partial class UpdateStructureFeb2026 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MoTa",
                table: "LoaiSanPham",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ThuTuHienThi",
                table: "LoaiSanPham",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "QuocGia",
                table: "HangSanXuat",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ThongTinLienHe",
                table: "HangSanXuat",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MoTa",
                table: "LoaiSanPham");

            migrationBuilder.DropColumn(
                name: "ThuTuHienThi",
                table: "LoaiSanPham");

            migrationBuilder.DropColumn(
                name: "ThongTinLienHe",
                table: "HangSanXuat");

            migrationBuilder.AlterColumn<string>(
                name: "QuocGia",
                table: "HangSanXuat",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
