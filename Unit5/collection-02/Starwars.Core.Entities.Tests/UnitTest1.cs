using Starwars.Core.Entities;
namespace Starwars.Core.Entities.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var jedi = new Jedi();
        jedi.Name = "Luke Skywalker";
        Assert.Equal("Luke Skywalker", jedi.Name);
    }
}