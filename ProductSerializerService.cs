using GlobalProduct.ProductJSON;
using GlobalProduct.ProductUI;

namespace GlobalProduct
{
    public class ProductSerializerService
    {
        public UIProduct Ui(Product product)
        {
            UIProduct uiProduct = new UIProduct
            {
                MainPrice = product.Variants[0].Price,
                MainSalePrice = product.Variants[0].CompareAtPrice,
                Title = product.Title,
                Sales = product.sales,
                averageStar = product.averageStar,
                AverageStarRate = product.averageStarRate,
                Feedback = product.feedbacks,
                Currency = product.Currency,
                Id2 = product.Id2,
                Variants = product.Variants.Select(x => new UIVariant
                {
                    ID = x.ID,
                    Id2 = x.Id2,
                    Title = x.Title,
                    Price = x.Price,
                    Sku = x.Sku,
                    Position = x.Position,
                    CompareAtPrice = x.CompareAtPrice,
                    FulfillmentService = x.FulfillmentService,
                    InventoryManagement = x.InventoryManagement,
                    Option1 = x.Option1,
                    Option2 = x.Option2,
                    Option3 = x.Option3,
                    CreatedAt = x.CreatedAt,
                    UpdatedAt = x.UpdatedAt,
                    ImageId = x.ImageId,
                }).ToList(),
                Images = product.Images.Select(x => new UIImage
                {
                    Name = x.Name,
                    Path = x.Src,
                    Alt = x.Alt,
                    ID = x.ID,
                    Id2 = x.Id2,
                    VariantIds = x.VariantIds,
                    RelativePath = $"assets\\{product.Channel.Name}\\{product.Shop.Name.Replace(" ", "_")}\\{product.Id2}\\{Util.GetAltImagePath(x.Src)}"
                }).ToList(),
                Shop = new UIShop
                {
                    ID = product.ID,
                    Name = product.Shop.Name,
                    Url = product.Shop.Url,
                },
                Options = product.Options.Select(x => new UIOption
                {
                    ID = x.ID,
                    Name = x.Name,
                    Values = x.Values,
                }).ToList()
            };
            for (int i = 0; i < uiProduct.Variants.Count; i++)
            {
                uiProduct.Variants[i].RelativeImagePath = uiProduct.Images.Find(x => x.Id2 == uiProduct.Variants[i].Id2)?.RelativePath;
            }
            return uiProduct;
        }
    }
}
