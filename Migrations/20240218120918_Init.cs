using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Npgsql_3074.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<List<int>>(
                table: "NotExistedTableButItDoesntMatter",
                name: "SomeColumn",
                type: "integer[]",
                nullable: false,
                defaultValue: "{}"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
