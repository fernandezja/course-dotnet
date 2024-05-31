using Microsoft.Extensions.DependencyInjection;
using Starwars.Core.Business;
using Starwars.Core.Configuration;
using Starwars.Core.Data;

var builder = WebApplication.CreateBuilder(args);


//var connectionString = builder.Configuration.Get("ConnectionStrings:StarwarsConnectionString");


var connectionString  = builder.Configuration.GetConnectionString("StarwarsConnectionString");

var config = new Starwars.Core.Configuration.Config()
{
    ConnectionString = connectionString
};

builder.Services.AddScoped<Config>(p => {
    return config;
});
builder.Services.AddScoped<JediRepository>();
builder.Services.AddScoped<JediBusiness>();


// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


//app.Run(async context => {
//    await context.Response.WriteAsync("Pagina no encontrada");
//});


app.Run();
