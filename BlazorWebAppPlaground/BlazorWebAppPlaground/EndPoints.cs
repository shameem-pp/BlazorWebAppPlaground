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
        var group = app.MapGroup("servicelifetime");
        group.MapGet("/singleton", GetSingletonCount);
        group.MapGet("/scopped", GetScoppedCount);
        group.MapGet("/transient", GetTransientCount);
        return app;
    }

    private static IResult GetScoppedCount([FromServices] Scopped e1,
        [FromServices] Scopped e2)
    {
        return Results.Ok(Scopped.Count);
    }

    private static IResult GetSingletonCount([FromServices] Singleton e1) =>
        Results.Ok(Singleton.Count);

    private static IResult GetTransientCount([FromServices] Transient e1,
                                             [FromServices] Transient e2) =>
        Results.Ok(Transient.Count);

}



