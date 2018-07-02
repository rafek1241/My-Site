using System;
using System.Collections.Generic;

namespace MySite.Shared.Models
{
    public class NavLink
    {
        public long NavLinkId { get; set; }

        public string Class { get; set; }

        public string Name { get; set; }

        public string Link { get; set; }

        public virtual ICollection<MenuNavLink> MenuNavLinks { get; set; }
    }
}
