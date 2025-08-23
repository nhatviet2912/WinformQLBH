using DTO;
using System.Data;

namespace DAL
{
    public class DAL_LoaiSanPham
    {
        // THÊM DỮ LIỆU
        public void AddData(DTO_LoaiSanPham ex)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"INSERT INTO LoaiSanPham 
                    (TenLoai, MoTa) VALUES (@TenLoai, @MoTa)";
                cmd.Parameters.AddWithValue("@TenLoai", ex.TenLoai);
                cmd.Parameters.AddWithValue("@MoTa", ex.MoTa);
                cmd.ExecuteNonQuery();
            }
        }

        // Sửa dữ liệu
        public void EditData(DTO_LoaiSanPham ex)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE LoaiSanPham SET TenLoai=@TenLoai, MoTa=@MoTa WHERE Id=@Id";
                cmd.Parameters.AddWithValue("@TenLoai", ex.TenLoai);
                cmd.Parameters.AddWithValue("@MoTa", ex.MoTa ?? "");
                cmd.Parameters.AddWithValue("@Id", ex.Id);
                cmd.ExecuteNonQuery();
            }
        }

        // Xóa dữ liệu
        public void DeleteData(DTO_LoaiSanPham ex)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM LoaiSanPham WHERE Id=@id";
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
                        TenLoai, 
                        MoTa,
                        NgayTao
                    FROM LoaiSanPham";

                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        // Tìm kiếm khách hàng theo tên
        public DataTable Search(string keyword)
        {
            var dt = new DataTable();
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"
                    SELECT 
                        Id, 
                        TenLoai, 
                        MoTa,
                        NgayTao
                        FROM LoaiSanPham 
                        WHERE TenLoai LIKE @kw";
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }
    }
}
