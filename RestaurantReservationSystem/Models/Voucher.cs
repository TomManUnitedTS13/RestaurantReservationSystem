namespace RestaurantReservationSystem.Models
{
    public class Voucher
    {
        private int id;
        private string code;
        private string discountType;
        private int discountValue;
        private int minOrderAmount;
        private DateTime expiryDate;
        private int usageLimit;
        public int Id { get => id; set => id = value; }
        public string Code { get => code; set => code = value; }
        public string DiscountType { get => discountType; set => discountType = value; }
        public int DiscountValue { get => discountValue; set => discountValue = value; }
        public int MinOrderAmount { get => minOrderAmount; set => minOrderAmount = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
        public int UsageLimit { get => usageLimit; set => usageLimit = value; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        public ICollection<VoucherUsage> VoucherUsages { get; set; } = new List<VoucherUsage>();
        public ICollection<VoucherMenu> VoucherMenus { get; set; } = new List<VoucherMenu>();
    }
}
