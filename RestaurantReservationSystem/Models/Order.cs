namespace RestaurantReservationSystem.Models
{
    public class Order
    {
        private int id;
        private int reservationId;
        private string status;
        private int totalPrice;
        private int staffId;
        private int voucherId;
        public int Id { get => id; set => id = value; }
        public int ReservationId { get => reservationId; set => reservationId = value; }
        public string Status { get => status; set => status = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int StaffId { get => staffId; set => staffId = value; }
        public int? VoucherId { get; set; }
        public Reservation Reservation { get; set; }
        public User Staff { get; set; }
        public Voucher? Voucher { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
