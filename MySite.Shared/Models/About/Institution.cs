using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Shared.Models.About
{
    public class Institution
    {
        public long InstitutionId { get; set; }

        public string Name { get; set; }

        public virtual Localization Localization { get; set; }

        public byte[] Photo { get; set; }
    }
}
