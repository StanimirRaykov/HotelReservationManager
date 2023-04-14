namespace HotelReservationManager.Data
{
    public class Product : BaseEntity
    {
        public Product()
        {
            Categories = new HashSet<Category>();
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        
        public ICollection<Category> Categories { get; set;}
    }
}
