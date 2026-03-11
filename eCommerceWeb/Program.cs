using eCommerce.DataAccess;
using eCommerce.Models;
using eCommerce.Utility;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var repository = new ProductRepository();

app.MapGet("/", () => "eCommerceWeb is running");

app.MapGet("/products", () => repository.GetAll());

app.MapGet("/cart/total", () =>
{
    var products = repository.GetAll();
    var cart = new List<CartItem>
    {
        new() { Product = products[0], Quantity = 1 },
        new() { Product = products[2], Quantity = 2 }
    };

    return Results.Ok(new
    {
        Items = cart.Count,
        Total = PricingHelper.CalculateCartTotal(cart)
    });
});

app.Run();
