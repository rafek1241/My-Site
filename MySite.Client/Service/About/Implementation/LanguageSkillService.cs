using MySite.Client.Service.About.Interfaces;
using MySite.Shared.Models.About;

namespace MySite.Client.Service.About.Implementation
{
    public class LanguageSkillService : BaseCrudService<LanguageSkill>, ILanguageSkillService
    {
        public LanguageSkillService()
        {
            ResourceBaseUrl = "api/language-skill";
        }
    }
}
