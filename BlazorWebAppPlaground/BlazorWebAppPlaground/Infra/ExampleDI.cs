namespace BlazorWebAppPlaground.Infra;

public class ExampleDI
{
    public static int Count { get; private set; }
    public ExampleDI()
    {
        Count++;
    }

}
