using System.Collections.Generic;
using UserManager.Models.Table;
using Xunit;

namespace UserManager.Models.Test;

public class TableAccountTest
{
    [Fact]
    public void GetTable_Test()
    {
        var expected = new List<Account>
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
            },
        };
        var actual = new TableAccount().GetTable();
        Assert.Equal(expected,actual);
    }

    [Fact]
    public void AddToTable_Test()
    {
        var FakeAccount = new Account()
        {
            Id = 3,
            Login = "FakeUser",
            Password = "123",
            RoleId = 1,
            IsActive = true
        };
        var expected = 1;
        var actual = new TableAccount().AddToTable(FakeAccount);
        Assert.Equal(expected,actual);
    }
}