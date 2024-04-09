using Starwars.Core.Entities;
namespace Starwars.Core.Entities.Tests;

public class ListGenericTest
{
    private List<Jedi> _jedis;

    public ListGenericTest()
    {
        _jedis = Generate(1000);
    }


    [Fact]
    public void Test1()
    {
        Assert.Equal(1000, _jedis.Count);
    }


    [Fact]
    public void Test1_removeAt()
    {

        _jedis.RemoveAt(10);
       
        Assert.Equal(999, _jedis.Count);
    }

    [Fact]
    public void Test2_removeAt_2()
    {
        var cantidad10 = 10;

        _jedis.RemoveAt(cantidad10);
        _jedis.RemoveAt(11);

        Assert.Equal(998, _jedis.Count);
    }

    [Fact]
    public void list_get()
    {
        var jedi666 = _jedis[665];        

        Assert.Equal("Jedi 666", jedi666.Name);
    }


    [Fact]
    public void list_indexOf()
    {
        var jedi10 = _jedis[9];

        var index = _jedis.IndexOf(jedi10);

        Assert.Equal("Jedi 10", jedi10.Name);
        Assert.Equal(9, index);
    }


    [Fact]
    public void list_indexOf_v2()
    {
        var jedi10 = new Jedi()
        {
            Name = "Jedi 10"
        };

       

        var index = _jedis.IndexOf(jedi10);

        var contains  = _jedis.Contains(jedi10);

        Assert.Equal("Jedi 10", jedi10.Name);
        Assert.Equal(9, index);
        Assert.True(contains);
    }


    [Fact]
    public void list_equal()
    {
        var jedi10 = new Jedi()
        {
            Name = "Jedi 10"
        };

        var equal = (_jedis[9] == jedi10);

        Assert.True(equal);
    }



    private static List<Jedi> Generate(int count)
    {
        var jedis = new List<Jedi>();

        for (int i = 1; i <= count; i++)
        {
            var jedi = new Jedi();
            jedi.Name = $"Jedi {i}";

            jedis.Add(jedi);
        }

        return jedis;
    }
}