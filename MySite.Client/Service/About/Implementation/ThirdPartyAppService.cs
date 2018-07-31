using MySite.Client.Service.About.Interfaces;
using MySite.Shared.Models.About;

namespace MySite.Client.Service.About.Implementation
{
    public class ThirdPartyAppService : BaseCrudService<ThirdPartyApp>, IThirdPartyAppService
    {
        public ThirdPartyAppService()
        {
            ResourceBaseUrl = "api/third-party-app";
        }
    }
}
