using System.Collections.Generic;

namespace MySite.Shared.Models.About
{
    public class Team
    {
        public long TeamId { get; set; }

        public string Name { get; set; }

        public virtual Award Award { get; set; }

        public ICollection<Person> Persons { get; set; }
    }
}