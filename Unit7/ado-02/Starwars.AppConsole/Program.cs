// See https://aka.ms/new-console-template for more information
using Starwars.Core.Business;
using Starwars.Core.Entities;

Console.WriteLine("Hello, World!");


var jediBusiness = new JediBusiness();

var jedisResult = jediBusiness.GetAll();

if (jedisResult.HasError)
{
    Console.WriteLine($"ERROR: {jedisResult.Message}");
}
else
{
    foreach (var item in jedisResult.Items)
    {
        Console.WriteLine(item.ToString());
    }

}


Console.WriteLine("End!");
