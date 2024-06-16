using System.Text.Json.Serialization;

namespace GlobalProduct.ProductJSON
{
    public class Shop
    {
        public int ID { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}