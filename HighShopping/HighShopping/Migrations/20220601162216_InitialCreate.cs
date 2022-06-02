using Microsoft.EntityFrameworkCore.Migrations;

namespace HighShopping.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sorting = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Content", "Slug", "Sorting", "Title" },
                values: new object[] { 1, "home page", "home", 0, "Trang chủ" });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Content", "Slug", "Sorting", "Title" },
                values: new object[] { 2, "about us page", "about-us", 100, "Về chúng tôi" });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Content", "Slug", "Sorting", "Title" },
                values: new object[] { 3, "contact page", "contact", 100, "Liên hệ" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pages");
        }
    }
}
