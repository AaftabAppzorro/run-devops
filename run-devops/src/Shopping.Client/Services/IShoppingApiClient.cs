using Shopping.Client.Models;

namespace Shopping.Client.Services;

public interface IShoppingApiClient
{
    Task<IEnumerable<ProductViewModel>> GetProductsAsync();
}
