namespace DAL
{
    public class DTO_ChiTietPhieuNhap
    {
        public int Id { get; set; }

        public int PhieuNhapKhoId { get; set; }

        public int SanPhamId { get; set; }

        public int SoLuong { get; set; }

        public decimal DonGiaNhap { get; set; }

        public decimal ThanhTien { get; set; }

        public virtual DTO_PhieuNhapKho? PhieuNhapKho { get; set; }

        public virtual DTO_SanPham? SanPham { get; set; }
    }
}
