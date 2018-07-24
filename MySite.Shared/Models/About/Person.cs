using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Shared.Models.About
{
    public class Person
    {
        public long PersonId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public byte[] Photo { get; set; }

        public virtual PersonalInformation PersonalInformation { get; set; }
    }
}
