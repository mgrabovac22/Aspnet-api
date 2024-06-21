namespace Aspnet_api_products.Models
{
    public class ProductDTO
    {
        public string title { get; set; }
        public string? description { get; set; }
        public string? thumbnail { get; set; }
        public float? price { get; set; }

        public ProductDTO(string title, string description, string thumbnail, float price)
        {
            this.title = title;
            this.description = description;
            this.thumbnail = thumbnail;
            this.price = price;
        }
    }
}
