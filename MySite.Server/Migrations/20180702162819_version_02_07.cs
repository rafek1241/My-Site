using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MySite.Server.Migrations
{
    public partial class version_02_07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mottoes",
                columns: table => new
                {
                    MottoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sentence = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mottoes", x => x.MottoId);
                });

            migrationBuilder.InsertData(
                table: "Mottoes",
                columns: new[] { "MottoId", "Active", "Author", "Sentence" },
                values: new object[,]
                {
                    { 1L, true, "Kristen Runolfsdottir", "Atque odit illum id asperiores eius est ut repudiandae molestiae." },
                    { 2L, false, "Wendy Weimann", "Nemo dolores non ut est id harum ea qui inventore qui." },
                    { 3L, true, "Colin Kautzer", "Deleniti hic fugit enim temporibus et molestiae fugit qui est consequatur deserunt vel deserunt aut." },
                    { 4L, false, "Pete Macejkovic", "Sed aliquam voluptatem id consequatur odio sequi voluptatibus dolore mollitia tempora quo ut magni sit." },
                    { 5L, true, "Darnell Luettgen", "Reiciendis sint sit sit iusto itaque quis aut molestiae optio iure ut et." },
                    { 6L, true, "Patricia Grady", "Quos necessitatibus occaecati non autem dolore id quia qui suscipit." },
                    { 7L, true, "Inez Haley", "Natus voluptatum quam repudiandae atque exercitationem rem est sit cumque magnam doloremque." },
                    { 8L, true, "Ivan Strosin", "Possimus dicta perferendis accusantium sequi nulla magnam ipsam vero quis." },
                    { 9L, false, "Courtney Gutkowski", "Qui dolor cupiditate iste et est error quo aliquam id adipisci nemo et." },
                    { 10L, true, "Tara Keebler", "Et magnam et tenetur rerum iure est ut illo repellat ab aut ut." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mottoes");
        }
    }
}
