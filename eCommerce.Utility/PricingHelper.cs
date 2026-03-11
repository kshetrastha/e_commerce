using eCommerce.Models;

namespace eCommerce.Utility;

public static class PricingHelper
{
    public static decimal CalculateLineTotal(CartItem item)
    {
        ArgumentNullException.ThrowIfNull(item);
        return item.Product.Price * item.Quantity;
    }

    public static decimal CalculateCartTotal(IEnumerable<CartItem> items)
    {
        ArgumentNullException.ThrowIfNull(items);
        return items.Sum(CalculateLineTotal);
    }
}
