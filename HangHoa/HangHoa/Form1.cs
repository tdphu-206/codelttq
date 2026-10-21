using HangHoa.Classes;
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace HangHoa
{
    public partial class Form1 : Form
    {
        DataProcesser dt = new DataProcesser();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

            LoadComboBoxChatLieu();

            // Load toàn bộ danh sách hàng hóa lên DataGridView lúc đầu
            LoadDataToGridView("SELECT h.Mahang, h.Tenhang, c.Tenchatlieu, h.Dongianhap, h.Dongiaban, h.Soluong" +
                " FROM tblHang h JOIN tblChatlieu c ON h.Machatlieu = c.Machatlieu");
        }
        // Hàm load dữ liệu vào ComboBox Chất liệu
        private void LoadComboBoxChatLieu()
        {
            string sql = "SELECT Machatlieu, Tenchatlieu FROM tblChatlieu";
            System.Data.DataTable dtChatLieu = dt.DocBang(sql);

            cboChatLieu.DataSource = dtChatLieu;
            cboChatLieu.DisplayMember = "Tenchatlieu"; // Hiển thị tên chất liệu cho người dùng
            cboChatLieu.ValueMember = "Machatlieu";     // Giá trị ẩn bên trong là mã chất liệu
            cboChatLieu.SelectedIndex = -1;             // Ban đầu không chọn mục nào
        }

        // Hàm hỗ trợ đổ dữ liệu vào DataGridView
        private void LoadDataToGridView(string sql)
        {

            DataTable dp = dt.DocBang(sql);
            dgvHang.DataSource = dp;

            // Đổi tên các tiêu đề cột trên lưới cho đẹp và dễ nhìn
            if (dgvHang.Columns.Count >= 6)
            {
                dgvHang.Columns["Mahang"].HeaderText = "Mã hàng";
                dgvHang.Columns["Tenhang"].HeaderText = "Tên hàng";
                dgvHang.Columns["Tenchatlieu"].HeaderText = "Chất liệu";
                dgvHang.Columns["Dongianhap"].HeaderText = "Giá nhập";
                dgvHang.Columns["Dongiaban"].HeaderText = "Giá bán";
                dgvHang.Columns["Soluong"].HeaderText = "Số lượng";
            }
        }

        private void txtGiaTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT h.Mahang, h.Tenhang, c.Tenchatlieu, h.Dongianhap, h.Dongiaban, h.Soluong " +
                         "FROM tblHang h JOIN tblChatlieu c ON h.Machatlieu = c.Machatlieu WHERE 1=1";

            // Lọc theo Mã hàng (Tìm kiếm gần đúng dùng LIKE)
            if (!string.IsNullOrWhiteSpace(txtMaHang.Text))
            {
                sql += " AND h.Mahang LIKE N'%" + txtMaHang.Text.Trim() + "%'";
            }

            // Lọc theo Tên hàng (Tìm kiếm gần đúng dùng LIKE)
            if (!string.IsNullOrWhiteSpace(txtTenHang.Text))
            {
                sql += " AND h.Tenhang LIKE N'%" + txtTenHang.Text.Trim() + "%'";
            }

            // Lọc theo Chất liệu (nếu người dùng đã chọn trong ComboBox)
            if (cboChatLieu.SelectedIndex != -1)
            {
                string maChatLieu = cboChatLieu.SelectedValue.ToString();
                sql += " AND h.Machatlieu = '" + maChatLieu + "'";
            }

            // Lọc theo Đơn giá từ
            if (!string.IsNullOrWhiteSpace(txtGiaTu.Text))
            {
                sql += " AND h.Dongiaban >= " + txtGiaTu.Text.Trim();
            }

            // Lọc theo Đơn giá đến
            if (!string.IsNullOrWhiteSpace(txtGiaDen.Text))
            {
                sql += " AND h.Dongiaban <= " + txtGiaDen.Text.Trim();
            }

            // Thực thi câu lệnh thông qua lớp DataProcesser đã có
            DataTable dtKetQua = dt.DocBang(sql);
            dgvHang.DataSource = dtKetQua;

            if (dtKetQua.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy mặt hàng nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra người dùng click vào dòng dữ liệu hợp lệ
            {
                // Lấy tên chất liệu của dòng đang chọn trên lưới
                string tenChatLieu = dgvHang.Rows[e.RowIndex].Cells["Tenchatlieu"].Value.ToString();

                // Câu lệnh đếm số lượng mặt hàng theo tên chất liệu
                string sql = "SELECT COUNT(*) FROM tblHang h JOIN tblChatlieu c ON h.Machatlieu = c.Machatlieu WHERE c.Tenchatlieu = N'" + tenChatLieu + "'";

                DataTable dtCount = dt.DocBang(sql);
                int count = 0;
                if (dtCount.Rows.Count > 0)
                {
                    count = Convert.ToInt32(dtCount.Rows[0][0]);
                }

                MessageBox.Show($"Có tất cả {count} mặt hàng thuộc chất liệu '{tenChatLieu}'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInExcel_Click(object sender, EventArgs e)
        {
            //// Kiểm tra xem DataGridView có dữ liệu để xuất hay không
            //if (dgvHang.Rows.Count == 0)
            //{
            //    MessageBox.Show("Không có dữ liệu để xuất ra Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //try
            //{
            //    // Khởi động chương trình Excel
            //    Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
            //    Microsoft.Office.Interop.Excel.Workbook exBook = exApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            //    Microsoft.Office.Interop.Excel.Worksheet exSheet = (Microsoft.Office.Interop.Excel.Worksheet)exBook.Worksheets[1];

            //    // Định dạng tiêu đề chung cho file Excel (Ví dụ: Tiêu đề báo cáo ở dòng 1, 2)
            //    Microsoft.Office.Interop.Excel.Range
            //    rowTieuDe = (Microsoft.Office.Interop.Excel.Range)exSheet.Cells[1, 1];
            //    rowTieuDe.Font.Size = 15;
            //    rowTieuDe.Font.Bold = true;
            //    rowTieuDe.Font.Color = Color.Red.ToArgb(); // Hoặc màu chữ tùy ý
            //    rowTieuDe.Value2 = "DANH SÁCH HÀNG HÓA TÌM KIẾM";

            //    // Tạo dòng tiêu đề cột (Bắt đầu từ dòng 3)
            //    int hang = 3;
            //    for (int i = 0; i < dgvHang.Columns.Count; i++)
            //    {
            //        Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)exSheet.Cells[hang, i + 1];
            //        range.Font.Bold = true;
            //        range.Value2 = dgvHang.Columns[i].HeaderText;
            //    }

            //    // Đổ dữ liệu từ DataGridView vào các dòng tiếp theo trong Excel
            //    for (int i = 0; i < dgvHang.Rows.Count; i++)
            //    {
            //        hang++;
            //        for (int j = 0; j < dgvHang.Columns.Count; j++)
            //        {
            //            // Kiểm tra nếu ô có dữ liệu thì mới gán tránh lỗi null
            //            if (dgvHang.Rows[i].Cells[j].Value != null)
            //            {
            //                exSheet.Cells[hang, j + 1] = dgvHang.Rows[i].Cells[j].Value.ToString();
            //            }
            //        }
            //    }

            //    // Tự động căn chỉnh độ rộng các cột cho vừa vặn nội dung
            //    exSheet.Columns.AutoFit();

            //    // Hiển thị ứng dụng Excel lên màn hình để người dùng xem hoặc lưu file
            //    exApp.Visible = true;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Có lỗi khi xuất file Excel: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
