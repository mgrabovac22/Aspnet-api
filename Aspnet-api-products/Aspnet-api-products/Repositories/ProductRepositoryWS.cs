using Aspnet_api_products.Interfaces;
using Aspnet_api_products.Models;
using System.Linq;

namespace Aspnet_api_products.Repositories
{
    public class ProductRepositoryWS : IProductRepository
    {
        public List<ProductDTO>? GetAllProducts()
        {
            var client = new HttpClient();
            Result? listOfProducts = null;
            
            Task.Run(async () =>
            {
                listOfProducts = await client.GetFromJsonAsync<Result>("https://dummyjson.com/products");
            }).Wait();

            if (listOfProducts == null || listOfProducts.products == null)
            {
                Console.WriteLine("Products not found!");
                return null;
            }

            var listResult = listOfProducts.products.Select(p => new ProductDTO(
                p.title,
                p.description.Length > 100 ? p.description.Substring(0, 100) + "..." : p.description,
                p.thumbnail,
                p.price
            )).ToList();

            return listResult;
        }

        public List<Product> GetOneProduct(string title)
        {
            throw new NotImplementedException();
        }

        public List<Product> SearchProducts(string title)
        {
            throw new NotImplementedException();
        }
        public List<Product> FilterProducts(string category, float price)
        {
            throw new NotImplementedException();
        }

    }
}
