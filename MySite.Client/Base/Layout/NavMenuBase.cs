using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.AspNetCore.Blazor.Layouts;
using MySite.Client.Service;
using MySite.Shared.Models;
using MySite.Shared.Models.Enums;

namespace MySite.Client.Base.Layout
{
    public class NavMenuBase : BlazorLayoutComponent
    {
        public bool collapseNavMenu { get; set; } = true;

        public Menu Menu { get; set; }

        [Inject] public IMenuService Service { get; set; }

        public void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }

        protected override async Task OnInitAsync()
        {
            var menu = await Service.Get();

            Menu = menu.SingleOrDefault(p => p.Name == MenuEnum.MainMenu.ToString());
        }
    }
}