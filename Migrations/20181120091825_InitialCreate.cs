using Microsoft.EntityFrameworkCore.Migrations;

namespace ReadMyLife.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StoryItem",
                columns: table => new
                {
                    StoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    AuthorName = table.Column<string>(nullable: true),
                    AuthorID = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Contents = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    NumRatings = table.Column<int>(nullable: false),
                    Tag = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoryItem", x => x.StoryID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoryItem");
        }
    }
}
