using System.Text.RegularExpressions;

namespace QuanLyBanHang.Helper
{
    public static class Helper
    {
        public static bool ValidateEmail (string email)
        {
            // Regex kiểm tra định dạng email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
    }
}
