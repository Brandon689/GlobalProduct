using System.Text.Json.Serialization;

namespace GlobalProduct.ExternalProducts
{
    public class ExternalShop
    {
        [JsonPropertyName("url")]
        public string? Url { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}