using FashionWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FashionWeb.FashionEF
{
    public class FashionDbContextFactory : IDesignTimeDbContextFactory<FashionDbContext>
    {
        public FashionDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("FashionConnection");

            var optionsBuilder = new DbContextOptionsBuilder<FashionDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new FashionDbContext(optionsBuilder.Options);
        }
    }
}
