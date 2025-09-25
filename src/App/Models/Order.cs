namespace App.Models;

public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;

    public List<CarOrder> CarOrders { get; set; } = new();
}
