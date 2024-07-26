// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Text;

Console.WriteLine("Hello, World!");


Persona persona1 = 
    new Persona();

var persona2 = new Persona();

Persona persona3 = new();


var cadena1 = "100";
int entero1 = 9999;


var edad1 = 100;
int edad2 = 100;
Int32 edad3 = 100;
var edad = Int32.MaxValue;


int valor1, valor2,  valor3 = 100; 

int cienMil1 = 100000;
int cienMil2 = 100_000;


if (cadena1 == "Hola")
{
    Console.WriteLine("Es igual");
}

for (int i = 0; i < 50; i++)
{
    //if ((i % 2) == 0) continue;
   

    if ((i % 2) == 0)
    {
        Console.Write("*");
    }else
    {
        Console.Write("|");
    }

    
}


Console.WriteLine("Start");

var net = ".NET";
var curso1 = "";

//for (int i = 0; i < 900_000; i++)
//{
//    //curso1 = curso1 + net;
//    curso1 += net;

//}
Console.WriteLine("Length1 = " + curso1.Length);


var curso2 = new StringBuilder();
for (int i = 0; i < 9_000_000; i++)
{
    //curso1 = curso1 + net;
    //curso1 += net;
    curso2.Append(net);
}

Console.WriteLine("Length2 = " + curso2.ToString().Length);

Console.WriteLine("End");

var edadPersona1990 = CalcularEdad(1990);

Console.WriteLine($"edadPersona1990 v1 = {edadPersona1990}");

Metodo1(edadPersona1990);

Console.WriteLine($"edadPersona1990 v2 = {edadPersona1990}");

var nombre = ".NET";
Console.WriteLine($"nombre v1 = {nombre}");
Metodo2(nombre);
Console.WriteLine($"nombre v2 = {nombre}");


int CalcularEdad(int anioNacimiento)
{
    return (DateTime.Now.Year - anioNacimiento);
}

void Metodo1(int edad)
{
    //Acciones
    edad = 100;

    return;
}


void Metodo2(string demo)
{
    //Acciones
    demo = "100";

    return;
}