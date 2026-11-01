namespace RestaurantReservationSystem.Models
{
    public class Notification
    {
        private int id;
        private int userId;
        private string title;
        private string message;
        private string type;
        private bool isRead;
        public int Id { get => id; set => id = value; }
        public int UserId { get => userId; set => userId = value; }
        public string Title { get => title; set => title = value; }
        public string Message { get => message; set => message = value; }
        public string Type { get => type; set => type = value; }
        public bool IsRead { get => isRead; set => isRead = value; }
        public User User { get; set; }
    }
}
