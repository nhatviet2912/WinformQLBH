using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class BLL_TonKho
    {
        DAL_TonKho bus = new DAL_TonKho();
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
