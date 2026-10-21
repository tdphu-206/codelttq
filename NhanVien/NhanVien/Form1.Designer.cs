namespace NhanVien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            cboPhongBan = new ComboBox();
            txtMucLuong = new TextBox();
            txtSDT = new TextBox();
            txtTenNV = new TextBox();
            txtMaNV = new TextBox();
            picAnh = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            btnAnh = new Button();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            dgvNhanVien = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radNu);
            groupBox1.Controls.Add(radNam);
            groupBox1.Controls.Add(cboPhongBan);
            groupBox1.Controls.Add(txtMucLuong);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtTenNV);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(picAnh);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnAnh);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(28, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(749, 268);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(188, 199);
            radNu.Name = "radNu";
            radNu.Size = new Size(50, 24);
            radNu.TabIndex = 21;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(104, 199);
            radNam.Name = "radNam";
            radNam.Size = new Size(62, 24);
            radNam.TabIndex = 20;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // cboPhongBan
            // 
            cboPhongBan.FormattingEnabled = true;
            cboPhongBan.Location = new Point(479, 176);
            cboPhongBan.Name = "cboPhongBan";
            cboPhongBan.Size = new Size(151, 28);
            cboPhongBan.TabIndex = 19;
            // 
            // txtMucLuong
            // 
            txtMucLuong.Location = new Point(479, 219);
            txtMucLuong.Name = "txtMucLuong";
            txtMucLuong.Size = new Size(125, 27);
            txtMucLuong.TabIndex = 18;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(104, 142);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(125, 27);
            txtSDT.TabIndex = 17;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(104, 89);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(125, 27);
            txtTenNV.TabIndex = 16;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(104, 46);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(125, 27);
            txtMaNV.TabIndex = 15;
            // 
            // picAnh
            // 
            picAnh.Location = new Point(479, 26);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(177, 130);
            picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnh.TabIndex = 14;
            picAnh.TabStop = false;
            picAnh.Click += pictureBox1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(369, 226);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 13;
            label8.Text = "Mức Lương";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(369, 179);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 12;
            label7.Text = "Phòng ban";
            // 
            // btnAnh
            // 
            btnAnh.Location = new Point(356, 26);
            btnAnh.Name = "btnAnh";
            btnAnh.Size = new Size(94, 29);
            btnAnh.TabIndex = 8;
            btnAnh.Text = "Ảnh";
            btnAnh.UseVisualStyleBackColor = true;
            btnAnh.Click += btnAnh_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 203);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 11;
            label6.Text = "Giới tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 92);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 9;
            label4.Text = "Tên NV";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 145);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 10;
            label5.Text = "Số ĐT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 44);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 8;
            label3.Text = "Mã NV";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(51, 354);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(703, 144);
            dgvNhanVien.TabIndex = 1;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(51, 534);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(174, 534);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(316, 534);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(444, 534);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(286, 20);
            label1.Name = "label1";
            label1.Size = new Size(306, 41);
            label1.TabIndex = 6;
            label1.Text = "Danh sách nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(227, 20);
            label2.TabIndex = 7;
            label2.Text = "Chào bạn: Nguyễn Thu Hường";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 575);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvNhanVien);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox picAnh;
        private Label label8;
        private Label label7;
        private Button btnAnh;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label3;
        private DataGridView dgvNhanVien;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private Label label1;
        private Label label2;
        private RadioButton radNu;
        private RadioButton radNam;
        private ComboBox cboPhongBan;
        private TextBox txtMucLuong;
        private TextBox txtSDT;
        private TextBox txtTenNV;
        private TextBox txtMaNV;
    }
}
