namespace BlazorWebAppPlaground.Infra;

public class Transient
{
    public static int Count { get; private set; }
    public Transient()
    {
        Count++;
    }
}
