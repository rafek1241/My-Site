﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MySite.Server;

namespace MySite.Server.Migrations
{
    [DbContext(typeof(MySiteContext))]
    partial class MySiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("MySite.Shared.Models.Motto", b =>
                {
                    b.Property<long>("MottoId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Author");

                    b.Property<string>("Sentence");

                    b.HasKey("MottoId");

                    b.ToTable("Mottoes");

                    b.HasData(
                        new { MottoId = 1L, Active = true, Author = "Kristen Runolfsdottir", Sentence = "Atque odit illum id asperiores eius est ut repudiandae molestiae." },
                        new { MottoId = 2L, Active = false, Author = "Wendy Weimann", Sentence = "Nemo dolores non ut est id harum ea qui inventore qui." },
                        new { MottoId = 3L, Active = true, Author = "Colin Kautzer", Sentence = "Deleniti hic fugit enim temporibus et molestiae fugit qui est consequatur deserunt vel deserunt aut." },
                        new { MottoId = 4L, Active = false, Author = "Pete Macejkovic", Sentence = "Sed aliquam voluptatem id consequatur odio sequi voluptatibus dolore mollitia tempora quo ut magni sit." },
                        new { MottoId = 5L, Active = true, Author = "Darnell Luettgen", Sentence = "Reiciendis sint sit sit iusto itaque quis aut molestiae optio iure ut et." },
                        new { MottoId = 6L, Active = true, Author = "Patricia Grady", Sentence = "Quos necessitatibus occaecati non autem dolore id quia qui suscipit." },
                        new { MottoId = 7L, Active = true, Author = "Inez Haley", Sentence = "Natus voluptatum quam repudiandae atque exercitationem rem est sit cumque magnam doloremque." },
                        new { MottoId = 8L, Active = true, Author = "Ivan Strosin", Sentence = "Possimus dicta perferendis accusantium sequi nulla magnam ipsam vero quis." },
                        new { MottoId = 9L, Active = false, Author = "Courtney Gutkowski", Sentence = "Qui dolor cupiditate iste et est error quo aliquam id adipisci nemo et." },
                        new { MottoId = 10L, Active = true, Author = "Tara Keebler", Sentence = "Et magnam et tenetur rerum iure est ut illo repellat ab aut ut." }
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