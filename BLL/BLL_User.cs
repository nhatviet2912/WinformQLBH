using DAL;
using DTO;

namespace BLL
{
    public class BLL_User
    {
        private DAL_User dal = new DAL_User();

        public List<DTO_User> GetAllUsers()
        {
            return dal.GetAll();
        }

        public void AddUser(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                var user = new DTO_User { Name = name };
                dal.Insert(user);
            }
        }
    }
}
