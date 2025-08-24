using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class BLL_HoaDonBan
    {
        DAL_HoaDonBan bus = new DAL_HoaDonBan();
        public void AddData(DTO_HoaDonBan ex)
        {
            bus.AddData(ex);
        }
        public DataTable GetData()
        {
            return bus.GetData();
        }

        public DataTable GetDetailData(string Id)
        {
            return bus.GetDetailData(Id);
        }

        public DataTable Search (string condition)
        {
            return bus.SearchKH(condition);
        }

        public string GetMaCodeAuto() {
            string lastCode = bus.GetMaCodeAuto(); // gọi DAL

            if (string.IsNullOrEmpty(lastCode))
            {
                return "HDB0001"; // Nếu chưa có dữ liệu thì khởi tạo mã đầu tiên
            }

            // Tách tiền tố + phần số
            string prefix = new string(lastCode.TakeWhile(c => !char.IsDigit(c)).ToArray());
            string numberPart = new string(lastCode.SkipWhile(c => !char.IsDigit(c)).ToArray());

            if (int.TryParse(numberPart, out int num))
            {
                return $"{prefix}{(num + 1).ToString("D4")}";
                // VD: PN0001 → PN0002
            }
            else
            {
                return prefix + "0001";
            }
        }
    }
}
