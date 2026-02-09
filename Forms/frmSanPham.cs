using Microsoft.EntityFrameworkCore.ChangeTracking;
using QuanLyCuaHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Slugify;
namespace QuanLyCuaHang.Forms
{
    public partial class frmSanPham : Form
    {
        QLCHDbContext context = new QLCHDbContext();    // Khởi tạo biến ngữ cảnh CSDL 
        bool xuLyThem = false;                          // Kiểm tra có nhấn vào nút Thêm hay không? 
        int id;                                         // Lấy mã sản phẩm (dùng cho Sửa và Xóa) 
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");
        SlugHelper slugHelper = new SlugHelper();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboHangSanXuat.Enabled = giaTri;
            cboLoaiSanPham.Enabled = giaTri;
            txtTenSanPham.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            numDonGia.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnDoiAnh.Enabled = giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        public void LayLoaiSanPhamVaoComboBox()
        {
            cboLoaiSanPham.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSanPham.ValueMember = "ID";
            cboLoaiSanPham.DisplayMember = "TenLoai";
        }

        public void LayHangSanXuatVaoComboBox()
        {
            cboHangSanXuat.DataSource = context.HangSanXuat.ToList();
            cboHangSanXuat.ValueMember = "ID";
            cboHangSanXuat.DisplayMember = "TenHang";
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LayLoaiSanPhamVaoComboBox();
            LayHangSanXuatVaoComboBox();

            dataGridView.AutoGenerateColumns = false;
            List<DanhSachSanPham> sp = new List<DanhSachSanPham>();
            sp = context.SanPham.Select(r => new DanhSachSanPham
            {
                ID = r.ID,
                LoaiSanPhamID = r.LoaiSanPhamID,
                TenLoai = r.LoaiSanPham.TenLoai,
                HangSanXuatID = r.HangSanXuatID,
                TenHangSanXuat = r.HangSanXuat.TenHang,
                TenSanPham = r.TenSanPham,
                SoLuongTon = r.SoLuongTon,
                DonGia = r.DonGia,
                HinhAnh = r.HinhAnh,
                MoTa = r.MoTa,
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sp;

            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add("SelectedValue", bindingSource, "LoaiSanPhamID",
                false, DataSourceUpdateMode.Never);

            // --- ComboBox Hãng sản xuất ---
            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add("SelectedValue", bindingSource, "HangSanXuatID",
                false, DataSourceUpdateMode.Never);

            // --- TextBox Tên sản phẩm ---
            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham",
                false, DataSourceUpdateMode.Never);

            // --- TextBox Mô tả ---
            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa",
                false, DataSourceUpdateMode.Never);

            // --- NumericUpDown Số lượng ---
            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuongTon",
                false, DataSourceUpdateMode.Never);

            // --- NumericUpDown Đơn giá ---
            numDonGia.DataBindings.Clear();
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia",
                false, DataSourceUpdateMode.Never);

