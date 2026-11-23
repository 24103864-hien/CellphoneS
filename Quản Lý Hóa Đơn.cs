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

            // Xử lý ký tự đặc biệt trong RowFilter (' và [ ] * %) để gõ ký tự lạ không bị lỗi cú pháp
            string k = raw
                .Replace("'", "''")
                .Replace("[", "[[]")
                .Replace("]", "[]]")
                .Replace("*", "[*]")
                .Replace("%", "[%]");

            dt.DefaultView.RowFilter =
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

            // Đưa ngày về ngày hiện tại
            dtpNgayLap.Value = DateTime.Now;

            // Bỏ chọn dòng
            dgv.ClearSelection();

        }

        private void Quản_Lý_Đơn_Hàng_Shown(object sender, EventArgs e)
        {
            dgv.ClearSelection();// bỏ chọn dòng khi form hiển thị
        }
    }
    }
