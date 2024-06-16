namespace GlobalProduct.Products
{
    public class Product
    {
        public long? Id { get; set; }

        public string? Title { get; set; }

        public string? Sku { get; set; }

        public string? BodyHtml { get; set; }

        public string? Vendor { get; set; }

        public string? ProductType { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string? Handle { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? PublishedAt { get; set; }

        public string? TemplateSuffix { get; set; }

        public string? PublishedScope { get; set; }

        public string? Tags { get; set; }

        public List<Variant>? Variants { get; set; }

        public List<Option>? Options { get; set; }

        public List<Image>? Images { get; set; }

        //public Image? Image { get; set; }

        public Shop Shop { get; set; }

        public Channel Channel { get; set; }




        //
        public bool Single() => this?.Variants?.Count == 1;
    }
}