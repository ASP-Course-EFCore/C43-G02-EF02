using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnInsIdToDepartmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ins_Id",
                schema: "Sales",
                table: "Depts",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ins_Id",
                schema: "Sales",
                table: "Depts");
        }
    }
}
