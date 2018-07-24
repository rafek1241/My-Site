using MySite.Shared.Models.About;

namespace MySite.Shared.Models
{
    public class Publication
    {
        public long PublicationId { get; set; }

        public Person Author { get; set; }

        public string Slug { get; set; }

        public byte[] Photo { get; set; }

        public string Link { get; set; }
    }
}