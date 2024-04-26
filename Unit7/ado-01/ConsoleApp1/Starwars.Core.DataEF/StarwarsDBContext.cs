using Microsoft.EntityFrameworkCore;
using Starwars.Core.Entities;
using System.Reflection.Metadata;

namespace Starwars.Core.DataEF
{
    public class StarwarsDBContext: DbContext
    {
        private readonly string CONNECTIONSTRING = "Persist Security Info=True;Initial Catalog=StarwarsBorrar;Data Source=.; Application Name=DemoApp; Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";

        public DbSet<Empleado> Empleados { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONNECTIONSTRING);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
