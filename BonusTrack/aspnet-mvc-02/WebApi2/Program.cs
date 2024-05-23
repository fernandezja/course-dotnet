using Starwars.Core.Business;
using Starwars.Core.Configuration;
using Starwars.Core.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("StarwarsConnectionString");

var config = new Starwars.Core.Configuration.Config()
{
    ConnectionString = connectionString
};

builder.Services.AddScoped<Config>(p => {
    return config;
});
builder.Services.AddScoped<JediRepository>();
builder.Services.AddScoped<JediBusiness>();


builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
