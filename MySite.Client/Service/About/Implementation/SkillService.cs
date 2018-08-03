using MySite.Client.Service.About.Interfaces;
using MySite.Shared.Models.About;

namespace MySite.Client.Service.About.Implementation
{
    public class SkillService : BaseCrudService<Skill>, ISkillService
    {
        public SkillService()
        {
            ResourceBaseUrl = "api/skill";
        }
    }
}
