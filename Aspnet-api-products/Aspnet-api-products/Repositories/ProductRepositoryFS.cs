using Aspnet_api_products.Interfaces;
using Aspnet_api_products.Models;

namespace Aspnet_api_products.Repositories
{
    public class ProductRepositoryFS : IProductRepository
    {
        public List<ProductDTO> FilterProducts(string category, float? minPrice, float? maxPrice)
        {
            throw new NotImplementedException();
        }

        public List<ProductDTO> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetOneProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductDTO> SearchProducts(string title)
        {
            throw new NotImplementedException();
        }
    }
}
