using System.Collections.Generic;
using System.Runtime.InteropServices;
using UserManager.Models.Table;
using Xunit;
namespace UserManager.Models.Test;
public class TableRoleTest
{
    [Fact]
    public void GetTable_Test()
    {
        var expected = new List<Role>
        {
            new()
            {
                Id = 1,
                Name = "admin",
            },
            new()
            {
                Id = 2,
                Name = "user",
            },
        };
        var tableRole = new TableRole();
        var actual = tableRole.GetTable();
        Assert.Equal(expected,actual);
    }

    [Fact]
    public void AddToTable_Test()
    {
        var FakeRole = new Role
        {
            Id = 3,
            Name = "user",
        };
        var expected = 1;
        var actual = new TableRole().AddToTable(FakeRole);
        Assert.Equal(expected,actual);
    }
}