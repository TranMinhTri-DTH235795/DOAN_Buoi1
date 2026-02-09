using QuanLyCuaHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang.Forms
{
    public partial class frmHoaDon : Form
    {
        QLCHDbContext db = new QLCHDbContext();
        int id;
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadDanhSachHoaDon();
        }

        private void LoadDanhSachHoaDon()
        {
            dataGridView.AutoGenerateColumns = false;

            List<DanhSachHoaDon> list = new List<DanhSachHoaDon>();
            list = db.HoaDon.Select(hd => new DanhSachHoaDon
            {
                ID = hd.ID,
                NhanVienID = hd.NhanVienID,
                HoVaTenNhanVien = hd.NhanVien.HoVaTen,
                KhachHangID = hd.KhachHangID,
                HoVaTenKhachHang = hd.KhachHang.HoVaTen,
                NgayLap = hd.NgayLap,
                PhuongThucThanhToan = hd.PhuongThucThanhToan,
                TongTienHoaDon = hd.HoaDon_ChiTiet.Sum(ct => (long)(int)ct.SoLuongBan * (int)ct.DonGiaBan),
                XemChiTiet = "Xem chi tiết"
            }).ToList();

            dataGridView.DataSource = list;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet frm = new frmHoaDon_ChiTiet())
            {
                frm.ShowDialog();
            }
            LoadDanhSachHoaDon();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["STT"].Value);

            using (frmHoaDon_ChiTiet frm = new frmHoaDon_ChiTiet(id))
            {
                frm.ShowDialog();
            }
            // Load lại sau khi đóng form
            LoadDanhSachHoaDon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["STT"].Value);
            string tenKH = dataGridView.CurrentRow.Cells["HoVaTenKhachHang"].Value.ToString();

            if (MessageBox.Show($"Xác nhận xóa hóa đơn của khách hàng {tenKH}?", "Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Xóa chi tiết trước, sau đó xóa hóa đơn
                var chiTiet = db.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).ToList();
                db.HoaDon_ChiTiet.RemoveRange(chiTiet);

                HoaDon hd = db.HoaDon.Find(id);
                if (hd != null)
                    db.HoaDon.Remove(hd);

                db.SaveChanges();
                LoadDanhSachHoaDon();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra đúng cột "Chi tiết" và không phải header
            if (e.RowIndex < 0) return;
            if (dataGridView.Columns[e.ColumnIndex].Name != "XemChiTiet") return;

            id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["STT"].Value);

            using (frmHoaDon_ChiTiet frm = new frmHoaDon_ChiTiet(id))
            {
                frm.ShowDialog();
            }

            // Load lại sau khi đóng
            LoadDanhSachHoaDon();
        }
    }
}
