using Microsoft.Data.Sqlite;
using System.Data;
using UserManager.Models.Table;
using UserManager.Models.TableBase;
namespace UserManager.Models.Table;
public class TableRole : Db,IGetTable<Role>,IAddToTable<Role>
{
    public TableRole() : base()
    {
    }
    public List<Role> GetTable()
    {
        var list = new List<Role>();
        var sql = "SELECT * FROM table_role";
        Query(sql);
        if (_result.HasRows)
        {
            while (_result.Read())
            {
                list.Add(new Role
                {
                    Id = _result.GetInt32("role_id"),
                    Name = _result.GetString("role_name")
                });    
            }
        }
        _db.Close();
        return list;
    }

    public int AddToTable(Role obj)
    {
        var sql = $"INSERT INTO table_role (role_id,role_name) VALUES ('{obj.Id}','{obj.Name}')";
        return NoQuery(sql);
    }
}