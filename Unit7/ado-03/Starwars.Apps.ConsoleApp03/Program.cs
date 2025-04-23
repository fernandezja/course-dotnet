// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using Starwars.Core.Business;
using Starwars.Core.Entities;


var configuration = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true)
                        .Build();

//Value
var title = configuration["StarwarsConfig:Title"];

var starwarsConnectionString1 = configuration["ConnectionStrings:StarwarsConnectionString"];
var starwarsConnectionString2 = configuration.GetConnectionString("StarwarsConnectionString");


//Binding
var starwarsConfig  = configuration.GetSection("StarwarsConfig").Get<StarwarsConfig>();


Console.WriteLine("Jedis!");


var jediBusiness = new JediBusiness();

var jedis = jediBusiness.GetAll();

foreach (var jedi in jedis)
{
    Console.WriteLine($"JediId: {jedi.JediId}, Name: {jedi.Name}, Height: {jedi.Height}");
}



//var file = new FileInfo("");



//file = null;

//using (var stream = new FileStream("test.txt", FileMode.OpenOrCreate))
//{
//    // Do something with the stream
//}