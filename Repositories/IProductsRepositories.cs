
using ProductsAPI.Models;

namespace ProductsAPI.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>?> GetProducts();
        Task<Product?> CreateProduct(Product product);
        Task<Product?> UpdateProduct(int id, ProductCreation product);
        Task<bool> DeleteProduct(int id);
    }
}