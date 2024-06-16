using System.Text.Json.Serialization;

namespace GlobalProduct.ExternalProducts;

public class ExternalChannel
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}