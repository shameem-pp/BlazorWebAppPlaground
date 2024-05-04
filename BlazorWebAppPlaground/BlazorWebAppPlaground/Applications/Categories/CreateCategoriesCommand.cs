using BlazorWebAppPlaground.Domain;
using BlazorWebAppPlaground.Infra;
using Microsoft.AspNetCore.Mvc;
using Tynamix.ObjectFiller;

namespace BlazorWebAppPlaground.Applications.Categories;

public class CreateCategoriesCommand
{
    public static async Task SeedAsync([FromServices] AppDbContext context)
    {
        if(context.Categories.Count() is not 0) return;

        Category furnitureCategory = await CreateFurnitureCategory(context);
        await CreateElectricalCategoryAsync(context);
        await CreateSanitaryCategoryAsync(context);

        var diningTableProduct = Product.Create("Dining Table");
        var coffeeTable = Product.Create("Coffee Table");
        var computerTable = Product.Create("Computer Table");

        var tableProducts = new List<Product>() 
        {
            diningTableProduct,
            coffeeTable,
            computerTable
        };

        _ = Category.Create(furnitureCategory.Id, "Table", tableProducts);
    }

    private static async Task CreateSanitaryCategoryAsync(AppDbContext context)
    {
        var pvc = Product.Create("PVC Pipe");
        var washBasin = Product.Create("Wash Basin");
        var fosset = Product.Create("Fosset");

        var sanitaryProducts = new List<Product>()
        {
            pvc,
            washBasin,
            fosset,
        };

        _ = Category.Create(null, "Sanitary", sanitaryProducts);

        await context.SaveChangesAsync();

    }

    private static async Task CreateElectricalCategoryAsync(AppDbContext context)
    {
        var fan = Product.Create("Fan");
        var washingMachine = Product.Create("Washing Machine");
        var ac = Product.Create("Ac");

        var electricalProducts = new List<Product>()
        {
            fan,
            washingMachine,
            ac,
        };

        var electricalCategory = Category.Create(null, "Electricals", electricalProducts);

        await context.SaveChangesAsync();
    }

    private static async Task<Category> CreateFurnitureCategory(AppDbContext context)
    {
        var table = Product.Create("Table");
        var bed = Product.Create("Bed");
        var chair = Product.Create("Chair");

        var furnitureProducts = new List<Product>()
        {
            table,
            bed,
            chair,
        };

        var furnitureCategory = Category.Create(null, "Furniture", furnitureProducts);

        await context.SaveChangesAsync();

        return furnitureCategory;
    }
}

public class CategorySeeder
{


    public static IEnumerable<Category> GetCategories(int count)
    {
        for (int i = 0; i < count; i++)
        {
            var customerFiller = new Filler<Category>();
            customerFiller.Setup()
                .OnProperty(x => x.Id)
                .IgnoreIt()
                .OnProperty(x => x.Products)
                .Use(GetProducts(5).ToList());


            yield return customerFiller.Create();
        }
    }

    private static IEnumerable<Product> GetProducts(int count)
    {
        for (int i = 0; i < count; i++)
        {
            var customerFiller = new Filler<Product>();
            customerFiller.Setup()
                .OnProperty(x => x.Id)
                .IgnoreIt();


            yield return customerFiller.Create();
        }
    }

}

