using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Shared.Models.About
{
    public class Experience
    {
        public long ExperienceId { get; set; }

        public virtual WorkPosition Position { get; set; }

        public virtual Company Company { get; set; }

        public DateTime WorkBegin { get; set; }

        /// <summary>
        /// If this property is not set it means that i'm currently working there.
        /// </summary>
        public DateTime? WorkEnd { get; set; }

        public virtual Localization Localization { get; set; }
    }
}
