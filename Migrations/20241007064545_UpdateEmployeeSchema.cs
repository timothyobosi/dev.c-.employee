using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAPIs.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmployeeSchema : Migration
    {
        /// <inheritdoc />
        //this method creates the Employees table with the specified columns
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId= table.Column<string>(type:"VARCHAR(50),", nullable: false),
                    EmployeeFirstName = table.Column<string>(type:"VARCHAR(100)",nullable: false),
                    EmployeeLastName = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    EmployeeDateOfBirth = table.Column<string>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x=> x.EmployeeId);
                });

        }

        /// <inheritdoc />
        //this method drops Employee table allowing revert the migration needed
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee"
            );

        }
    }
}
