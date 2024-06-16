using System.Text.Json.Serialization;

namespace GlobalProduct.ExternalProducts
{
    public class ExternalOption
    {
        [JsonPropertyName("id")]
        public long? Id { get; set; }

        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("position")]
        public int? Position { get; set; }

        [JsonPropertyName("values")]
        public List<string>? Values { get; set; }
    }
}