namespace DAL
{
    public class DTO_PhieuNhapKho
    {
        public int Id { get; set; }

        public string? MaPhieu { get; set; }

        public DateTime NgayNhap { get; set; }

        public string? NhaCungCap {  get; set; }

        public string? NhanVienNhap { get; set; }

        public decimal TongTien { get; set; }

        public string? GhiChu { get; set; }

        public DateTime NgayTao { get; set; } = DateTime.Now;

        public DateTime NgayCapNhat { get; set; } = DateTime.Now;

        public ICollection<DTO_ChiTietPhieuNhap> chiTietPhieuNhaps { get; set; }
    }
}
