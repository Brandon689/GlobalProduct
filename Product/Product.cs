namespace GlobalProduct.Product
{
    public class Product
    {
        public int ID { get; set; }

        public long? Id2 { get; set; }

        public string? Title { get; set; }

        public string? BodyHtml { get; set; }

        public string? Vendor { get; set; }

        public string? ProductType { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string Handle { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? PublishedAt { get; set; }

        public string? TemplateSuffix { get; set; }

        public string? PublishedScope { get; set; }

        public string? Tags { get; set; }

        public List<Variant>? Variants { get; set; }

        public List<Option>? Options { get; set; }

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