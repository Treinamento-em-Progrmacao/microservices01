namespace GeekShopping.ProductAPI.Data.ValueObjects
{
    public class ProductVO
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }
        public string Descripition { get; set; }
        public string CategoryName { get; set; }
        public string Image_URl { get; set; }
    }
}
