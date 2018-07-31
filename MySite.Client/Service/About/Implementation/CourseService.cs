using MySite.Client.Service.About.Interfaces;
using MySite.Shared.Models;

namespace MySite.Client.Service.About.Implementation
{
    public class CourseService : BaseCrudService<Course>, ICourseService
    {
        public CourseService()
        {
            ResourceBaseUrl = "api/course";
        }
    }
}
