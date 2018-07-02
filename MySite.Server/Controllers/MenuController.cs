using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySite.Server.Repositories;
using MySite.Shared.Models;

namespace MySite.Server.Controllers
{
    [Route("api/menu")]
    public class MenuController : Controller
    {
        private readonly IMenuRepository _menuRepository;

        public MenuController(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        [HttpGet]
        public async Task<Menu[]> Get()
        {
            return await _menuRepository.GetAsync();
        }
    }
}
