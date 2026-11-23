using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CellphoneS
{
    public static class HoaDonDAL
    {
//ConnStr: tên biến lưu chuỗi kết nối.
//ConfigurationManager.ConnectionStrings: lấy danh sách chuỗi kết nối trong file cấu hình.
//"CellPhoneSConn": tên chuỗi kết nối mà chương trình tìm trong App.config.
//.ConnectionString: lấy giá trị chuỗi kết nối đó.
        private static string ConnStr =>
            ConfigurationManager.ConnectionStrings["CellPhoneSConn"].ConnectionString;

        // Lấy toàn bộ hóa đơn (cho form Quản Lý Đơn Hàng)
        public static DataTable LayTatCa()
        {
            string sql = @"
                SELECT
                    MaHD       AS [Mã Hóa Đơn],
                    NgayLap    AS [Ngày Lập],
                    KhachHang  AS [Khách Hàng],
                    SDT        AS [SDT],
                    SanPham    AS [Sản Phẩm],
                    SoLuong    AS [SốLượng],
                    DonGia     AS [ĐơnGiá],
                    ThanhTien  AS [Thành Tiền]
                FROM HoaDon
                ORDER BY NgayLap DESC";// Lấy tất cả hóa đơn, sắp xếp theo ngày lập giảm dần

            DataTable dt = new DataTable();// Tạo DataTable để chứa dữ liệu
            using (SqlConnection conn = new SqlConnection(ConnStr))// Tạo kết nối đến cơ sở dữ liệu
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))// Tạo SqlDataAdapter để thực hiện truy vấn và điền dữ liệu vào DataTable
            {
                da.Fill(dt);//Điền dữ liệu từ truy vấn vào DataTable
            }
            return dt;
        }

        // Lấy hóa đơn theo khoảng ngày (cho form Thống Kê)
        public static DataTable LayTheoNgay(DateTime tu, DateTime den)
        {
            string sql = @"
                SELECT
                    MaHD       AS [Mã Hóa Đơn],
                    NgayLap    AS [Ngày Lập],
                    KhachHang  AS [Khách Hàng],
                    SDT        AS [SDT],
                    SanPham    AS [Sản Phẩm],
                    SoLuong    AS [SốLượng],
                    DonGia     AS [ĐơnGiá],
                    ThanhTien  AS [Thành Tiền]
                FROM HoaDon
                WHERE NgayLap >= @Tu AND NgayLap < @Den
                ORDER BY NgayLap DESC";

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                // Lấy hết ngày 'tu' (bắt đầu từ 00:00:00.000)
                cmd.Parameters.Add("@Tu", SqlDbType.DateTime).Value = tu.Date;
                // Lấy hết ngày 'den' (đến 23:59:59.999)
                cmd.Parameters.Add("@Den", SqlDbType.DateTime).Value = den.Date.AddDays(1);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))// Tạo SqlDataAdapter để thực hiện truy vấn và điền dữ liệu vào DataTable
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}