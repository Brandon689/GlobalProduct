namespace GlobalProduct.Products
{
    public class Option
    {
        public long? Id { get; set; }

        public long ProductId { get; set; }

        public string? Name { get; set; }

        public int? Position { get; set; }

        public List<string>? Values { get; set; }
    }
}