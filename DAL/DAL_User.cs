using DTO;
using Microsoft.Data.Sqlite;

namespace DAL
{
    public class DAL_User
    {
        public DAL_User()
        {
            DatabaseHelper.InitDatabase();
        }

        public List<DTO_User> GetAll()
        {
            var list = new List<DTO_User>();
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT Id, Name FROM Users";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new DTO_User
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
            }
            return list;
        }

        public void Insert(DTO_User user)
        {
            using (var connection = DatabaseHelper.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO Users (Name) VALUES (@name)";
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
