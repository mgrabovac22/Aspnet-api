using Aspnet_api_products.Models;

namespace Aspnet_api_products.Interfaces
{
    public interface IProductRepository
    {
        List<ProductDTO> GetAllProducts();
        List<Product> GetOneProduct(string title);
        List<Product> FilterProducts(string category, float price);
        List<Product> SearchProducts(string title);
    }
}
