using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellphoneS
{
    public partial class Quản_Lý_Đơn_Hàng : Form
    {
        public Quản_Lý_Đơn_Hàng()
        {
            InitializeComponent();
            dgv.DataSource = HoaDonDAL.LayTatCa();

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;   // bấm vào tiêu đề cột thì bỏ qua

            DataGridViewRow r = dgv.Rows[e.RowIndex];

            txtMaHoaDon.Text = r.Cells["Mã Hóa Đơn"].Value.ToString();
            txtKhachHang.Text = r.Cells["Khách Hàng"].Value.ToString();
            txtSDT.Text = r.Cells["SDT"].Value.ToString();
            txtSanPham.Text = r.Cells["Sản Phẩm"].Value.ToString();
            txtSoLuong.Text = r.Cells["SốLượng"].Value.ToString();
            txtDonGia.Text = r.Cells["ĐơnGiá"].Value.ToString();
            txtThanhTien.Text = r.Cells["Thành Tiền"].Value.ToString();
            dtpNgayLap.Value = Convert.ToDateTime(r.Cells["Ngày Lập"].Value);
            txtTrangThai.Text = r.Cells["Trạng Thái"].Value.ToString();


        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

            var dt = dgv.DataSource as DataTable;
            if (dt == null) return;

            string raw = txtTimKiem.Text.Trim();
            if (string.IsNullOrEmpty(raw))
            {
                dt.DefaultView.RowFilter = string.Empty;
                return;
            }

            string k = txtTimKiem.Text.Trim();
            dt.DefaultView.RowFilter =// Lọc dữ liệu trong DataTable dựa trên các cột Mã Hóa Đơn
                                      // , Khách Hàng, SDT và Sản Phẩm có chứa từ khóa tìm kiếm
                $"[Mã Hóa Đơn] LIKE '%{k}%' OR " +
                $"[Khách Hàng] LIKE '%{k}%' OR " +
                $"[SDT] LIKE '%{k}%' OR " +
                $"[Sản Phẩm] LIKE '%{k}%'";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgv.DataSource = HoaDonDAL.LayTatCa();

            // Xóa nội dung tìm kiếm
            txtTimKiem.Clear();

            // Xóa dữ liệu trên các ô nhập
            txtMaHoaDon.Clear();
            txtKhachHang.Clear();
            txtSDT.Clear();
            txtSanPham.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtThanhTien.Clear();
            txtTrangThai.Clear();

            // Đưa ngày về ngày hiện tại
            dtpNgayLap.Value = DateTime.Now;

            // Bỏ chọn dòng
            dgv.ClearSelection();

        }

        private void Quản_Lý_Đơn_Hàng_Shown(object sender, EventArgs e)
        {
            dgv.ClearSelection();// bỏ chọn dòng khi form hiển thị
        }

        private void cboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = dgv.DataSource as DataTable;// Lấy dữ liệu từ DataGridView và ép kiểu về DataTable

            if (dt == null) return;

            string trangThai = cboLoc.Text;

            if (trangThai == "Tất Cả")
            {
                dt.DefaultView.RowFilter = "";// Hiển thị tất cả các hóa đơn
            }
            else
            {
                dt.DefaultView.RowFilter =
                    $"[Trạng Thái] = '{trangThai.Replace("'", "''")}'";// Lọc dữ liệu theo trạng thái được chọn trong ComboBox
            }

            dgv.ClearSelection();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Index < 0)// Kiểm tra xem có dòng nào được chọn hay không
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xác nhận!");
                return;
            }

            string maHD = dgv.CurrentRow.Cells["Mã Hóa Đơn"].Value.ToString();

            string trangThai = dgv.CurrentRow.Cells["Trạng Thái"].Value.ToString();

            if (trangThai == "Hoàn thành")
            {
                MessageBox.Show("Hóa đơn đã hoàn thành!");
                return;
            }
            if (!KiemTraThongTinHoaDon(maHD))
            {
                MessageBox.Show("Thông tin hóa đơn không hợp lệ!");
                return;
            }


            bool ketQua = HoaDonDAL.XacNhanHoaDon(maHD);// Gọi phương thức XacNhanHoaDon trong lớp HoaDonDAL để xác nhận hóa đơn

            if (ketQua)
            {
                MessageBox.Show("Xác nhận hóa đơn thành công!");

                dgv.DataSource = HoaDonDAL.LayTatCa();// Cập nhật lại dữ liệu trong DataGridView sau khi xác nhận hóa đơn

                cboLoc_SelectedIndexChanged(null, null);// Gọi lại sự kiện SelectedIndexChanged của ComboBox để áp dụng bộ lọc hiện tại

                dgv.ClearSelection();
                txtMaHoaDon.Clear();
                txtKhachHang.Clear();
                txtSDT.Clear();
                txtSanPham.Clear();
                txtSoLuong.Clear();
                txtDonGia.Clear();
                txtThanhTien.Clear();
                txtTrangThai.Clear();
            }
            else
            {
                MessageBox.Show("Không thể xác nhận hóa đơn!");
            }
        }
        
    private bool KiemTraThongTinHoaDon(string maHD)
        {
            DataTable dt = HoaDonDAL.LayTheoMa(maHD);// Lấy thông tin hóa đơn từ cơ sở dữ liệu dựa trên mã hóa đơn

            if (dt.Rows.Count == 0)
                return false;

            DataRow row = dt.Rows[0];

            return
                txtKhachHang.Text.Trim() == row["KhachHang"].ToString().Trim() &&
                txtSDT.Text.Trim() == row["SDT"].ToString().Trim() &&
                txtSanPham.Text.Trim() == row["SanPham"].ToString().Trim() &&
                txtSoLuong.Text.Trim() == row["SoLuong"].ToString() &&
                txtDonGia.Text.Trim() == row["DonGia"].ToString() &&
                txtThanhTien.Text.Trim() == row["ThanhTien"].ToString();
        }
    }
}
    
