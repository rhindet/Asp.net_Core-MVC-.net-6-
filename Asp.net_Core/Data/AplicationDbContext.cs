
using Asp.net_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.net_Core.Data
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
