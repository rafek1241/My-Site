using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySite.Shared.Models.About;

namespace MySite.Shared.Models
{
    public class PersonalInformation
    {
        public long PersonalInformationId { get; set; }

        public string Description { get; set; }

        public virtual Person Person { get; set; }
    }
}
