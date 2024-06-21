using Aspnet_api_products.Models;

namespace Aspnet_api_products.Interfaces
{
    public interface IProductRepository
    {
        List<ProductDTO>? GetAllProducts();
        Product? GetOneProduct(string title);
        List<Product>? FilterProducts(string category, float price);
        List<ProductDTO>? SearchProducts(string title);
    }
}
