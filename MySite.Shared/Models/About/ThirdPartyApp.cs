using System.Collections.Generic;

namespace MySite.Shared.Models.About
{
    public class ThirdPartyApp
    {
        public long ThirdPartyAppId { get; set; }

        public string Link { get; set; }

        public string Icon { get; set; }

        public virtual ICollection<AppAdditionalInformation> AppAdditionalInformations { get; set; }
    }
}
