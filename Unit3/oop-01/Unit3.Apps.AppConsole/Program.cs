using Unit3.Core.Entities;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("OOP!");


var p1 = new Unit3.Core.Entities.Person("FirstName 1");

var p2 = new Person("FirstName 2", "LastName 2");
p2.FirstName = "Leia ";
p2.LastName = "Organa";


var p3 = new Person("FirstName 3") {
    FirstName = "FirstName 3v2"
};

Person p4 = new ("FirstName 4")
{
    LastName = "LastName 4"
};


//Identidad
Person p5 = new("FirstName 1");
Person p6 = p1;
p6.LastName = "LastName 6";

Console.WriteLine(p1 == p5);
Console.WriteLine(p1 == p6);
Console.WriteLine(p1.LastName);

Console.ReadKey();

//var value = true;

//while (value) {
//    //DoSomething();
//    //DoSomethingElse();
//}


//while (value)
//{
//    //DoSomething();
//    //DoSomethingElse();
//}