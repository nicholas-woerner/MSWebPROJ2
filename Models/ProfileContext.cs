using Microsoft.EntityFrameworkCore;
namespace MSWebPROJ2.Models;
public class ProfileContext : DbContext
    {

        public ProfileContext(DbContextOptions<ProfileContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
