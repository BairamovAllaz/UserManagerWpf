using System.Collections.Generic;
using System.Runtime.InteropServices;
using UserManager.Models.Table;
using Xunit;
namespace UserManager.Models.Test;
public class TableRoleTest
{
    private List<Role> _expected;
    private TableRole _tableRole;
    
    public TableRoleTest()
    {
        _tableRole = new TableRole();
        _expected = new List<Role>
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
    }
    [Fact]
    public void GetTable_Test()
    {
        var tableRole = new TableRole();
        var actual = tableRole.GetTable();
        Assert.Equal(_expected,actual);
    }

    [Fact]
    public void AddToTable_Test()
    {
        _expected.Add(new()
        {
            
        });
    }
}