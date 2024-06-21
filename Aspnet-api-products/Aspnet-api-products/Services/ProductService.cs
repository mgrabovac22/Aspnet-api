using Aspnet_api_products.Interfaces;
using Aspnet_api_products.Models;
using Aspnet_api_products.Repositories;

namespace Aspnet_api_products.Services
{
    public class ProductService : IProductRepository
    {
        public List<ProductDTO>? FilterProducts(string category, float? minPrice, float? maxPrice)
        {
            IProductRepository productRepository = new ProductRepositoryWS();
            return productRepository.FilterProducts(category, minPrice, maxPrice);
        }

        public List<ProductDTO>? GetAllProducts()
        {
            IProductRepository productRepository = new ProductRepositoryWS();
            return productRepository.GetAllProducts();
        }

        public Product? GetOneProduct(string title)
        {
            IProductRepository productRepository = new ProductRepositoryWS();
            return productRepository.GetOneProduct(title);
        }

        public List<ProductDTO>? SearchProducts(string title)
        {
            IProductRepository productRepository = new ProductRepositoryWS();
            return productRepository.SearchProducts(title);
        }
    }
}