            // --- PictureBox Hình ảnh ---
            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, ev) =>
            {
                if (ev.Value != null && !string.IsNullOrEmpty(ev.Value.ToString()))
                    ev.Value = Path.Combine(imagesFolder, ev.Value.ToString());
            };
            picHinhAnh.DataBindings.Add(hinhAnh);

            // --- DataGridView ---
            dataGridView.DataSource = bindingSource;


        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh" && e.RowIndex >= 0)
            {
                // Lấy dữ liệu của nguyên 1 dòng hiện tại (ép kiểu về DanhSachSanPham)
                DanhSachSanPham rowData = dataGridView.Rows[e.RowIndex].DataBoundItem as DanhSachSanPham;

                if (rowData != null && !string.IsNullOrEmpty(rowData.HinhAnh))
                {
                    try
                    {
                        string imgPath = Path.Combine(imagesFolder, rowData.HinhAnh);

                        if (File.Exists(imgPath))
                        {
                            using (Image img = Image.FromFile(imgPath))
                            {
                                // Tạo ảnh nhỏ 24x24
                                e.Value = new Bitmap(img, new Size(24, 24));
                            }
                            e.FormattingApplied = true;
                        }
                    }
                    catch (Exception)
                    {
                        // Bỏ qua nếu lỗi
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            cboLoaiSanPham.Text = "";
            cboHangSanXuat.Text = "";
            txtTenSanPham.Clear();
            txtMoTa.Clear();
            numSoLuong.Value = 0;
            numDonGia.Value = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa sản phẩm " + txtTenSanPham.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["STT"].Value.ToString());
                SanPham sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    context.SanPham.Remove(sp);
                }
                context.SaveChanges();

                frmSanPham_Load(sender, e);
            }
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 1. Hiển thị ảnh lên giao diện một cách an toàn (không khóa file)
                using (Bitmap bmpTemp = new Bitmap(openFileDialog.FileName))
                {
                    if (picHinhAnh.Image != null) picHinhAnh.Image.Dispose();
                    picHinhAnh.Image = new Bitmap(bmpTemp);
                    picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                }

                // 2. Gửi đường dẫn ảnh gốc vào Tag để lát nữa nút "Lưu" lấy ra xử lý
                picHinhAnh.Tag = openFileDialog.FileName;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["STT"].Value);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // ===== VALIDATE =====
            if (string.IsNullOrWhiteSpace(cboLoaiSanPham.Text))
            { MessageBox.Show("Vui lòng chọn loại sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (string.IsNullOrWhiteSpace(cboHangSanXuat.Text))
            { MessageBox.Show("Vui lòng chọn hãng sản xuất.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
            { MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (numSoLuong.Value <= 0)
            { MessageBox.Show("Số lượng phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (numDonGia.Value <= 0)
            { MessageBox.Show("Đơn giá sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            // ===== KIỂM TRA TRÙNG TÊN =====
            string tenSanPham = txtTenSanPham.Text.Trim();
            bool trungTen = context.SanPham.Any(r =>
                r.TenSanPham.ToLower() == tenSanPham.ToLower() && r.ID != id);
            if (trungTen)
            { MessageBox.Show("Tên sản phẩm đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            int loaiSanPhamID = Convert.ToInt32(cboLoaiSanPham.SelectedValue);
            int hangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue);
            int soLuong = (int)numSoLuong.Value;
            int donGia = (int)numDonGia.Value;
            string moTa = txtMoTa.Text.Trim();

            // ===== THÊM MỚI =====
            if (xuLyThem)
            {   

                SanPham sp = new SanPham()
                {
                    LoaiSanPhamID = loaiSanPhamID,
                    HangSanXuatID = hangSanXuatID,
                    TenSanPham = tenSanPham,
                    MoTa = moTa,
                    SoLuongTon = soLuong,
                    DonGia = donGia,
                    HinhAnh = null
                };
                context.SanPham.Add(sp);
                context.SaveChanges();

                if (picHinhAnh.Tag != null && !string.IsNullOrEmpty(picHinhAnh.Tag.ToString()))
                {
                    string tempPath = picHinhAnh.Tag.ToString();
                    string ext = Path.GetExtension(tempPath);
                    string slugName = Path.GetFileNameWithoutExtension(tempPath);
                    string tenFile = $"sp_{sp.ID}_{slugName}{ext}";
                    string newPath = Path.Combine(imagesFolder, tenFile);

                    if (File.Exists(tempPath) && tempPath != newPath)
                        File.Move(tempPath, newPath, true);

                    // Cập nhật lại tên file ảnh vào Database
                    sp.HinhAnh = tenFile;
                    context.SanPham.Update(sp);
                    context.SaveChanges();

                    // Reset Tag
                    picHinhAnh.Tag = null;
                }

                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // ===== SỬA =====
            else
            {
                SanPham sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    sp.LoaiSanPhamID = loaiSanPhamID;
                    sp.HangSanXuatID = hangSanXuatID;
                    sp.TenSanPham = tenSanPham;
                    sp.MoTa = moTa;
                    sp.SoLuongTon = soLuong;
                    sp.DonGia = donGia;

                    // KIỂM TRA: Nếu Tag có dữ liệu nghĩa là người dùng vừa bấm nút "Đổi ảnh"
                    if (picHinhAnh.Tag != null && !string.IsNullOrEmpty(picHinhAnh.Tag.ToString()))
                    {
                        string sourcePath = picHinhAnh.Tag.ToString();
                        string ext = Path.GetExtension(sourcePath);

                        // Tạo tên file mới (ví dụ: sp_2.jpg)
                        string tenFile = $"sp_{id}{ext}";
                        string destPath = Path.Combine(imagesFolder, tenFile);

                        // Xóa ảnh cũ trên PictureBox trước khi copy đè file mới (chống lỗi khóa file)
                        if (picHinhAnh.Image != null)
                        {
                            picHinhAnh.Image.Dispose();
                            picHinhAnh.Image = null;
                        }

                        // Copy file từ nơi người dùng chọn vào thư mục Images của Project
                        File.Copy(sourcePath, destPath, true);

                        // Cập nhật tên file vào DB
                        sp.HinhAnh = tenFile;
                    }

                    context.SanPham.Update(sp);
                    context.SaveChanges();

                    // Cập nhật xong thì reset Tag
                    picHinhAnh.Tag = null;

                    MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            frmSanPham_Load(sender, e);
        }
    }
    
}
