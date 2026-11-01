namespace RestaurantReservationSystem.Models
{
    public class VoucherMenu
    {
        private int id;
        private int voucherId;
        private int menuItemId;
        public int Id { get { return id; } set { id = value; } }
        public int VoucherId { get { return voucherId; } set { voucherId = value; } }
        public int MenuItemId { get { return menuItemId; } set { menuItemId = value; } }
        public Voucher Voucher { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}
