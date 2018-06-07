using System;
using System.Collections.Generic;

namespace MySite.Shared
{
    public class Menu 
    {
        public long MenuId { get; set; }

        public virtual ICollection<MenuNavLink> MenuNavLinks { get; set; }
    }
}
