using Microsoft.Data.Sqlite;

namespace DAL
{
    public partial class DatabaseHelper
    {
        private static readonly string dbFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "QuanLyBanHang"
        );
        private static readonly string dbPath = Path.Combine(dbFolder, "data.db");
        private static readonly string connectionString = $"Data Source={dbPath}";

        public static SqliteConnection GetConnection() => new SqliteConnection(connectionString);

        public static void InitDatabase()
        {
            // tạo thư mục nếu chưa có
            if (!Directory.Exists(dbFolder))
                Directory.CreateDirectory(dbFolder);

            using (var connection = GetConnection())
            {
                connection.Open();
                var tableCmd = connection.CreateCommand();
                tableCmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS LoaiSanPham (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        TenLoai TEXT NOT NULL UNIQUE,       -- Ví dụ: Quần áo, Điện thoại, Mỹ phẩm
                        MoTa TEXT,
                        NgayTao DATETIME DEFAULT CURRENT_TIMESTAMP,
                        NgayCapNhat DATETIME DEFAULT CURRENT_TIMESTAMP
                    );

                    CREATE TABLE IF NOT EXISTS SanPham (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        MaSanPham TEXT UNIQUE,              
                        TenSanPham TEXT NOT NULL,           
                        MoTa TEXT,                          
                        GiaBan DECIMAL(15,2) NOT NULL,      
                        DonViTinh TEXT,                     
                        LoaiSanPhamId INT NOT NULL,
                        ThuongHieu NVARCHAR(100),
                        XuatXu NVARCHAR(100),
                        TrangThai INTEGER DEFAULT 1,        
                        NgayTao DATETIME DEFAULT CURRENT_TIMESTAMP,
                        NgayCapNhat DATETIME DEFAULT CURRENT_TIMESTAMP,
                        FOREIGN KEY (LoaiSanPhamId) REFERENCES LoaiSanPham(Id)
                    );

                    CREATE TABLE IF NOT EXISTS KhachHang (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        MaCode TEXT UNIQUE,
                        TenKhachHang TEXT NOT NULL,
                        DiaChi TEXT,
                        DienThoai TEXT,
                        Email TEXT UNIQUE,
                        GioiTinh INTEGER ,
                        TrangThai INTEGER DEFAULT 1,
                        NgayTao DATETIME DEFAULT CURRENT_TIMESTAMP,
                        NgayCapNhat DATETIME DEFAULT CURRENT_TIMESTAMP
                    );

                    CREATE TABLE IF NOT EXISTS PhieuNhapKho (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        MaPhieu TEXT NOT NULL UNIQUE,
                        NgayNhap DATETIME DEFAULT CURRENT_TIMESTAMP,
                        NhaCungCap TEXT,
                        NhanVienNhap TEXT,
                        TongTien DECIMAL(18,2) DEFAULT 0,
                        GhiChu TEXT,
                        NgayTao DATETIME DEFAULT CURRENT_TIMESTAMP,
                        NgayCapNhat DATETIME DEFAULT CURRENT_TIMESTAMP
                    );

                    CREATE TABLE IF NOT EXISTS ChiTietPhieuNhap (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        PhieuNhapKhoId INT NOT NULL,
                        SanPhamId INT NOT NULL,
                        SoLuong INT NOT NULL,
                        DonGiaNhap DECIMAL(18,2) NOT NULL,
                        ThanhTien DECIMAL(18,2) GENERATED ALWAYS AS (SoLuong * DonGiaNhap) VIRTUAL, 
                        FOREIGN KEY (PhieuNhapKhoId) REFERENCES PhieuNhapKho(Id),
                        FOREIGN KEY (SanPhamId) REFERENCES SanPham(Id)
                    );

                    CREATE TABLE IF NOT EXISTS TonKho (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        SanPhamId INT NOT NULL UNIQUE,
                        SoLuong INT NOT NULL DEFAULT 0,
                        FOREIGN KEY (SanPhamId) REFERENCES SanPham(Id)
                    );";
                tableCmd.ExecuteNonQuery();
            }
        }
    }
}
