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

        public Product? GetOneProduct(int id)
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

            var product = listOfProducts.products.FirstOrDefault(p => p.id.Equals(id));

            return product;
        }

        public List<ProductDTO>? SearchProducts(string title)
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

            var filteredProducts = listOfProducts.products.Where(p => p.title.ToLower().Contains(title.ToLower())).ToList();

            var listResult = filteredProducts.Select(p => new ProductDTO(
               p.title,
               p.description.Length > 100 ? p.description.Substring(0, 100) + "..." : p.description,
               p.thumbnail,
               p.price
           )).ToList();

            return listResult;
        }
        public List<ProductDTO>? FilterProducts(string category, float? minPrice, float? maxPrice)
        {
            var client = new HttpClient();
            Result? listOfProducts = null;

            Task.Run(async () =>
            {
                listOfProducts = await client.GetFromJsonAsync<Result>("https://dummyjson.com/products/category/" + category);
            }).Wait();

            if (listOfProducts == null || listOfProducts.products == null)
            {
                Console.WriteLine("Products not found!");
                return null;
            }

            var filtered = listOfProducts.products.Select(p => new ProductDTO(
               p.title,
               p.description.Length > 100 ? p.description.Substring(0, 100) + "..." : p.description,
               p.thumbnail,
               p.price
            ));


            if (minPrice != null)
            {
                filtered = filtered.Where(p => p.price >= minPrice);
            }


            if (maxPrice != null)
            {
                filtered = filtered.Where(p => p.price <= maxPrice);
            }

            return filtered.ToList();

        }
    }
}
