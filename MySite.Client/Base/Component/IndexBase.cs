using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Components;
using MySite.Client.Service;
using MySite.Shared.Models;

namespace MySite.Client.Base.Component
{
    public class IndexBase : BlazorComponent
    {
        [Inject]
        public IMenuService MenuService { get; set; }


        private void Log(string message) => Console.WriteLine($"{DateTime.UtcNow:O} - {message}");


    }
}
