using Aspnet_api_products.Models;
using Aspnet_api_products.Repositories;
using Aspnet_api_products.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Aspnet_api_products.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        public List<ProductDTO>? FetchAllJSONObjects()
        {
            ProductService productService = new ProductService();
            return productService.GetAllProducts();
        }

        [HttpGet("{id}")]
        public Product? FetchOneJSONObject(int id)
        {
            ProductService productService = new ProductService();
            return productService.GetOneProduct(id);
        }

        [HttpGet("search")]
        public List<ProductDTO>? SearchProducts([FromQuery] string title)
        {
            ProductService productsService = new ProductService();
            return productsService.SearchProducts(title);
        }

        [HttpGet("categories/{category}")]
        public List<ProductDTO>? FilterProducts([FromQuery] float? minPrice, [FromQuery] float? maxPrice, string category) { 
            ProductService productsService = new ProductService();
            return productsService.FilterProducts(category, minPrice, maxPrice);
        }
    }
}
