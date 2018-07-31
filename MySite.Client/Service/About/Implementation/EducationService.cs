using MySite.Client.Service.About.Interfaces;
using MySite.Shared.Models.About;

namespace MySite.Client.Service.About.Implementation
{
    public class EducationService : BaseCrudService<Education>, IEducationService
    {
        public EducationService()
        {
            ResourceBaseUrl = "api/education";
        }
    }
}
