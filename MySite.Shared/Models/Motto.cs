namespace MySite.Shared.Models
{
    public class Motto
    {
        public long MottoId { get; set; }

        public string Sentence { get; set; }

        public string Author { get; set; }

        public bool Active { get; set; }
    }
}
