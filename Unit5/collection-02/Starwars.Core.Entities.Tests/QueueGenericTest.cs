using Starwars.Core.Entities;
using System.Collections.Generic;
namespace Starwars.Core.Entities.Tests;

public class QueueGenericTest
{
    private Queue<Jedi> _jedisQueue;

    public QueueGenericTest()
    {
        _jedisQueue = Generate(1000);
    }


    [Fact]
    public void Dequeue_test()
    {
        Assert.Equal(1000, _jedisQueue.Count);
        Assert.Equal("Jedi 1", _jedisQueue.Dequeue().Name);
    }


    private static Queue<Jedi> Generate(int count)
    {
       var jedisQueue = new Queue<Jedi>();

        for (int i = 1; i <= count; i++)
        {
            var jedi = new Jedi() {
                Name = $"Jedi {i}"
            };

            jedisQueue.Enqueue(jedi);
        }

        return jedisQueue;
    }
}