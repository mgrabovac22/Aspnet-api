namespace Aspnet_api_products.Models
{
    public class Result
    {
        public Product[] products { get; set; }
        public int total { get; set; }
        public int skip { get; set; }
        public int limit { get; set; }
    }
}
