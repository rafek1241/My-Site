using MySite.Client.Service.About.Interfaces;
using MySite.Shared.Models;

namespace MySite.Client.Service.About.Implementation
{
    public class PublicationService : BaseCrudService<Publication>, IPublicationService
    {
        public PublicationService()
        {
            ResourceBaseUrl = "api/publication";
        }
    }
}
