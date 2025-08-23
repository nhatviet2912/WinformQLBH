namespace DAL
{
    public class DTO_LoaiSanPham
    {
        public int Id { get; set; }

        public string TenLoai { get; set; } = string.Empty;

        public string? MoTa { get; set; }

        public DateTime NgayTao { get; set; } = DateTime.Now;

        public DateTime NgayCapNhat { get; set; } = DateTime.Now;

        public virtual ICollection<DTO_SanPham> SanPhams { get; set; } = new List<DTO_SanPham>();
    }
}
