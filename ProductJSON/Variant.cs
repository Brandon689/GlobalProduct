using System.Text.Json.Serialization;

namespace GlobalProduct.ProductJSON
{
    public class Variant
    {
        public int ID { get; set; }

        [JsonPropertyName("id")]
        public long Id2 { get; set; }

        [JsonPropertyName("product_id")]
        public long ProductId2 { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("price")]
        public string? Price { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("position")]
        public int? Position { get; set; }

        [JsonPropertyName("compare_at_price")]
        public string? CompareAtPrice { get; set; }

        [JsonPropertyName("fulfillment_service")]
        public string? FulfillmentService { get; set; }

        [JsonPropertyName("inventory_management")]
        public string? InventoryManagement { get; set; }

        [JsonPropertyName("option1")]
        public string? Option1 { get; set; }

        [JsonPropertyName("option2")]
        public string? Option2 { get; set; }

        [JsonPropertyName("option3")]
        public string? Option3 { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("taxable")]
        public bool? Taxable { get; set; }

        [JsonPropertyName("barcode")]
        public string? Barcode { get; set; }

        [JsonPropertyName("grams")]
        public int? Grams { get; set; }

        [JsonPropertyName("image_id")]
        public long? ImageId { get; set; }

        [JsonPropertyName("weight")]
        public double? Weight { get; set; }

        [JsonPropertyName("weight_unit")]
        public string? WeightUnit { get; set; }

        [JsonPropertyName("requires_shipping")]
        public bool? RequiresShipping { get; set; }
    }
}