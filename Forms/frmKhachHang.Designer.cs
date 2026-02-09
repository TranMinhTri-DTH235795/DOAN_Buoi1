namespace QuanLyCuaHang.Forms
{
    partial class frmKhachHang
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
            groupBox1 = new GroupBox();
            txtDiemTichLuy = new TextBox();
            txtDienThoai = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtDiaChi = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtHoVaTen = new TextBox();
            label1 = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            btnThem = new Button();
            btnHuyBo = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnLuu = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            Gmail = new DataGridViewTextBoxColumn();
            DiemTichLuy = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDiemTichLuy);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Location = new Point(17, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(964, 146);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtDiemTichLuy
            // 
            txtDiemTichLuy.Location = new Point(548, 68);
            txtDiemTichLuy.Name = "txtDiemTichLuy";
            txtDiemTichLuy.Size = new Size(111, 26);
            txtDiemTichLuy.TabIndex = 2;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(479, 36);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(180, 26);
            txtDienThoai.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 71);
            label5.Name = "label5";
            label5.Size = new Size(87, 19);
            label5.TabIndex = 1;
            label5.Text = "Điểm tích lũy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 39);
            label3.Name = "label3";
            label3.Size = new Size(91, 19);
            label3.TabIndex = 1;
            label3.Text = "Số điện thoại:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(82, 100);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(577, 26);
            txtDiaChi.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 103);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 1;
            label4.Text = "Địa chỉ:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(82, 68);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(367, 26);
            txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 71);
            label2.Name = "label2";
            label2.Size = new Size(45, 19);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(104, 36);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(272, 26);
            txtHoVaTen.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 39);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 1;
            label1.Text = "Họ và Tên:";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(688, 63);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(74, 34);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(688, 103);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(74, 34);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(865, 63);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(91, 34);
            btnNhap.TabIndex = 0;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(865, 103);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(91, 34);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(688, 25);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(74, 34);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(769, 63);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(74, 34);
            btnHuyBo.TabIndex = 0;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(865, 25);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(91, 34);
            btnTimKiem.TabIndex = 0;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(769, 103);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(74, 34);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(769, 25);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(74, 34);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(17, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(964, 347);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { STT, HoVaTen, DienThoai, Gmail, DiemTichLuy, DiaChi });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 22);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(958, 322);
            dataGridView.TabIndex = 0;
            // 
            // STT
            // 
            STT.DataPropertyName = "ID";
            STT.FillWeight = 15F;
            STT.HeaderText = "ID";
            STT.Name = "STT";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.FillWeight = 90F;
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.Name = "HoVaTen";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.FillWeight = 90F;
            DienThoai.HeaderText = "Điện Thoại";
            DienThoai.Name = "DienThoai";
            // 
            // Gmail
            // 
            Gmail.DataPropertyName = "Email";
            Gmail.FillWeight = 90F;
            Gmail.HeaderText = "Gmail";
            Gmail.Name = "Gmail";
            // 
            // DiemTichLuy
            // 
            DiemTichLuy.DataPropertyName = "DiemTichLuy";
            DiemTichLuy.FillWeight = 40F;
            DiemTichLuy.HeaderText = "Điểm TL";
            DiemTichLuy.Name = "DiemTichLuy";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.Name = "DiaChi";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 510);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmKhachHang";
            Load += frmKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSua;
        private Button btnXoa;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnThem;
        private Button btnHuyBo;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnLuu;
        private TextBox txtHoVaTen;
        private Label label1;
        private TextBox txtDienThoai;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private Label label5;
        private TextBox txtDiaChi;
        private Label label4;
        private TextBox txtDiemTichLuy;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn Gmail;
        private DataGridViewTextBoxColumn DiemTichLuy;
        private DataGridViewTextBoxColumn DiaChi;
    }
}