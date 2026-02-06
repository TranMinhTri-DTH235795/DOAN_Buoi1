namespace QuanLyCuaHang
{
    partial class frmHangSanXuat
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
            button8 = new Button();
            button7 = new Button();
            btnLuu = new Button();
            btnThoat = new Button();
            btnXoa = new Button();
            btnHuyBo = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtThongTinLienHe = new TextBox();
            txtQuocGia = new TextBox();
            txtTenHangSanXuat = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            STT = new DataGridViewTextBoxColumn();
            TenHang = new DataGridViewTextBoxColumn();
            QuocGia = new DataGridViewTextBoxColumn();
            ThongTinLienHe = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtThongTinLienHe);
            groupBox1.Controls.Add(txtQuocGia);
            groupBox1.Controls.Add(txtTenHangSanXuat);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(919, 142);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hãng sản xuất";
            // 
            // button8
            // 
            button8.Location = new Point(829, 70);
            button8.Name = "button8";
            button8.Size = new Size(76, 29);
            button8.TabIndex = 3;
            button8.Text = "button2";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(739, 70);
            button7.Name = "button7";
            button7.Size = new Size(75, 29);
            button7.TabIndex = 2;
            button7.Text = "button1";
            button7.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(648, 105);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(76, 29);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(829, 105);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(76, 29);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(558, 105);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(739, 105);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(75, 29);
            btnHuyBo.TabIndex = 2;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(648, 70);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(76, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(558, 70);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 104);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 19);
            label3.TabIndex = 1;
            label3.Text = "Thông tin liên hệ: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 70);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 1;
            label2.Text = "Quốc Gia:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 1;
            label1.Text = "Tên hãng sản xuất: ";
            // 
            // txtThongTinLienHe
            // 
            txtThongTinLienHe.Location = new Point(162, 101);
            txtThongTinLienHe.Margin = new Padding(4);
            txtThongTinLienHe.Name = "txtThongTinLienHe";
            txtThongTinLienHe.Size = new Size(344, 26);
            txtThongTinLienHe.TabIndex = 0;
            // 
            // txtQuocGia
            // 
            txtQuocGia.Location = new Point(162, 67);
            txtQuocGia.Margin = new Padding(4);
            txtQuocGia.Name = "txtQuocGia";
            txtQuocGia.Size = new Size(344, 26);
            txtQuocGia.TabIndex = 0;
            // 
            // txtTenHangSanXuat
            // 
            txtTenHangSanXuat.Location = new Point(162, 33);
            txtTenHangSanXuat.Margin = new Padding(4);
            txtTenHangSanXuat.Name = "txtTenHangSanXuat";
            txtTenHangSanXuat.Size = new Size(743, 26);
            txtTenHangSanXuat.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(15, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(919, 342);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hãng sản xuất";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { STT, TenHang, QuocGia, ThongTinLienHe });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 22);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(913, 317);
            dataGridView.TabIndex = 0;
            // 
            // STT
            // 
            STT.DataPropertyName = "ID";
            STT.FillWeight = 15F;
            STT.HeaderText = "ID";
            STT.Name = "STT";
            // 
            // TenHang
            // 
            TenHang.DataPropertyName = "TenHang";
            TenHang.HeaderText = "Tên hãng sản xuất ";
            TenHang.Name = "TenHang";
            // 
            // QuocGia
            // 
            QuocGia.DataPropertyName = "QuocGia";
            QuocGia.FillWeight = 60F;
            QuocGia.HeaderText = "Quốc Gia";
            QuocGia.Name = "QuocGia";
            // 
            // ThongTinLienHe
            // 
            ThongTinLienHe.DataPropertyName = "ThongTinLienHe";
            ThongTinLienHe.HeaderText = "Thông tin liên hệ";
            ThongTinLienHe.Name = "ThongTinLienHe";
            // 
            // frmHangSanXuat
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 510);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmHangSanXuat";
            Text = "frmHangSanXuat";
            Load += frmHangSanXuat_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSua;
        private Button btnThem;
        private Label label1;
        private TextBox txtTenHangSanXuat;
        private Button button8;
        private Button button7;
        private Button btnLuu;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnHuyBo;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Label label2;
        private TextBox txtQuocGia;
        private Label label3;
        private TextBox txtThongTinLienHe;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn TenHang;
        private DataGridViewTextBoxColumn QuocGia;
        private DataGridViewTextBoxColumn ThongTinLienHe;
    }
}