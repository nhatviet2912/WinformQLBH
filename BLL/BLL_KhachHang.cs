using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class BLL_KhachHang
    {
        DAL_KhachHang bus = new DAL_KhachHang();
        public void AddData(DTO_KhachHang ex)
        {
            bus.AddData(ex);
        }
        //  SỬA DỮ LIỆU
        public void EditData(DTO_KhachHang ex)
        {
            bus.EditData(ex);
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(DTO_KhachHang ex)
        {
            bus.DeleteData(ex);
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData()
        {
            return bus.GetData();
        }
        public DataTable SearchKH(string Condition)
        {
            return bus.SearchKH(Condition);
        }

        public bool ExitMaCode (string maCode)
        {
            return bus.ExitMaCode(maCode);
        }
    }
}
