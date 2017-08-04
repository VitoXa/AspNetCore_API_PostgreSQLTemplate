using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore_API_PostgreSQLTemplate.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }

}
