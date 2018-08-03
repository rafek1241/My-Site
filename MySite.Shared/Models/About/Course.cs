using MySite.Shared.Models.About;

namespace MySite.Shared.Models
{
    public class Course
    {
        public long CourseId { get; set; }

        public string Name { get; set; }

        public string Link { get; set; }

        public virtual Company Company { get; set; }
    }
}