using Microsoft.EntityFrameworkCore;

namespace RestaurantReservationSystem.Models
{
    public class RestaurantReservationSystemDbContext : DbContext
    {
        public RestaurantReservationSystemDbContext(DbContextOptions<RestaurantReservationSystemDbContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<VoucherUsage> VoucherUsages { get; set; }
        public DbSet<VoucherMenu> VoucherMenus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MenuItem>(entity => {
                entity.HasKey(x => x.Id); 
                entity.Property(x => x.Name).IsRequired().HasMaxLength(200); 
                entity.Property(x => x.Category).HasMaxLength(100); 
                entity.Property(x => x.Available).HasMaxLength(50); 
                entity.Property(x => x.Details).HasMaxLength(1000); 
                entity.Property(x => x.Image).HasMaxLength(500); 
            });

            modelBuilder.Entity<User>(entity => {
                entity.HasKey(x => x.Id); 
                entity.Property(x => x.Name).IsRequired().HasMaxLength(100); 
                entity.Property(x => x.Email).IsRequired().HasMaxLength(255); 
                entity.Property(x => x.Password).IsRequired(); 
                entity.Property(x => x.Role).IsRequired().HasMaxLength(50); 
                entity.Property(x => x.Phone).HasMaxLength(20); 
                entity.Property(x => x.Image).HasMaxLength(500); 
                entity.HasIndex(x => x.Email).IsUnique(); 
            });

            modelBuilder.Entity<Notification>(entity => { 
                entity.HasKey(x => x.Id); 
                entity.Property(x => x.Title).IsRequired().HasMaxLength(200); 
                entity.Property(x => x.Message).IsRequired().HasMaxLength(1000); 
                entity.Property(x => x.Type).HasMaxLength(50); 
                entity.HasOne(x => x.User)
                .WithMany(x => x.Notifications)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict); });

            modelBuilder.Entity<Order>(entity => {
                entity.HasKey(x => x.Id); 
                entity.Property(x => x.Status).IsRequired().HasMaxLength(50); 
                entity.HasOne(x => x.Reservation) 
                .WithMany() 
                .HasForeignKey(x => x.ReservationId) 
                .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(x => x.Staff) 
                .WithMany(x => x.Orders) 
                .HasForeignKey(x => x.StaffId) 
                .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(x => x.Voucher) 
                .WithMany(x => x.Orders) 
                .HasForeignKey(x => x.VoucherId) 
                .IsRequired(false) 
                .OnDelete(DeleteBehavior.Restrict); });
            
            modelBuilder.Entity<OrderItem>(entity => { 
                entity.HasKey(x => x.Id); 
                entity.HasOne(x => x.Order)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(x => x.MenuItem)
                .WithMany(x => x.OrderItems)
                .HasForeignKey(x => x.MenuItemId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Payment>(entity => { 
                entity.HasKey(x => x.Id); 
                entity.Property(x => x.Method)
                .IsRequired()
                .HasMaxLength(50); 
                entity.Property(x => x.Status)
                .IsRequired()
                .HasMaxLength(50); 
                entity.HasOne(x => x.Order)
                .WithMany(x => x.Payments)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Restrict); });

            modelBuilder.Entity<Reservation>(entity => {
                entity.HasKey(x => x.Id); 
                entity.Property(x => x.Status).IsRequired().HasMaxLength(50);  
                entity.HasOne(x => x.User) 
                .WithMany(x => x.Reservations) 
                .HasForeignKey(x => x.CustomerId) 
                .OnDelete(DeleteBehavior.Restrict); 
                entity.HasOne(x => x.Table) 
                .WithMany(x => x.Reservations) 
                .HasForeignKey(x => x.TableId) 
                .OnDelete(DeleteBehavior.Restrict); 
                entity.HasOne(x => x.Voucher) 
                .WithMany(x => x.Reservations) 
                .HasForeignKey(x => x.VoucherId) 
                .OnDelete(DeleteBehavior.Restrict); });

            modelBuilder.Entity<Table>(entity => { 
                entity.HasKey(x => x.ID); 
                entity.Property(x => x.Number)
                .IsRequired()
                .HasMaxLength(20); 
                entity.Property(x => x.Status)
                .IsRequired()
                .HasMaxLength(50); });

            modelBuilder.Entity<Voucher>(entity => { 
                entity.HasKey(x => x.Id); 
                entity.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(50); 
                entity.Property(x => x.DiscountType)
                .IsRequired()
                .HasMaxLength(50); 
                entity.HasIndex(x => x.Code)
                .IsUnique(); 
            });

            modelBuilder.Entity<VoucherMenu>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.HasOne(x => x.Voucher)
                .WithMany(x => x.VoucherMenus)
                .HasForeignKey(x => x.VoucherId)
                .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(x => x.MenuItem)
                .WithMany(x => x.VoucherMenus)
                .HasForeignKey(x => x.MenuItemId)
                .OnDelete(DeleteBehavior.Restrict);
                entity.HasIndex(x => new
                { x.VoucherId, x.MenuItemId })
                .IsUnique();
            });

            modelBuilder.Entity<VoucherUsage>(entity => { 
                entity.HasKey(x => x.Id); 
                entity.HasOne(x => x.Voucher)
                .WithMany(x => x.VoucherUsages)
                .HasForeignKey(x => x.VoucherId)
                .OnDelete(DeleteBehavior.Restrict); 
                entity.HasOne(x => x.User)
                .WithMany(x => x.VoucherUsages)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict); 
                entity.HasOne(x => x.Reservation)
                .WithMany(x => x.VoucherUsages)
                .HasForeignKey(x => x.ReservationId)
                .OnDelete(DeleteBehavior.Restrict); });
        }
    }
}
