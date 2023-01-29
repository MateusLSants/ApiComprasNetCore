using AppComprasNetCore.Domain.Entities;
using AppComprasNetCore.Domain.Repositories;
using AppComprasNetCore.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AppComprasNetCore.Infra.Data.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDBContext _db;

    public ProductRepository(AppDBContext db)
    {
        _db = db;
    }

    public async Task<Product> CreateAsync(Product product)
    {
        _db.Add(product);
        await _db.SaveChangesAsync();
        return product;
    }

    public async Task DeleteAsync(Product product)
    {
        _db.Remove(product);
        await _db.SaveChangesAsync();
    }

    public async Task EditAsync(Product product)
    {
        _db.Update(product);
        await _db.SaveChangesAsync();
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        return await _db.Products.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<ICollection<Product>> GetPeopleAsync()
    {
        return await _db.Products.ToListAsync();
    }
}
