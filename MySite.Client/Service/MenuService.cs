using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;
using MySite.Shared.Models;
using MySite.Shared.Models.Utils;

namespace MySite.Client.Service
{
    public class MenuService : IMenuService
    {
        private const string _menuBaseUrl = "/api/Menu";

        public MenuService(HttpClient client)
        {
            HttpClient = client;
        }

        public HttpClient HttpClient { get; }

        public async Task<Menu[]> GetMenus()
        {
            var result = await HttpClient.GetJsonAsync<Menu[]>(_menuBaseUrl);
            Console.WriteLine(result.ToString());
            return result;
        }

        public async Task<Menu> GetMenu(long menuId)
        {
            return await HttpClient.GetJsonAsync<Menu>($"{_menuBaseUrl}/{menuId}");
        }

        public async Task<List<Menu>> GetMenusByName(string menuName)
        {
            return await HttpClient.GetJsonAsync<List<Menu>>($"{_menuBaseUrl}?name={menuName}");
        }

        public async Task<ResponseModel> AddMenu(Menu menu)
        {
            var response = await HttpClient.PostJsonAsync<ResponseModel>(_menuBaseUrl, menu);

            return response;
        }

        public async Task<ResponseModel> EditMenu(long menuId, Menu menu)
        {
            var response =
                await HttpClient.PutJsonAsync<ResponseModel>(_menuBaseUrl, new {MenuId = menuId, Menu = menu});

            return response;
        }

        public async Task<ResponseModel> RemoveMenu(Menu menu)
        {
            var response = await HttpClient.SendJsonAsync<ResponseModel>(HttpMethod.Delete, _menuBaseUrl, menu);

            return response;
        }
    }
}