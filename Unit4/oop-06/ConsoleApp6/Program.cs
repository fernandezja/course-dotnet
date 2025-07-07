// See https://aka.ms/new-console-template for more information

using Starwars.Core.Entidades;


var jedi = new Jedi()
{
    JediId = 1,
    Name = "Luke Skywalker"
};

Console.WriteLine($"Hello, {jedi.Name}!");
