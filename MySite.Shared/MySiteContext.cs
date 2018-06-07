using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MySite.Shared
{
    public class MySiteContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<NavLink> NavLinks { get; set; }
        public DbSet<MenuNavLink> MenuNavLinks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");
        }
    }
}
