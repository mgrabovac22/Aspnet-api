using Aspnet_api_products.Models;

namespace Aspnet_api_products.Interfaces
{
    public interface IProductRepository
    {
        List<ProductDTO>? GetAllProducts();
        Product? GetOneProduct(int id);
        List<ProductDTO>? FilterProducts(string category, float? minPrice, float? maxPrice);
        List<ProductDTO>? SearchProducts(string title);
    }
}
