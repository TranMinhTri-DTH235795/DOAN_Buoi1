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
    public partial class frmKhachHang : Form
    {
        QLCHDbContext context = new QLCHDbContext();
        bool xuLyThem = false; // Biến cờ để phân biệt giữa Thêm mới và Cập nhật
        int id;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtEmail.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtDiemTichLuy.Enabled = giaTri;

            btnTimKiem.Enabled = !giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtDiemTichLuy.Text = "0"; // Mặc định điểm tích lũy mới là 0

            txtHoVaTen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu từ giao diện và cắt bỏ khoảng trắng thừa
            string hoTen = txtHoVaTen.Text.Trim();
            string dienThoai = txtDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            // ================= CÁC RÀNG BUỘC DỮ LIỆU =================

            // Ràng buộc: Họ và tên (Bắt buộc nhập)
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoVaTen.Focus();
                return;
            }

            // Ràng buộc: Điện thoại (Bắt buộc nhập + Phải là số + Độ dài khoảng 10 số)
            if (string.IsNullOrEmpty(dienThoai))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return;
            }
            // Lệnh .All(char.IsDigit) giúp kiểm tra chuỗi có chứa toàn là chữ số hay không
            if (!dienThoai.All(char.IsDigit) || dienThoai.Length < 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ (phải là các chữ số và từ 10 số trở lên)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return;
            }

            // Ràng buộc: Email (Bắt buộc nhập + Phải đúng định dạng cơ bản)
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập Email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Email không đúng định dạng (phải chứa ký tự '@' và '.')!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            bool trungSdt = context.KhachHang.Any(kh => kh.DienThoai == dienThoai && (xuLyThem || kh.ID != id));
            bool trungEmail = context.KhachHang.Any(kh => kh.Email == email && (xuLyThem || kh.ID != id));

            if (trungSdt)
            {
                MessageBox.Show("Số điện thoại này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienThoai.Focus();
                return;
            }

            if (trungEmail)
            {
                MessageBox.Show("Email này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            // Ràng buộc: Địa chỉ 
            if (string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }

            // ================= XỬ LÝ ĐIỂM TÍCH LŨY VÀ LƯU DATABASE =================
            int diemTichLuy = 0;
            int.TryParse(txtDiemTichLuy.Text.Trim(), out diemTichLuy);

            if (xuLyThem) // TRƯỜNG HỢP THÊM MỚI
            {
                KhachHang kh = new KhachHang();
                kh.HoVaTen = hoTen;
                kh.DienThoai = dienThoai; // Đã bắt buộc nhập ở trên nên không cần kiểm tra null nữa
                kh.Email = email;
                kh.DiaChi = diaChi;
                kh.DiemTichLuy = diemTichLuy;

                context.KhachHang.Add(kh);
            }
            else // TRƯỜNG HỢP CẬP NHẬT (SỬA)
            {
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    kh.HoVaTen = hoTen;
                    kh.DienThoai = dienThoai;
                    kh.Email = email;
                    kh.DiaChi = diaChi;
                    kh.DiemTichLuy = diemTichLuy;

                    context.KhachHang.Update(kh);
                }
            }

            // Lưu thay đổi và làm mới giao diện
            context.SaveChanges();
            MessageBox.Show("Lưu thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frmKhachHang_Load(sender, e);
            BatTatChucNang(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["STT"].Value);
            txtHoVaTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Lấy ID từ dòng đang chọn
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["STT"].Value.ToString());

                // Tìm và xóa trong Database
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                    context.SaveChanges();
                    MessageBox.Show("Đã xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Tải lại lưới dữ liệu sau khi xóa
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<KhachHang> list = new List<KhachHang>();
            list = context.KhachHang.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = list;
            // xóa tất cả các binding cũ trước khi tạo mới để tránh lỗi hiển thị
            txtHoVaTen.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtDiemTichLuy.DataBindings.Clear();

            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
            txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            txtDiemTichLuy.DataBindings.Add("Text", bindingSource, "DiemTichLuy", false, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
        }
    }

}
