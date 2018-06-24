namespace MySite.Shared.Models
{
    public class MenuNavLink
    {
        public long MenuNavLinkId { get; set; }

        public long NavLinkId { get; set; }

        public long MenuId { get; set; }

        public virtual NavLink NavLink { get; set; }

        public virtual Menu Menu { get; set; }
    }
}