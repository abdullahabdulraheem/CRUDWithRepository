using CRUDWithRepository.Core;
using Microsoft.EntityFrameworkCore;

namespace CRUDWithRepository.Infrastructure;

public class ProductRepository : IProductRepository
{
    private readonly MyAppDBContext _dbContext;
    public ProductRepository(MyAppDBContext _dbContext)
    {
        this._dbContext = _dbContext;
    }
    public async Task<IEnumerable<Product>> GetAll()
    {
        var products = await _dbContext.Products.ToListAsync();
        return products;
    }

    public async Task Add(Product model)
    {
        await _dbContext.AddAsync(model);
        await Save();
    }

    public Task<Product> GetById(int Id)
    {
        throw new NotImplementedException();
    }

    public Task Update(Product model)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int Id)
    {
        throw new NotImplementedException();
    }

    public async Task Save()
    {
         await _dbContext.SaveChangesAsync();
    }
}
