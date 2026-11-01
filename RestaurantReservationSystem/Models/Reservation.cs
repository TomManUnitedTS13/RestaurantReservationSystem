namespace RestaurantReservationSystem.Models
{
    public class Reservation
    {
        private int id;
        private int customerId;
        private int tableId;
        private DateTime time;
        private string status;
        private int numOfGuest;
        private int voucherId;
        public int Id { get { return id; } set { id = value; } }
        public int CustomerId { get { return customerId; } set { customerId = value; } }
        public int TableId { get { return tableId; } set { tableId = value; } }
        public DateTime Time { get { return time; } set { time = value; } }
        public string Status { get { return status; } set { status = value; } }
        public int NumOfGuest { get { return numOfGuest; } set { numOfGuest = value; } }
        public int VoucherId { get { return voucherId; } set { voucherId = value; } }
        public User User { get; set; }
        public Table Table { get; set; }
        public Voucher Voucher { get; set; }
        public ICollection<VoucherUsage> VoucherUsages { get; set; } = new List<VoucherUsage>();
    }
}
