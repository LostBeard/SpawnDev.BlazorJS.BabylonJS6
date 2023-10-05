using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SpawnDev.BlazorJS;
using SpawnDev.BlazorJS.BabylonJS6;
using SpawnDev.BlazorJS.BabylonJS6.Demo;
using SpawnDev.BlazorJS.JSObjects;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazorJSRuntime();
builder.Services.AddSingleton<BabylonJS6Loader>();

builder.Services.AddSingleton(sp => sp.GetRequiredService<BlazorJSRuntime>().Get<Document>("document"));
builder.Services.AddSingleton(sp => sp.GetRequiredService<BlazorJSRuntime>().Get<Window>("window"));

builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().BlazorJSRunAsync();
