using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task1.Migrations
{
    /// <inheritdoc />
    public partial class AddedEmployeeIdandProjectIdtoEmployeesProjectsrelationtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeesProjectsId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeesProjectsId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EmployeesProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesProjects", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_EmployeesProjectsId",
                table: "Projects",
                column: "EmployeesProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeesProjectsId",
                table: "Employees",
                column: "EmployeesProjectsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeesProjects_EmployeesProjectsId",
                table: "Employees",
                column: "EmployeesProjectsId",
                principalTable: "EmployeesProjects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_EmployeesProjects_EmployeesProjectsId",
                table: "Projects",
                column: "EmployeesProjectsId",
                principalTable: "EmployeesProjects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeesProjects_EmployeesProjectsId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_EmployeesProjects_EmployeesProjectsId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "EmployeesProjects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_EmployeesProjectsId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeesProjectsId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeesProjectsId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "EmployeesProjectsId",
                table: "Employees");
        }
    }
}
