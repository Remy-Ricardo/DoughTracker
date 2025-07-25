namespace DoughTracker.Models;

public class Transaction
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public int AccountId { get; set; }
    public int CategoryId { get; set; }
    public string Description { get; set; } = string.Empty;
}
