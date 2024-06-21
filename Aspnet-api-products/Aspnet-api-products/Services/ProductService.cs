using Aspnet_api_products.Interfaces;
using Aspnet_api_products.Models;
using Aspnet_api_products.Repositories;

namespace Aspnet_api_products.Services
{
    public class ProductService : IProductRepository
    {
        public List<Product> FilterProducts(string category, float price)
        {
            throw new NotImplementedException();
        }

        public List<ProductDTO> GetAllProducts()
        {
            IProductRepository productRepository = new ProductRepositoryWS();
            return productRepository.GetAllProducts();
        }

        public Product GetOneProduct(string title)
        {
            IProductRepository productRepository = new ProductRepositoryWS();
            return productRepository.GetOneProduct(title);
        }

        public List<Product> SearchProducts(string title)
        {
            throw new NotImplementedException();
        }
    }
}
