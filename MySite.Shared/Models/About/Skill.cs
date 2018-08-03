using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Shared.Models.About
{
    public class Skill
    {
        public long SkillId { get; set; }

        public string IconBase64 { get; set; }

        public string Name { get; set; }

        public virtual SkillCategory SkillCategory { get; set; }

        /// <summary>
        /// from 0 to 10
        /// </summary>
        public byte Level { get; set; }
    }
}
