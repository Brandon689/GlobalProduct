using System.Text.Json.Serialization;

namespace GlobalProduct.ExternalProducts
{
    public class ExternalProduct
    {
        [JsonPropertyName("id")]
        public long? Id { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("body_html")]
        public string? BodyHtml { get; set; }

        [JsonPropertyName("vendor")]
        public string? Vendor { get; set; }

        [JsonPropertyName("product_type")]
        public string? ProductType { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("handle")]
        public string? Handle { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("published_at")]
        public DateTime? PublishedAt { get; set; }

        [JsonPropertyName("template_suffix")]
        public string? TemplateSuffix { get; set; }

        [JsonPropertyName("published_scope")]
        public string? PublishedScope { get; set; }

        [JsonPropertyName("tags")]
        public string? Tags { get; set; }

        [JsonPropertyName("variants")]
        public List<ExternalVariant>? Variants { get; set; }

        [JsonPropertyName("options")]
        public List<ExternalOption>? Options { get; set; }

        [JsonPropertyName("images")]
        public List<ExternalImage>? Images { get; set; }

        //[JsonPropertyName("image")]
        //public Image? Image { get; set; }

        //added
        public string? Currency { get; set; }

        //public long AliExpressId { get; set; }
        public string? Url { get; set; }

        public double? averageStar { get; set; }
        public int? feedbacks { get; set; }

        public int? wishListCount { get; set; }

        public double? averageStarRate { get; set; }
        public string sales { get; set; }

        public ExternalShop Shop { get; set; }

        public ExternalChannel Channel { get; set; }
    }
}