using MySite.Shared.Models.About;

namespace MySite.Shared.Models
{
    public class Recommendation
    {
        public long RecommendationId { get; set; }

        public string Description { get; set; }

        public Person Person { get; set; }

        public Company Company { get; set; }
    }
}