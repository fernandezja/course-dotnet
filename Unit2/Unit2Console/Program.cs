using Unit2Console.Entities;
using System;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var demo1 = bool.Parse("true");
var demo2 = bool.Parse("True");

//Convert.ToBoolean()

var montoUsuario = Console.ReadLine();

var monto = float.Parse(montoUsuario);


Unit2Console.Entities.Person person1;

Person person2;
person2 = new Person();

Int32 value0 = 0;
int value1 = Int32.MaxValue;
Int32 value2;


int a,
    b,
    c;


var course = "Course";

Console.WriteLine("Init..." + course);


//if (value1 == 1) { 
//}else if (value2 == 2) { }
//else if (value1 == 3) { }


//switch (value1)
//{
//    case 1:
//        //algo 1
//        break;
//    case 2:
//    case 3:
//        //algo 2 o 3
//        break;
//    default:
//        break;
//}


//for (int i = 0; i < 500000; i++)
//{
//    course = course + " net";
//}

void DemoFunction()
{
    var a = 1 + 2;

    return;
}

string ConcatStringFunction(string text, int count)
{

    const string NET_STRING = " .NET";

    var sb = new System.Text.StringBuilder(text);

    for (int i = 0; i < count; i++)
    {
        sb.Append(NET_STRING);
    }

    return sb.ToString();
}

DemoFunction();

var result = ConcatStringFunction(course, 1000000);

DemoFunction();

Console.WriteLine("End...." + result.Length);