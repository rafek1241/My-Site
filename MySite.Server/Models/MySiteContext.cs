using Microsoft.EntityFrameworkCore;
using MySite.Server.Models;
using MySite.Shared.Models;

namespace MySite.Server
{
    public class MySiteContext : DbContext
    {
        public MySiteContext(DbContextOptions<MySiteContext> options) : base(options)
        { }

        public DbSet<Menu> Menus { get; set; }
        public DbSet<NavLink> NavLinks { get; set; }
        public DbSet<MenuNavLink> MenuNavLinks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }
    }

}
