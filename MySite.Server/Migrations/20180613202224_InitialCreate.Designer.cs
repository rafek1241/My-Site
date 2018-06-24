﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySite.Server;

namespace MySite.Server.Migrations
{
    [DbContext(typeof(MySiteContext))]
    [Migration("20180613202224_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MySite.Shared.Models.Menu", b =>
                {
                    b.Property<long>("MenuId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("MenuId");

                    b.HasIndex("Name");

                    b.ToTable("Menus");

                    b.HasData(
                        new { MenuId = 1L, Name = "MainMenu" },
                        new { MenuId = 2L, Name = "SubMenu" }
                    );
                });

            modelBuilder.Entity("MySite.Shared.Models.MenuNavLink", b =>
                {
                    b.Property<long>("MenuNavLinkId")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("MenuId");

                    b.Property<long>("NavLinkId");

                    b.HasKey("MenuNavLinkId");

                    b.HasIndex("MenuId");

                    b.HasIndex("NavLinkId");

                    b.ToTable("MenuNavLinks");

                    b.HasData(
                        new { MenuNavLinkId = 1L, MenuId = 1L, NavLinkId = 1L },
                        new { MenuNavLinkId = 2L, MenuId = 1L, NavLinkId = 2L },
                        new { MenuNavLinkId = 3L, MenuId = 1L, NavLinkId = 3L },
                        new { MenuNavLinkId = 4L, MenuId = 1L, NavLinkId = 4L }
                    );
                });

            modelBuilder.Entity("MySite.Shared.Models.NavLink", b =>
                {
                    b.Property<long>("NavLinkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Class");

                    b.Property<string>("Link");

                    b.Property<string>("Name");

                    b.HasKey("NavLinkId");

                    b.ToTable("NavLinks");

                    b.HasData(
                        new { NavLinkId = 1L, Class = "home", Link = "/", Name = "Homepage" },
                        new { NavLinkId = 2L, Class = "user", Link = "/about", Name = "About" },
                        new { NavLinkId = 3L, Class = "th", Link = "/portfolio", Name = "Portfolio" },
                        new { NavLinkId = 4L, Class = "address", Link = "/contact", Name = "Contact" }
                    );
                });

            modelBuilder.Entity("MySite.Shared.Models.MenuNavLink", b =>
                {
                    b.HasOne("MySite.Shared.Models.Menu", "Menu")
                        .WithMany("MenuNavLinks")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MySite.Shared.Models.NavLink", "NavLink")
                        .WithMany("MenuNavLinks")
                        .HasForeignKey("NavLinkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
