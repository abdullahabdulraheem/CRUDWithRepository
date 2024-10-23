using CRUDWithRepository.Core;

namespace CRUDWithRepository.Infrastructure;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAll();
    Task<Product> GetById(int Id);
    Task Add(Product model);
    Task Update(Product model);
    Task Delete(int Id);
}
