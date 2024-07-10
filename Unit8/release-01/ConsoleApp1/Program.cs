// See https://aka.ms/new-console-template for more information


using ConsoleApp1;

Console.WriteLine("Hello, World!");

var a = 0;

Console.WriteLine(a);

var c = System.Text.Encoding.ASCII.GetBytes("NET");


var client = new ClientApi();

try
{
    var d = client.GetValue(hasError: true);

    Console.WriteLine($"Result: {d}");
}
catch (CustomException ex)
{
    Console.WriteLine($"Custom Error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
}
finally { 
    //acciones... 
}


#if DEBUG
    Console.WriteLine("Debug DEBUG");
#endif

#if RELEASE
    Console.WriteLine("Debug RELEASE");
#endif

//try
//{

//}
//catch (Exception)
//{

//	throw;
//}

////TODO: Revisar
//var b = 1 / a;

Console.WriteLine(a);