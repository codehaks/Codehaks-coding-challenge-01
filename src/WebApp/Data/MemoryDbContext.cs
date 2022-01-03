using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class MemoryDbContext : DbContext
    {

        public MemoryDbContext(DbContextOptions<MemoryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }

    }
}
