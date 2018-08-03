using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Shared.Models.About
{
    public class LanguageSkill
    {
        public long LanguageId { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// from 0 to 5. (5 means native)
        /// </summary>
        public byte Level { get; set; }
    }
}
