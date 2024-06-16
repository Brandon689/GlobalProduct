using System.Text.Json.Serialization;

namespace GlobalProduct.ExternalProducts
{
    public class ExternalImage
    {
        [JsonPropertyName("id")]
        public long Id2 { get; set; }

        [JsonPropertyName("product_id")]
        public long ProductId2 { get; set; }

        [JsonPropertyName("position")]
        public int? Position { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("alt")]
        public string? Alt { get; set; }

        [JsonPropertyName("width")]
        public int? Width { get; set; }

        [JsonPropertyName("height")]
        public int? Height { get; set; }

        [JsonPropertyName("src")]
        public string? Src { get; set; }

        [JsonPropertyName("variant_ids")]
        public List<long>? VariantIds { get; set; }

        //public string RelativePath { get; set; }
        public string? Name { get; set; }
    }
}