namespace RestaurantReservationSystem.Models
{
    public class Payment
    {
        private int id; 
        private int orderId;
        private int amount;
        private string method;
        private string status;
        public int Id { get => id; set => id = value; }
        public int OrderId { get => orderId; set => orderId = value; }
        public int Amount { get => amount; set => amount = value; }
        public string Method { get => method; set => method = value; }
        public string Status { get => status; set => status = value; }
        public Order Order { get; set; }
    }
}
