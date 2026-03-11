using eCommerce.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceWeb.Controllers;

public class ProductController(ProductRepository repository) : Controller
{
    public IActionResult Index()
    {
        var products = repository.GetAll();
        return View(products);
    }
}
