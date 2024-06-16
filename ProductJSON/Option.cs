using System.Text.Json.Serialization;

namespace GlobalProduct.ProductJSON
{
    public class Option
    {
        public int ID { get; set; }

        [JsonPropertyName("id")]
        public long? Id2 { get; set; }

        [JsonPropertyName("product_id")]
        public long ProductId2 { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("position")]
        public int? Position { get; set; }

        [JsonPropertyName("values")]
        public List<string>? Values { get; set; }
    }
}