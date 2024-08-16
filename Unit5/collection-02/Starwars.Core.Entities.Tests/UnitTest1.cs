using Starwars.Core.Entities;
namespace Starwars.Core.Entities.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string name = null;


        var jedi = new Jedi();
        jedi.Name = "Luke Skywalker";
        Assert.Equal("Luke Skywalker", jedi.Name);
    }


    [Fact]
    public void Test2()
    {
        
    }

}