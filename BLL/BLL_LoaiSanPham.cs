using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class BLL_LoaiSanPham
    {
        DAL_LoaiSanPham bus = new DAL_LoaiSanPham();
        public void AddData(DTO_LoaiSanPham ex)
        {
            bus.AddData(ex);
        }
        //  SỬA DỮ LIỆU
        public void EditData(DTO_LoaiSanPham ex)
        {
            bus.EditData(ex);
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(DTO_LoaiSanPham ex)
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
    }
}
