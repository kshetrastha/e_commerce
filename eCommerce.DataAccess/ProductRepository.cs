using eCommerce.Models;

namespace eCommerce.DataAccess;

public sealed class ProductRepository
{
    private readonly List<Product> _products =
    [
        new Product { Id = 1, Title = "Laptop", Price = 799.99m },
        new Product { Id = 2, Title = "Phone", Price = 599.99m },
        new Product { Id = 3, Title = "Headphones", Price = 149.99m }
    ];

    public IReadOnlyList<Product> GetAll()
    {
        return _products;
    }

    public Product? GetById(int id)
    {
        return _products.FirstOrDefault(x => x.Id == id);
    }
}
