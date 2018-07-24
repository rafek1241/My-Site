using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Shared.Models.About
{
    public class Company
    {
        public long CompanyId { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Information about specified company what can be visible through popover or something.
        /// </summary>
        public string Information { get; set; }

        public byte[] Photo { get; set; }
    }
}
