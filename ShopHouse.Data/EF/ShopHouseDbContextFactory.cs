using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ShopHouse.Data.EF
{
    public class ShopHouseDbContextFactory : IDesignTimeDbContextFactory<ShopHouseDbContext>
    {
        public ShopHouseDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = "DESKTOP-QQMOOO4\\SQLEXPRESS;Database=eShopHouseDB;Trusted_Connection=True;";
            //configuration.GetConnectionString("defaultString");

            var optionsBuilder = new DbContextOptionsBuilder<ShopHouseDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ShopHouseDbContext(optionsBuilder.Options);
        }
    }
}
