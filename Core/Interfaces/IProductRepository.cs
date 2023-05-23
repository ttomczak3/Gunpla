using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAysnc(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
    }
}
