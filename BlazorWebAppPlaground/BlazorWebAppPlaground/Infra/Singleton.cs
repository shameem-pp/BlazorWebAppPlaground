namespace BlazorWebAppPlaground.Infra;

public class Singleton
{
    public static int Count { get; private set; }
    public Singleton()
    {
        Count++;
    }

}
