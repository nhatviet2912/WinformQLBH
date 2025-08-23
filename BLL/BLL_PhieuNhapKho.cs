using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class BLL_PhieuNhapKho
    {
        DAL_PhieuNhapKho bus = new DAL_PhieuNhapKho();
        public void AddData(DTO_PhieuNhapKho ex)
        {
            bus.AddData(ex);
        }
        //  SỬA DỮ LIỆU
        public void EditData(DTO_PhieuNhapKho ex)
        {
            bus.EditData(ex);
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(DTO_PhieuNhapKho ex)
        {
            bus.DeleteData(ex);
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData()
        {
            return bus.GetData();
        }

        public bool ExitMaCode (string maCode)
        {
            return bus.ExitMaCode(maCode);
        }

        public string GetMaCodeAuto() {
            string lastCode = bus.GetMaCodeAuto(); // gọi DAL

            if (string.IsNullOrEmpty(lastCode))
            {
                return "PN0001"; // Nếu chưa có dữ liệu thì khởi tạo mã đầu tiên
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
