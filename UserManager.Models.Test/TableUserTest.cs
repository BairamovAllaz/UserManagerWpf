using System.Collections.Generic;
using UserManager.Models.Table;
using Xunit;
namespace UserManager.Models.Test;
public class TableUserTest
{
    [Fact]
    public void GetTable_Test()
    {
        var expected = new List<User>
        {
            new()
            {
                Id = 1,
                FirstName = "anonim",
                LastName = "anonimus",
                Email = "anonim@admin.ru",
                PhotoUrl = "url"
            },
            new()
            {
                Id = 2,
                FirstName = "user",
                LastName = "anonimus",
                Email = "user@admin.ru",
                PhotoUrl = "url"
            },
        };
        var actual = new TableUser().GetTable();
        Assert.Equal(expected,actual);
    }
    [Fact]
    public void AddToTable_Test()
    {
        var FakeUser = new User
        {
            Id = 3,
            FirstName = "anonim",
            LastName = "anonimus",
            Email = "anonim@admin.ru",
            PhotoUrl = "url"
        };
        var expected = 1;
        var actual = new TableUser().AddToTable(FakeUser);
        Assert.Equal(expected,actual);
    }
}