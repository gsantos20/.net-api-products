using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;
using ProductsAPI.Data;


namespace ProductsAPI.Repositories.sqlserver
{
    public class SQLServerProductRepository : IProductRepository
    {
        private readonly SQLServerContext _context;

        public SQLServerProductRepository(SQLServerContext context)
        {
            _context = context;
        }

        public async Task<List<Product>?> GetProducts()
        {
            var products = await _context.Products.ToListAsync();

            return products;
        }

        public async Task<Product?> CreateProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<Product?> UpdateProduct(int id, ProductCreation request)
        {
            var product = await _context.Products.FindAsync(id);

            if (product is null)
                return null;

            product.Name = request.Name;
            product.Description = request.Description;
            product.Price = request.Price;

            await _context.SaveChangesAsync();


            return product;

        }

        public async Task<Boolean> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product is null)
                return false;

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return true;

        }
    }
}
