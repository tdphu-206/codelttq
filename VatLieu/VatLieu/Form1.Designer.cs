namespace VatLieu
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
            dgvVatLieu = new DataGridView();
            groupBox1 = new GroupBox();
            picAnh = new PictureBox();
            txtGhiChu = new TextBox();
            txtSoLuong = new TextBox();
            txtGiaBan = new TextBox();
            txtDonViTinh = new TextBox();
            txtGiaNhap = new TextBox();
            txtTenVL = new TextBox();
            txtMaVL = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAnh = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnBoQua = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVatLieu).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            SuspendLayout();
            // 
            // dgvVatLieu
            // 
            dgvVatLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVatLieu.Location = new Point(39, 292);
            dgvVatLieu.Name = "dgvVatLieu";
            dgvVatLieu.RowHeadersWidth = 51;
            dgvVatLieu.Size = new Size(714, 121);
            dgvVatLieu.TabIndex = 0;
            dgvVatLieu.CellClick += dgvVatLieu_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picAnh);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(txtGiaBan);
            groupBox1.Controls.Add(txtDonViTinh);
            groupBox1.Controls.Add(txtGiaNhap);
            groupBox1.Controls.Add(txtTenVL);
            groupBox1.Controls.Add(txtMaVL);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAnh);
            groupBox1.Location = new Point(39, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(714, 252);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin vật liệu";
            // 
            // picAnh
            // 
            picAnh.Location = new Point(454, 26);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(202, 123);
            picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnh.TabIndex = 18;
            picAnh.TabStop = false;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(454, 179);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(202, 58);
            txtGhiChu.TabIndex = 17;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(116, 214);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(125, 27);
            txtSoLuong.TabIndex = 16;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(116, 179);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(125, 27);
            txtGiaBan.TabIndex = 15;
            txtGiaBan.KeyPress += txtGiaBan_KeyPress;
            // 
            // txtDonViTinh
            // 
            txtDonViTinh.Location = new Point(116, 100);
            txtDonViTinh.Name = "txtDonViTinh";
            txtDonViTinh.Size = new Size(125, 27);
            txtDonViTinh.TabIndex = 14;
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.Location = new Point(116, 139);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.Size = new Size(125, 27);
            txtGiaNhap.TabIndex = 13;
            txtGiaNhap.KeyPress += txtGiaNhap_KeyPress;
            // 
            // txtTenVL
            // 
            txtTenVL.Location = new Point(116, 60);
            txtTenVL.Name = "txtTenVL";
            txtTenVL.Size = new Size(125, 27);
            txtTenVL.TabIndex = 12;
            // 
            // txtMaVL
            // 
            txtMaVL.Location = new Point(116, 26);
            txtMaVL.Name = "txtMaVL";
            txtMaVL.Size = new Size(125, 27);
            txtMaVL.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(356, 186);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 10;
            label7.Text = "Ghi chú";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 217);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 9;
            label6.Text = "Số lượng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 179);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 8;
            label5.Text = "Giá bán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 142);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 7;
            label4.Text = "Giá nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 103);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 6;
            label3.Text = "Đơn vị tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 63);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 5;
            label2.Text = "Tên VL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã VL";
            // 
            // btnAnh
            // 
            btnAnh.Location = new Point(339, 29);
            btnAnh.Name = "btnAnh";
            btnAnh.Size = new Size(94, 43);
            btnAnh.TabIndex = 3;
            btnAnh.Text = "Ảnh";
            btnAnh.UseVisualStyleBackColor = true;
            btnAnh.Click += btnAnh_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(85, 418);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(225, 418);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(366, 418);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(503, 419);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(94, 29);
            btnBoQua.TabIndex = 5;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 460);
            Controls.Add(btnBoQua);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Controls.Add(dgvVatLieu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVatLieu).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVatLieu;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAnh;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnBoQua;
        private PictureBox picAnh;
        private TextBox txtGhiChu;
        private TextBox txtSoLuong;
        private TextBox txtGiaBan;
        private TextBox txtDonViTinh;
        private TextBox txtGiaNhap;
        private TextBox txtTenVL;
        private TextBox txtMaVL;
        private Label label7;
    }
}
