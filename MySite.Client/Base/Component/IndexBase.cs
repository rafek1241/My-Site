using System;
using Microsoft.AspNetCore.Blazor.Components;
using MySite.Client.Service;

namespace MySite.Client.Base.Component
{
    public class IndexBase : BlazorComponent
    {
        [Inject] public IMenuService MenuService { get; set; }


        private void Log(string message)
        {
            Console.WriteLine($"{DateTime.UtcNow:O} - {message}");
        }
    }
}