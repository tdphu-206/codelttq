
using System.Data;
using VatLieu.Classes;

namespace VatLieu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnBoQua.Enabled = true;

            DataProcesser dp = new DataProcesser();
            DataTable dt = dp.DocBang("SELECT * FROM tblVatLieu");
            dgvVatLieu.DataSource = dt;
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh vat lieu";
                ofd.Filter = "File ảnh|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picAnh.ImageLocation = ofd.FileName;
                }
            }
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show(
       "Bạn có muốn thoát không",
       "Xác nhận",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaVL.Text) ||
        string.IsNullOrWhiteSpace(txtTenVL.Text) ||
        string.IsNullOrWhiteSpace(txtGiaNhap.Text) ||
        string.IsNullOrWhiteSpace(txtGiaBan.Text) ||
        string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            if (!int.TryParse(txtGiaNhap.Text, out int giaNhap) ||
                !int.TryParse(txtGiaBan.Text, out int giaBan) ||
                !int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                MessageBox.Show("Giá nhập, giá bán và số lượng phải là số nguyên!");
                return;
            }
            DataProcesser dp = new DataProcesser();
            try
            {
                // Kiểm tra mã vật liệu đã tồn tại
                DataTable dt = dp.DocBang(
                    "SELECT * FROM tblVatLieu WHERE MaVL = N'" +
                    txtMaVL.Text.Trim().Replace("'", "''") + "'");

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Mã vật liệu đã tồn tại!");
                    txtMaVL.Focus();
                    return;
                }

                // Tạo câu lệnh INSERT
                string sql = "INSERT INTO tblVatLieu " +
                "(MaVL, TenVatLieu, DonViTinh, GiaNhap, GiaBan, SoLuong, GhiChu) " +
                "VALUES (N'" + txtMaVL.Text.Trim().Replace("'", "''") + "', " +
                "N'" + txtTenVL.Text.Trim().Replace("'", "''") + "', " +
                "N'" + txtDonViTinh.Text.Trim().Replace("'", "''") + "', " +
                "N'" + txtGiaNhap.Text.Trim().Replace("'", "''") + "', " +
                "N'" + txtGiaBan.Text.Trim().Replace("'", "''") + "', " +
                soLuong + ", " +
                 "N'" + txtGhiChu.Text.Trim().Replace("'", "''") + "')";

                dp.CapNhatDuLieu(sql);

                MessageBox.Show("Thêm vật liệu thành công!");

                // Cập nhật lại danh sách
                dgvVatLieu.DataSource = dp.DocBang("SELECT * FROM tblVatLieu");

                // Xóa trắng các ô nhập
                txtMaVL.Clear();
                txtTenVL.Clear();
                txtDonViTinh.Clear();
                txtGiaNhap.Clear();
                txtGiaBan.Clear();
                txtSoLuong.Clear();
                txtGhiChu.Clear();

                picAnh.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm vật liệu: " + ex.Message);
            }
        }

        private void dgvVatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvVatLieu.Rows[e.RowIndex];

            txtMaVL.Text = row.Cells["MaVL"].Value?.ToString();
            txtTenVL.Text = row.Cells["TenVatLieu"].Value?.ToString();
            txtDonViTinh.Text = row.Cells["DonViTinh"].Value?.ToString();
            txtGiaNhap.Text = row.Cells["GiaNhap"].Value?.ToString();
            txtGiaBan.Text = row.Cells["GiaBan"].Value?.ToString();
            txtSoLuong.Text = row.Cells["SoLuong"].Value?.ToString();
            txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
            string anh = row.Cells["Anh"].Value?.ToString();
            // Không cho sửa mã vật liệu
            txtMaVL.ReadOnly = true;

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtMaVL.Text) ||
                string.IsNullOrWhiteSpace(txtTenVL.Text) ||
                string.IsNullOrWhiteSpace(txtDonViTinh.Text) ||
                string.IsNullOrWhiteSpace(txtGiaNhap.Text) ||
                string.IsNullOrWhiteSpace(txtGiaBan.Text) ||
                string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!int.TryParse(txtGiaNhap.Text, out _) ||
                !int.TryParse(txtGiaBan.Text, out _) ||
                !int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                MessageBox.Show("Giá nhập, giá bán và số lượng phải là số nguyên!");
                return;
            }

            try
            {
                DataProcesser dp = new DataProcesser();

                string anh = string.IsNullOrWhiteSpace(picAnh.ImageLocation)
                    ? "NULL"
                    : "N'" + picAnh.ImageLocation.Replace("'", "''") + "'";

                string sql = "UPDATE tblVatLieu SET " +
                    "TenVatLieu = N'" + txtTenVL.Text.Trim().Replace("'", "''") + "', " +
                    "DonViTinh = N'" + txtDonViTinh.Text.Trim().Replace("'", "''") + "', " +
                    "GiaNhap = N'" + txtGiaNhap.Text.Trim() + "', " +
                    "GiaBan = N'" + txtGiaBan.Text.Trim() + "', " +
                    "SoLuong = " + soLuong + ", " +
                    "Anh = " + anh + ", " +
                    "GhiChu = N'" + txtGhiChu.Text.Trim().Replace("'", "''") + "' " +
                    "WHERE MaVL = N'" + txtMaVL.Text.Trim().Replace("'", "''") + "'";

                dp.CapNhatDuLieu(sql);

                // Tải lại danh sách vật liệu
                dgvVatLieu.DataSource = dp.DocBang("SELECT * FROM tblVatLieu");

                // Xóa trắng các ô nhập
                txtMaVL.Clear();
                txtTenVL.Clear();
                txtDonViTinh.Clear();
                txtGiaNhap.Clear();
                txtGiaBan.Clear();
                txtSoLuong.Clear();
                txtGhiChu.Clear();

                picAnh.Image = null;
                picAnh.ImageLocation = null;

                // Khôi phục trạng thái các nút
                txtMaVL.ReadOnly = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;

                MessageBox.Show("Cập nhật vật liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa vật liệu: " + ex.Message);
            }
        }
    
    }
}
