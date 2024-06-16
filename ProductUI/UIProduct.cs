namespace GlobalProduct.ProductUI
{
    public class UIProduct
    {
        public int ID { get; set; }

        public long? Id2 { get; set; }

        public string MainImagePath { get; set; }

        public string MainPrice { get; set; }

        public string MainSalePrice { get; set; }

        public string? Title { get; set; }

        public string? ProductType { get; set; }

        public DateTime? CreatedAt { get; set; }

        public List<UIVariant>? Variants { get; set; }

        public List<UIOption>? Options { get; set; }

        public List<UIImage>? Images { get; set; }

        public string Currency { get; set; }

        //public long AliExpressId { get; set; }

        public string Url { get; set; }

        public double? averageStar { get; set; }

        public int? Feedback { get; set; }

        public double? AverageStarRate { get; set; }

        public string Sales { get; set; }

        public UIShop Shop { get; set; }

        public UIChannel Channel { get; set; }
    }
}
