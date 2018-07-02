using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Components;
using MySite.Client.Service;
using MySite.Shared.Models;

namespace MySite.Client.Base.Component
{
    public class HomepageBase : BlazorComponent
    {
        protected Motto Motto { get; set; }

        [Inject] private IMottoService MottoService { get; set; }

        protected override async Task OnInitAsync()
        {
            var random = new Random();
            var list = (await MottoService.Get()).Where(p => p.Active).ToArray();

            Motto = list[random.Next(list.Length)];
        }
    }
}