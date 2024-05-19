namespace BlazorWebAppPlaground.Infra;

public class Scopped
{
    public static int Count { get; private set; }
    public Scopped()
    {
        Count++;
    }
}
