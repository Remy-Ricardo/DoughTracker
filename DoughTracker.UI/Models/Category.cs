namespace DoughTracker.Models;

public enum CategoryType
{
    Expense,
    Income
}

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public CategoryType Type { get; set; }
}
