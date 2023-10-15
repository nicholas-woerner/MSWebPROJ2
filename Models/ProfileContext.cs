using Microsoft.EntityFrameworkCore;

namespace MSWebPROJ2.Models
{
    public class ProfileContext : DbContext
    {
        public ProfileContext() { }

        public ProfileContext(DbContextOptions<ProfileContext> options) : base(options)
        { }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    FirstName = "Kylan",
                    LastName = "Larson"
                },
                new User
                {
                    ID = 2,
                    FirstName = "Nicholas",
                    LastName = "Woerner"
                },
                new User
                {
                    ID = 3,
                    FirstName = "Michael",
                    LastName = "Myers"
                });
        }
    }
}
