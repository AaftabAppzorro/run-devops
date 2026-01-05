using Microsoft.AspNetCore.Mvc;
using Shopping.Api.Models;

namespace Shopping.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class ProductsController : ControllerBase
{
    private static readonly List<Product> Products =
    [
        new() { Id = Guid.NewGuid(), Name = "Laptop", Price = 1200 },
        new() { Id = Guid.NewGuid(), Name = "Keyboard", Price = 80 },
        new() { Id = Guid.NewGuid(), Name = "Mouse", Price = 40 }
    ];

    [HttpGet]
    public ActionResult<IEnumerable<Product>> Get()
    {
        return Ok(Products);
    }
}
