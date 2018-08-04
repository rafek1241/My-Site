using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySite.Shared.Models.About;

namespace MySite.Server.Controllers
{
    [Route("api/skill")]
    public class SkillController : Controller
    {
        [HttpGet]
        public async Task<Skill[]> Get()
        {
            //TODO: Swap Task.Run() to fetch data from database
            return await Task.Run(() => new[]
            {
                new Skill()
                {
                    Name = "Test1"
                }, new Skill()
                {
                    Name = "Test2"
                    }, new Skill()
                {
                    Name = "Test3"
                }
            });
        }
    }
}
