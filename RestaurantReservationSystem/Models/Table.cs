namespace RestaurantReservationSystem.Models
{
    public class Table
    {
        private int id;
        private string number;
        private int capacity;
        private string status;
        public int ID { get => id; set => id = value; }
        public string Number { get => number; set => number = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public string Status { get => status; set => status = value; }

        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
