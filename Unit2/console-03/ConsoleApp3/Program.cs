// See https://aka.ms/new-console-template for more information
using ConsoleApp3.Entidades;
using System.Text;

Console.WriteLine("Hello, World!");


Persona persona1;
persona1 = new Persona();
persona1.Nombre = "Curso .NET";

Console.WriteLine("Hello,"
                    + persona1.Nombre);

Persona persona2 = 
    new Persona();
var persona3 = 
        new Persona();
Persona persona4 = new();


var persona5 = new ConsoleApp3.Entidades.Persona();

int numero = 0;
System.Int32 numero1 = 10;
Int32 numero2 = 20;
int numero3 = 30;

int n4 = 4,
    n5 = 5,














    n6 = 6; 

Console.WriteLine(numero.ToString());

if ((persona1.Nombre == "Curso .NET"
    && true)
    || false)
{
    Console.WriteLine("ddd");
}


for (int i = 0; i < 10; i++)
{
    if (i % 2 != 0)
    {
        continue;       
    }

    Console.WriteLine(i);

    //if (i % 2 == 0)
    //{
    //    Console.WriteLine(i);
    //}
    //Console.WriteLine(i);
}

Metodo(2);
Metodo(3);


void Metodo(int valor)
{
    if (!ClassLibrary3.Helper.EsPar(valor))
    {
        Console.WriteLine("ES IMPAR");
        return;
    }

    Console.WriteLine("ES PAR!!");
    return;
}

//bool EsPar(int valor)
//{
//    return (valor % 2 == 0);
//}

Console.WriteLine("Comenzando la concatenacion...");
var curso = "CURSO .NET";
var cursoSb = new StringBuilder();
var concatenacionCantidad = 1000000;
for (int i = 0; i < concatenacionCantidad; i++)
{
    //curso += " - CURSO .NET";
    cursoSb.Append(" - CURSO .NET");
}
Console.WriteLine("Longitud: ");
Console.WriteLine(cursoSb.Length);