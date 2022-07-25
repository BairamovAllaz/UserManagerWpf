using System.Collections.Generic;
using UserManager.Models.Table;
using Xunit;
namespace UserManager.Models.Test;
public class TableAccountTest
{
    private List<Account> _expected;
    private TableAccount _tableAccount;

    public TableAccountTest()
    {
        _tableAccount = new TableAccount();
        _expected = new List<Account>
        {
            new()
            {
                Id = 1,
                Login = "admin",
                Password = "123",
                RoleId = 1,
                IsActive = true
            },
            new()
            {
                Id = 2,
                Login = "user",
                Password = "123",
                RoleId = 2,
                IsActive = true
            }
        };
    }
    [Fact]
    public void GetTable_Test()
    {
        var actual = _tableAccount.GetTable();
        Assert.Equal(_expected,actual);
    }

    [Fact]
    public void AddToTable_Test()
    {
        var account = new Account()
        {
            Login = "user",
            Password = "123",
            RoleId = 2,
            IsActive = true
        }; 
        _expected.Add(account);
        _tableAccount.AddToTable(account);
        var actual = _tableAccount.GetTable();
        Assert.Equal(_expected,actual);
    }
}