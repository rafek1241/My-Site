using Microsoft.AspNetCore.Blazor.Layouts;

namespace MySite.Client.Base.Layout
{
    public class NavMenuBase : BlazorLayoutComponent
    {
        public bool collapseNavMenu { get; set; } = true;

        public void ToggleNavMenu()
        {
            collapseNavMenu = !collapseNavMenu;
        }
    }
}
