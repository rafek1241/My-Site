using MySite.Client.Service.About.Interfaces;
using MySite.Shared.Models.About;

namespace MySite.Client.Service.About.Implementation
{
    public class CertificateService : BaseCrudService<Certificate>, ICertificateService
    {
        public CertificateService()
        {
            ResourceBaseUrl = "api/certificate";
        }
    }
}
