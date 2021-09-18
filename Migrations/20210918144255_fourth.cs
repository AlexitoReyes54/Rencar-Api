using Microsoft.EntityFrameworkCore.Migrations;

namespace rentCar.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Identificacion = table.Column<string>(type: "TEXT", nullable: true),
                    CreditCard = table.Column<string>(type: "TEXT", nullable: true),
                    CreditLimit = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonType = table.Column<string>(type: "TEXT", nullable: true),
                    able = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clients");
        }
    }
}
