using System.Collections.Generic;
using System.Threading.Tasks;
using MySite.Shared.Models;
using MySite.Shared.Models.Utils;

namespace MySite.Client.Service
{
    public interface IMenuService
    {
        Task<Menu[]> GetMenus();

        Task<Menu> GetMenu(long menuId);

        Task<List<Menu>> GetMenusByName(string menuName);

        Task<ResponseModel> AddMenu(Menu menu);

        Task<ResponseModel> EditMenu(long menuId, Menu menu);

        Task<ResponseModel> RemoveMenu(Menu menu);
    }
}