namespace eCommerce.Models;

public sealed class CartItem
{
    public required Product Product { get; init; }
    public int Quantity { get; init; }
}
