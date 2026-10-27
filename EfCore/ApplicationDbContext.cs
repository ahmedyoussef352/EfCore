

using Microsoft.EntityFrameworkCore;

namespace EfCore;

public class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=EfCore1; Trusted_Connection=True; TrustServerCertificate=True");
    }


    public DbSet<User> Users { get; set; }
    public DbSet<Department> Departments { get; set; }
}
