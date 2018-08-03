using MySite.Client.Service.About.Interfaces;
using MySite.Shared.Models.About;

namespace MySite.Client.Service.About.Implementation
{
    public class AwardService : BaseCrudService<Award>,IAwardService
    {
        public AwardService()
        {
            ResourceBaseUrl = "api/award";
        }   
    }
}
