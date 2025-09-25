using App;
using App.Models;

using var db = new AppDbContext();
db.Database.EnsureDeleted();
db.Database.EnsureCreated();

var customers = Enumerable.Range(1, 15).Select(i => new Customer
{
    Name = $"Customer {i}",
    Phone = $"000-111-22{i:D2}"
}).ToList();
db.Customers.AddRange(customers);

var cars = Enumerable.Range(1, 15).Select(i => new Car
{
    Model = $"Car Model {i}",
    Price = 20000 + i * 1000,
    CarDetail = new CarDetail
    {
        Color = i % 2 == 0 ? "Red" : "Blue",
        Engine = $"Engine {i}",
        Year = 2010 + (i % 10)
    }
}).ToList();
db.Cars.AddRange(cars);

var orders = Enumerable.Range(1, 15).Select(i => new Order
{
    Date = DateTime.Now.AddDays(-i),
    Customer = customers[i % customers.Count],
    CarOrders = new List<CarOrder>
    {
        new CarOrder { Car = cars[i % cars.Count] },
        new CarOrder { Car = cars[(i+1) % cars.Count] }
    }
}).ToList();
db.Orders.AddRange(orders);

db.SaveChanges();
Console.WriteLine("Database seeded with test data!");
