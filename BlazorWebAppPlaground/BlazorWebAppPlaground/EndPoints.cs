using BlazorWebAppPlaground.Applications.Categories;

namespace BlazorWebAppPlaground;

public static class EndPoints
{
    public static WebApplication UseEndPoints(this WebApplication app)
    {
        app.MapPost("createCategories", CreateCategoriesCommand.SeedAsync);
        return app;
    }

}



