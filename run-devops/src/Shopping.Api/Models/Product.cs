namespace Shopping.Api.Models;

public sealed class Product
{
    public Guid Id { get; init; }
    public string Name { get; init; } = default!;
    public decimal Price { get; init; }
}
