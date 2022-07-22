using Microsoft.Data.Sqlite;
namespace UserManager.Models.TableBase;
public abstract class Db
{
    private const string conn = @"Data Source=user.db;";
    protected readonly SqliteConnection _db;
    protected readonly SqliteCommand _command;
    protected SqliteDataReader _result;
    protected Db()
    {
        _db = new SqliteConnection(conn);
        _command = new SqliteCommand
        {
            Connection = _db
        };
    }
    protected void Query(string sql)
    {
        _db.Open();
        _command.CommandText = sql;
        _result = _command.ExecuteReader();
    }
    protected void NoQuery(string sql)
    {
        _db.Open();
        _command.CommandText = sql;
        _command.ExecuteNonQuery();
    }
}