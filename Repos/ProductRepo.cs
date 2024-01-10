using app_rvprod_test.Data;
using app_rvprod_test.Models;
using Microsoft.EntityFrameworkCore;

namespace app_rvprod_test.Repos;

public class ProductRepo : IDisposable
{
    private readonly ApplicationDbContext _context;

    public ProductRepo(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetAllAsync()
    {
        return await _context.Products.ToListAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}

