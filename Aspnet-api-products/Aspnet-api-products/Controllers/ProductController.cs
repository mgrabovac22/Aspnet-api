using Aspnet_api_products.Models;
using Aspnet_api_products.Repositories;
using Aspnet_api_products.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Aspnet_api_products.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        public List<ProductDTO> FetchJSON()
        {
            ProductService productService = new ProductService();
            return productService.GetAllProducts();
        }
    }
}
