using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Shared.Models.About
{
    public class Education
    {
        public long EducationId { get; set; }

        public string Place { get; set; }

        public string Specialization { get; set; }

        public DateTime EducationBegin { get; set; }
        
        /// <summary>
        /// If null then Education still on going
        /// </summary>
        public DateTime? EducationEnd { get; set; }

        public virtual EducationDegree Degree { get; set; }
    }
}
