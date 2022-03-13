using LinkConverter.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LinkConverter.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ConvertedLink> ConvertedLinks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}