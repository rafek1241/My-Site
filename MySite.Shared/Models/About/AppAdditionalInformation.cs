using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Shared.Models.About
{
    public class AppAdditionalInformation
    {
        public long AppAdditionalInformationId { get; set; }

        public virtual ThirdPartyApp ThirdPartyApp { get; set; }

        public string Key { get; set; }

        public object Value { get; set; }
    }
}
