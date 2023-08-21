using ProductsAPI.Models;
using ProductsAPI.Repositories;

namespace ProductsAPI.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>?> List()
        {

            var products = await _productRepository.GetProducts();

            return products;
        }

        public async Task<Product?> Create(ProductCreation product)
        {

            var _product = new Product
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
            };

            var productNew = await _productRepository.CreateProduct(_product);

            return productNew;
        }

        public async Task<Product?> Update(int id, ProductCreation product)
        {


            var productNew = await _productRepository.UpdateProduct(id, product);

            if (productNew is null)
            {
                throw new Exception("Ops... produto informado não encontrado!");
            }

            return productNew;
        }

        public async Task<string> Delete(int Id)
        {

            var product = await _productRepository.DeleteProduct(Id);
            var msg = "Produto deletado com sucesso!";

            if (!product)
            {
               throw new Exception("Ops... produto informado não encontrado!");
            }


            return msg;
        }

    }
}
