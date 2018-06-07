using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Components;
using MySite.Client.Service;
using MySite.Shared;

namespace MySite.Client.Base.Component
{
    public class IndexBase : BlazorComponent
    {
        [Inject]
        public IMenuService MenuService { get; set; }

        public Menu Menu { get; set; }

        private void Log(string message) => Console.WriteLine($"{DateTime.UtcNow:O} - {message}");


        protected override async Task OnInitAsync()
        {
            Log("OnInitAsync starting");
            var menus = await MenuService.GetMenus();
            Log(menus.ToString());
            Menu = menus.First();
            // Simulate async initialization work

            Log("OnInitAsync finished");
        }

    }
}
