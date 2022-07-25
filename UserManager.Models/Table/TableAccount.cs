using System.Data;
using UserManager.Models.TableBase;
namespace UserManager.Models.Table;
public class TableAccount : Db,IGetTable<Account>,IAddToTable<Account>
{
    public TableAccount() : base()
    {
    }
    public List<Account> GetTable()
    {
        var list = new List<Account>();
        var sql = "SELECT * FROM table_account";
        Query(sql);
        if (_result.HasRows)
        {
            while (_result.Read())
            {
                list.Add(new Account
                {
                    Id = _result.GetInt32("account_id"),
                    Login = _result.GetString("login"),
                    Password = _result.GetString("password"),
                    RoleId = _result.GetInt32("role_id"),
                    IsActive = _result.GetBoolean("is_active")
                });
            }
        }
        _db.Close();
        return list; 
    }

    public void AddToTable(Account obj)
    {
        var sql = $"INSERT INTO table_account (login,password,role_id) VALUES ('{obj.Login}','{obj.Password}','{obj.RoleId}')";
        NoQuery(sql);
    }
}