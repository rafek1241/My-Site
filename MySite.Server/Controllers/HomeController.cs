using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MySite.Server.Controllers
{
    public class HomeController : Controller
    {
        public string ApiNotFound()
        {
            return "API WAS NOT FOUND!!!!";
        }
    }
}
