namespace RestaurantReservationSystem.Models
{
    public class VoucherUsage
    {
        private int id;
        private int voucherId;
        private int userId;
        private int reservationId;
        public int Id { get { return id; } set { id = value; } }
        public int VoucherId { get { return voucherId; } set { voucherId = value; } }
        public int UserId { get { return userId; } set { userId = value; } }
        public int ReservationId { get { return reservationId; } set { reservationId = value; } }
        public Voucher Voucher { get; set; }
        public User User { get; set; }
        public Reservation Reservation { get; set; }
    }
}
