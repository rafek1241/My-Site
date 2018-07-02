using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySite.Shared.Models;

namespace MySite.Server.Repositories
{
    public interface IMenuRepository
    {
        Task<Menu[]> GetAsync();
    }
}
