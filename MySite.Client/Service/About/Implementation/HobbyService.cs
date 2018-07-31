using MySite.Client.Service.About.Interfaces;
using MySite.Shared.Models.About;

namespace MySite.Client.Service.About.Implementation
{
    public class HobbyService : BaseCrudService<Hobby>, IHobbyService
    {
        public HobbyService()
        {
            ResourceBaseUrl = "api/hobby";
        }
    }
}
