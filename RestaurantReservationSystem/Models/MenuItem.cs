namespace RestaurantReservationSystem.Models
{
    public class MenuItem
    {
        private int id;
        private string name;
        private string category;
        private string available;
        private int price;
        private string details;
        private string image;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public string Available { get => available; set => available = value; }
        public int Price { get => price; set => price = value; }
        public string Details { get => details; set => details = value; }
        public string Image { get => image; set => image = value; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public ICollection<VoucherMenu> VoucherMenus { get; set; } = new List<VoucherMenu>();   
    }
}
