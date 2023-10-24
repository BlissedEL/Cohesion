using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Style
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            // Create a WebAssembly host builder
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            // Configure the root component
            builder.RootComponents.Add<App>("#app");

            // Add services, such as HttpClient
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // Initialize the WebAssembly host
            var host = builder.Build();

            // Run the application
            await host.RunAsync();
        }
    }
}