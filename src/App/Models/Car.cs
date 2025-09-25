namespace App.Models;

public class Car
{
    public int Id { get; set; }
    public string Model { get; set; } = null!;
    public decimal Price { get; set; }

    public CarDetail CarDetail { get; set; } = null!;

    public List<CarOrder> CarOrders { get; set; } = new();
}
