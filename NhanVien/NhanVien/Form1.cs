
using NhanVien.Classes;
using System.Data;


namespace NhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataProcesser dp = new DataProcesser();
            DataTable dt = dp.DocBang("SELECT * FROM tblNhanVien");
            dgvNhanVien.DataSource = dt;


            cboPhongBan.Items.Add("Kế Toán");
            cboPhongBan.Items.Add("Thu Ngân");
            cboPhongBan.Items.Add("Bảo vệ");

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

            txtMaNV.Text = row.Cells["MaNV"].Value?.ToString();
            txtTenNV.Text = row.Cells["TenNV"].Value?.ToString();
            txtSDT.Text = row.Cells["SoDT"].Value?.ToString();
            string gioiTinh = row.Cells["GioiTinh"].Value?.ToString();

            radNam.Checked = gioiTinh == "Nam";
            radNu.Checked = gioiTinh == "Nữ";
            cboPhongBan.Text = row.Cells["PhongBan"].Value?.ToString();
            txtMucLuong.Text = row.Cells["MucLuong"].Value?.ToString();

            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh nhân viên";
                ofd.Filter = "File ảnh|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picAnh.ImageLocation = ofd.FileName;
                    //txtAnh.Text = System.IO.Path.GetFileName(ofd.FileName);
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!");
                txtMaNV.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!");
                txtTenNV.Focus();
                return;
            }

            if (!radNam.Checked && !radNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMucLuong.Text) ||
        !decimal.TryParse(txtMucLuong.Text, out decimal mucLuong) ||
        mucLuong < 0)
            {
                MessageBox.Show("Mức lương không hợp lệ!");
                txtMucLuong.Focus();
                txtMucLuong.SelectAll();
                return;
            }
            string maNV = txtMaNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            string soDT = txtSDT.Text.Trim();
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string phongBan = cboPhongBan.Text.Trim();

            DataProcesser dp = new DataProcesser();

            try
            {
                // Kiểm tra mã nhân viên trùng
                DataTable dt = dp.DocBang(
                    "SELECT * FROM tblNhanVien WHERE MaNV = N'"
                    + maNV.Replace("'", "''") + "'");

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!");
                    txtMaNV.Focus();
                    txtMaNV.SelectAll();
                    return;
                }

                string sql = "INSERT INTO tblNhanVien " +
    "(MaNV, TenNV, SoDT, GioiTinh, PhongBan, MucLuong, MatKhau, Anh) " +
    "VALUES (N'" + maNV.Replace("'", "''") + "', " +
    "N'" + tenNV.Replace("'", "''") + "', " +
    "N'" + soDT.Replace("'", "''") + "', " +
    "N'" + gioiTinh + "', " +
    "N'" + phongBan.Replace("'", "''") + "', " +
    mucLuong.ToString(
        System.Globalization.CultureInfo.InvariantCulture) + ", " +
    "N'" + maNV.Replace("'", "''") + "', " +
    "N'" + "')";

                dp.CapNhatDuLieu(sql);
                MessageBox.Show("Thêm nhân viên thành công!");

                // Cập nhật lại danh sách
                dgvNhanVien.DataSource =
                    dp.DocBang("SELECT * FROM tblNhanVien");

                txtMaNV.Clear();
                txtTenNV.Clear();
                txtSDT.Clear();
                txtMucLuong.Clear();
                cboPhongBan.SelectedIndex = -1;
                radNam.Checked = false;
                radNu.Checked = false;
                picAnh.ImageLocation = null;
                picAnh.Image = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã nhân viên
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
                return;
            }

            // Kiểm tra tên nhân viên
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!");
                txtTenNV.Focus();
                return;
            }

            // Kiểm tra giới tính
            if (!radNam.Checked && !radNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return;
            }

            // Kiểm tra mức lương
            if (!decimal.TryParse(txtMucLuong.Text, out decimal mucLuong)
                || mucLuong < 0)
            {
                MessageBox.Show("Mức lương không hợp lệ!");
                txtMucLuong.Focus();
                txtMucLuong.SelectAll();
                return;
            }

            string maNV = txtMaNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            string soDT = txtSDT.Text.Trim();
            string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
            string phongBan = cboPhongBan.Text.Trim();

            try
            {
                DataProcesser dp = new DataProcesser();

                string sql = "UPDATE tblNhanVien SET " +
                    "TenNV = N'" + tenNV.Replace("'", "''") + "', " +
                    "SoDT = N'" + soDT.Replace("'", "''") + "', " +
                    "GioiTinh = N'" + gioiTinh + "', " +
                    "PhongBan = N'" + phongBan.Replace("'", "''") + "', " +
                    "MucLuong = " + mucLuong.ToString(
                        System.Globalization.CultureInfo.InvariantCulture) +
                    " WHERE MaNV = N'" + maNV.Replace("'", "''") + "'";

                dp.CapNhatDuLieu(sql);

                MessageBox.Show("Cập nhật nhân viên thành công!");

                // Hiển thị lại danh sách sau khi sửa
                dgvNhanVien.DataSource =
                    dp.DocBang("SELECT * FROM tblNhanVien");

                txtMaNV.Clear();
                txtTenNV.Clear();
                txtSDT.Clear();
                txtMucLuong.Clear();
                cboPhongBan.SelectedIndex = -1;
                radNam.Checked = false;
                radNu.Checked = false;
                picAnh.ImageLocation = null;
                picAnh.Image = null;

                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

                txtMaNV.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa nhân viên: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            // Kiểm tra đã chọn nhân viên chưa
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            // Hỏi xác nhận xóa
            DialogResult ketQua = MessageBox.Show(
                "Bạn có muốn xóa không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Nếu chọn No thì không làm gì
            if (ketQua == DialogResult.No)
            {
                return;
            }

            try
            {
                string maNV = txtMaNV.Text.Trim();

                DataProcesser dp = new DataProcesser();

                // Xóa nhân viên đang chọn
                string sql = "DELETE FROM tblNhanVien WHERE MaNV = N'"
                    + maNV.Replace("'", "''") + "'";

                dp.CapNhatDuLieu(sql);

                MessageBox.Show("Xóa nhân viên thành công!");

                // Cập nhật lại danh sách trên lưới
                dgvNhanVien.DataSource =
                    dp.DocBang("SELECT * FROM tblNhanVien");

                txtMaNV.Clear();
                txtTenNV.Clear();
                txtSDT.Clear();
                txtMucLuong.Clear();
                cboPhongBan.SelectedIndex = -1;
                radNam.Checked = false;
                radNu.Checked = false;
                picAnh.ImageLocation = null;
                picAnh.Image = null;

                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

                txtMaNV.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhân viên: " + ex.Message);
            }
        }
    
    }
}