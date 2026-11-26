using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellphoneS
{
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
            dgv1.DataSource = HoaDonDAL.LayTatCa();
         
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime tu = dtpTuNgay.Value.Date;
            DateTime den = dtpDenNgay.Value.Date;

            if (tu > den)
            {
                MessageBox.Show("Từ ngày phải nhỏ hơn hoặc bằng Đến ngày!");
                return;
            }

            DataTable dt = HoaDonDAL.LayTheoNgay(tu, den);
            dgv1.DataSource = dt;

            decimal tongTien = dt.AsEnumerable().Sum(r => r.Field<decimal>("Thành Tiền"));//Tính tổng tiền 
            int soHoaDon = dt.Rows.Count;
            int soSanPham = dt.AsEnumerable().Sum(r => r.Field<int>("SốLượng"));//Tính tổng số sản phẩm bán ra

            lblDoanhThu.Text = tongTien.ToString("N0") + " đ";
            lblHoaDon.Text = soHoaDon.ToString();
            lblSanPham.Text = soSanPham.ToString();
        }
        private void lblDoanhThu_Click(object sender, EventArgs e)
        {

        }
        private void frmDoanhThu_Shown(object sender, EventArgs e)
        {
            dgv1.ClearSelection();// bỏ chọn dòng khi form hiển thị
        }
    }
}
