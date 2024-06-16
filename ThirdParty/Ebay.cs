//using System.ComponentModel;
//using System.Xml.Serialization;

//namespace GlobalProduct.ThirdParty;

//public class Item
//{
//    [XmlElement("BuyItNowPrice")]
//    public AmountType BuyItNowPrice { get; set; }

//    public string Country { get; set; }

//    public string Currency { get; set; }

//    public string Description { get; set; }

//    public string ItemID { get; set; }

//    public string ListingDuration { get; set; }

//    public string ListingType { get; set; }

//    public string Location { get; set; }

//    public PrimaryCategory PrimaryCategory { get; set; }

//    public ProductListingDetails ProductListingDetails { get; set; }

//    [DefaultValue(-1)]
//    public int Quantity { get; set; } = -1;

//    [DefaultValue(-1)]
//    public int QuantityAvailable { get; set; } = -1;

//    public string Site { get; set; }

//    [XmlElement("StartPrice")]
//    public AmountType StartPrice { get; set; }
//    public string Title { get; set; }

//    [DefaultValue(null)]
//    public bool? GetItFast { get; set; } = null;

//    public string SKU { get; set; }

//    public PictureDetails PictureDetails { get; set; }

//    [DefaultValue(0)]
//    public int DispatchTimeMax { get; set; }

//    [DefaultValue(null)]
//    public bool? ProxyItem { get; set; } = null;

//    [XmlElement("BuyerGuaranteePrice")]
//    public AmountType BuyerGuaranteePrice { get; set; }

//    [DefaultValue(0)]
//    public int ConditionID { get; set; }

//    public string ConditionDisplayName { get; set; }

//    public SellerProfiles SellerProfiles { get; set; }

//    [DefaultValue(null)]
//    public bool? HideFromSearch { get; set; } = null;

//    [DefaultValue(null)]
//    public bool? OutOfStockControl { get; set; } = null;

//    [XmlElement("PaymentMethods")]
//    public string[] PaymentMethods { get; set; }

//    public string SubTitle { get; set; }

//    public string PostalCode { get; set; }

//    public ItemSpecifics ItemSpecifics { get; set; }

//    public string SellerProvidedTitle { get; set; }

//    [XmlElement("Variations")]
//    public Variations Variations { get; set; }

//    public string VIN { get; set; }
//}
//[XmlRoot("ProductListingDetails")]
//public class ProductListingDetails
//{
//    [XmlElement("BrandMPN")]
//    public BrandMPN BrandMPN { get; set; }
//}
//public class SellerProfiles
//{
//    public SellerShippingProfile SellerShippingProfile { get; set; }

//    public SellerReturnProfile SellerReturnProfile { get; set; }

//    public SellerPaymentProfile SellerPaymentProfile { get; set; }
//}
//public class PictureDetails
//{
//    public string GalleryType { get; set; }

//    public string PhotoDisplay { get; set; }

//    [XmlElement("PictureURL")]
//    public string[] PictureURL { get; set; }

//    public string PictureSource { get; set; }
//}
//public class SellerShippingProfile
//{
//    public string ShippingProfileID { get; set; }
//}
//public class SellerReturnProfile
//{
//    public string ReturnProfileID { get; set; }
//}
//public class SellerPaymentProfile
//{
//    public string PaymentProfileID { get; set; }
//}
//[XmlRoot("BrandMPN")]
//public class BrandMPN
//{
//    [XmlElement("Brand")]
//    public string Brand { get; set; }

//    [XmlElement("MPN")]
//    public string MPN { get; set; }
//}
//public class ItemSpecifics
//{
//    [XmlElement("NameValueList")]
//    public NameValueList[] NameValueList { get; set; }
//}

//public class NameValueList
//{
//    [XmlElement("Name")]
//    public string Name { get; set; }

//    [XmlElement("Value")]
//    public string[] Value { get; set; }
//}

//public class PrimaryCategory
//{
//    public int CategoryID { get; set; }
//}

//[XmlRoot("AmountType")]
//public class AmountType
//{
//    [XmlAttribute(AttributeName = "currencyID")]
//    public string CurrencyID { get; set; }

//    [XmlText]
//    public string Text { get; set; }
//}

//[XmlRoot("Variations")]
//public class Variations
//{
//    [XmlElement("Variation")]
//    public Variation[] Variation { get; set; }

//    [XmlElement("Pictures")]
//    public Pictures Pictures { get; set; }

//    [XmlElement("VariationSpecificsSet")]
//    public VariationSpecificsSet VariationSpecificsSet { get; set; }
//}

//[XmlRoot("Pictures")]
//public class Pictures
//{
//    [XmlElement("VariationSpecificName")]
//    public string VariationSpecificName { get; set; }

//    [XmlElement("VariationSpecificPictureSet")]
//    public VariationSpecificPictureSet[] VariationSpecificPictureSet { get; set; }
//}

//[XmlRoot("VariationSpecificsSet")]
//public class VariationSpecificsSet
//{
//    [XmlElement("NameValueList")]
//    public NameValueList[] NameValueList { get; set; }
//}

//[XmlRoot("VariationSpecificPictureSet")]
//public class VariationSpecificPictureSet
//{
//    [XmlElement("VariationSpecificValue")]
//    public string VariationSpecificValue { get; set; }

//    [XmlElement("PictureURL")]
//    public string PictureURL { get; set; }
//}

//[XmlRoot("Variation")]
//public class Variation
//{
//    [XmlElement("SKU")]
//    public string SKU { get; set; }

//    [XmlElement("StartPrice")]
//    public AmountType StartPrice { get; set; }

//    [XmlElement("Quantity")]
//    public int Quantity { get; set; }

//    public int UnitsAvailable { get; set; }

//    [XmlElement("VariationSpecifics")]
//    public VariationSpecifics VariationSpecifics { get; set; }

//    //[XmlElement("SellingStatus")]
//    //public SellingStatus SellingStatus { get; set; }

//    //[XmlElement("VariationProductListingDetails")]
//    //public VariationProductListingDetails VariationProductListingDetails { get; set; }

//    public string PrivateNotes { get; set; }

//    public string VariationTitle { get; set; }

//    public string VariationViewItemURL { get; set; }

//    public long WatchCount { get; set; }

//    //public DiscountPriceInfo DiscountPriceInfo { get; set; }

//    [DefaultValue(null)]
//    public bool? Delete { get; set; }

//    public bool ShouldSerializeDelete() => Delete != null;
//}

//public class VariationSpecifics
//{
//    [XmlElement("NameValueList")]
//    public NameValueList[] NameValueList { get; set; }
//}