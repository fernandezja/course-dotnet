// See https://aka.ms/new-console-template for more information
using Starwars.Core.Data;
using Starwars.Core.DataEF;
using Starwars.Core.Entities;

Console.WriteLine("Hello, World!");


/*
Console.WriteLine("ADO.NET");
var empleadoRepository = new EmpleadoRepository();

var empleados = empleadoRepository.ObtenerTodos();

Console.WriteLine("Empleados:");

foreach (var e in empleados) {
    Console.WriteLine($"{e.Id} | {e.NombreCompleto}");
}
*/

Console.WriteLine("Entity Framework");
var dbContext = new Starwars.Core.DataEF.StarwarsDBContext();
var empleadoRepositoryEF = new Starwars.Core.DataEF.EmpleadoRepository(dbContext);


var newEmpleado = new Empleado()
{
    NombreCompleto = "Demo A",
    DNI = "A123456",
    Edad = 10,
    Casado = false
};
empleadoRepositoryEF.Guardar(newEmpleado); 


var empleados = empleadoRepositoryEF.ObtenerTodos();

Console.WriteLine("Empleados:");

foreach (var e in empleados)
{
    Console.WriteLine($"{e.Id} | {e.NombreCompleto}");
}


var empleadoParaEliminar = empleados.Last();
empleadoRepositoryEF.Eliminar(empleadoParaEliminar);

Console.ReadKey();

