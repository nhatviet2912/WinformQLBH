namespace DAL
{
    public class DTO_TonKho
    {
        public int Id { get; set; }

        public int SanPhamId { get; set; }

        public int SoLuong { get; set; }

        public virtual DTO_SanPham? SanPham { get; set; }
    }
}
