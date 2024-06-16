namespace GlobalProduct.ThirdParty;

public class WooCommerceProduct
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; } = "simple";

    public string? Description { get; set; }

    public string? RegularPrice { get; set; }

    public WooCommerceImage[]? Images { get; set; }

    public ProductMetadata[]? MetaData { get; set; }

    public string? Slug { get; set; }

    public string? Permalink { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateCreatedGmt { get; set; }

    public DateTime? DateModified { get; set; }

    public DateTime? DateModifiedGmt { get; set; }

    public string? Status { get; set; }

    public bool? Featured { get; set; }

    public string? CatalogVisibility { get; set; }

    public string? ShortDescription { get; set; }

    public string? Sku { get; set; }

    public string? Price { get; set; }

    public string? SalePrice { get; set; }

    public DateTime? DateOnSaleFrom { get; set; }

    public DateTime? DateOnSaleFromGmt { get; set; }

    public DateTime? DateOnSaleTo { get; set; }

    public DateTime? DateOnSaleToGmt { get; set; }

    public string? PriceHtml { get; set; }

    public bool? OnSale { get; set; }

    public bool? Purchasable { get; set; }

    public int? TotalSales { get; set; }

    public bool? Virtual { get; set; }

    public bool? Downloadable { get; set; }

    //public List<object> Downloads { get; set; }

    //public int DownloadLimit { get; set; }

    //public int DownloadExpiry { get; set; }

    public string? ExternalUrl { get; set; }

    public string? ButtonText { get; set; }

    public string? TaxStatus { get; set; }

    public string? TaxClass { get; set; }

    public bool? ManageStock { get; set; }

    public int? StockQuantity { get; set; }

    public string? StockStatus { get; set; }

    public string? Backorders { get; set; }

    public bool? BackordersAllowed { get; set; }

    public bool? Backordered { get; set; }

    public bool? SoldIndividually { get; set; }

    public string? Weight { get; set; }

    public Dimensions? Dimensions { get; set; }

    public bool? ShippingRequired { get; set; }

    public bool? ShippingTaxable { get; set; }

    public string? ShippingClass { get; set; }

    public int? ShippingClassId { get; set; }

    public bool? ReviewsAllowed { get; set; }

    public string? AverageRating { get; set; }

    public int? RatingCount { get; set; }

    public int[] RelatedIds { get; set; }

    //public List<object> UpsellIds { get; set; }

    public object[] CrossSellIds { get; set; }

    public int? ParentId { get; set; }

    public string? PurchaseNote { get; set; }

    public Category[]? Categories { get; set; }

    public Tag[]? Tags { get; set; }

    public ProductAttribute[]? Attributes { get; set; }

    public DefaultAttribute[]? DefaultAttributes { get; set; }

    public int[]? Variations { get; set; }

    //public List<object> GroupedProducts { get; set; }

    public int? MenuOrder { get; set; }

    public Links? Links { get; set; }
}

public class ProductMetadata
{
    public int? Id { get; set; }

    public string? Key { get; set; }

    public string? Value { get; set; }
}

public class WooCommerceImage
{
    public int Id { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateCreatedGmt { get; set; }

    public DateTime? DateModified { get; set; }

    public DateTime? DateModifiedGmt { get; set; }

    public string? Src { get; set; }

    public string? Name { get; set; }

    public string? Alt { get; set; }
}

public class Dimensions
{
    public string? Length { get; set; }

    public string? Width { get; set; }

    public string? Height { get; set; }
}

public class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Slug { get; set; }
}

public class Tag
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Slug { get; set; }
}

public class ProductAttribute
{
    public int Id { get; set; } = 0;

    public int Position { get; set; } = 0;

    public string Name { get; set; } = string.Empty;

    public bool Visible { get; set; } = true;

    public bool Variation { get; set; } = false;

    public string[] Options { get; set; } = null;
}

public class DefaultAttribute
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Option { get; set; }
}

public class Links
{
    public Self[] Self { get; set; }

    public Collection[] Collection { get; set; }
}

public class Self
{
    public string? Href { get; set; }
}

public class Collection
{
    public string? Href { get; set; }
}





public class ProductVariation
{
    public int? Id { get; set; }

    public string? Sku { get; set; }

    public string? RegularPrice { get; set; }

    public ProductVariationAttribute[]? Attributes { get; set; }

    public WooCommerceImage? Image { get; set; }
}

public class ProductVariationAttribute
{
    public int Id { get; set; } = 0;

    public string Option { get; set; } = string.Empty;

    public string? Slug { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;
}