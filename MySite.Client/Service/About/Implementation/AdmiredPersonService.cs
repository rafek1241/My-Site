using MySite.Client.Service.About.Interfaces;
using MySite.Shared.Models;

namespace MySite.Client.Service.About.Implementation
{

    public class AdmiredPersonService : BaseCrudService<AdmiredPerson>, IAdmiredPersonService
    {
        public AdmiredPersonService()
        {
            ResourceBaseUrl = "api/admired-person";
        }        
    }
}
