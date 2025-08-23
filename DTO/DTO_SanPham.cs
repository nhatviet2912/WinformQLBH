namespace DAL
{
    public class DTO_SanPham
    {
        public int Id { get; set; }

        public string? MaSanPham { get; set; }

        public string TenSanPham { get; set; } = string.Empty;

        public string? MoTa { get; set; }

        public decimal GiaBan { get; set; }

        public string? DonViTinh { get; set; }

        public int LoaiSanPhamId { get; set; }

        public string? ThuongHieu { get; set; }

        public string? XuatXu { get; set; }

        public int TrangThai { get; set; } = 1;

        public DateTime NgayTao { get; set; } = DateTime.Now;

        public DateTime NgayCapNhat { get; set; } = DateTime.Now;

        public virtual DTO_LoaiSanPham? LoaiSanPham { get; set; }
    }
}
