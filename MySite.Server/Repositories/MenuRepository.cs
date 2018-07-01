using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySite.Shared.Models;

namespace MySite.Server.Repositories
{
    public class MenuRepository : Repository, IMenuRepository
    {
        public MenuRepository(MySiteContext context) : base(context)
        {
        }

        public async Task<Menu[]> GetAsync()
        {
            return await db.Menus.Include(p=>p.MenuNavLinks).ThenInclude(p=>p.NavLink).ToArrayAsync();
        }
    }
}
