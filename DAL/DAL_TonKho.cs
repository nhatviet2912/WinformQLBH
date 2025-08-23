using DTO;
using System.Data;

namespace DAL
{
    public class DAL_TonKho
    {
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
                    SanPham.MaSanPham, 
                    SanPham.TenSanPham, 
                    SanPham.MoTa AS MoTa, 
                    SanPham.GiaBan, 
                    SanPham.DonViTinh, 
                    SanPham.ThuongHieu, 
                    SanPham.XuatXu, 
                    LoaiSanPham.TenLoai AS LoaiSanPhamTen,
                    TonKho.SoLuong AS SoLuong,
                    SanPham.LoaiSanPhamId
                FROM TonKho
                INNER JOIN SanPham ON TonKho.SanPhamId = SanPham.Id
                INNER JOIN LoaiSanPham ON SanPham.LoaiSanPhamId = LoaiSanPham.Id
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
                    SanPham.MaSanPham, 
                    SanPham.TenSanPham, 
                    SanPham.MoTa AS MoTa, 
                    SanPham.GiaBan, 
                    SanPham.DonViTinh, 
                    SanPham.ThuongHieu, 
                    SanPham.XuatXu, 
                    LoaiSanPham.TenLoai AS LoaiSanPhamTen,
                    TonKho.SoLuong AS SoLuong,
                    SanPham.LoaiSanPhamId
                FROM TonKho
                INNER JOIN SanPham ON TonKho.SanPhamId = SanPham.Id
                INNER JOIN LoaiSanPham ON SanPham.LoaiSanPhamId = LoaiSanPham.Id
                WHERE SanPham.TrangThai = 1 AND (TenSanPham LIKE @kw OR MaSanPham LIKE @kw)";
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
