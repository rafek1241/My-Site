using MySite.Shared.Models.About;

namespace MySite.Shared.Models
{
    public class AdmiredPerson
    {
        public long AdmiredPersonId { get; set; }

        public virtual Person Person { get; set; }

        public string Link { get; set; }
    }
}