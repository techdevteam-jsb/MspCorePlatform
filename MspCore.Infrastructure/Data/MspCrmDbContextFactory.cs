using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace MspCore.Infrastructure.Data
{
    public class MspCrmDbContextFactory : IDesignTimeDbContextFactory<MspCrmDbContext>
    {
        public MspCrmDbContext CreateDbContext(string[] args)
        {
            Console.WriteLine("Starting CreateDbContext...");

            var builder = new DbContextOptionsBuilder<MspCrmDbContext>();

            try
            {
                var basePath = Path.Combine(Directory.GetCurrentDirectory(), "../MspCore.WebApi");
                Console.WriteLine($"Using base path: {basePath}");

                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MspCore.WebApi"))
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");
                Console.WriteLine($"Connection string retrieved: {(string.IsNullOrEmpty(connectionString) ? "null or empty" : "OK")}");

                builder.UseNpgsql(connectionString);

                Console.WriteLine("Creating MspCrmDbContext instance...");
                var context = new MspCrmDbContext(builder.Options);
                Console.WriteLine("MspCrmDbContext instance created successfully.");
                return context;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception creating MspCrmDbContext: " + ex);
                throw;
            }
        }

    }
}
