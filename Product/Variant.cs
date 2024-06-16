namespace GlobalProduct.Product
{
    public class Variant
    {
        public int ID { get; set; }

        public long Id2 { get; set; }

        public long ProductId2 { get; set; }

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

        public bool? Taxable { get; set; }

        public string? Barcode { get; set; }

        public int? Grams { get; set; }

        public long? ImageId { get; set; }

        public double? Weight { get; set; }

        public string? WeightUnit { get; set; }

        public bool? RequiresShipping { get; set; }
    }
}