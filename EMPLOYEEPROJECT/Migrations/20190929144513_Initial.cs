using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EMPLOYEEPROJECT.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<long>(nullable: false),
                    DateTimeCreated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<long>(nullable: false),
                    DateTimeUpdated = table.Column<DateTime>(nullable: false),
                    LastTimeUpdated = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<long>(nullable: false),
                    DateTimeCreated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<long>(nullable: false),
                    DateTimeUpdated = table.Column<DateTime>(nullable: false),
                    LastTimeUpdated = table.Column<Guid>(nullable: false),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDepartmentRelations",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<long>(nullable: false),
                    DateTimeCreated = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<long>(nullable: false),
                    DateTimeUpdated = table.Column<DateTime>(nullable: false),
                    LastTimeUpdated = table.Column<Guid>(nullable: false),
                    EmployeeId = table.Column<long>(nullable: false),
                    DepartmentId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDepartmentRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeDepartmentRelations_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeDepartmentRelations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDepartmentRelations_DepartmentId",
                table: "EmployeeDepartmentRelations",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDepartmentRelations_EmployeeId",
                table: "EmployeeDepartmentRelations",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeDepartmentRelations");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
