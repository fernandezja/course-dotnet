using Curso.NET.Utils;

// See https://aka.ms/new-console-template for more information

string name = "World";

//string completeName = Curso.NET.Utils.Builder.Build(name);
string completeName = Builder.Build(name);

Console.WriteLine($"{completeName}!" );
