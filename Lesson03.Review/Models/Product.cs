namespace Lesson03.Review.Models
{
    /// <summary>
    /// Product gồm : Id, Name, Image, Price, SalePrice, CategoryId, Description, Status, CreatedAt
    /// </summary>
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public double SalePrice { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt { get; set; }

    }
}
