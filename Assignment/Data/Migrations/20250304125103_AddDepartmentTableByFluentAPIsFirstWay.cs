using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDepartmentTableByFluentAPIsFirstWay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Sales");

            migrationBuilder.CreateTable(
                name: "Depts",
                schema: "Sales",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10, 10"),
                    DepartmentName = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    HiringDate = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depts", x => x.DepartmentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Depts",
                schema: "Sales");
        }
    }
}
