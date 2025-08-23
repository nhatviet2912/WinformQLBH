using DTO;
using System.Data;

namespace DAL
{
    public class DAL_SanPham
    {
        public void AddData(DTO_SanPham ex)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"
                INSERT INTO SanPham 
                (MaSanPham, TenSanPham, MoTa, GiaBan, DonViTinh, LoaiSanPhamId, ThuongHieu, XuatXu, TrangThai) 
                VALUES 
                (@MaSanPham, @TenSanPham, @MoTa, @GiaBan, @DonViTinh, @LoaiSanPhamId, @ThuongHieu, @XuatXu, @TrangThai)";

                cmd.Parameters.AddWithValue("@MaSanPham", ex.MaSanPham ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TenSanPham", ex.TenSanPham);
                cmd.Parameters.AddWithValue("@MoTa", ex.MoTa ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GiaBan", ex.GiaBan);
                cmd.Parameters.AddWithValue("@DonViTinh", ex.DonViTinh ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@LoaiSanPhamId", ex.LoaiSanPhamId);
                cmd.Parameters.AddWithValue("@ThuongHieu", ex.ThuongHieu ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@XuatXu", ex.XuatXu ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TrangThai", ex.TrangThai);

                cmd.ExecuteNonQuery();
            }
        }

        // SỬA DỮ LIỆU
        public void EditData(DTO_SanPham ex)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"
                UPDATE SanPham SET 
                    MaSanPham=@MaSanPham, 
                    TenSanPham=@TenSanPham, 
                    MoTa=@MoTa,
                    GiaBan=@GiaBan, 
                    DonViTinh=@DonViTinh, 
                    LoaiSanPhamId=@LoaiSanPhamId,
                    ThuongHieu=@ThuongHieu,
                    XuatXu=@XuatXu,
                    TrangThai=@TrangThai,
                    NgayCapNhat=CURRENT_TIMESTAMP
                WHERE Id=@Id";

                cmd.Parameters.AddWithValue("@MaSanPham", ex.MaSanPham ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TenSanPham", ex.TenSanPham);
                cmd.Parameters.AddWithValue("@MoTa", ex.MoTa ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GiaBan", ex.GiaBan);
                cmd.Parameters.AddWithValue("@DonViTinh", ex.DonViTinh ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@LoaiSanPhamId", ex.LoaiSanPhamId);
                cmd.Parameters.AddWithValue("@ThuongHieu", ex.ThuongHieu ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@XuatXu", ex.XuatXu ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TrangThai", ex.TrangThai);
                cmd.Parameters.AddWithValue("@Id", ex.Id);

                cmd.ExecuteNonQuery();
            }
        }

        // XÓA DỮ LIỆU
        public void DeleteData(DTO_SanPham ex)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE SanPham SET TrangThai = 0 WHERE Id=@Id";
                cmd.Parameters.AddWithValue("@Id", ex.Id);
                cmd.ExecuteNonQuery();
            }
        }

        // LẤY TOÀN BỘ DỮ LIỆU
        public DataTable GetData()
        {
            var dt = new DataTable();
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"
                SELECT 
                    SanPham.Id AS Id, 
                    SanPham.MaSanPham, 
                    SanPham.TenSanPham, 
                    SanPham.MoTa AS MoTa, 
                    SanPham.GiaBan, 
                    SanPham.DonViTinh, 
                    SanPham.ThuongHieu, 
                    SanPham.XuatXu, 
                    SanPham.NgayTao,
                    SanPham.LoaiSanPhamId,
                    LoaiSanPham.TenLoai AS LoaiSanPhamTen
                FROM SanPham
                LEFT JOIN LoaiSanPham ON SanPham.LoaiSanPhamId = LoaiSanPham.Id
                WHERE SanPham.TrangThai = 1";

                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        // TÌM KIẾM SẢN PHẨM THEO TÊN
        public DataTable Search(string keyword)
        {
            var dt = new DataTable();
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"
                SELECT 
                    SanPham.Id AS Id, 
                    SanPham.MaSanPham, 
                    SanPham.TenSanPham, 
                    SanPham.MoTa AS MoTa, 
                    SanPham.GiaBan, 
                    SanPham.DonViTinh, 
                    SanPham.ThuongHieu, 
                    SanPham.XuatXu, 
                    SanPham.NgayTao,
                    SanPham.LoaiSanPhamId,
                    LoaiSanPham.TenLoai AS LoaiSanPhamTen
                FROM SanPham
                LEFT JOIN LoaiSanPham ON SanPham.LoaiSanPhamId = LoaiSanPham.Id
                WHERE SanPham.TrangThai = 1 AND TenSanPham LIKE @kw";
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        public bool ExitMaCode(string maSp, int id)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    if (id == 0) // trường hợp thêm mới
                    {
                        cmd.CommandText = "SELECT COUNT(1) FROM SanPham WHERE MaSanPham = @MaSanPham";
                    }
                    else // trường hợp sửa -> loại trừ sản phẩm đang sửa
                    {
                        cmd.CommandText = "SELECT COUNT(1) FROM SanPham WHERE MaSanPham = @MaSanPham AND Id <> @Id";
                        cmd.Parameters.AddWithValue("@Id", id);
                    }

                    cmd.Parameters.AddWithValue("@MaSanPham", maSp);

                    var count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
