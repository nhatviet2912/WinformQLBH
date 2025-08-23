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
    PhieuNhapKho.Id AS PhieuNhapId, 
    PhieuNhapKho.MaPhieu, 
    PhieuNhapKho.NgayNhap, 
    PhieuNhapKho.NhaCungCap, 
    PhieuNhapKho.NhanVienNhap, 
    PhieuNhapKho.TongTien,
    PhieuNhapKho.GhiChu
FROM PhieuNhapKho";

                dt.Columns.Add("PhieuNhapId", typeof(int));
                dt.Columns.Add("MaPhieu", typeof(string));
                dt.Columns.Add("NgayNhap", typeof(DateTime));
                dt.Columns.Add("NhaCungCap", typeof(string));
                dt.Columns.Add("NhanVienNhap", typeof(string));
                dt.Columns.Add("TongTien", typeof(decimal));
                dt.Columns.Add("GhiChu", typeof(string));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dt.Rows.Add(
                            reader["PhieuNhapId"],
                            reader["MaPhieu"],
                            reader["NgayNhap"],
                            reader["NhaCungCap"],
                            reader["NhanVienNhap"],
                            reader["TongTien"],
                            reader["GhiChu"]
                        );
                    }
                }
            }
            return dt;
        }

        // Lấy dữ liệu (có thể kèm điều kiện)
        public DataTable GetDetailData(string id)
        {
            var dt = new DataTable();
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"
                    SELECT 
                        ChiTietPhieuNhap.SoLuong, 
                        ChiTietPhieuNhap.DonGiaNhap, 
                        ChiTietPhieuNhap.ThanhTien, 
                        SanPham.MaSanPham, 
                        SanPham.TenSanPham,
                        SanPham.ThuongHieu,
                        SanPham.XuatXu,
                        PhieuNhapKho.TongTien
                    FROM ChiTietPhieuNhap
                    INNER JOIN SanPham ON ChiTietPhieuNhap.SanPhamId = SanPham.Id
                    INNER JOIN PhieuNhapKho ON ChiTietPhieuNhap.PhieuNhapKhoId = PhieuNhapKho.Id
                    WHERE ChiTietPhieuNhap.PhieuNhapKhoId = @id";
                cmd.Parameters.AddWithValue("@id", id);

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
                        PhieuNhapKho.Id AS PhieuNhapId, 
                        PhieuNhapKho.MaPhieu, 
                        PhieuNhapKho.NgayNhap, 
                        PhieuNhapKho.NhaCungCap, 
                        PhieuNhapKho.NhanVienNhap, 
                        PhieuNhapKho.TongTien,
                        PhieuNhapKho.GhiChu,
                        ChiTietPhieuNhap.Id AS ChiTietId
                    FROM PhieuNhapKho
                    INNER JOIN ChiTietPhieuNhap ON PhieuNhapKho.Id = ChiTietPhieuNhap.PhieuNhapKhoId
                    INNER JOIN SanPham ON ChiTietPhieuNhap.SanPhamId = SanPham.Id
                    WHERE MaPhieu LIKE @kw";
                cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                using (var reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
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
