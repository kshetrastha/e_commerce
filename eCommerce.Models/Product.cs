namespace eCommerce.Models;

public sealed class Product
{
    public int Id { get; init; }
    public string Title { get; init; } = string.Empty;
    public decimal Price { get; init; }
}
