using app_rvprod_test.Models;
using Microsoft.EntityFrameworkCore;

namespace app_rvprod_test.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Product> Products { get; set; } = default!;
}