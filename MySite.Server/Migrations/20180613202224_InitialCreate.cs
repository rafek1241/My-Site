using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MySite.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "NavLinks",
                columns: table => new
                {
                    NavLinkId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Class = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NavLinks", x => x.NavLinkId);
                });

            migrationBuilder.CreateTable(
                name: "MenuNavLinks",
                columns: table => new
                {
                    MenuNavLinkId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NavLinkId = table.Column<long>(nullable: false),
                    MenuId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuNavLinks", x => x.MenuNavLinkId);
                    table.ForeignKey(
                        name: "FK_MenuNavLinks_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuNavLinks_NavLinks_NavLinkId",
                        column: x => x.NavLinkId,
                        principalTable: "NavLinks",
                        principalColumn: "NavLinkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "Name" },
                values: new object[,]
                {
                    { 1L, "MainMenu" },
                    { 2L, "SubMenu" }
                });

            migrationBuilder.InsertData(
                table: "NavLinks",
                columns: new[] { "NavLinkId", "Class", "Link", "Name" },
                values: new object[,]
                {
                    { 1L, "home", "/", "Homepage" },
                    { 2L, "user", "/about", "About" },
                    { 3L, "th", "/portfolio", "Portfolio" },
                    { 4L, "address", "/contact", "Contact" }
                });

            migrationBuilder.InsertData(
                table: "MenuNavLinks",
                columns: new[] { "MenuNavLinkId", "MenuId", "NavLinkId" },
                values: new object[,]
                {
                    { 1L, 1L, 1L },
                    { 2L, 1L, 2L },
                    { 3L, 1L, 3L },
                    { 4L, 1L, 4L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuNavLinks_MenuId",
                table: "MenuNavLinks",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuNavLinks_NavLinkId",
                table: "MenuNavLinks",
                column: "NavLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_Name",
                table: "Menus",
                column: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuNavLinks");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "NavLinks");
        }
    }
}
