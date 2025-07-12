namespace DoughTracker.Models;

public class BudgetItem
{
    public int Id { get; set; }
    public int BudgetId { get; set; }
    public int CategoryId { get; set; }
    public decimal Amount { get; set; }
}
