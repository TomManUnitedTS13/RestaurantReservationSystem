namespace RestaurantReservationSystem.Models
{
    public class OrderItem
    {
        private int id;
        private int orderId;
        private int menuItemId;
        private int quantity;
        private int price;
        public int Id { get => id; set => id = value; }
        public int OrderId { get => orderId; set => orderId = value; }
        public int MenuItemId { get => menuItemId; set => menuItemId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }

        public Order Order { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}
