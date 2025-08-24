using DAL;

namespace DTO
{
    public class DTO_ChiTietHoaDonBan
    {
        public int Id { get; set; }
        public int HoaDonBanId { get; set; }
        public int SanPhamId { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

        public virtual DTO_SanPham DTO_SanPham { get; set; }
    }
}
