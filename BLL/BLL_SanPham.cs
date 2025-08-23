using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class BLL_SanPham
    {
        DAL_SanPham bus = new DAL_SanPham();
        public void AddData(DTO_SanPham ex)
        {
            bus.AddData(ex);
        }
        //  SỬA DỮ LIỆU
        public void EditData(DTO_SanPham ex)
        {
            bus.EditData(ex);
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(DTO_SanPham ex)
        {
            bus.DeleteData(ex);
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData()
        {
            return bus.GetData();
        }
        public DataTable Search(string Condition)
        {
            return bus.Search(Condition);
        }

        public bool ExitCode (string maSp, int Id)
        {
            return bus.ExitMaCode(maSp, Id);
        }
    }
}
