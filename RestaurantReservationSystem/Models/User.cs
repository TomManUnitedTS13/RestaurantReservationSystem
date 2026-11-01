using System.Linq.Expressions;

namespace RestaurantReservationSystem.Models
{
    public class User
    {
        private int id;
        private string name;
        private string email;
        private string password;
        private string role;
        private string phone;
        private DateTime created_at;
        private string image;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime CreatedAt { get => created_at; set => created_at = value; }
        public string Image { get => image; set => image = value; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        public ICollection<VoucherUsage> VoucherUsages { get; set; } = new List<VoucherUsage>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
    }
}
