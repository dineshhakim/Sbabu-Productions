
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Extensions.Configuration;
using Sbabu.Web.Models;

namespace Sbabu.Web.Repository.Infrastructure
{

    public class DatabaseContext : DbContext
    {
        //public IConfigurationRoot Configuration { get; set; }
        public DatabaseContext()
        {
           // Configuration = configuration;
        }

        public IConfigurationRoot Configuration { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options = new DbContextOptionsBuilder();
            ////options.UseSqlServer(Configuration["Data:DefaultConnection:ConnectionString"]);

            //options.UseSqlServer(@"Server=.;Database=Sbabu;user id=sa;password=ura@tech12345");
            //this.Add
            var configuration = new ConfigurationBuilder()
             .AddJsonFile("appsettings.json");
            Configuration = configuration.Build();
            options.UseSqlServer(Configuration["Data:DefaultConnection:ConnectionString"]);


        }
        public DbSet<Company> Company { get; set; }



        public DbSet<User> Users { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }




        public virtual void Commit()
        {
            base.SaveChanges();
        }

    }

}
