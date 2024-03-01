using Unit2Console.Entities;
using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Unit2Console.Entities.Person person1;

Person person2;
person2 = new Person();

int value1 = Int32.MaxValue;
Int32 value2;


int a, 
    b, 
    c;


var course = "Course";
Console.WriteLine("Init...");


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



//for (int i = 0; i < 10; i++)
//{
//    //
//    curso = curso + " net";
//}

string ConcatStringFunction(string text, int count) {
    
    var sb = new System.Text.StringBuilder(text);

    for (int i = 0; i < count; i++)
    {

        //text = text + " .NET";
        sb.Append(" .NET");
    }

    return sb.ToString();
}


var result = ConcatStringFunction(course, 1000000);

Console.WriteLine("End....");