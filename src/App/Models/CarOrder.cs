namespace App.Models;

public class CarOrder
{
    public int CarId { get; set; }
    public Car Car { get; set; } = null!;

    public int OrderId { get; set; }
    public Order Order { get; set; } = null!;
}
