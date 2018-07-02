using System.Collections.Generic;
using System.Threading.Tasks;
using MySite.Shared.Models;

namespace MySite.Client.Service
{
    public interface IMenuService : ICrudService<Menu>
    {
            Task<List<Menu>> GetByName(string name);
    }
}
