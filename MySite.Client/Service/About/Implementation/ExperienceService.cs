using MySite.Client.Service.About.Interfaces;
using MySite.Shared.Models.About;

namespace MySite.Client.Service.About.Implementation
{
    public class ExperienceService : BaseCrudService<Experience>, IExperienceService
    {
        public ExperienceService()
        {
            ResourceBaseUrl = "api/experience";
        }
    }
}
