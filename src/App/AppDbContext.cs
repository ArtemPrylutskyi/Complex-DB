using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App;

public class AppDbContext : DbContext
{
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Car> Cars => Set<Car>();
    public DbSet<CarDetail> CarDetails => Set<CarDetail>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<CarOrder> CarOrders => Set<CarOrder>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=dealershipdb;Username=postgres;Password=postgres");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>()
            .HasOne(c => c.CarDetail)
            .WithOne(cd => cd.Car)
            .HasForeignKey<CarDetail>(cd => cd.CarId);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Customer)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o.CustomerId);

        modelBuilder.Entity<CarOrder>()
            .HasKey(co => new { co.CarId, co.OrderId });
    }
}
