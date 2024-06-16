using AutoMapper;
using GlobalProduct;
using GlobalProduct.ExternalProducts;
using GlobalProduct.Mapper;
using GlobalProduct.Products;
using System.Text.Json;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        string json = File.ReadAllText(@"C:\2024\5\GlobalProduct\j.json");
        ;
        var ext = JsonSerializer.Deserialize<ExternalProduct>(json);

        var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
        var mapper = config.CreateMapper();

        var destination = mapper.Map<Product>(ext);


        var p = WooCommerceMapper.Map(destination);
        var v = WooCommerceMapper.Map2(destination);
        ;
    }
}
