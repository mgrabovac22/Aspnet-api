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
        public List<ProductDTO> FetchAllJSONObjects()
        {
            ProductService productService = new ProductService();
            return productService.GetAllProducts();
        }
        [HttpGet("{title}")]
        public Product FetchOneJSONObject(string title)
        {
            ProductService productService = new ProductService();
            return productService.GetOneProduct(title);
        }
    }
}
