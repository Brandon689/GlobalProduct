using GlobalProduct.Products;
using GlobalProduct.ThirdParty;
using static System.Net.Mime.MediaTypeNames;

namespace GlobalProduct.Mapper;

public static class WooCommerceMapper
{
    public static WooCommerceProduct Map(Product p)
    {
        WooCommerceProduct product = new WooCommerceProduct()
        {
            Name = p.Title,
            Description = p.BodyHtml,
            Sku = p.Sku,
            Images = p.Images.Where(x => x.VariantIds.Count == 0).Select(x => new WooCommerceImage
            //Images = p.Images.Select(x => new WooCommerceImage
            {
                Src = x.Src,
                Alt = x.Alt,
                Name = x.Name,
            }).ToArray(),
        };
        if (p.Single())
        {
            var a = p.Variants[0];
            product.RegularPrice = a.Price;
        }
        return product;
    }

    public static List<ProductVariation> Map2(Product p)
    {
        List<string> variantLabels = p.Options.Select(x => x.Name).ToList();
        List<ProductVariation> productVariations = new List<ProductVariation>();
        for (int i = 0; i < p.Variants.Count; i++)
        {
            int variants = p.Options.Count;
            ProductVariation v = new();
            productVariations.Add(v);
            v.RegularPrice = p.Variants[i].Price;

            // image
            var f = p.Images.Find(x => x.VariantIds.Contains(p.Variants[i].Id));
            v.Image = new WooCommerceImage()
            {
                Src = f.Src
            };

            // variations
            v.Attributes = new ProductVariationAttribute[variants];
            for (int j = 0; j < variants; j++)
            {
                string opt = p.Variants[i].Option1;
                if (j == 1) opt = p.Variants[i].Option2;
                else if (j == 2) opt = p.Variants[i].Option3;
                v.Attributes[j] = new ProductVariationAttribute()
                {
                    Name = p.Options[j].Name,
                    Option = opt
                };        
            }
        }
        return productVariations;
    }
}
