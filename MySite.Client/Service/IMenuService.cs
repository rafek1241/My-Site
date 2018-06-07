using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySite.Shared;

namespace MySite.Client.Service
{
    public interface IMenuService
    {
        Task<List<Menu>> GetMenus();

        Task<Menu> GetMenu(long menuId);

        Task<List<Menu>> GetMenusByName(string menuName);

        Task<ResponseModel> AddMenu(Menu menu);

        Task<ResponseModel> EditMenu(long menuId, Menu menu);

        Task<ResponseModel> RemoveMenu(Menu menu);
    }
}
