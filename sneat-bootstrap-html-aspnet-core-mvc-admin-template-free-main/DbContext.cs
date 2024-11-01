using Microsoft.EntityFrameworkCore;
using AspnetCoreMvcFull.Models;

namespace AspnetCoreMvcFull.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<UserRegistration> UserRegistrations { get; set; }
  }
}
