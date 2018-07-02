using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Shared.Models
{
    public class Motto
    {
        public long MottoId { get; set; }

        public string Sentence { get; set; }

        public string Author { get; set; }

        public bool Active { get; set; }
    }
}
