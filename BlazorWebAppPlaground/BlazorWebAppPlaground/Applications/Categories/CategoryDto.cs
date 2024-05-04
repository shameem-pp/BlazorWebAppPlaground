namespace BlazorWebAppPlaground.Applications.Categories;

public class CategoryDto
{
    public int Id { get; }
    public int? ParentCategoryId { get; set; }
    public CategoryDto? ParentCategory { get; set; }
    public required string Name { get; set; }
    public required List<ProductDto> Products { get; set; }
}



