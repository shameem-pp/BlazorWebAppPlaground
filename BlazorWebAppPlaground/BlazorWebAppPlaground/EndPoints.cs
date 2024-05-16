using BlazorWebAppPlaground.Applications.Categories;
using BlazorWebAppPlaground.Infra;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWebAppPlaground;

public static class EndPoints
{
    public static WebApplication UseEndPoints(this WebApplication app)
    {
        app.MapPost("createCategories", 
            CreateCategoriesCommand.SeedAsync);
        app.MapGet("scoped", GetCount);

        return app;
    }

    private static IResult GetCount([FromServices] ExampleDI e1,
        [FromServices] ExampleDI e2)
    {
        return Results.Ok(ExampleDI.Count);
    }

    private static IResult GetCount2([FromServices] ExampleDI e1) =>
        Results.Ok(ExampleDI.Count);

}



