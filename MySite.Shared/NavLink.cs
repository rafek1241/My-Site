using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Shared
{
    public class NavLink
    {
        public long NavLinkId { get; set; }

        public string Class { get; set; }

        public string Name { get; set; }

        public Uri Link { get; set; }

        public virtual ICollection<MenuNavLink> MenuNavLinks { get; set; }
    }
}
