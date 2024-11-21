// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using Serilog;


var logger = new LoggerConfiguration()
                    .WriteTo.Console()
                    .CreateLogger();


Console.WriteLine("Hello, .NET!");

var a = 0;

Console.WriteLine(a);

var c = System.Text.Encoding.ASCII.GetBytes("NET");


var client = new ClientApi();


try
{
    var d = client.GetValue(hasError: false);

    Console.WriteLine($"Result: {d}");
}
//catch (DivideByZeroException ex) when (a == 0)
//{
//    //Acciones particulares
//    Console.WriteLine($"ERROR: {ex.Message}");
//}
catch (DivideByZeroException ex) 
{
    //Acciones particulares
    logger.Error(ex, $"ERROR: {ex.Message}");
    Console.WriteLine($"ERROR: {ex.Message}");
}
catch (CustomException ex)
{
    logger.Error(ex, $"Custom Error: {ex.Message}");
    Console.WriteLine($"Custom Error: {ex.Message}");
}
catch (Exception ex)
{
    logger.Error(ex, $"ERROR: {ex.Message}");
    Console.WriteLine($"ERROR: {ex.Message}");
}
finally
{
    //acciones... 
}


#if DEBUG
    logger.Information("Debug DEBUG");
    Console.WriteLine("Debug DEBUG");
#endif

#if RELEASE
    logger.Information("Debug RELEASE");
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