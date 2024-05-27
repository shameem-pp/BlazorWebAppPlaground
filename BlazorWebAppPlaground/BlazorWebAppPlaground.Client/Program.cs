using BlazorWebAppPlaground.Client.ApiServices;
using BlazorWebAppPlaground.Client.States;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped(sp => 
    new HttpClient { BaseAddress = new Uri("https://localhost:7161") });

builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<CartState>();

await builder.Build().RunAsync();
