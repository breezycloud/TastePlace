using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.NetworkInformation;
using TastePlace.Client;
using TastePlace.Shared.Context;
using TastePlace.Shared.Util;
using TastePlace.Client.Handlers;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor.Services;
using MudBlazor;
using TastePlace.Shared.Models;
using TastePlace.Client.Interfaces;
using TastePlace.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;

    config.SnackbarConfiguration.PreventDuplicates = false;
    config.SnackbarConfiguration.NewestOnTop = false;
    config.SnackbarConfiguration.ShowCloseIcon = true;
    config.SnackbarConfiguration.VisibleStateDuration = 10000;
    config.SnackbarConfiguration.HideTransitionDuration = 500;
    config.SnackbarConfiguration.ShowTransitionDuration = 500;
});
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<LayoutService>();
builder.Services.AddScoped<AppState>();
builder.Services.AddScoped<IUserPreferencesService, UserPreferencesService>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHttpClient<CustomAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(options => options.GetRequiredService<CustomAuthenticationStateProvider>());
builder.Services.AddTransient<CustomAuthorizationHandler>();

builder.Services.AddHttpClient<IUserService, UserService>(client =>
{
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
}).AddHttpMessageHandler<CustomAuthorizationHandler>();

builder.Services.AddHttpClient<IOrderService, OrderService>(client => 
{ 
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress); 
}).AddHttpMessageHandler<CustomAuthorizationHandler>();

builder.Services.AddHttpClient<IMenuService, MenuService>(client => 
{ 
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress); 
}).AddHttpMessageHandler<CustomAuthorizationHandler>();

builder.Services.AddTransient<IConverter, Converter>();


await builder.Build().RunAsync();
