using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhachHang
    {
        public int Id { get; set; }                  // Mã khách hàng (PK, tự tăng)
        public string MaCode { get; set; }           // Mã khách hàng duy nhất
        public string TenKhachHang { get; set; }     // Tên khách hàng
        public string DiaChi { get; set; }           // Địa chỉ
        public string DienThoai { get; set; }        // Số điện thoại
        public string Email { get; set; }            // Email (duy nhất)
        public int GioiTinh { get; set; }            // 1 = Nam, 2 = Nữ, 3 = Khác
        public int TrangThai { get; set; }           // 1 = Hoạt động, 0 = Ngừng
        public DateTime NgayTao { get; set; }        // Ngày tạo
        public DateTime NgayCapNhat { get; set; }
    }
}
