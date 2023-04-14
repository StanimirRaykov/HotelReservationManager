namespace HotelReservationManager.Data
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public string Title { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
