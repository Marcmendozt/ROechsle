using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRUEBA_FRANCO.Migrations
{
    public partial class employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    document_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    profile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee");
        }
    }
}
