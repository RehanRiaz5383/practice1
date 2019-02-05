using Microsoft.EntityFrameworkCore.Migrations;

namespace practice1.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    personId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    personName = table.Column<string>(nullable: true),
                    perosnAge = table.Column<int>(nullable: false),
                    personAddress = table.Column<string>(nullable: true),
                    gender = table.Column<string>(nullable: true),
                    picUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.personId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
