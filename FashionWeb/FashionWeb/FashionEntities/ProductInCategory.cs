namespace FashionWeb.Models
{
    public class ProductInCategory
    {
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}