namespace GlobalProduct.Products
{
    public class Image
    {
        public long Id { get; set; }

        public long ProductId { get; set; }

        public int? Position { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string? Alt { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        public string? Src { get; set; }

        public List<long>? VariantIds { get; set; }

        //public string RelativePath { get; set; }
        public string Name { get; set; }
    }
}