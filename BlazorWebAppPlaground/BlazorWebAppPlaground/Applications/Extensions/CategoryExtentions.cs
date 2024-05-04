using BlazorWebAppPlaground.Applications.Categories;
using BlazorWebAppPlaground.Domain;

namespace BlazorWebAppPlaground.Applications.Extensions;

public static class CategoryExtentions
{
    public static CategoryDto MapToDto(this Category category) => new()
    {
        Name = category.Name
        ,
        Products = category.Products
            .Select(p => p.MapToDto())
            .ToList()
    };
}