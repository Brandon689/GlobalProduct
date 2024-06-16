namespace GlobalProduct.Product
{
    public class Image
    {
        public int ID { get; set; }

        public long Id2 { get; set; }

        public long ProductId2 { get; set; }

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