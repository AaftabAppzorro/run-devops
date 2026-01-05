namespace Shopping.Client.Models;

public sealed class ProductViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }
}
