// See https://aka.ms/new-console-template for more information
using Starwars.Core.Business;
using Starwars.Core.Entities;

Console.WriteLine("Hello, World!");


var jediBusiness = new JediBusiness();

List(jediBusiness);

//var result = jediBusiness.DeleteAsync(1002);

var jedi3 = jediBusiness.GetAsync(3);
jedi3.Name = jedi3.Name + "3";

var result = jediBusiness.UpdateAsync(jedi3);



List(jediBusiness);

Console.WriteLine("End!");




static void List(JediBusiness jediBusiness)
{
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
}