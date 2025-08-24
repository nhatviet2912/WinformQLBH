using DTO;
using System.Data;
using System.Reflection.Emit;

namespace DAL
{
    public class DAL_HoaDonBan
    {
        // THÊM DỮ LIỆU
        public void AddData(DTO_HoaDonBan ex)
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
                        cmd.CommandText = @"INSERT INTO HoaDonBan 
                            (MaHoaDon, NgayBan, KhachHangId, NhanVienBan, TongTien) 
                            VALUES (@MaHoaDon, @NgayBan, @KhachHangId, @NhanVienBan, @TongTien)";
                        cmd.Parameters.AddWithValue("@MaHoaDon", ex.MaHoaDon);
                        cmd.Parameters.AddWithValue("@NgayBan", ex.NgayBan);
                        cmd.Parameters.AddWithValue("@KhachHangId", ex.KhachHangId ?? "");
                        cmd.Parameters.AddWithValue("@NhanVienBan", ex.NhanVienBan ?? "");
                        cmd.Parameters.AddWithValue("@TongTien", ex.TongTien);
                        cmd.ExecuteNonQuery();

                        var cmdGetId = conn.CreateCommand();
                        cmdGetId.Transaction = tran;
                        cmdGetId.CommandText = "SELECT last_insert_rowid();";
                        long phieuNhapId = (long)(long)cmdGetId.ExecuteScalar();

                        var cmdGetMa = conn.CreateCommand();
                        cmdGetMa.Transaction = tran;
                        cmdGetMa.CommandText = "SELECT MaHoaDon FROM HoaDonBan WHERE Id = @id";
                        cmdGetMa.Parameters.AddWithValue("@id", phieuNhapId);
                        string maPhieuVuaThem = (string)cmdGetMa.ExecuteScalar();

                        // 2. Insert chi tiết
                        foreach (var ct in ex.chiTietHoaDonBans)
                        {
                            var cmdCt = conn.CreateCommand();
                            cmdCt.Transaction = tran;
                            cmdCt.CommandText = @"INSERT INTO ChiTietHoaDonBan 
                                (HoaDonBanId, SanPhamId, SoLuong, DonGia) 
                                VALUES (@HoaDonBanId, @SanPhamId, @SoLuong, @DonGia)";
                            cmdCt.Parameters.AddWithValue("@HoaDonBanId", phieuNhapId);
                            cmdCt.Parameters.AddWithValue("@SanPhamId", ct.SanPhamId);
                            cmdCt.Parameters.AddWithValue("@SoLuong", ct.SoLuong);
                            cmdCt.Parameters.AddWithValue("@DonGia", ct.DonGia);
                            cmdCt.ExecuteNonQuery();

                            // 3. Update tồn kho
                            var cmdTon = conn.CreateCommand();
                            cmdTon.Transaction = tran;
                            cmdTon.CommandText = @"
                                INSERT INTO TonKho (SanPhamId, SoLuong)
                                VALUES (@SanPhamId, @SoLuong)
                                ON CONFLICT(SanPhamId) 
                                DO UPDATE SET SoLuong = SoLuong - @SoLuong";
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
                        HoaDonBan.Id AS HoaDonBanId, 
                        HoaDonBan.MaHoaDon, 
                        HoaDonBan.NgayBan, 
                        HoaDonBan.NhanVienBan, 
                        HoaDonBan.TongTien,
                        KhachHang.TenKhachHang
                    FROM HoaDonBan
                    INNER JOIN KhachHang ON HoaDonBan.KhachHangId = KhachHang.Id";

                dt.Columns.Add("HoaDonBanId", typeof(int));
                dt.Columns.Add("MaHoaDon", typeof(string));
                dt.Columns.Add("NgayBan", typeof(DateTime));
                dt.Columns.Add("TenKhachHang", typeof(string));
                dt.Columns.Add("NhanVienBan", typeof(string));
                dt.Columns.Add("TongTien", typeof(decimal));

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dt.Rows.Add(
                            reader["HoaDonBanId"],
                            reader["MaHoaDon"],
                            reader["NgayBan"],
                            reader["TenKhachHang"],
                            reader["NhanVienBan"],
                            reader["TongTien"]
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
                        ChiTietHoaDonBan.SoLuong, 
                        ChiTietHoaDonBan.DonGia, 
                        ChiTietHoaDonBan.ThanhTien, 
                        SanPham.MaSanPham, 
                        SanPham.TenSanPham,
                        SanPham.ThuongHieu,
                        SanPham.XuatXu,
                        HoaDonBan.TongTien
                    FROM ChiTietHoaDonBan
                    INNER JOIN SanPham ON ChiTietHoaDonBan.SanPhamId = SanPham.Id
                    INNER JOIN HoaDonBan ON ChiTietHoaDonBan.HoaDonBanId = HoaDonBan.Id
                    WHERE ChiTietHoaDonBan.HoaDonBanId = @id";
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
                    cmd.CommandText = "SELECT MaHoaDon FROM HoaDonBan ORDER BY Id DESC LIMIT 1";

                    var result = cmd.ExecuteScalar();
                    return result == null || result == DBNull.Value ? null : result.ToString();
                }
            }
        }
    }
}
