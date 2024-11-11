// See https://aka.ms/new-console-template for more information
using Starwars.Core.Business;
using Starwars.Core.Entities;
using Microsoft.Extensions.Configuration;
using Serilog;

var logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();


var builder = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appSettings.json", optional: false);

var configuration = builder.Build();

var titleSection = configuration.GetSection("Title");

var title = titleSection.Value;

Console.WriteLine($"Hello, {title}!");

logger.Information("Demo Log 1");
logger.Error("Demo Log 2");
logger.Warning("Demo Log 3");

/*




var variable1 = configuration["variable1"];

//logger.Verbose
logger.Information($"Information DEmo");
logger.Warning("Warning DEmo");
logger.Error($"Error DEmo");

try
{
    var currentDirectory = System.IO.Directory.GetCurrentDirectory();
    var directoryInfo = System.IO.Directory.CreateDirectory($"Demo-{DateTime.Today.ToString("yyyMMdd")}");


}
catch (Exception ex)
{
    logger.Error($"Error {ex.Message}");
    throw;
}
*/


var jediBusiness = new JediBusiness();

List(jediBusiness, logger);

//var result = jediBusiness.DeleteAsync(1002);

//var jedi3 = jediBusiness.GetAsync(3);
//jedi3.Name = jedi3.Name + "3";

//var result = jediBusiness.UpdateAsync(jedi3);



//List(jediBusiness);

Console.WriteLine("End!");




static void List(JediBusiness jediBusiness, 
                 Serilog.ILogger logger)
{
    var jedisResult = jediBusiness.GetAll();

    if (jedisResult.HasError)
    {
        logger.Error($"ERROR: {jedisResult.Message}");
        Console.WriteLine($"ERROR: {jedisResult.Message}");
    }
    else
    {
        foreach (var item in jedisResult.Items)
        {
            Console.WriteLine(item.ToString());
        }

    }
}