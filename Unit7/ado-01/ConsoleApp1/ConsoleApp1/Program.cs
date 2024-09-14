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

var empleadoRepositoryEF = new Starwars.Core.DataEF.EmpleadoRepository();


//var newEmpleado = new Empleado()
//{
//    Nombre = "Demo A",
//    DNI = "A123456",
//    Edad = 10,
//    Casado = false
//};
//empleadoRepositoryEF.Guardar(newEmpleado); 


//var empleados = empleadoRepositoryEF.ObtenerTodos();

var filtro = new EmpleadoFiltro()
{
    TextoABuscar = string.Empty,
    PageIndex = 1,
    PageSize = 3
};
var empleados = empleadoRepositoryEF.ObtenerTodos(filtro);

Console.WriteLine("Empleados:");

foreach (var e in empleados)
{
    Console.WriteLine($"{e.Id} | {e.Nombre}");
}


//var empleadoParaEliminar = empleados.Last();
//empleadoRepositoryEF.Eliminar(empleadoParaEliminar);

Console.ReadKey();

