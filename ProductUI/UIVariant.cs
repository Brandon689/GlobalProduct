namespace GlobalProduct.ProductUI
{
    public class UIVariant
    {
        public long Id { get; set; }

        public string? Title { get; set; }

        public string? Price { get; set; }

        public string? Sku { get; set; }

        public int? Position { get; set; }

        public string? CompareAtPrice { get; set; }

        public string? FulfillmentService { get; set; }

        public string? InventoryManagement { get; set; }

        public string? Option1 { get; set; }

        public string? Option2 { get; set; }

        public string? Option3 { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long? ImageId { get; set; }

        public string? RelativeImagePath { get; set; }
    }
}
