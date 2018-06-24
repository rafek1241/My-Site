using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return await db.Menus.ToArrayAsync();
        }
    }
}
