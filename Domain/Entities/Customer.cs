namespace Domain.Entities;
public class Customer
{
    public int CustomerId { get; set; }
    public required string CustomerName { get; set; }
    public string? CustomerEmail { get; set; }
}
//mayur phase 2, convert this into records as per Domain driven programming, like value object in DDD
