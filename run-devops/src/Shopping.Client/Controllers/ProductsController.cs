using Microsoft.AspNetCore.Mvc;
using Shopping.Client.Services;

namespace Shopping.Client.Controllers;

public sealed class ProductsController(IShoppingApiClient apiClient) : Controller
{
    public async Task<IActionResult> Index()
    {
        var products = await apiClient.GetProductsAsync();
        return View(products);
    }
}
