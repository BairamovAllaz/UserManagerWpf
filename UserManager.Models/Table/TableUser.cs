using System.Data;
using UserManager.Models.TableBase;
namespace UserManager.Models.Table;
public class TableUser : Db,IGetTable<User>,IAddToTable<User>
{
    public List<User> GetTable()
    {
        var list = new List<User>();
        var sql = "SELECT * FROM table_user";
        Query(sql);
        if (_result.HasRows)
        {
            while (_result.Read())
            {
                list.Add(new User
                {
                    Id = _result.GetInt32("user_id"),
                    FirstName = _result.GetString("first_name"), 
                    LastName = _result.GetString("last_name"),
                    Email = _result.GetString("email"),
                    PhotoUrl = _result.GetString("photo"),
                });
            }
        }
        _db.Close();
        return list; 
    }

    public void AddToTable(User obj)
    {
        var sql = $"INSERT INTO table_user (user_id,first_name,last_name,email,photo) VALUES ('{obj.Id}','{obj.FirstName}','{obj.LastName}','{obj.Email}','{obj.PhotoUrl}')";
        NoQuery(sql);
    }
}