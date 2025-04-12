using IdentityDataProtection.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdentityDataProtection.Context
{
    public class IdentityDbContext : DbContext
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base(options)
        {

        }

        public DbSet<UserEntity> Users { get; set; }
    }
}