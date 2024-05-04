using BlazorWebAppPlaground.Applications.Categories;
using BlazorWebAppPlaground.Domain;

namespace BlazorWebAppPlaground.Applications.Extensions;

public static class ProductExtentions
{
    public static ProductDto MapToDto(this Product product) => new() { Name = product.Name };
}
