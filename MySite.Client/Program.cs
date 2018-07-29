using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.Extensions.DependencyInjection;
using MySite.Client.Service;

namespace MySite.Client
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
                // Add any custom services here
                services.AddSingleton<IMenuService, MenuService>();
                services.AddSingleton<IMottoService, MottoService>();
                services.AddSingleton<IPersonalInformationService, PersonalInformationService>();
            });

            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}