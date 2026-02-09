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
using BC = BCrypt.Net.BCrypt;
namespace QuanLyCuaHang.Forms
{
    public partial class frmNhanVien : Form
    {
        QLCHDbContext context = new QLCHDbContext(); // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;
            dateTimePicker.Enabled = giaTri;
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
            btnThoat.Enabled = true;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            context = new QLCHDbContext();

            List<NhanVien> list = context.NhanVien.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = list;

            txtHoVaTen.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtMatKhau.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Clear();
            cboQuyenHan.DataBindings.Clear();
            dateTimePicker.DataBindings.Clear();

            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);
            cboQuyenHan.DataBindings.Add("SelectedIndex", bindingSource, "LaQuanLy", true, DataSourceUpdateMode.Never);
            dateTimePicker.DataBindings.Add("Value", bindingSource, "NgaySinh", true, DataSourceUpdateMode.Never);
            dataGridView.DataSource = bindingSource;
            if (dataGridView.Columns["MatKhau"] != null)
            {
                dataGridView.Columns["MatKhau"].Visible = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            // Làm sạch các ô nhập liệu
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            dateTimePicker.Value = DateTime.Now;
            if (cboQuyenHan.Items.Count > 0)
                cboQuyenHan.SelectedIndex = 1; // Mặc định là nhân viên thường

            txtHoVaTen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu và loại bỏ khoảng trắng
            string hoTen = txtHoVaTen.Text.Trim();
            string dienThoai = txtDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            bool laQuanLy = cboQuyenHan.SelectedIndex == 0;

            // ================= CÁC RÀNG BUỘC DỮ LIỆU =================
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoVaTen.Focus(); return;
            }

            if (string.IsNullOrEmpty(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus(); return;
            }

            // Mật khẩu bắt buộc khi Thêm Mới
            if (xuLyThem && string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cho nhân viên mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus(); return;
            }

            // Kiểm tra trùng lặp Tên đăng nhập
            bool trungTenDN = context.NhanVien.Any(nv => nv.TenDangNhap == tenDangNhap && (xuLyThem || nv.ID != id));
            bool trungSdt = context.NhanVien.Any(nv => nv.DienThoai == dienThoai && (xuLyThem || nv.ID != id));
            if (trungTenDN)
            {
                MessageBox.Show("Tên đăng nhập này đã tồn tại, vui lòng chọn tên khác!", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus(); return;
            }

            if (trungSdt)
            {
                MessageBox.Show("Số điện thoại này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDienThoai.Focus();
                return;
            }
            // ================= LƯU DATABASE =================
            try
            {
                if (xuLyThem) // THÊM MỚI
                {
                    NhanVien nv = new NhanVien();
                    nv.HoVaTen = txtHoVaTen.Text;
                    nv.DienThoai = txtDienThoai.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    nv.TenDangNhap = txtTenDangNhap.Text;
                    nv.MatKhau = BC.HashPassword(txtMatKhau.Text);
                    nv.NgaySinh = dateTimePicker.Value;
                    nv.LaQuanLy = cboQuyenHan.SelectedIndex == 0;

                    context.NhanVien.Add(nv);
                }
                else // CẬP NHẬT
                {
                    NhanVien nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.HoVaTen = txtHoVaTen.Text;
                        nv.DienThoai = txtDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.NgaySinh = dateTimePicker.Value;
                        nv.LaQuanLy = cboQuyenHan.SelectedIndex == 0;
                        
                        context.NhanVien.Update(nv);
                        // Chỉ cập nhật mật khẩu nếu người dùng có gõ mật khẩu mới
                        if (string.IsNullOrEmpty(txtMatKhau.Text))
                            context.Entry(nv).Property(x => x.MatKhau).IsModified = false;
                        else
                            nv.MatKhau = BC.HashPassword(txtMatKhau.Text);

                        
                    }
                }

                context.SaveChanges();
                MessageBox.Show("Lưu thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmNhanVien_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["STT"].Value);

            txtMatKhau.Clear();
            txtHoVaTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["STT"].Value);

                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                    context.SaveChanges();
                    MessageBox.Show("Đã xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                frmNhanVien_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }


    }
}