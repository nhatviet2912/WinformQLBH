namespace DTO
{
    public class DTO_HoaDonBan
    {
        public int Id { get; set; }
        public string MaHoaDon { get; set; }
        public DateTime NgayBan { get; set; }
        public string KhachHangId { get; set; }
        public string NhanVienBan { get; set; }
        public decimal TongTien { get; set; }
        public int TrangThai { get; set; }

        public virtual ICollection<DTO_ChiTietHoaDonBan> chiTietHoaDonBans { get; set; }
    }
}
