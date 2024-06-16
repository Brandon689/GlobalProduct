namespace GlobalProduct
{
    public static class Util
    {
        public static string GetImagePath(string imageUrl)
        {
            Uri uri = new(imageUrl);
            string[] segments = uri.Segments;
            return segments[^1].TrimEnd('/');
        }

        public static string GetAltImagePath(string imageUrl)
        {
            Uri uri = new(imageUrl);
            string[] segments = uri.Segments;
            string end = segments[^1];
            return segments[^2].TrimEnd('/') + end[end.IndexOf('.')..];
        }

        public static string GetImageName(string imageUrl)
        {
            string c = GetImagePath(imageUrl);
            return c[..c.IndexOf('.')];
        }

        public static string GetAltImageName(string imageUrl)
        {
            string c = GetAltImagePath(imageUrl);
            return c[..c.IndexOf('.')];
        }
    }
}
