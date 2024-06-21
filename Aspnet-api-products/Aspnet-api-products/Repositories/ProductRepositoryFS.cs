using Aspnet_api_products.Interfaces;
using Aspnet_api_products.Models;

namespace Aspnet_api_products.Repositories
{
    public class ProductRepositoryFS : IProductRepository
    {
        public List<Product> FilterProducts(string category, float price)
        {
            throw new NotImplementedException();
        }

        public List<ProductDTO> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetOneProduct(string title)
        {
            throw new NotImplementedException();
        }

        public List<Product> SearchProducts(string title)
        {
            throw new NotImplementedException();
        }
    }
}
