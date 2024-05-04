namespace BlazorWebAppPlaground.Domain;

public class Category
{
    private Category() { }
    public int Id { get; set; }
    public int? ParentCategoryId { get; private set; }
    public Category? ParentCategory { get; private set; }
    public string Name { get; private set; } = default!;
    public List<Product> Products { get; private set; } = default!;

    public static Category Create(int? parentCategoryId, string name, List<Product> products) => new()
    {
        Name = name,
        ParentCategoryId = parentCategoryId,
        Products = products,
    };
}



