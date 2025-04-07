

namespace Pratik1_JWT.Context
{
    public class JWTDbContext : DbContext

    {

        public JWTDbContext(DbContextOptions<JWTDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }

    }

}