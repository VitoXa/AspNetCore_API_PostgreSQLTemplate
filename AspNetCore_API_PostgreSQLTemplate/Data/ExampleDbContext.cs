using AspNetCore_API_PostgreSQLTemplate.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_API_PostgreSQLTemplate.Data
{
    public class ExampleDbContext : DbContext
    {

        public ExampleDbContext(DbContextOptions<ExampleDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }

}
