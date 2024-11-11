using Microsoft.EntityFrameworkCore;
using Starwars.Core.Entities;
using System.Reflection.Metadata;

namespace Starwars.Core.DataEF;

    internal class StarwarsContext: DbContext
    {

        private readonly string CONNECTIONSTRING = "Persist Security Info=True;Initial Catalog=Starwars;Data Source=.; Application Name=DemoApp; Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";


        public DbSet<Jedi> Jedis { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTIONSTRING);
        }
    }

