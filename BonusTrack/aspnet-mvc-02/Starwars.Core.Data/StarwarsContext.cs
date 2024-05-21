using Microsoft.EntityFrameworkCore;
using Starwars.Core.Configuration;
using Starwars.Core.Entities;
using System.Reflection.Metadata;

namespace Starwars.Core.Data;

    internal class StarwarsContext: DbContext
    {

    //private readonly string CONNECTIONSTRING = "Persist Security Info=True;Initial Catalog=StarwarsBorrar2;Data Source=.; Application Name=DemoApp; Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";

    private readonly Config _config;

    public StarwarsContext(Config config)
    {
        _config = config;
    }


    public DbSet<Jedi> Jedis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.ConnectionString);
        }
    }

