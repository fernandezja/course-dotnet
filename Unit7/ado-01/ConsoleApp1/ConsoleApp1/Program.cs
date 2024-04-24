// See https://aka.ms/new-console-template for more information
using Starwars.Core.Data;

Console.WriteLine("Hello, World!");


var empleadoRepository = new EmpleadoRepository();

var empleados = empleadoRepository.ObtenerTodos();

Console.WriteLine("Empleados:");

foreach (var e in empleados) {
    Console.WriteLine($"{e.Id} | {e.NombreCompleto}");
}


Console.ReadKey();

