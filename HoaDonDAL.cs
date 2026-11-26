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
                    ThanhTien  AS [Thành Tiền],
 TrangThai  AS [Trạng Thái]
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
                    ThanhTien  AS [Thành Tiền],
 TrangThai  AS [Trạng Thái]
                FROM HoaDon
                WHERE NgayLap >= @Tu AND NgayLap < @Den AND TrangThai = N'Hoàn thành'
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
        public static bool XacNhanHoaDon(string maHD)
        {
            string sql = @"
        UPDATE HoaDon
        SET TrangThai = N'Hoàn thành'
        WHERE MaHD = @MaHD
        AND TrangThai = N'Chờ xác nhận'";// Cập nhật trạng thái hóa đơn từ "Chờ xác nhận" sang "Hoàn thành" nếu mã hóa đơn và trạng thái hiện tại khớp

            using (SqlConnection conn = new SqlConnection(ConnStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar, 30).Value = maHD;// Thêm tham số @MaHD với giá trị là mã hóa đơn cần xác nhận

                conn.Open();// Mở kết nối đến cơ sở dữ liệu

                return cmd.ExecuteNonQuery() > 0;// Thực hiện truy vấn và kiểm tra xem có bao nhiêu hàng bị ảnh hưởng. Nếu có ít nhất 1 hàng bị ảnh hưởng, trả về true, ngược lại trả về false.
            }
        }
        public static DataTable LayTheoMa(string maHD)
        {
            string sql = "SELECT * FROM HoaDon WHERE MaHD = @MaHD";// Truy vấn để lấy thông tin hóa đơn dựa trên mã hóa đơn

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConnStr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar, 30).Value = maHD;// Thêm tham số @MaHD với giá trị là mã hóa đơn cần lấy thông tin

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
    }
}