namespace BlazorWebAppPlaground.Domain;

public class Product
{
    private Product() { }
    public int Id { get; set; }
    public string Name { get; private set; } = default!;

    public static Product Create(string name) => new()
    {
        Name = name
    };

}