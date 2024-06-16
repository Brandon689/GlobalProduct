using System.Text.Json.Serialization;

namespace GlobalProduct.ProductJSON
{
    public class Channel
    {
        public int ID { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}