using DTO;
using System.Data;
using System.Reflection.Emit;

namespace DAL
{
    public class DAL_PhieuNhapKho
    {
        // THÊM DỮ LIỆU
        public void AddData(DTO_PhieuNhapKho ex)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Insert phiếu nhập
                        var cmd = conn.CreateCommand();
                        cmd.Transaction = tran;
                        cmd.CommandText = @"INSERT INTO PhieuNhapKho 
                            (MaPhieu, NgayNhap, NhaCungCap, NhanVienNhap, TongTien, GhiChu) 
                            VALUES (@MaPhieu, @NgayNhap, @NCC, @NV, @TongTien, @GhiChu)";
                        cmd.Parameters.AddWithValue("@MaPhieu", ex.MaPhieu);
                        cmd.Parameters.AddWithValue("@NgayNhap", ex.NgayNhap);
                        cmd.Parameters.AddWithValue("@NCC", ex.NhaCungCap ?? "");
                        cmd.Parameters.AddWithValue("@NV", ex.NhanVienNhap ?? "");
                        cmd.Parameters.AddWithValue("@TongTien", ex.TongTien);
                        cmd.Parameters.AddWithValue("@GhiChu", ex.GhiChu ?? "");
                        cmd.ExecuteNonQuery();

                        var cmdGetId = conn.CreateCommand();
                        cmdGetId.Transaction = tran;
                        cmdGetId.CommandText = "SELECT last_insert_rowid();";
                        long phieuNhapId = (long)(long)cmdGetId.ExecuteScalar();

                        var cmdGetMa = conn.CreateCommand();
                        cmdGetMa.Transaction = tran;
                        cmdGetMa.CommandText = "SELECT MaPhieu FROM PhieuNhapKho WHERE Id = @id";
                        cmdGetMa.Parameters.AddWithValue("@id", phieuNhapId);
                        string maPhieuVuaThem = (string)cmdGetMa.ExecuteScalar();

                        // 2. Insert chi tiết
                        foreach (var ct in ex.chiTietPhieuNhaps)
                        {
                            var cmdCt = conn.CreateCommand();
                            cmdCt.Transaction = tran;
                            cmdCt.CommandText = @"INSERT INTO ChiTietPhieuNhap 
                                (PhieuNhapKhoId, SanPhamId, SoLuong, DonGiaNhap) 
                                VALUES (@PhieuNhapKhoId, @SanPhamId, @SoLuong, @DonGiaNhap)";
                            cmdCt.Parameters.AddWithValue("@PhieuNhapKhoId", phieuNhapId);
                            cmdCt.Parameters.AddWithValue("@SanPhamId", ct.SanPhamId);
                            cmdCt.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                            cmdCt.Parameters.AddWithValue("@DonGiaNhap", ct.DonGiaNhap);
                            cmdCt.ExecuteNonQuery();

                            // 3. Update tồn kho
                            var cmdTon = conn.CreateCommand();
                            cmdTon.Transaction = tran;
                            cmdTon.CommandText = @"
                                INSERT INTO TonKho (SanPhamId, SoLuong)
                                VALUES (@SanPhamId, @SoLuong)
                                ON CONFLICT(SanPhamId) 
                                DO UPDATE SET SoLuong = SoLuong + @SoLuong";
                            cmdTon.Parameters.AddWithValue("@SanPhamId", ct.SanPhamId);
                            cmdTon.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                            cmdTon.ExecuteNonQuery();
                        }

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        // Sửa dữ liệu
        public void EditData(DTO_PhieuNhapKho ex)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "UPDATE PhieuNhapKho SET TenPhieuNhapKho=@ten, DiaChi=@diachi, DienThoai=@dt WHERE Id=@id";
                cmd.Parameters.AddWithValue("@id", ex.Id);
                cmd.ExecuteNonQuery();
            }
        }

        // Xóa dữ liệu
        public void DeleteData(DTO_PhieuNhapKho ex)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "DELETE FROM PhieuNhapKho WHERE Id=@id";
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
                        TenPhieuNhapKho, 
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
                    FROM PhieuNhapKho";

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
                        TenPhieuNhapKho, 
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

        public string GetMaCodeAuto()
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT MaPhieu FROM PhieuNhapKho ORDER BY Id DESC LIMIT 1";

                    var result = cmd.ExecuteScalar();
                    return result == null || result == DBNull.Value ? null : result.ToString();
                }
            }
        }
    }
}
