// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using Serilog;


var logger = new LoggerConfiguration()
                    .WriteTo.Console()
                    .WriteTo.File("log.log", rollingInterval: RollingInterval.Day)
                    .CreateLogger();



Console.WriteLine("Hello, .NET!");
logger.Information("Hello, .NET!");

var a = 0;

Console.WriteLine(a);

var c = System.Text.Encoding.ASCII.GetBytes("NET");


var client = new ClientApi();

/*
try
{
    //accion...
}
catch (Exception) 
    throw;
}
finally
{
    //acciones...finales 
}
*/

try
{
    var result = client.GetValue(hasError: true);

    Console.WriteLine($"Result: {result}");


    //var b = 1 / a; // DivideByZeroException
}

catch (DivideByZeroException ex) when (a == 0)
{
    //Acciones particulares
    logger.Error(ex, $"ERROR: {ex.Message}");
    Console.WriteLine($"ERROR: {ex.Message}");
}
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