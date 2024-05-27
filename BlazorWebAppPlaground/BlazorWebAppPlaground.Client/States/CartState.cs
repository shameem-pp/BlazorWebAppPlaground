namespace BlazorWebAppPlaground.Client.States;

public class CartState
{
    public Action<int>? OnCartCountChanged { get; set; }
}
