using Microsoft.EntityFrameworkCore.Migrations;

namespace rentCar.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Identificacion = table.Column<string>(type: "TEXT", nullable: true),
                    WorkTime = table.Column<string>(type: "TEXT", nullable: true),
                    Comision = table.Column<string>(type: "TEXT", nullable: true),
                    AdmisionDate = table.Column<string>(type: "TEXT", nullable: true),
                    Able = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "inspections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Car = table.Column<int>(type: "INTEGER", nullable: false),
                    Client = table.Column<int>(type: "INTEGER", nullable: false),
                    HasScratches = table.Column<bool>(type: "INTEGER", nullable: false),
                    FuelQuantity = table.Column<string>(type: "TEXT", nullable: true),
                    ReplacementRubber = table.Column<bool>(type: "INTEGER", nullable: false),
                    HasCat = table.Column<bool>(type: "INTEGER", nullable: false),
                    GlassBroken = table.Column<bool>(type: "INTEGER", nullable: false),
                    FrontLeftWheel = table.Column<bool>(type: "INTEGER", nullable: false),
                    FrontRightWheel = table.Column<bool>(type: "INTEGER", nullable: false),
                    RearLeftWheel = table.Column<bool>(type: "INTEGER", nullable: false),
                    RearRightWheel = table.Column<bool>(type: "INTEGER", nullable: false),
                    date = table.Column<string>(type: "TEXT", nullable: true),
                    Employee = table.Column<int>(type: "INTEGER", nullable: false),
                    able = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inspections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Employee = table.Column<int>(type: "INTEGER", nullable: false),
                    Car = table.Column<int>(type: "INTEGER", nullable: false),
                    Client = table.Column<int>(type: "INTEGER", nullable: false),
                    RentDate = table.Column<string>(type: "TEXT", nullable: true),
                    RentReturn = table.Column<string>(type: "TEXT", nullable: true),
                    PricePerDay = table.Column<int>(type: "INTEGER", nullable: false),
                    DaysAmount = table.Column<string>(type: "TEXT", nullable: true),
                    Comment = table.Column<string>(type: "TEXT", nullable: true),
                    able = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rents", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "inspections");

            migrationBuilder.DropTable(
                name: "rents");
        }
    }
}
