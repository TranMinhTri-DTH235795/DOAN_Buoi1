namespace QuanLyCuaHang.Forms
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtMatKhau = new TextBox();
            txtDienThoai = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtDiaChi = new TextBox();
            label4 = new Label();
            txtTenDangNhap = new TextBox();
            label2 = new Label();
            txtHoVaTen = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker = new DateTimePicker();
            btnSua = new Button();
            btnXoa = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            btnThem = new Button();
            btnHuyBo = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            cboQuyenHan = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(563, 61);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(133, 26);
            txtMatKhau.TabIndex = 8;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(115, 58);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(118, 26);
            txtDienThoai.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(465, 66);
            label5.Name = "label5";
            label5.Size = new Size(70, 19);
            label5.TabIndex = 3;
            label5.Text = "Mật khẩu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 64);
            label3.Name = "label3";
            label3.Size = new Size(40, 19);
            label3.TabIndex = 4;
            label3.Text = "SDT:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(115, 90);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(306, 26);
            txtDiaChi.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 96);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 5;
            label4.Text = "Địa chỉ:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(563, 29);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(133, 26);
            txtTenDangNhap.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(428, 32);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 6;
            label2.Text = "Tên đăng nhập:";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(115, 26);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(286, 26);
            txtHoVaTen.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 29);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 7;
            label1.Text = "Họ và Tên:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 136);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // dateTimePicker
            // 
            dateTimePicker.CustomFormat = "DD/MM/YY";
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(336, 58);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(106, 26);
            dateTimePicker.TabIndex = 24;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(702, 61);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(74, 34);
            btnSua.TabIndex = 15;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(702, 101);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 34);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(879, 61);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(91, 34);
            btnNhap.TabIndex = 17;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(879, 101);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(91, 34);
            btnXuat.TabIndex = 18;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(702, 23);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 34);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(783, 61);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(74, 34);
            btnHuyBo.TabIndex = 20;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(879, 23);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(91, 34);
            btnTimKiem.TabIndex = 21;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(783, 101);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(74, 34);
            btnThoat.TabIndex = 22;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(783, 23);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(74, 34);
            btnLuu.TabIndex = 23;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Nhân viên", "Quản lý" });
            cboQuyenHan.Location = new Point(563, 93);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(133, 27);
            cboQuyenHan.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(465, 98);
            label6.Name = "label6";
            label6.Size = new Size(74, 19);
            label6.TabIndex = 3;
            label6.Text = "Quyền hạn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(239, 61);
            label7.Name = "label7";
            label7.Size = new Size(72, 19);
            label7.TabIndex = 3;
            label7.Text = "Ngày sinh:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(12, 154);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(982, 371);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { STT, HoVaTen, DienThoai, DiaChi, NgaySinh, TenDangNhap, QuyenHan });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 22);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(976, 346);
            dataGridView.TabIndex = 0;
            // 
            // STT
            // 
            STT.DataPropertyName = "ID";
            STT.FillWeight = 30F;
            STT.HeaderText = "ID";
            STT.MinimumWidth = 6;
            STT.Name = "STT";
            STT.ReadOnly = true;
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            HoVaTen.ReadOnly = true;
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            NgaySinh.DefaultCellStyle = dataGridViewCellStyle1;
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 6;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "LaQuanLy";
            QuyenHan.HeaderText = "Quyền hạn";
            QuyenHan.MinimumWidth = 6;
            QuyenHan.Name = "QuyenHan";
            QuyenHan.ReadOnly = true;
            QuyenHan.Resizable = DataGridViewTriState.True;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 537);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân viên";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtMatKhau;
        private TextBox txtDienThoai;
        private Label label5;
        private Label label3;
        private TextBox txtDiaChi;
        private Label label4;
        private TextBox txtTenDangNhap;
        private Label label2;
        private TextBox txtHoVaTen;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cboQuyenHan;
        private Label label6;
        private Button btnSua;
        private Button btnXoa;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnThem;
        private Button btnHuyBo;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnLuu;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DateTimePicker dateTimePicker;
        private Label label7;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
    }
}