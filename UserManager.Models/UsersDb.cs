using System.Data;
using Microsoft.Data.Sqlite;
namespace UserManager.Models;
public class UsersDb
{
    private const string conn = @"Data Source=user.db;";
    public List<Role> TableRole { get; set; }
    public List<Account> TableAccount { get; set; }
    public List<User> TableUser { get; set; }
    public UsersDb()
    {
        TableRole = GetTableRole();
        TableAccount = GetTableAccount();
        TableUser = GetTableUser();
    }
    private SqliteDataReader Query(string sql,out SqliteConnection db)
    {
        db = new SqliteConnection(conn);
        db.Open();
        var command = new SqliteCommand(sql, db);
        return command.ExecuteReader();
    }
    public List<Role> GetTableRole()
    {
        var list = new List<Role>();
        var sql = "SELECT * FROM table_role";
        var result = Query(sql,out var db);
        if (result.HasRows)
        {
            while (result.Read())
            {
                list.Add(new Role
                {
                    Id = result.GetInt32("role_id"),
                    Name = result.GetString("role_name")
                });    
            }
        }
        db.Close();
        return list;
    }

    public List<Account> GetTableAccount()
    {
        var list = new List<Account>();
        var sql = "SELECT * FROM table_account";
        var result = Query(sql,out var db);
        if (result.HasRows)
        {
            while (result.Read())
            {
                list.Add(new Account
                {
                    Id = result.GetInt32("account_id"),
                    Login = result.GetString("login"),
                    Password = result.GetString("password"),
                    RoleId = result.GetInt32("role_id"),
                    IsActive = result.GetBoolean("is_active")
                });
            }
        }
        db.Close();
        return list; 
    }
    
    
    public List<User> GetTableUser()
    {
        var list = new List<User>();
        var sql = "SELECT * FROM table_user";
        var result = Query(sql,out var db);
        if (result.HasRows)
        {
            while (result.Read())
            {
                list.Add(new User
                {
                    Id = result.GetInt32("user_id"),
                    FirstName = result.GetString("first_name"), 
                    LastName = result.GetString("last_name"),
                    Email = result.GetString("email"),
                    PhotoUrl = result.GetString("photo"),
                });
            }
        }
        db.Close();
        return list; 
    }

    private void NoQuery(string sql)
    {
        SqliteConnection db = new SqliteConnection(conn);
        db.Open();
        var command = new SqliteCommand(sql, db);
        command.ExecuteNonQuery();
        db.Close();
    }
    public void AddToTableAccount(Account account)
    {
        var sql = $"INSERT INTO table_account (login,password,role_id) VALUES ('{account.Login}','{account.Password}','{account.RoleId}')";
        NoQuery(sql);
    }
    public void AddToTableUser(User user)
    {
        var sql = $"INSERT INTO table_user (user_id,first_name,last_name,email,photo) VALUES ('{user.Id}','{user.FirstName}','{user.LastName}','{user.Email}','{user.PhotoUrl}')";
        NoQuery(sql);
    }
    public void AddToTableRole(Role role)
    {
        var sql = $"INSERT INTO table_role (role_id,role_name) VALUES ('{role.Id}','{role.Name}')";
        NoQuery(sql);
    }
}