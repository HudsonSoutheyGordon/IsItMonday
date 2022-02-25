using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Mondays;
using Mondays.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient<IMondayServices, MondayServices>(client =>
{
    //client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
    client.BaseAddress = new Uri("https://localhost:7096/");
});

await builder.Build().RunAsync();
