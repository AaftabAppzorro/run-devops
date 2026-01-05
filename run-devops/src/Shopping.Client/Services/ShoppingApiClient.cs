using Shopping.Client.Models;

namespace Shopping.Client.Services;

public sealed class ShoppingApiClient(HttpClient httpClient) : IShoppingApiClient
{
    public async Task<IEnumerable<ProductViewModel>> GetProductsAsync()
    {
        var response = await httpClient.GetFromJsonAsync<IEnumerable<ProductViewModel>>("api/products");
        return response ?? Enumerable.Empty<ProductViewModel>();
    }
}
