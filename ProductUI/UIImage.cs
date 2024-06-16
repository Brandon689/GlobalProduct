namespace GlobalProduct.ProductUI
{
    public class UIImage
    {
        public long Id { get; set; }

        public string? Alt { get; set; }

        public string? Path { get; set; }

        public List<long>? VariantIds { get; set; }

        public string? RelativePath { get; set; }

        public string? Name { get; set; }
    }
}
