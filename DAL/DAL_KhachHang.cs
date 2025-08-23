using DTO;
using System.Data;

namespace DAL
{
    public class DAL_KhachHang
    {
        // THÊM DỮ LIỆU
        public void AddData(DTO_KhachHang ex)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"INSERT INTO KhachHang 
                    (MaCode, TenKhachHang, DiaChi, DienThoai, Email, GioiTinh) 
                    VALUES (@MaCode, @TenKhachHang, @DiaChi, @DienThoai, @Email, @GioiTinh)";
                cmd.Parameters.AddWithValue("@MaCode", ex.MaCode);
                cmd.Parameters.AddWithValue("@TenKhachHang", ex.TenKhachHang);
                cmd.Parameters.AddWithValue("@DiaChi", ex.DiaChi ?? "");
                cmd.Parameters.AddWithValue("@DienThoai", ex.DienThoai ?? "");
                cmd.Parameters.AddWithValue("@Email", ex.Email);
                cmd.Parameters.AddWithValue("@GioiTinh", ex.GioiTinh);
                cmd.ExecuteNonQuery();
            }
        }

        // Sửa dữ liệu
        public void EditData(DTO_KhachHang ex)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE KhachHang SET TenKhachHang=@ten, DiaChi=@diachi, DienThoai=@dt WHERE Id=@id";
                cmd.Parameters.AddWithValue("@ten", ex.TenKhachHang);
                cmd.Parameters.AddWithValue("@diachi", ex.DiaChi ?? "");
                cmd.Parameters.AddWithValue("@dt", ex.DienThoai ?? "");
                cmd.Parameters.AddWithValue("@id", ex.Id);
                cmd.ExecuteNonQuery();
            }
        }

        // Xóa dữ liệu
        public void DeleteData(DTO_KhachHang ex)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM KhachHang WHERE Id=@id";
                cmd.Parameters.AddWithValue("@id", ex.Id);
                cmd.ExecuteNonQuery();
            }
        }

        // Lấy dữ liệu (có thể kèm điều kiện)
        public DataTable GetData()
        {
            var dt = new DataTable();
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"
                    SELECT 
                        Id, 
                        TenKhachHang, 
                        DiaChi, 
                        DienThoai, 
                        MaCode, 
                        Email, 
                        CASE GioiTinh
                            WHEN 1 THEN 'Nam'
                            WHEN 2 THEN 'Nữ'
                            WHEN 3 THEN 'Khác'
                            ELSE ''
                        END AS GioiTinh
                    FROM KhachHang";

                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        // Tìm kiếm khách hàng theo tên
        public DataTable SearchKH(string keyword)
        {
            var dt = new DataTable();
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"
                    SELECT 
                        Id, 
                        TenKhachHang, 
                        DiaChi, 
                        DienThoai, 
                        MaCode, 
                        Email, 
                        CASE GioiTinh
                            WHEN 1 THEN 'Nam'
                            WHEN 2 THEN 'Nữ'
                            WHEN 3 THEN 'Khác'
                            ELSE ''
                        END AS GioiTinh 
                        FROM KhachHang 
                        WHERE TenKhachHang LIKE @kw";
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        public bool ExitMaCode(string maCode)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(1) FROM KhachHang WHERE MaCode = @MaCode";
                    cmd.Parameters.AddWithValue("@MaCode", maCode);

                    var count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
