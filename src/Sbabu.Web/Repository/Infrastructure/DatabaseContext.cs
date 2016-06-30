﻿
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Extensions.Configuration;
using Sbabu.Web.Models;

namespace Sbabu.Web.Repository.Infrastructure
{
    public class DatabaseContext : DbContext
    {       
        public DatabaseContext()
        {
            
        }

        public IConfigurationRoot Configuration { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {             
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
