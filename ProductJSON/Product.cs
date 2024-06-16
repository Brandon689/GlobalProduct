using System.Text.Json.Serialization;

namespace GlobalProduct.ProductJSON
{
    public class Product
    {
        public int ID { get; set; }

        [JsonPropertyName("id")]
        public long? Id2 { get; set; }

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
        public string Handle { get; set; }

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
        public List<Variant>? Variants { get; set; }

        [JsonPropertyName("options")]
        public List<Option>? Options { get; set; }

        [JsonPropertyName("images")]
        public List<Image>? Images { get; set; }

        //[JsonPropertyName("image")]
        //public Image? Image { get; set; }

        //added
        public string Currency { get; set; }

        //public long AliExpressId { get; set; }
        public string Url { get; set; }

        public double? averageStar { get; set; }
        public int? feedbacks { get; set; }

        public int? wishListCount { get; set; }

        public double? averageStarRate { get; set; }
        public string sales { get; set; }

        public Shop Shop { get; set; }

        public Channel Channel { get; set; }
    }
}