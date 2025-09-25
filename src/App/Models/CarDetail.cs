namespace App.Models;

public class CarDetail
{
    public int Id { get; set; }
    public string Color { get; set; } = null!;
    public string Engine { get; set; } = null!;
    public int Year { get; set; }

    public int CarId { get; set; }
    public Car Car { get; set; } = null!;
}
