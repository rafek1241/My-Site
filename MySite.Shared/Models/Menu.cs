using System.Collections.Generic;

namespace MySite.Shared.Models
{
    public class Menu
    {
        public long MenuId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<MenuNavLink> MenuNavLinks { get; set; }
    }
}
