using Aspnet_api_products.Interfaces;
using Aspnet_api_products.Models;
using Aspnet_api_products.Repositories;

namespace Aspnet_api_products.Services
{
    public class ProductService : IProductRepository
    {
        private static Dictionary<(string category, float? minPrice, float? maxPrice), List<ProductDTO>?> cachedFilterResult = [];
        private static Dictionary<string, List<ProductDTO>?> cachedSearchResult = [];

        public List<ProductDTO>? FilterProducts(string category, float? minPrice, float? maxPrice)
        {
            if (cachedFilterResult.ContainsKey((category, minPrice, maxPrice)))
            {
                return cachedFilterResult.GetValueOrDefault((category, minPrice, maxPrice));
            }

            IProductRepository productRepository = new ProductRepositoryWS();

            var resultToReturn = productRepository.FilterProducts(category, minPrice, maxPrice);

            cachedFilterResult.Add((category, minPrice, maxPrice), resultToReturn);

            if (cachedFilterResult.Count > 10)
            {
                cachedFilterResult.Remove(cachedFilterResult.Keys.First());
            }

            return resultToReturn;
        }

        public List<ProductDTO>? GetAllProducts()
        {
            IProductRepository productRepository = new ProductRepositoryWS();
            return productRepository.GetAllProducts();
        }

        public Product? GetOneProduct(int id)
        {
            IProductRepository productRepository = new ProductRepositoryWS();
            return productRepository.GetOneProduct(id);
        }

        public List<ProductDTO>? SearchProducts(string title)
        {
            if (cachedSearchResult.ContainsKey(title))
            {
                return cachedSearchResult.GetValueOrDefault(title);
            }

            IProductRepository productRepository = new ProductRepositoryWS();

            var resultToReturn = productRepository.SearchProducts(title);

            cachedSearchResult.Add(title, resultToReturn);

            if (cachedSearchResult.Count > 10)
            {
                cachedSearchResult.Remove(cachedSearchResult.Keys.First());
            }

            return resultToReturn;
        }
    }
}
