// See https://aka.ms/new-console-template for more information
using Starwars.Core.Business;
using Starwars.Core.Entities;
using Microsoft.Extensions.Configuration;
using Serilog;
using Microsoft.Extensions.DependencyInjection;
using Starwars.Core.Config;

var logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();


var builder = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appSettings.json", optional: false);

var configuration = builder.Build();



var titleSection = configuration.GetSection("Title");
var title = titleSection.Value;

var connString1 = configuration.GetConnectionString("StarwarsConnectionString");
var connString2 = configuration.GetSection("ConnectionStrings:StarwarsConnectionString").Value;


var config = new Config()
{
    ConnectionString = configuration.GetConnectionString("StarwarsConnectionString")
};


//Inyeccion de dependencia
var serviceCollection = new ServiceCollection();

serviceCollection.AddSingleton<IConfig>(config);
serviceCollection.AddScoped<Starwars.Core.DataEF.JediRepository>();
serviceCollection.AddScoped<JediBusiness>();

var serviceProvider  = serviceCollection.BuildServiceProvider();


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


//var jediBusiness = new JediBusiness();
var jediBusiness = serviceProvider.GetService<JediBusiness>();

List(jediBusiness, logger);


//Delete
//var result = jediBusiness.DeleteAsync(1);

//Update
//var jedi3 = jediBusiness.GetAsync(2);
//jedi3.Name = ".NET";

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