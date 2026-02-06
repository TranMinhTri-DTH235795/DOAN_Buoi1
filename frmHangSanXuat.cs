using QuanLyCuaHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class frmHangSanXuat : Form
    {
        QLCHDbContext context = new QLCHDbContext();
        bool xuLyThem = false;
        int id;
        public frmHangSanXuat()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtTenHangSanXuat.Enabled = giaTri;
            txtQuocGia.Enabled = giaTri;
            txtThongTinLienHe.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            List<HangSanXuat> list = new List<HangSanXuat>();
            list = context.HangSanXuat.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = list;
            // Binding cho Tên Hãng
            txtTenHangSanXuat.DataBindings.Clear();
            txtTenHangSanXuat.DataBindings.Add("Text", bindingSource, "TenHang", false, DataSourceUpdateMode.Never);
            // Binding cho Quốc Gia
            txtQuocGia.DataBindings.Clear();
            txtQuocGia.DataBindings.Add("Text", bindingSource, "QuocGia", false, DataSourceUpdateMode.Never);
            // Binding cho Thông Tin Liên Hệ
            txtThongTinLienHe.DataBindings.Clear();
            txtThongTinLienHe.DataBindings.Add("Text", bindingSource, "ThongTinLienHe", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            txtTenHangSanXuat.Clear();
            txtQuocGia.Clear();
            txtThongTinLienHe.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["STT"].Value.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenHang = txtTenHangSanXuat.Text.Trim();
            string quocGia = txtQuocGia.Text.Trim();
            string thongTinLienHe = txtThongTinLienHe.Text.Trim();

            if (string.IsNullOrEmpty(tenHang))
            {
                MessageBox.Show("Vui lòng nhập tên hãng sản xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHangSanXuat.Focus();
                return;
            }

            bool biTrungTen = false;
            if (xuLyThem)
            {
                // Nếu là Thêm mới: Tìm xem trong DB đã có tên này chưa
                biTrungTen = context.HangSanXuat.Any(h => h.TenHang.ToLower() == tenHang.ToLower());
            }
            else
            {
                // Nếu là Sửa: Tìm xem có tên này trong DB chưa, nhưng PHẢI TRỪ dòng hiện tại đang sửa ra (dựa vào id)
                biTrungTen = context.HangSanXuat.Any(h => h.TenHang.ToLower() == tenHang.ToLower() && h.ID != id);
            }

            if (biTrungTen)
            {
                MessageBox.Show("Tên hãng sản xuất này đã tồn tại. Vui lòng nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHangSanXuat.Focus();
                return; 
            }

            // 4. Tiến hành Lưu dữ liệu nếu vượt qua hết các ràng buộc
            if (xuLyThem)
            {
                HangSanXuat hangSanXuat = new HangSanXuat();
                hangSanXuat.TenHang = tenHang;

                // Nếu textbox trống thì gán null, ngược lại gán giá trị
                hangSanXuat.QuocGia = string.IsNullOrEmpty(quocGia) ? null : quocGia;
                hangSanXuat.ThongTinLienHe = string.IsNullOrEmpty(thongTinLienHe) ? null : thongTinLienHe;

                context.HangSanXuat.Add(hangSanXuat);
            }
            else 
            {
                HangSanXuat hangSanXuat = context.HangSanXuat.Find(id);
                if (hangSanXuat != null)
                {
                    hangSanXuat.TenHang = tenHang;
                    hangSanXuat.QuocGia = string.IsNullOrEmpty(quocGia) ? null : quocGia;
                    hangSanXuat.ThongTinLienHe = string.IsNullOrEmpty(thongTinLienHe) ? null : thongTinLienHe;

                    context.HangSanXuat.Update(hangSanXuat);
                }
            }


            context.SaveChanges();
            MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmHangSanXuat_Load(sender, e);
            BatTatChucNang(false);
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa loại sản phẩm?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["STT"].Value.ToString());
                HangSanXuat lsp = context.HangSanXuat.Find(id);
                if (lsp != null)
                {
                    context.HangSanXuat.Remove(lsp);
                    context.SaveChanges();
                }

                frmHangSanXuat_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmHangSanXuat_Load(sender, e);
        }
    }
}
