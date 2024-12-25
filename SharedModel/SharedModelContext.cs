namespace SharedModel
{
    using Microsoft.EntityFrameworkCore;
    using SharedModel.Models;
    public class SharedModelContext : DbContext
    {
        public SharedModelContext(DbContextOptions<SharedModelContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.UserId);
                entity.Property(u => u.Email).IsRequired().HasMaxLength(100);
                entity.Property(u => u.UserName).IsRequired().HasMaxLength(50);
                entity.Property(u => u.PasswordHash).IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
