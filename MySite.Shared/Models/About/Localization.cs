using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Shared.Models.About
{
    public class Localization
    {
        public long WorkLocalizationId { get; set; }

        public float Lattitude { get; set; }

        public float Longitude { get; set; }

        public float Accuracy { get; set; }
    }
}
