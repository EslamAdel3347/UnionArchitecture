using Microsoft.EntityFrameworkCore.Migrations;

namespace HrLeaveManagement.Presistance.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmpType",
                table: "Employees",
                defaultValue:"Full",
                
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpType",
                table: "Employees");
        }
    }
}
