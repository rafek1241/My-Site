using MySite.Client.Service.About.Interfaces;
using MySite.Shared.Models;

namespace MySite.Client.Service.About.Implementation
{
    public class RecommendationService : BaseCrudService<Recommendation>, IRecommendationService
    {
        public RecommendationService()
        {
            ResourceBaseUrl = "api/recommendation";
        }
    }
}
