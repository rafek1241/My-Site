using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySite.Shared;

namespace MySite.Server.Controllers
{
    [Route("api/menu")]
    public class MenuController : Controller
    {
        [HttpGet]
        public Menu[] Get()
        {
            return new List<Menu>()
            {
                new Menu()
                {
                    MenuId = 1,
                    MenuNavLinks = new List<MenuNavLink>()
                    {
                        new MenuNavLink()
                        {
                            MenuId = 1,
                            Menu = null,
                            MenuNavLinkId = 1,
                            NavLink = new NavLink()
                            {
                                Name = "Test",
                                Link = new Uri("http://localhost"),
                                Class = "Test"
                            }
                        }
                    }
                }
            }.ToArray();
        }
    }
}
