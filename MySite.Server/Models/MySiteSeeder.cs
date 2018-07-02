using Bogus;
using Microsoft.EntityFrameworkCore;
using MySite.Shared.Models;
using MySite.Shared.Models.Enums;

namespace MySite.Server.Models
{
    public static class Seeder
    {
        public static void Seed(this ModelBuilder builder)
        {

            builder.Entity<Menu>(typeBuilder =>
            {
                typeBuilder.HasKey(p => p.MenuId);
                typeBuilder.HasIndex(p => p.Name);
                typeBuilder.HasData(new Menu()
                {
                    MenuId = 1,
                    Name = MenuEnum.MainMenu.ToString()
                }, new Menu()
                {
                    MenuId = 2,
                    Name = MenuEnum.SubMenu.ToString()
                });
            });

            builder.Entity<NavLink>().HasData(
                new NavLink()
                {
                    NavLinkId = 1,
                    Name = "Homepage",
                    Class = "home",
                    Link = "/"
                },
                new NavLink()
                {
                    NavLinkId = 2,
                    Name = "About",
                    Class = "user",
                    Link = "/about"
                },
                new NavLink()
                {
                    NavLinkId = 3,
                    Name = "Portfolio",
                    Class = "th",
                    Link = "/portfolio"
                },
                new NavLink()
                {
                    NavLinkId = 4,
                    Name = "Contact",
                    Class = "address",
                    Link = "/contact"
                });


            builder.Entity<MenuNavLink>().HasData(
                new MenuNavLink()
                {
                    NavLinkId = 1,
                    MenuId = 1,
                    MenuNavLinkId = 1,
                },
                new MenuNavLink()
                {
                    NavLinkId = 2,
                    MenuId = 1,
                    MenuNavLinkId = 2,
                },
                new MenuNavLink()
                {
                    NavLinkId = 3,
                    MenuId = 1,
                    MenuNavLinkId = 3,
                },
                new MenuNavLink()
                {
                    NavLinkId = 4,
                    MenuId = 1,
                    MenuNavLinkId = 4,
                }
                );

            var mottoFaker = new Faker<Motto>();

            long mottoId = 1;

            mottoFaker.RuleFor(p => p.MottoId, w => mottoId++);
            mottoFaker.RuleFor(p => p.Active, w => w.Random.Bool());
            mottoFaker.RuleFor(p => p.Author, w => w.Person.FullName);
            mottoFaker.RuleFor(p => p.Sentence, w => w.Lorem.Sentence(10, 6));

            var mottoes = mottoFaker.Generate(10);

            builder.Entity<Motto>().HasData(
                mottoes.ToArray()
            );

        }
    }
}
