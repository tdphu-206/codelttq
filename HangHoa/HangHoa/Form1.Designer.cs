namespace HangHoa
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
            cboChatLieu = new ComboBox();
            txtTenHang = new TextBox();
            txtGiaDen = new TextBox();
            txtGiaTu = new TextBox();
            txtMaHang = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnTimKiem = new Button();
            btnInExcel = new Button();
            btnThoat = new Button();
            dgvHang = new DataGridView();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHang).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboChatLieu);
            groupBox1.Controls.Add(txtTenHang);
            groupBox1.Controls.Add(txtGiaDen);
            groupBox1.Controls.Add(txtGiaTu);
            groupBox1.Controls.Add(txtMaHang);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(749, 132);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cboChatLieu
            // 
            cboChatLieu.FormattingEnabled = true;
            cboChatLieu.Location = new Point(604, 83);
            cboChatLieu.Name = "cboChatLieu";
            cboChatLieu.Size = new Size(125, 28);
            cboChatLieu.TabIndex = 11;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(606, 31);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(125, 27);
            txtTenHang.TabIndex = 10;
            // 
            // txtGiaDen
            // 
            txtGiaDen.Location = new Point(326, 83);
            txtGiaDen.Name = "txtGiaDen";
            txtGiaDen.Size = new Size(99, 27);
            txtGiaDen.TabIndex = 9;
            txtGiaDen.KeyPress += txtGiaDen_KeyPress;
            // 
            // txtGiaTu
            // 
            txtGiaTu.Location = new Point(141, 83);
            txtGiaTu.Name = "txtGiaTu";
            txtGiaTu.Size = new Size(96, 27);
            txtGiaTu.TabIndex = 8;
            txtGiaTu.KeyPress += txtGiaTu_KeyPress;
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new Point(96, 34);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.Size = new Size(125, 27);
            txtMaHang.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(531, 86);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 6;
            label7.Text = "Chất liệu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(531, 34);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 5;
            label6.Text = "Tên hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(431, 86);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 4;
            label5.Text = "VNĐ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 86);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "VNĐ) đến:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 86);
            label3.Name = "label3";
            label3.Size = new Size(23, 20);
            label3.TabIndex = 2;
            label3.Text = "từ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 86);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Đơn giá bán: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 34);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hàng";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(55, 238);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnInExcel
            // 
            btnInExcel.Location = new Point(186, 238);
            btnInExcel.Name = "btnInExcel";
            btnInExcel.Size = new Size(94, 29);
            btnInExcel.TabIndex = 2;
            btnInExcel.Text = "in ra Excel ";
            btnInExcel.UseVisualStyleBackColor = true;
            btnInExcel.Click += btnInExcel_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(327, 238);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // dgvHang
            // 
            dgvHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHang.Location = new Point(23, 283);
            dgvHang.Name = "dgvHang";
            dgvHang.RowHeadersWidth = 51;
            dgvHang.Size = new Size(749, 155);
            dgvHang.TabIndex = 4;
            dgvHang.CellDoubleClick += dgvHang_CellDoubleClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Freestyle Script", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(280, 25);
            label8.Name = "label8";
            label8.Size = new Size(238, 36);
            label8.TabIndex = 5;
            label8.Text = "TÌM KIẾM HÀNG HÓA";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(dgvHang);
            Controls.Add(btnThoat);
            Controls.Add(btnInExcel);
            Controls.Add(btnTimKiem);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnTimKiem;
        private Button btnInExcel;
        private Button btnThoat;
        private ComboBox cboChatLieu;
        private TextBox txtTenHang;
        private TextBox txtGiaDen;
        private TextBox txtGiaTu;
        private TextBox txtMaHang;
        private DataGridView dgvHang;
        private Label label8;
    }
}
