using System;
using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;

namespace ProductsAPI.Data
{
    public class SQLServerContext : DbContext
    {
        public IConfiguration Configuration { get; }

        public SQLServerContext(DbContextOptions<SQLServerContext> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);

            var server = Configuration["DbServer"] ?? "localhost";
            var port = Configuration["DbPort"] ?? "1433";
            var user = Configuration["DbUser"] ?? "SA";
            var password = Configuration["Password"] ?? "admin123";
            var database = Configuration["Database"] ?? "ProductDb";

            var connectionString = $"Server={server}, {port};Initial Catalog={database};User ID={user};Password={password};TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
    
        }
        public DbSet<Product> Products { get; set; } 
    }
}