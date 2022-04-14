namespace EcommerceApi.Controllers
{
    public class Product
    {
        public int ProductId { get; internal set; }
        public string Vendor { get; internal set; }
        public string ProductName { get; internal set; }
        public string ProductSize { get; internal set; }
        public string ProductDescription { get; internal set; }
        public string ProductColor { get; internal set; }
        public string Category { get; internal set; }
        public int? Discount { get; internal set; }
        public decimal? Mrp { get; internal set; }
        public decimal? FinalPrice { get; internal set; }
    }
}